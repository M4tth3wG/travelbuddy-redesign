import React, { useState, useEffect } from "react";
import { View } from "react-native";
import { Text, ActivityIndicator, useTheme } from "react-native-paper";
import { useWeather } from "@/context/WeatherContext";
import { MaterialCommunityIcons } from "@expo/vector-icons";

// Pomocnicza funkcja do wyboru ikony na podstawie danych numerycznych
const getWeatherIcon = (rain: number, clouds: number) => {
  if (rain > 0) return "weather-rainy";
  if (clouds > 70) return "weather-cloudy";
  if (clouds > 20) return "weather-partly-cloudy";
  return "weather-sunny";
};

const WeatherBadge = ({
  lat,
  lon,
  date,
}: {
  lat: number;
  lon: number;
  date: string;
}) => {
  const theme = useTheme();
  const weatherService = useWeather();
  const [weather, setWeather] = useState<{ temp: number; icon: string } | null>(
    null,
  );
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    let isMounted = true;
    const fetchWeather = async () => {
      try {
        const data = await weatherService.getDaySummary({ lat, lon }, date);
        if (data && isMounted) {
          const iconName = getWeatherIcon(
            data.precipitation.total,
            data.cloud_cover.afternoon,
          );

          setWeather({
            temp: data.temperature.afternoon,
            icon: iconName,
          });
        }
      } catch (e) {
        console.error("Weather fetch error:", e);
      } finally {
        if (isMounted) setLoading(false);
      }
    };
    fetchWeather();
    return () => {
      isMounted = false;
    };
  }, [lat, lon, date]);

  if (loading)
    return <ActivityIndicator size="small" style={{ marginLeft: 15 }} />;
  if (!weather) return null;

  return (
    <View
      style={{
        flexDirection: "row",
        alignItems: "center",
        backgroundColor: theme.colors.secondaryContainer,
        borderRadius: 8,
        paddingHorizontal: 10,
        paddingVertical: 4,
        marginLeft: 15,
        alignSelf: "flex-start",
        marginTop: 8,
      }}
    >
      <MaterialCommunityIcons
        // eslint-disable-next-line @typescript-eslint/no-explicit-any
        name={weather.icon as any}
        size={16}
        color={theme.colors.onSecondaryContainer}
        style={{ marginRight: 6 }}
      />
      <Text
        style={{
          color: theme.colors.onSecondaryContainer,
          fontWeight: "bold",
          fontSize: 14,
        }}
      >
        {Math.round(weather.temp)}°C
      </Text>
      <Text
        style={{
          color: theme.colors.onSecondaryContainer,
          fontSize: 12,
          marginLeft: 6,
        }}
      >
        Prognoza popołudniowa
      </Text>
    </View>
  );
};

export default WeatherBadge;
