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
  IconButton,
} from "react-native-paper";
import {
  convertTimestampToDateTime,
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
import { TripPointDetails, Category } from "@/types/TripDayData";
import { useLocalSearchParams, useRouter } from "expo-router";
import LoadingView from "../LoadingView";
import { useSnackbar } from "@/context/SnackbarContext";
import { useAuth } from "@/app/ctx";
import {
  CATEGORY_NAME_LIST,
  CategoryLabelsForProfiles,
  DEFAULT_CATEGORY_NAME,
} from "@/types/Profile";
import { useGetCategories } from "@/composables/useCategoryCondition";
import { API_TRIP_POINT } from "@/constants/Endpoints";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { width } = Dimensions.get("window");

const EditingTripPointView3 = () => {
  const theme = useTheme();
  const styles = useMemo(() => createStyles(theme), [theme]);
  const router = useRouter();
  const { showSnackbar } = useSnackbar();
  const { addRefreshScreen } = useShouldRefresh();
  const { api } = useAuth();

  const { tripPointId } = useLocalSearchParams();

  const [loading, setLoading] = useState(true);
  const [tripPointName, setTripPointName] = useState("");
  const [comment, setComment] = useState("");
  const [expectedCost, setExpectedCost] = useState(0);
  const [startTime, setStartTime] = useState<Date>(new Date());
  const [endTime, setEndTime] = useState<Date>(new Date());
  const [tripPointCategory, setTripPointCategory] = useState<
    Category | undefined
  >();

  const [isStartPickerVisible, setIsStartPickerVisible] = useState(false);
  const [isEndPickerVisible, setIsEndPickerVisible] = useState(false);
  const [isSheetVisible, setIsSheetVisible] = useState(false);

  const { items: categories } = useGetCategories();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await api!.get<TripPointDetails>(
          `${API_TRIP_POINT}/${tripPointId}`,
        );
        const data = response.data;

        setTripPointName(data.name);
        setComment(data.comment || "");
        setExpectedCost(data.predictedCost);
        setStartTime(convertTimestampToDateTime(data.startTime));
        setEndTime(convertTimestampToDateTime(data.endTime));

        const cat = categories.find(
          (c) => c.id === data.place?.superCategory?.id,
        );
        setTripPointCategory(cat);
      } catch (err) {
        showSnackbar("Nie udało się pobrać danych punktu");
      } finally {
        setLoading(false);
      }
    };
    if (categories.length > 0) fetchData();
  }, [tripPointId, categories]);

  const onUpdate = async () => {
    try {
      const request = {
        name: tripPointName,
        comment: comment,
        startTime: formatTime(startTime, true),
        endTime: formatTime(endTime, true),
        predictedCost: expectedCost,
        // Zachowujemy resztę danych bez zmian w tym uproszczonym przykładzie
      };

      await api!.put(`${API_TRIP_POINT}/${tripPointId}`, request);
      showSnackbar("Zmiany zapisane");
      addRefreshScreen("trip-day");
      router.back();
    } catch (err) {
      showSnackbar("Błąd podczas aktualizacji");
    }
  };

  if (loading) return <LoadingView transparent={false} />;

  return (
    <GestureHandlerRootView style={{ flex: 1 }}>
      <KeyboardAvoidingView
        behavior={Platform.OS === "ios" ? "padding" : undefined}
        style={{ flex: 1 }}
      >
        <ScrollView style={styles.scrollView}>
          <View style={styles.header}>
            <View style={styles.headerRow}>
              <Text variant="headlineSmall" style={styles.headerTitle}>
                Edytuj Punkt
              </Text>
              <IconButton
                icon="delete-outline"
                iconColor={theme.colors.error}
                onPress={() => {}}
              />
            </View>
            <Text variant="bodyMedium" style={{ color: theme.colors.outline }}>
              Modyfikujesz istniejący element planu
            </Text>
          </View>

          <View style={styles.content}>
            <Surface style={styles.surface} elevation={1}>
              <List.Section
                titleStyle={styles.sectionLabel}
                title="Główna treść"
              >
                <View style={styles.cardPadding}>
                  <TextInput
                    mode="flat"
                    label="Nazwa punktu"
                    value={tripPointName}
                    onChangeText={setTripPointName}
                    style={styles.flatInput}
                  />

                  <TripPointTypePicker
                    onPress={() => setIsSheetVisible(true)}
                    selectedCategory={tripPointCategory}
                  />

                  <TextInput
                    mode="flat"
                    label="Twoje notatki"
                    value={comment}
                    multiline
                    onChangeText={setComment}
                    style={[styles.flatInput, { height: 100 }]}
                  />
                </View>
              </List.Section>
            </Surface>

            <Surface style={styles.surface} elevation={1}>
              <List.Item
                title="Czas i Budżet"
                titleStyle={styles.sectionLabel}
                left={(p) => <List.Icon {...p} icon="clock-edit-outline" />}
              />
              <View style={styles.row}>
                <View style={{ flex: 1 }}>
                  <TimePicker
                    date={startTime}
                    onDateChange={setStartTime}
                    label="Od"
                    showPicker={isStartPickerVisible}
                    setShowPicker={setIsStartPickerVisible}
                  />
                </View>
                <View style={{ flex: 1, marginLeft: 12 }}>
                  <TimePicker
                    date={endTime}
                    onDateChange={setEndTime}
                    label="Do"
                    showPicker={isEndPickerVisible}
                    setShowPicker={setIsEndPickerVisible}
                  />
                </View>
              </View>

              <View style={styles.divider} />

              <View style={styles.cardPadding}>
                <CurrencyValueInput
                  label="Koszt łączny"
                  budget={expectedCost}
                  currency="EUR"
                  handleBudgetChange={setExpectedCost}
                />
              </View>
            </Surface>
          </View>

          <View style={styles.actions}>
            <ActionButtons
              onAction1={() => router.back()}
              action1ButtonLabel="Odrzuć zmiany"
              onAction2={onUpdate}
              action2ButtonLabel="Zatwierdź edycję"
              action1Icon={undefined}
              action2Icon={undefined}
            />
          </View>
        </ScrollView>

        <SettingsBottomSheet
          title="Kategoria"
          items={CategoryLabelsForProfiles}
          selectedItem={tripPointCategory?.name || DEFAULT_CATEGORY_NAME}
          isVisible={isSheetVisible}
          onSelect={(item) => {
            setTripPointCategory(categories.find((c) => c.name === item));
            setIsSheetVisible(false);
          }}
          onClose={() => setIsSheetVisible(false)}
        />
      </KeyboardAvoidingView>
    </GestureHandlerRootView>
  );
};

export default EditingTripPointView3;

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
