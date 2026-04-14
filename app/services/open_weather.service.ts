import axios, { AxiosInstance } from "axios";

export interface WeatherCoordinates {
  lat: number;
  lon: number;
}

export interface WeatherOptions {
  units?: "metric" | "imperial" | "standard";
  lang?: string;
}

export interface DaySummaryResponse {
  lat: number;
  lon: number;
  tz: string;
  date: string;
  units: string;
  cloud_cover: { afternoon: number };
  humidity: { afternoon: number };
  precipitation: { total: number };
  temperature: {
    min: number;
    max: number;
    afternoon: number;
    night: number;
    evening: number;
    morning: number;
  };
  pressure: { afternoon: number };
  wind: {
    max: { speed: number; direction: number };
  };
}

export class OpenWeatherService {
  private axiosInstance: AxiosInstance;
  private readonly apiKey: string;

  /**
   * @param apiKey Your OpenWeather API Key
   * @param baseUrl Base URL for One Call API (Defaults to v3.0)
   */
  constructor(
    apiKey: string,
    baseUrl: string = "https://api.openweathermap.org/data/3.0",
  ) {
    this.apiKey = apiKey;
    this.axiosInstance = axios.create({
      baseURL: baseUrl,
    });
  }

  async getFullForecast(
    coords: WeatherCoordinates,
    options: WeatherOptions = {},
  ) {
    const { lat, lon } = coords;
    const { units = "metric", lang = "en" } = options;

    try {
      const response = await this.axiosInstance.get("/onecall", {
        params: {
          lat,
          lon,
          units,
          lang,
          appid: this.apiKey,
        },
      });
      return response.data;
    } catch (error) {
      this.handleError(error);
    }
  }

  async getWeatherByTimestamp(
    coords: WeatherCoordinates,
    timestamp: number,
    options: WeatherOptions = {},
  ) {
    const { lat, lon } = coords;
    const { units = "metric", lang = "en" } = options;

    try {
      const response = await this.axiosInstance.get("/onecall/timemachine", {
        params: {
          lat,
          lon,
          dt: timestamp,
          units,
          lang,
          appid: this.apiKey,
        },
      });
      return response.data;
    } catch (error) {
      this.handleError(error);
    }
  }

  async getDaySummary(
    coords: WeatherCoordinates,
    date: string,
    options: WeatherOptions = {},
  ): Promise<DaySummaryResponse | undefined> {
    const { lat, lon } = coords;
    const { units = "metric", lang = "en" } = options;

    try {
      const response = await this.axiosInstance.get<DaySummaryResponse>(
        "/onecall/day_summary",
        {
          params: {
            lat,
            lon,
            date,
            units,
            lang,
            appid: this.apiKey,
          },
        },
      );
      return response.data;
    } catch (error) {
      this.handleError(error);
    }
  }

  private handleError(error: unknown): never {
    if (axios.isAxiosError(error)) {
      const status = error.response?.status;
      const message =
        (error.response?.data as { message?: string })?.message ||
        error.message;

      if (status === 401) {
        throw new Error(
          `Authentication Error: Ensure the 'One Call by Call' plan is active. Details: ${message}`,
        );
      }

      throw new Error(`OpenWeather API Error (${status}): ${message}`);
    }

    if (error instanceof Error) {
      throw new Error(`System Error: ${error.message}`);
    }

    throw new Error("An unexpected error occurred during API communication.");
  }
}
