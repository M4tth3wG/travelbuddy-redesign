import React, { createContext, useContext, useMemo } from "react";
import { OpenWeatherService } from "@/services/open_weather.service";

interface WeatherContextType {
  weatherService: OpenWeatherService;
}

const WeatherContext = createContext<WeatherContextType | undefined>(undefined);

export const WeatherProvider: React.FC<{ children: React.ReactNode }> = ({
  children,
}) => {
  const weatherService = useMemo(() => {
    return new OpenWeatherService(
      process.env.EXPO_PUBLIC_WEATHER_API_KEY || "",
    );
  }, []);

  return (
    <WeatherContext.Provider value={{ weatherService }}>
      {children}
    </WeatherContext.Provider>
  );
};

export const useWeather = () => {
  const context = useContext(WeatherContext);
  if (!context) {
    throw new Error("useWeather must be used within a WeatherProvider");
  }
  return context.weatherService;
};
