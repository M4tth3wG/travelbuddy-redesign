/* eslint-disable @typescript-eslint/no-explicit-any */
import { StyleSheet, View, Image, Dimensions, ScrollView } from "react-native";
import React, {
  useMemo,
  useState,
  useCallback,
  useEffect,
  useLayoutEffect,
} from "react";
import TripDetailLabel from "@/components/TripDetailLabel";
import { FAB, Text, useTheme } from "react-native-paper";
import {
  CALENDAR_ICON,
  DELETE_ICON,
  EDIT_ICON_MATERIAL,
  NOTE_ICON_MATERIAL,
} from "@/constants/Icons";
import { router, useLocalSearchParams, useNavigation } from "expo-router";
import SingleDatePickerModal from "@/components/SingleDatePickerModal/SingleDatePickerModal";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import { useTripDetails } from "@/composables/useTripDetails";
import { TripDay, TripViewModel } from "@/types/Trip";
import { useSnackbar } from "@/context/SnackbarContext";
import { convertTripResponseToViewModel } from "@/converters/tripConverters";
import usePlaceDetails from "@/composables/usePlace";
import LoadingView from "./LoadingView";
import { MD3ThemeExtended } from "@/constants/Themes";
import CustomModal from "@/components/CustomModal";
import ActionTextButtons from "@/components/ActionTextButtons";
import { useAuth } from "@/app/ctx";
import { formatDateToISO } from "@/utils/TimeUtils";
import { useGetProfile } from "@/composables/useProfiles";
import useTripImageStorage from "@/hooks/useTripImageStore";
import { DEFAULT_TRIP_IMAGE, TRIP_IMAGES } from "@/constants/Images";
import { conditionalItem } from "@/utils/ArrayUtils";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { height, width } = Dimensions.get("window");

