using System;
using System.Windows;
using System.Windows.Controls;

namespace sentry
{
    public partial class AddEventPopup : UserControl
    {
        public event EventHandler<EventData> EventAdded;
        public event EventHandler Cancelled;

        public AddEventPopup()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Please enter an event name.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create event data object
            var eventData = new EventData
            {
                EventName = txtEventName.Text,
                EventDate = dpEventDate.SelectedDate?.ToString("MMMM dd, yyyy") ?? DateTime.Now.ToString("MMMM dd, yyyy"),
                EventTime = txtEventTime.Text,
                Location = txtLocation.Text  // ADDED LOCATION
            };

            // Save to static store
            EventDataStore.SaveEvent(eventData.EventName, eventData.EventDate, eventData.EventTime, eventData.Location);

            // Raise event with data
            EventAdded?.Invoke(this, eventData);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Cancelled?.Invoke(this, EventArgs.Empty);
        }
    }

    public class EventData : EventArgs
    {
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public string Location { get; set; }  // ADDED
    }
}