using System;

namespace sentry
{
    public static class EventDataStore
    {
        public static string EventName { get; set; } = "No event added";
        public static string EventDate { get; set; } = "-";
        public static string EventTime { get; set; } = "-";
        public static string Location { get; set; } = "-";
        public static bool HasEvent { get; set; } = false;

        public static void SaveEvent(string name, string date, string time, string location)
        {
            EventName = name;
            EventDate = date;
            EventTime = time;
            Location = location;
            HasEvent = true;
        }

        public static void ClearEvent()
        {
            EventName = "No event added";
            EventDate = "-";
            EventTime = "-";
            Location = "-";
            HasEvent = false;
        }
    }
}