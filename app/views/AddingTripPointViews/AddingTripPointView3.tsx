/* eslint-disable @typescript-eslint/no-explicit-any */
import {
  StyleSheet,
  View,
  Dimensions,
  ScrollView,
  KeyboardAvoidingView,
  Platform,
} from "react-native";
import React, { useEffect, useMemo, useState } from "react";
import {
  useTheme,
  MD3Theme,
  TextInput,
  Text,
  SegmentedButtons,
  Surface,
  List,
} from "react-native-paper";
import {
  addHoursToTheSameDay,
  formatTime,
  roundToNearestQuarterHour,
} from "@/utils/TimeUtils";
import CurrencyValueInput from "@/components/CurrencyValueInput";
import ActionButtons from "@/components/ActionButtons";
import TimePicker from "@/components/TimePicker";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import SettingsBottomSheet from "@/components/SettingsBottomSheet";
import { TripErrors } from "@/types/Trip";
import TripPointTypePicker from "@/components/TripPointTypePicker";
import {
  TripPointRequest,
  TripPointDetails,
  Category,
} from "@/types/TripDayData";
import { Place } from "@/types/Place";
import { useLocalSearchParams, useRouter } from "expo-router";
import LoadingView from "../LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";
import { useTripDetails } from "@/composables/useTripDetails";
import usePlaceDetails from "@/composables/usePlace";
import { useAuth } from "@/app/ctx";
import {
  CATEGORY_NAME_LIST,
  CategoryLabelsForProfiles,
  DEFAULT_CATEGORY_NAME,
} from "@/types/Profile";
import { useGetCategories } from "@/composables/useCategoryCondition";
import {
  API_TRIP_POINT,
  ATTRACTION_DETAILS_ENDPOINT,
  PLACE_DETAILS_ENDPOINT,
} from "@/constants/Endpoints";
import {
  NEW_OVERLAPPING_ERROR_MESSAGE,
  OVERLAPPING_TRIP_POINTS_MESSAGE,
} from "@/constants/Messages";
import {
  requiredFieldsForTripPoint,
  onEndEditingString,
} from "@/utils/validations";
import { findAttractionCategory } from "@/utils/CategoryUtils";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { width } = Dimensions.get("window");

