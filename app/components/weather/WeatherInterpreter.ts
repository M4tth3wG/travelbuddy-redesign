import { DaySummaryResponse } from "@/services/open_weather.service";

export interface ClothingTip {
  text: string;
  icon: string;
  severity: "info" | "warning" | "alert";
}

const MESSAGES = {
  rain: {
    heavy: [
      "Ulewa! Potrzebne nieprzemakalne buty i solidny płaszcz.",
      "Zapowiada się mocny deszcz, wybierz kalosze i kurtkę przeciwdeszczową.",
      "Intensywne opady. Bez porządnego płaszcza ani rusz!",
    ],
    moderate: [
      "Pada deszcz. Nie zapomnij o parasolu.",
      "Mokro na zewnątrz. Weź ze sobą parasolkę.",
      "Deszczowa aura. Parasol będzie dziś Twoim najlepszym przyjacielem.",
    ],
    light: [
      "Możliwa mżawka. Lekka kurtka z kapturem powinna wystarczyć.",
      "Spodziewany lekki opad. Coś z kapturem będzie dobrym wyborem.",
      "Może trochę kropić. Przyda się lekka warstwa ochronna.",
    ],
  },
  temp: {
    freezing: [
      "Mróz! Bielizna termiczna i gruba kurtka obowiązkowe.",
      "Bardzo zimno. Ubierz się najcieplej jak możesz.",
      "Ujemne temperatury. Nie zapomnij o czapce i ciepłych rękawicach.",
    ],
    cold: {
      humid: [
        "Zimno i wilgotno. Ubierz się warstwowo.",
        "Przenikliwy chłód. Wybierz ubiór na cebulkę.",
      ],
      dry: [
        "Chłodno. Załóż płaszcz lub grubszą kurtkę.",
        "Zimno. Przyda się coś ciepłego na wierzch.",
      ],
    },
    mild: [
      "Umiarkowanie. Dobry czas na bluzę lub bomberkę.",
      "Nie za ciepło, nie za zimno. Lekka kurtka będzie idealna.",
      "Przyjemna temperatura na sweter lub przejściową kurtkę.",
    ],
    warm: [
      "Ciepło. T-shirt i krótkie spodenki wystarczą.",
      "Słonecznie i przyjemnie. Wybierz coś lekkiego.",
      "Idealna pogoda na letnie ubrania.",
    ],
    hot: {
      humid: [
        "Upał i duszno. Unikaj pełnego słońca.",
        "Bardzo gorąco i wilgotno. Szukaj cienia.",
      ],
      dry: [
        "Bardzo gorąco. Postaw na len i jasne kolory.",
        "Upał. Wybierz najbardziej przewiewne ubrania.",
      ],
    },
  },
  wind: [
    "Silny wiatr! Zrezygnuj z kapeluszy, załóż wiatrówkę.",
    "Mocno wieje. Coś chroniącego przed wiatrem będzie niezbędne.",
    "Porywisty wiatr. Uważaj na luźne nakrycia głowy.",
  ],
  sun: [
    "Bezchmurne niebo. Okulary i krem z filtrem zalecane.",
    "Dużo słońca. Nie zapomnij o okularach przeciwsłonecznych.",
    "Oślepiające słońce. Weź okulary i coś na głowę.",
  ],
  amplitude: [
    "Duża różnica temperatur. Weź coś na wierzch na wieczór.",
    "Wieczorem znacznie się ochłodzi. Przyda się dodatkowa warstwa.",
    "Chłodny wieczór po ciepłym dniu. Pamiętaj o bluzie.",
  ],
};

const getRandom = (arr: string[]): string =>
  arr[Math.floor(Math.random() * arr.length)];

export const getClothingTips = (data: DaySummaryResponse): ClothingTip[] => {
  const tips: ClothingTip[] = [];

  const tempMin = data.temperature.min;
  const tempAfternoon = data.temperature.afternoon;
  const rainTotal = data.precipitation.total;
  const humidity = data.humidity.afternoon;
  const windSpeed = data.wind.max.speed;
  const clouds = data.cloud_cover.afternoon;

  if (rainTotal > 10) {
    tips.push({
      text: getRandom(MESSAGES.rain.heavy),
      icon: "weather-pouring",
      severity: "alert",
    });
  } else if (rainTotal > 1) {
    tips.push({
      text: getRandom(MESSAGES.rain.moderate),
      icon: "umbrella",
      severity: "warning",
    });
  } else if (rainTotal > 0) {
    tips.push({
      text: getRandom(MESSAGES.rain.light),
      icon: "weather-partly-rainy",
      severity: "info",
    });
  }

  const isHumid = humidity > 65;

  if (tempAfternoon < 0) {
    tips.push({
      text: getRandom(MESSAGES.temp.freezing),
      icon: "snowflake",
      severity: "alert",
    });
  } else if (tempAfternoon < 10) {
    tips.push({
      text: getRandom(
        isHumid ? MESSAGES.temp.cold.humid : MESSAGES.temp.cold.dry,
      ),
      icon: "jacket",
      severity: "warning",
    });
  } else if (tempAfternoon < 18) {
    tips.push({
      text: getRandom(MESSAGES.temp.mild),
      icon: "tshirt-crew",
      severity: "info",
    });
  } else if (tempAfternoon < 26) {
    tips.push({
      text: getRandom(MESSAGES.temp.warm),
      icon: "tshirt",
      severity: "info",
    });
  } else {
    tips.push({
      text: getRandom(
        isHumid ? MESSAGES.temp.hot.humid : MESSAGES.temp.hot.dry,
      ),
      icon: "weather-sunny",
      severity: "alert",
    });
  }

  if (windSpeed > 30) {
    tips.push({
      text: getRandom(MESSAGES.wind),
      icon: "weather-windy",
      severity: "warning",
    });
  }

  if (clouds < 20) {
    tips.push({
      text: getRandom(MESSAGES.sun),
      icon: "sunglasses",
      severity: "warning",
    });
  }

  if (tempAfternoon - tempMin > 10) {
    tips.push({
      text: getRandom(MESSAGES.amplitude),
      icon: "thermometer-chevron-down",
      severity: "info",
    });
  }

  return tips;
};
