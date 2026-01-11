import React, { useState, useEffect } from "react";
import { StyleSheet, ScrollView, View } from "react-native";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useTheme, Button, Modal, Portal, Text } from "react-native-paper";
import { stringToDate, formatDateToPolish } from "@/utils/TimeUtils";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";

interface SingleDatePickerModalProps {
  visible: boolean;
  startDate: string;
  endDate: string;
  onDismiss: () => void;
  onConfirm: ({ date }: { date: CalendarDate }) => void;
}

const SingleDatePickerModal2 = ({
  visible,
  startDate,
  endDate,
  onDismiss,
  onConfirm,
}: SingleDatePickerModalProps) => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = createStyles(theme);

  const start = stringToDate(startDate);
  const end = stringToDate(endDate);
  start.setDate(start.getDate() + 1);
  end.setDate(end.getDate() + 1);

  const [daysList, setDaysList] = useState<string[]>([]);

  useEffect(() => {
    const list: string[] = [];
    const current = new Date(start);
    while (current <= end) {
      list.push(current.toISOString().split("T")[0]);
      current.setDate(current.getDate() + 1);
    }
    setDaysList(list);
  }, [startDate, endDate]);

  const handleConfirm = (day: string) => {
    const dateObj = stringToDate(day);
    onConfirm({ date: dateObj });
    onDismiss();
  };

  return (
    <Portal>
      <Modal
        visible={visible}
        onDismiss={onDismiss}
        contentContainerStyle={styles.modalContainer}
      >
        <Text style={styles.modalTitle}>Wybierz dzień</Text>

        <ScrollView style={styles.scrollContainer}>
          <View>
            {daysList.map((day) => (
              <Button
                key={day}
                mode="outlined"
                style={styles.dateButton}
                onPress={() => handleConfirm(day)}
              >
                {formatDateToPolish(stringToDate(day))}
              </Button>
            ))}
          </View>
        </ScrollView>

        <Button onPress={onDismiss} style={styles.closeButton}>
          Anuluj
        </Button>
      </Modal>
    </Portal>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    modalContainer: {
      backgroundColor: theme.colors.surface,
      padding: 16,
      marginHorizontal: 16,
      borderRadius: 12,
      maxHeight: "80%",
    },
    modalTitle: {
      ...theme.fonts.titleMedium,
      color: theme.colors.onSurface,
      marginBottom: 12,
      textAlign: "center",
    },
    scrollContainer: {
      maxHeight: 300,
    },
    dateButton: {
      marginVertical: 4,
    },
    closeButton: {
      marginTop: 12,
    },
  });

export default SingleDatePickerModal2;
