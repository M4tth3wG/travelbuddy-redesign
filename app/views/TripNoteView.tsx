import React, { useState, useEffect } from "react";
import { View, StyleSheet, Dimensions, ScrollView } from "react-native";
import { TextInput, Text, useTheme } from "react-native-paper";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useSnackbar } from "@/context/SnackbarContext";
import { useRouter, useLocalSearchParams } from "expo-router";
import ActionButtons from "@/components/ActionButtons";
import { useTripNotes, useSaveTripNote } from "@/composables/useTripDetails";
import LoadingView from "./LoadingView";
import { useShouldRefresh } from "@/context/ShouldRefreshContext";

const { width } = Dimensions.get("window");

const TripNoteView = () => {
  const theme = useTheme() as MD3ThemeExtended;
  const { addRefreshScreen } = useShouldRefresh();
  const styles = createStyles(theme);
  const router = useRouter();
  const params = useLocalSearchParams<{ trip_id: string }>();
  const { trip_id } = params;
  const { showSnackbar } = useSnackbar();

  const { notes, loading: getNoteLoading, refetch } = useTripNotes(trip_id);
  const {
    saveNote,
    loading: saveNoteLoading,
    error,
  } = useSaveTripNote(trip_id);

  // teraz notes jest obiektem { content: string } lub null
  const [content, setContent] = useState(notes?.content || "");

  // synchronizacja stanu content z notes.content
  useEffect(() => {
    if (notes !== null) setContent(notes.content);
  }, [notes]);

  const loading = getNoteLoading || saveNoteLoading;

  const handleSave = async () => {
    if (!content.trim()) {
      showSnackbar("Notatka nie może być pusta", "error");
      return;
    }

    if (content === notes?.content) {
      showSnackbar("Nie wprowadzono żadnych zmian", "info");
      return;
    }

    try {
      const updatedNote = await saveNote(content);
      if (updatedNote) {
        showSnackbar("Notatka została zapisana!", "success");
        addRefreshScreen("trip-details");
        router.back();
      } else if (error) {
        showSnackbar(error, "error");
      }
    } catch (err) {
      showSnackbar("Wystąpił błąd podczas zapisania notatki", "error");
    }
  };

  const handleReset = () => {
    setContent(notes?.content || "");
  };

  if (loading) return <LoadingView />;

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