const AddingTripPointView3 = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();
  const { showSnackbar } = useSnackbar();
  const { addRefreshScreen } = useShouldRefresh();
  const { api } = useAuth();

  const { trip_id, day_id, date, attractionProviderId } =
    useLocalSearchParams();

  // --- LOGIKA POBIERANIA DANYCH ---
  const {
    tripDetails,
    loading: tripLoading,
    error: tripError,
  } = useTripDetails(trip_id as string);
  const {
    placeDetails: destinationDetails,
    loading: destLoading,
    error: destError,
  } = usePlaceDetails(
    attractionProviderId
      ? (attractionProviderId as string)
      : tripDetails?.destinationId,
    attractionProviderId ? ATTRACTION_DETAILS_ENDPOINT : PLACE_DETAILS_ENDPOINT,
  );
  const {
    items: categories,
    loading: catsLoading,
    error: catsError,
  } = useGetCategories();

  // --- STAN FORMULARZA ---
  const [tripPointName, setTripPointName] = useState("");
  const [comment, setComment] = useState("");
  const [expectedCost, setExpectedCost] = useState(0);
  const [costType, setCostType] = useState("perPerson");
  const [tripPointCategory, setTripPointCategory] = useState<
    Category | undefined
  >();
  const [startTime, setStartTime] = useState<Date>(roundToNearestQuarterHour());
  const [endTime, setEndTime] = useState<Date>(
    addHoursToTheSameDay(startTime, 1),
  );

  // Stany widoczności pickerów (Naprawa błędu TS)
  const [isStartPickerVisible, setIsStartPickerVisible] = useState(false);
  const [isEndPickerVisible, setIsEndPickerVisible] = useState(false);
  const [isSheetVisible, setIsSheetVisible] = useState(false);

  const [errors, setErrors] = useState<TripErrors>({});
  const [filteredCategories, setFilteredCategories] = useState<Category[]>([]);

  // Lokalizacja
  const [loc, setLoc] = useState({
    country: "",
    state: "",
    city: "",
    street: "",
    houseNumber: "",
    lat: "",
    lon: "",
  });

  useEffect(() => {
    const filtered = categories.filter((c: Category) =>
      CATEGORY_NAME_LIST.includes(c.name),
    );
    setFilteredCategories(filtered);

    if (destinationDetails) {
      setLoc({
        country: destinationDetails.country || "",
        state: destinationDetails.state || "",
        city: destinationDetails.city || "",
        street: destinationDetails.street || "",
        houseNumber: destinationDetails.houseNumber || "",
        lat: destinationDetails.latitude?.toString() || "",
        lon: destinationDetails.longitude?.toString() || "",
      });
      if (attractionProviderId) {
        setTripPointName(destinationDetails.name);
        const catName =
          destinationDetails.superCategory?.name ??
          findAttractionCategory(destinationDetails);
        setTripPointCategory(filtered.find((c) => c.name === catName));
      } else {
        setTripPointCategory(
          filtered.find((c) => c.name === DEFAULT_CATEGORY_NAME),
        );
      }
    }
  }, [destinationDetails, categories]);

  const onSave = async () => {
    // Prosta walidacja na potrzeby przykładu
    if (!tripPointName) {
      setErrors({ tripPointName: "Nazwa jest wymagana" });
      return;
    }

    try {
      let totalExpectedCost = expectedCost;
      if (costType === "perPerson") {
        totalExpectedCost =
          (tripDetails?.numberOfTravelers || 1) * expectedCost;
      }

      const { lat, lon, ...addressData } = loc;

      const request: TripPointRequest = {
        name: tripPointName,
        comment: comment,
        tripDayId: day_id as string,
        place: {
          ...addressData,
          name: destinationDetails?.name || tripPointName,
          providerId: attractionProviderId as string,
          superCategoryId: tripPointCategory?.id,
          latitude: loc.lat ? parseFloat(loc.lat) : null,
          longitude: loc.lon ? parseFloat(loc.lon) : null,
        } as unknown as Place,
        startTime: formatTime(startTime, true),
        endTime: formatTime(endTime, true),
        predictedCost: totalExpectedCost,
      };

      await api!.post(API_TRIP_POINT, request);
      showSnackbar("Punkt dodany!");
      addRefreshScreen("trip-day");
      router.back();
    } catch (err: any) {
      showSnackbar("Błąd zapisu: " + (err.response?.data || "Nieznany błąd"));
    }
  };

  if (tripLoading || destLoading || catsLoading)
    return <LoadingView transparent={false} />;

  return (
    <GestureHandlerRootView style={{ flex: 1 }}>
      <KeyboardAvoidingView
        behavior={Platform.OS === "ios" ? "padding" : undefined}
        style={{ flex: 1 }}
      >
        <ScrollView
          style={styles.scrollView}
          keyboardShouldPersistTaps="handled"
        >
          <View style={styles.header}>
            <Text variant="headlineSmall" style={styles.headerTitle}>
              Nowy Punkt
            </Text>
            <Text variant="bodyMedium" style={{ color: theme.colors.outline }}>
              {attractionProviderId
                ? "Dodajesz wybraną atrakcję"
                : "Zaplanuj własne wydarzenie"}
            </Text>
          </View>

          <View style={styles.content}>
            <Surface style={styles.surface} elevation={1}>
              <List.Section
                titleStyle={styles.sectionLabel}
                title="Informacje o aktywności"
              >
                <View style={styles.cardPadding}>
                  <TextInput
                    mode="flat"
                    label="Nazwa punktu"
                    value={tripPointName}
                    onChangeText={(val) => {
                      setTripPointName(val);
                      setErrors((prev) => ({ ...prev, tripPointName: "" }));
                    }}
                    error={!!errors.tripPointName}
                    style={styles.flatInput}
                  />
                  {errors.tripPointName && (
                    <Text style={styles.errorText}>{errors.tripPointName}</Text>
                  )}

                  <TripPointTypePicker
                    onPress={() => setIsSheetVisible(true)}
                    selectedCategory={tripPointCategory}
                    disabled={!!attractionProviderId}
                  />

                  <TextInput
                    mode="flat"
                    label="Komentarz / Notatki"
                    value={comment}
                    multiline
                    numberOfLines={3}
                    onChangeText={setComment}
                    style={[styles.flatInput, { height: 80 }]}
                  />
                </View>
              </List.Section>
            </Surface>

            <Surface style={styles.surface} elevation={1}>
              <List.Item
                title="Czas i Koszty"
                titleStyle={styles.sectionLabel}
                left={(p) => <List.Icon {...p} icon="calendar-clock" />}
              />
              <View style={styles.row}>
                <View style={{ flex: 1 }}>
                  <TimePicker
                    date={startTime}
                    onDateChange={setStartTime}
                    label="Rozpoczęcie"
                    showPicker={isStartPickerVisible}
                    setShowPicker={setIsStartPickerVisible}
                  />
                </View>
                <View style={{ flex: 1, marginLeft: 12 }}>
                  <TimePicker
                    date={endTime}
                    onDateChange={setEndTime}
                    label="Zakończenie"
                    showPicker={isEndPickerVisible}
                    setShowPicker={setIsEndPickerVisible}
                  />
                </View>
              </View>

              <View style={styles.divider} />

              <View style={styles.cardPadding}>
                <CurrencyValueInput
                  label="Koszt przewidywany"
                  budget={expectedCost}
                  currency={tripDetails?.currencyCode || "EUR"}
                  handleBudgetChange={setExpectedCost}
                />
                <SegmentedButtons
                  value={costType}
                  onValueChange={setCostType}
                  style={{ marginTop: 12 }}
                  buttons={[
                    { value: "perPerson", label: "Na osobę", icon: "account" },
                    { value: "total", label: "Łącznie", icon: "cash-multiple" },
                  ]}
                />
              </View>
            </Surface>

            <Surface style={styles.surface} elevation={1}>
              <List.Accordion
                title="Szczegóły lokalizacji"
                left={(p) => <List.Icon {...p} icon="map-marker" />}
              >
                <View style={styles.cardPadding}>
                  <TextInput
                    mode="outlined"
                    label="Kraj"
                    value={loc.country}
                    dense
                    style={styles.marginB}
                    disabled={!!attractionProviderId}
                  />
                  <TextInput
                    mode="outlined"
                    label="Miasto"
                    value={loc.city}
                    dense
                    style={styles.marginB}
                    disabled={!!attractionProviderId}
                  />
                  <TextInput
                    mode="outlined"
                    label="Ulica i numer"
                    value={`${loc.street} ${loc.houseNumber}`}
                    dense
                    disabled={!!attractionProviderId}
                  />
                </View>
              </List.Accordion>
            </Surface>
          </View>

          <View style={styles.actions}>
            <ActionButtons
              onAction1={() => router.back()}
              action1ButtonLabel="Anuluj"
              onAction2={onSave}
              action2ButtonLabel="Zapisz punkt"
              action1Icon={undefined}
              action2Icon={undefined}
            />
          </View>
        </ScrollView>

        <SettingsBottomSheet
          title="Wybierz kategorię"
          items={CategoryLabelsForProfiles}
          selectedItem={tripPointCategory?.name || DEFAULT_CATEGORY_NAME}
          isVisible={isSheetVisible}
          onSelect={(item) => {
            setTripPointCategory(
              filteredCategories.find((c) => c.name === item),
            );
            setIsSheetVisible(false);
          }}
          onClose={() => setIsSheetVisible(false)}
        />
      </KeyboardAvoidingView>
    </GestureHandlerRootView>
  );
};

