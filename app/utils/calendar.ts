import * as Calendar from "expo-calendar";
import { useEffect } from "react";
import { Platform } from "react-native";
import { Colors } from "@/constants/Colors";
import { TripDay } from "@/types/Trip";
import { TripPointCompact } from "@/types/TripDayData";

const CALENDAR_IDENTIFIER = "travelbuddy-calendar";

const getDefaultCalendar = async (): Promise<string> => {
  if (Platform.OS === "ios") {
    return (await Calendar.getDefaultCalendarAsync()).id;
  } else {
    const calendars = await Calendar.getCalendarsAsync();
    const defaultCalendar = calendars.find(
      (cal) => cal.source.name === CALENDAR_IDENTIFIER,
    );

    if (!defaultCalendar) {
      return createDefaultCalendar();
    }

    return defaultCalendar.id;
  }
};

async function createDefaultCalendar(): Promise<string> {
  const source = {
    name: CALENDAR_IDENTIFIER,
    isLocalAccount: true,
  } as Calendar.Source;
  return await Calendar.createCalendarAsync({
    title: "TravelBuddy",
    color: Colors.light.primary,
    entityType: Calendar.EntityTypes.EVENT,
    sourceId: source.id,
    source,
    name: "TravelBuddy",
    ownerAccount: "personal",
    accessLevel: Calendar.CalendarAccessLevel.OWNER,
    isVisible: true,
  });
}

export default function CalendarUtil() {
  useEffect(() => {
    (async () => {
      await Calendar.requestCalendarPermissionsAsync();
    })();
  }, []);

  return null;
}

export async function addEventToMainCalendar(
  data: Omit<Partial<Calendar.Event>, "id">,
): Promise<boolean> {
  const calendarId = await getDefaultCalendar();

  try {
    const eventId = await Calendar.createEventAsync(calendarId, data);
    Calendar.openEventInCalendar(eventId);
    return true;
  } catch (error) {
    console.error(error);
  }
  return false;
}

export async function addTripDayPointsToCalendar(
  tripDay: TripDay | undefined,
  tripPoints: TripPointCompact[],
): Promise<boolean> {
  try {
    if (!tripDay || tripPoints.length === 0) {
      console.error("Brak punktów w tym dniu");
      return false;
    }

    const sorted = [...tripPoints].sort((a, b) =>
      a.startTime.localeCompare(b.startTime),
    );

    for (const point of sorted) {
      const startDate = new Date(`${tripDay?.date}T${point.startTime}`);
      const endDate = new Date(`${tripDay?.date}T${point.endTime}`);

      await addEventToMainCalendar({
        title: point.name,
        startDate: startDate,
        endDate: endDate,
        timeZone: "GMT+1",
      });
    }
  } catch (err) {
    console.error(err);
    return false;
  }
  return true;
}

export async function addWholeTripDayToCalendar(
  tripDay: TripDay | undefined,
  tripPoints: TripPointCompact[],
  tripName: string | undefined,
): Promise<boolean> {
  try {
    if (!tripDay || tripName || tripPoints.length === 0) {
      console.error("Brak punktów w tym dniu");
      return false;
    }

    const sorted = [...tripPoints].sort((a, b) =>
      a.startTime.localeCompare(b.startTime),
    );

    const first = sorted[0];
    const last = sorted[sorted.length - 1];

    const startDate = new Date(`${tripDay.date}T${first.startTime}`);
    const endDate = new Date(`${tripDay.date}T${last.endTime}`);

    const notes = sorted
      .map((p) => `• ${p.startTime}-${p.endTime} ${p.name}`)
      .join("\n");

    await addEventToMainCalendar({
      title: `${tripName} – ${tripDay.date}`,
      startDate: startDate,
      endDate: endDate,
      notes: notes,
      timeZone: "GMT+1",
    });
  } catch (err) {
    console.error(err);
    return false;
  }
  return true;
}