const TripDetailsView = () => {
  const { api } = useAuth();
  const theme = useTheme();
  const styles = useMemo(
    () => createStyles(theme as MD3ThemeExtended),
    [theme],
  );
  const [dateModalVisible, setDateModalVisible] = useState(false);
  const [tripViewModel, setTripViewModel] = useState<TripViewModel | undefined>(
    undefined,
  );

  const { refreshScreens, addRefreshScreen, removeRefreshScreen } =
    useShouldRefresh();

  const shouldRefresh = useMemo(
    () => refreshScreens.includes("trip-details"),
    [refreshScreens],
  );

  const [isModalVisible, setIsModalVisible] = useState(false);
  const hideModal = () => setIsModalVisible(false);
  const showRemovalModal = () => setIsModalVisible(true);

  const deleteTrip = async (tripId: string | undefined) => {
    if (!tripId) return;
    hideModal();
    try {
      await api!.delete(`/trips/${tripId}`);
      await removeImage(tripId);
      addRefreshScreen("trips");
      router.navigate("/trips");
      showSnackbar("Usunięto wycieczkę!");
    } catch (error: any) {
      showSnackbar("Wystąpił błąd podczas usuwania wycieczki", "error");
    }
  };

  const { trip_id } = useLocalSearchParams();
  const navigation = useNavigation();

  const {
    tripDetails,
    tripSummary,
    loading: tripLoading,
    error: tripError,
    refetch: tripRefetch,
  } = useTripDetails(trip_id as string);

  const {
    placeDetails: destinationDetails,
    loading: destinationLoading,
    error: destinationError,
    refetch: destinationRefetch,
  } = usePlaceDetails(tripDetails?.destinationId);

  const {
    profile: categoryProfile,
    error: categoryProfileError,
    refetch: refetchCategoryProfile,
  } = useGetProfile("Category", tripDetails?.categoryProfileId as string, {
    immediate: false,
  });
  const {
    profile: conditionProfile,
    error: conditionProfileError,
    refetch: refetchConditionProfile,
  } = useGetProfile("Condition", tripDetails?.conditionProfileId as string, {
    immediate: false,
  });

  const { getImageName, removeImage } = useTripImageStorage();
  const [resolvedImage, setResolvedImage] = useState(null);
  const resolvedImageSource = resolvedImage ?? DEFAULT_TRIP_IMAGE;

  useEffect(() => {
    const fetchImageName = async () => {
      const storedImageName = await getImageName(trip_id as string);
      if (storedImageName) {
        setResolvedImage(TRIP_IMAGES[storedImageName]);
      }
    };
    fetchImageName();
  }, [trip_id, getImageName]);

  useEffect(() => {
    const refetch = async () => {
      if (tripDetails) {
        if (tripDetails.categoryProfileId) await refetchCategoryProfile();
        if (tripDetails.conditionProfileId) await refetchConditionProfile();
      }
    };
    refetch();
  }, [tripDetails]);

  const loading = useMemo(
    () => tripLoading || destinationLoading || false,
    [tripLoading, destinationLoading],
  );
  const error = useMemo(
    () =>
      tripError ||
      destinationError ||
      categoryProfileError ||
      conditionProfileError ||
      null,
    [tripError, destinationError, categoryProfileError, conditionProfileError],
  );

  const { showSnackbar } = useSnackbar();

  useEffect(() => {
    const refreshOnFocus = async () => {
      if (shouldRefresh) {
        await tripRefetch();
        await destinationRefetch();
        removeRefreshScreen("trip-details");
      }
    };
    refreshOnFocus();
  }, [shouldRefresh]);

  useEffect(() => {
    if (tripDetails && destinationDetails) {
      setTripViewModel(
        convertTripResponseToViewModel(
          tripDetails,
          tripSummary,
          destinationDetails,
          categoryProfile,
          conditionProfile,
        ),
      );
    }
  }, [
    tripDetails,
    tripSummary,
    destinationDetails,
    categoryProfile,
    conditionProfile,
  ]);

  const labels: Record<string, string> = {
    name: "Nazwa wycieczki",
    dateRange: "Termin wycieczki",
    destination: "Cel wycieczki",
    numberOfTripPoints: "Liczba punktów wycieczki",
    numberOfTravelers: "Liczba osób",
    predictedCost: "Przewidywany koszt wycieczki",
    actualCost: "Ogólny koszt wycieczki",
    budget: "Budżet wycieczki",
    categoryProfileName: "Profil preferencji",
    conditionProfileName: "Profil udogodnień",
    note: "Notatki",
  };

  const dateToIdMap = useMemo(() => {
    return new Map(
      tripDetails?.tripDays.map((day: TripDay) => [day.date, day.id]) || [],
    );
  }, [tripDetails]);

  const handlePress = () => setDateModalVisible(true);

  useLayoutEffect(() => {
    navigation.setOptions({
      actions: [
        {
          hasMenu: true,
          menuActions: [
            ...conditionalItem(
              new Date(tripDetails?.endDate ?? new Date()) >= new Date(),
              {
                title: "Edytuj",
                icon: EDIT_ICON_MATERIAL,
                color: theme.colors.onSurface,
                onPress: () => router.push(`/trips/edit/${trip_id}`),
              },
            ),
            {
              title: "Zobacz notatkę",
              icon: NOTE_ICON_MATERIAL,
              color: theme.colors.onSurface,
              onPress: () => router.push(`/trips/note/${trip_id}`),
            },
            {
              title: "Usuń",
              icon: DELETE_ICON,
              color: theme.colors.error,
              onPress: () => showRemovalModal(),
            },
          ],
        },
      ],
    });
  }, [navigation, tripDetails]);

  const handleDismiss = useCallback(() => setDateModalVisible(false), []);

  const handleConfirm = useCallback(
    ({ date }: { date: CalendarDate }) => {
      const formattedDate = formatDateToISO(date as Date);
      const tripDayId = dateToIdMap.get(formattedDate);
      if (tripDayId) {
        setDateModalVisible(false);
        router.push({
          pathname: `/trips/details/${trip_id}/day/${tripDayId}`,
          params: { tripName: tripDetails?.name },
        });
      }
    },
    [trip_id, tripDetails, dateToIdMap],
  );

  const renderFAB = () => {
    const version = process.env.EXPO_PUBLIC_FEATURE_VERSION || "v1";

    switch (version) {
      case "v2":
        return (
          <FAB
            color={theme.colors.onPrimary}
            style={styles.fab}
            icon={CALENDAR_ICON}
            label="Wybierz dzień"
            customSize={width * 0.1}
            onPress={handlePress}
          />
        );
      case "v3":
        return (
          <FAB
            color={theme.colors.onPrimary}
            style={[styles.fab, styles.fabV3]}
            label="Otwórz kalendarz wycieczki"
            customSize={width * 0.1}
            onPress={handlePress}
          />
        );
      case "v1":
      default:
        return (
          <FAB
            color={theme.colors.onPrimary}
            style={styles.fab}
            icon={CALENDAR_ICON}
            customSize={width * 0.25}
            onPress={handlePress}
          />
        );
    }
  };

  if (loading) return <LoadingView transparent={false} />;
  if (error) {
    router.back();
    showSnackbar(error?.toString() || "Unknown error", "error");
    return null;
  }

  return (
    <>
      <View style={styles.container}>
        <ScrollView contentContainerStyle={styles.scrollContent}>
          <Image
            source={resolvedImageSource}
            style={styles.image}
            resizeMode="cover"
          />

          <View style={styles.detailsContainer}>
            <View style={styles.entriesContainer}>
              {tripViewModel &&
                Object.entries(tripViewModel)
                  .filter(([key]) => key in labels)
                  .map(([key, value]) => (
                    <TripDetailLabel
                      key={key}
                      title={labels[key]}
                      value={value ? value.toString() : ""}
                    />
                  ))}
            </View>

            {renderFAB()}
          </View>
        </ScrollView>

        {tripDetails && (
          <SingleDatePickerModal
            visible={dateModalVisible}
            startDate={tripDetails?.startDate}
            endDate={tripDetails?.endDate}
            onDismiss={handleDismiss}
            onConfirm={handleConfirm}
          />
        )}
      </View>

      <CustomModal visible={isModalVisible} onDismiss={hideModal}>
        <View>
          <Text style={styles.modalTitleText}>
            Czy na pewno chcesz usunąć tą wycieczkę?
          </Text>
          <View style={styles.modalContent}>
            <Text style={styles.boldText}>{tripViewModel?.name}</Text>
            <Text style={styles.modalSubtitle}>{tripViewModel?.dateRange}</Text>
          </View>
          <ActionTextButtons
            onAction1={hideModal}
            onAction2={() => deleteTrip(tripDetails?.id)}
            action1ButtonLabel="Anuluj"
            action2ButtonLabel="Usuń"
            action1Icon={undefined}
            action2Icon={undefined}
          />
        </View>
      </CustomModal>
    </>
  );
};

export default TripDetailsView;

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    scrollContent: {
      alignItems: "center",
      paddingBottom: 25,
    },
    detailsContainer: {
      width: "100%",
      flexDirection: "row",
      justifyContent: "space-between",
      alignItems: "center",
      position: "relative",
    },
    entriesContainer: {
      flex: 1,
      paddingRight: 16,
    },
    fab: {
      backgroundColor: theme.colors.primary,
      position: "absolute",
      top: 16,
      right: 16,
      borderRadius: 10000,
    },
    fabV2: {
      borderRadius: 12,
      top: 24,
    },
    fabV3: {
      borderRadius: 20,
      backgroundColor: theme.colors.tertiary,
      top: 10,
    },
    image: {
      marginBottom: 25,
      width: "100%",
      height: height * 0.25,
    },
    modalTitleText: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
    },
    modalContent: {
      marginVertical: 20,
    },
    boldText: {
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    modalSubtitle: {
      color: theme.colors.onSurface,
    },
  });
