import React, { useState, useEffect } from "react";
import { StyleSheet, ScrollView, View } from "react-native";
import {
  useTheme,
  Button,
  Modal,
  Portal,
  Text,
  Divider,
  Avatar,
} from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { stringToDate, formatDateToPolish } from "@/utils/TimeUtils";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";

interface SingleDatePickerModalProps {
  visible: boolean;
  startDate: string;
  endDate: string;
  onDismiss: () => void;
  onConfirm: ({ date }: { date: CalendarDate }) => void;
}

const SingleDatePickerModal3 = ({
  visible,
  startDate,
  endDate,
  onDismiss,
  onConfirm,
}: SingleDatePickerModalProps) => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = createStyles(theme);

  const [daysList, setDaysList] = useState<
    { date: string; dayIndex: number }[]
  >([]);

  useEffect(() => {
    const list: { date: string; dayIndex: number }[] = [];
    const current = stringToDate(startDate);
    const end = stringToDate(endDate);
    let index = 1;

    while (current <= end) {
      list.push({
        date: current.toISOString().split("T")[0],
        dayIndex: index,
      });
      current.setDate(current.getDate() + 1);
      index++;
    }
    setDaysList(list);
  }, [startDate, endDate]);

  const handleConfirm = (day: string) => {
    onConfirm({ date: stringToDate(day) });
    onDismiss();
  };

  return (
    <Portal>
      <Modal
        visible={visible}
        onDismiss={onDismiss}
        contentContainerStyle={styles.modalContainer}
      >
        <View style={styles.header}>
          <Avatar.Icon
            size={40}
            icon="calendar-multiselect"
            style={styles.headerIcon}
          />
          <View>
            <Text style={styles.modalTitle}>Harmonogram wycieczki</Text>
            <Text style={styles.modalSubtitle}>
              Wybierz dzień do zaplanowania
            </Text>
          </View>
        </View>

        <Divider style={styles.divider} />

        <ScrollView style={styles.scrollContainer}>
          <View style={styles.listPadding}>
            {daysList.map((item) => {
              const dateObj = stringToDate(item.date);
              return (
                <Button
                  key={item.date}
                  mode="contained-tonal"
                  style={styles.dayCard}
                  contentStyle={styles.dayCardContent}
                  onPress={() => handleConfirm(item.date)}
                >
                  <View style={styles.buttonInnerRow}>
                    <View style={styles.dayBadge}>
                      <Text style={styles.dayBadgeText}>{item.dayIndex}</Text>
                    </View>
                    <View style={styles.dateInfo}>
                      <Text style={styles.dateText}>
                        {formatDateToPolish(dateObj)}
                      </Text>
                    </View>
                  </View>
                </Button>
              );
            })}
          </View>
        </ScrollView>

        <Button
          mode="text"
          onPress={onDismiss}
          textColor={theme.colors.error}
          style={styles.cancelButton}
        >
          Zamknij
        </Button>
      </Modal>
    </Portal>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    modalContainer: {
      backgroundColor: theme.colors.surface,
      marginHorizontal: 20,
      borderRadius: 24,
      maxHeight: "75%",
      paddingVertical: 20,
    },
    header: {
      flexDirection: "row",
      alignItems: "center",
      paddingHorizontal: 24,
      marginBottom: 16,
      gap: 12,
    },
    headerIcon: {
      backgroundColor: theme.colors.primaryContainer,
    },
    modalTitle: {
      fontSize: 20,
      fontWeight: "bold",
      color: theme.colors.onSurface,
    },
    modalSubtitle: {
      fontSize: 14,
      color: theme.colors.onSurfaceVariant,
    },
    divider: {
      marginBottom: 8,
    },
    scrollContainer: {
      paddingHorizontal: 16,
    },
    listPadding: {
      paddingVertical: 8,
    },
    dayCard: {
      marginVertical: 6,
      borderRadius: 12,
      borderWidth: 0,
    },
    dayCardContent: {
      height: 56,
      justifyContent: "flex-start",
    },
    buttonInnerRow: {
      flexDirection: "row",
      alignItems: "center",
      width: "100%",
    },
    dayBadge: {
      backgroundColor: theme.colors.primary,
      width: 28,
      height: 28,
      borderRadius: 14,
      justifyContent: "center",
      alignItems: "center",
      marginRight: 12,
    },
    dayBadgeText: {
      color: theme.colors.onPrimary,
      fontSize: 12,
      fontWeight: "bold",
    },
    dateInfo: {
      flexDirection: "column",
      alignItems: "flex-start",
    },
    dateText: {
      fontSize: 16,
      color: theme.colors.onSecondaryContainer,
    },
    cancelButton: {
      marginTop: 8,
      alignSelf: "center",
    },
  });

export default SingleDatePickerModal3;
