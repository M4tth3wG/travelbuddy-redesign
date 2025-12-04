import React, { useState, useEffect } from "react";
import { View, StyleSheet, Dimensions, ScrollView } from "react-native";
import { TextInput, Text, useTheme } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useSnackbar } from "@/context/SnackbarContext";
import { useRouter, useLocalSearchParams } from "expo-router";
import ActionButtons from "@/components/ActionButtons";
import { useTripNotes, useSaveTripNote } from "@/composables/useTripDetails";

const { width } = Dimensions.get("window");

const TripNoteView = () => {
  const theme = useTheme() as MD3ThemeExtended;
  const styles = createStyles(theme);
  const router = useRouter();
  const params = useLocalSearchParams<{ tripId: string }>();
  const { tripId } = params;
  const { showSnackbar } = useSnackbar();

  const { notes, refetch } = useTripNotes(tripId || null);
  const { saveNote, loading, error } = useSaveTripNote(tripId || null);

  const [content, setContent] = useState("");

  useEffect(() => {
    if (notes) setContent(notes.content);
  }, [notes]);

  const handleSave = async () => {
    if (!content.trim()) {
      showSnackbar("Notatka nie może być pusta", "error");
      return;
    }

    const success = await saveNote(content);
    if (success) {
      showSnackbar("Notatka została zapisana!", "success");
      refetch();
      router.back();
    } else if (error) {
      showSnackbar(error, "error");
    }
  };

  const handleReset = () => {
    setContent(notes?.content || "");
  };

  return (
    <View style={styles.container}>
      <ScrollView contentContainerStyle={styles.scrollContent}>
        <Text style={styles.title}>Notatka do wycieczki</Text>
        <TextInput
          mode="outlined"
          label="Twoja notatka"
          value={content}
          onChangeText={setContent}
          multiline
          numberOfLines={10}
          style={styles.textInput}
          placeholder="Np. szczegóły dotyczące tej wycieczki..."
          textAlignVertical="top"
        />
      </ScrollView>

      <ActionButtons
        onAction1={handleReset}
        onAction2={handleSave}
        action1ButtonLabel="Reset"
        action2ButtonLabel={loading ? "Zapisywanie..." : "Zapisz"}
        action1Icon={undefined}
        action2Icon={undefined}
      />
    </View>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: theme.colors.surface,
    },
    scrollContent: {
      paddingHorizontal: 0.05 * width,
      paddingBottom: 120,
    },
    title: {
      ...theme.fonts.titleLarge,
      color: theme.colors.onSurface,
      marginBottom: 20,
    },
    textInput: {
      backgroundColor: theme.colors.surface,
      minHeight: 200,
    },
  });

export default TripNoteView;