export default AddingTripPointView3;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    scrollView: { flex: 1, backgroundColor: theme.colors.background },
    header: {
      padding: 24,
      paddingTop: 40,
      backgroundColor: theme.colors.surface,
    },
    headerRow: {
      flexDirection: "row",
      justifyContent: "space-between",
      alignItems: "center",
    },
    headerTitle: {
      fontWeight: "800",
      color: theme.colors.primary,
      letterSpacing: -0.5,
    },
    content: { padding: 16, gap: 16 },
    surface: {
      borderRadius: 20,
      overflow: "hidden",
      backgroundColor: theme.colors.surface,
    },
    cardPadding: { padding: 16, paddingTop: 0 },
    sectionLabel: {
      fontWeight: "700",
      color: theme.colors.primary,
      fontSize: 12,
      textTransform: "uppercase",
      letterSpacing: 1.2,
      marginBottom: 8,
    },
    flatInput: { backgroundColor: "transparent", marginBottom: 8 },
    row: { flexDirection: "row", paddingHorizontal: 16, marginBottom: 12 },
    divider: {
      height: 1,
      backgroundColor: theme.colors.outlineVariant,
      marginHorizontal: 24,
      marginBottom: 16,
    },
    marginB: { marginBottom: 12 },
    actions: { padding: 16, paddingBottom: 40 },
    errorText: {
      color: theme.colors.error,
      fontSize: 12,
      marginLeft: 16,
      marginBottom: 8,
    },
  });
