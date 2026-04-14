/* eslint-disable @typescript-eslint/no-explicit-any */
import React, { useEffect, useState } from "react";
import { View, StyleSheet, TouchableOpacity } from "react-native";
import { Text, useTheme } from "react-native-paper";
import { MaterialCommunityIcons } from "@expo/vector-icons";
import { MD3ThemeExtended } from "@/constants/Themes";
import { ClothingTip, getClothingTips } from "./WeatherInterpreter";
import { useWeather } from "@/context/WeatherContext";

export const WeatherAdviceCard = ({
  lat,
  lon,
  date,
}: {
  lat: number;
  lon: number;
  date: string;
}) => {
  const theme = useTheme() as MD3ThemeExtended;
  const weatherService = useWeather();
  const [tips, setTips] = useState<ClothingTip[]>([]);
  const [isCollapsed, setIsCollapsed] = useState(false);

  useEffect(() => {
    const loadAdvice = async () => {
      try {
        const summary = await weatherService.getDaySummary({ lat, lon }, date);
        if (summary) setTips(getClothingTips(summary));
      } catch (err) {
        console.warn("Weather advice failed", err);
      }
    };
    loadAdvice();
  }, [lat, lon, date]);

  if (tips.length === 0) return null;

  const getSeverityColor = (severity: string) => {
    if (severity === "alert") return theme.colors.error;
    if (severity === "warning") return "#FFA500";
    return theme.colors.primary;
  };

  if (isCollapsed) {
    return (
      <TouchableOpacity
        style={[
          styles.collapsedCircle,
          { backgroundColor: theme.colors.elevation.level2 },
        ]}
        onPress={() => setIsCollapsed(false)}
      >
        <MaterialCommunityIcons
          name="tshirt-crew"
          size={24}
          color={theme.colors.primary}
        />
      </TouchableOpacity>
    );
  }

  return (
    <View
      style={[styles.card, { backgroundColor: theme.colors.elevation.level2 }]}
    >
      <View style={styles.header}>
        <Text style={[styles.title, { color: theme.colors.onSurfaceVariant }]}>
          Rekomendacja ubioru:
        </Text>
        <TouchableOpacity onPress={() => setIsCollapsed(true)} hitSlop={10}>
          <MaterialCommunityIcons
            name="chevron-up"
            size={20}
            color={theme.colors.onSurfaceVariant}
          />
        </TouchableOpacity>
      </View>

      {tips.map((tip, i) => (
        <View key={i} style={styles.tipRow}>
          <View style={styles.iconContainer}>
            <MaterialCommunityIcons
              name={tip.icon as any}
              size={22}
              color={getSeverityColor(tip.severity)}
            />
          </View>
          <View style={styles.textContainer}>
            <Text style={[styles.tipText, { color: theme.colors.onSurface }]}>
              {tip.text}
            </Text>
          </View>
        </View>
      ))}
    </View>
  );
};

const styles = StyleSheet.create({
  card: {
    padding: 16,
    borderRadius: 16,
    width: "90%",
    alignSelf: "center",
    marginBottom: 20,
    borderWidth: 1,
    borderColor: "transparent",
  },
  header: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    marginBottom: 12,
  },
  collapsedCircle: {
    width: 44,
    height: 44,
    borderRadius: 22,
    justifyContent: "center",
    alignItems: "center",
    alignSelf: "flex-end",
    marginRight: "5%",
    marginBottom: 20,
    elevation: 3,
    shadowColor: "#000",
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 0.25,
    shadowRadius: 3.84,
  },
  title: {
    fontWeight: "bold",
    fontSize: 14,
    textTransform: "uppercase",
    letterSpacing: 0.5,
  },
  tipRow: {
    flexDirection: "row",
    alignItems: "flex-start",
    marginBottom: 10,
  },
  iconContainer: {
    width: 30,
    marginTop: 2,
  },
  textContainer: {
    flex: 1,
    paddingRight: 4,
  },
  tipText: {
    fontSize: 14,
    lineHeight: 20,
  },
});
