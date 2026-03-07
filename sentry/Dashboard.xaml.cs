using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace sentry
{
    public partial class Dashboard : UserControl
    {
        private AddEventPopup _popup;

        public Dashboard()
        {
            InitializeComponent();

            // Load saved event data when control is created
            Loaded += Dashboard_Loaded;
            LoadAttendance();
        }

        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            // Load event data from static store
            LoadEventData();
        }

        private void LoadEventData()
        {
            tbEventName.Text = EventDataStore.EventName;
            tbEventDate.Text = EventDataStore.EventDate;
            tbEventTime.Text = EventDataStore.EventTime;
            tbEventLocation.Text = EventDataStore.Location;
        }

        public void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (time_in.IsChecked == true)
            {
                // Time-in selected
            }
            else if (time_out.IsChecked == true)
            {
                // Time-out selected
            }
        }

        public void btnAddEvent_Click(object sender, RoutedEventArgs e)
        {
            // Create and configure popup
            _popup = new AddEventPopup();
            _popup.EventAdded += OnEventAdded;
            _popup.Cancelled += OnPopupCancelled;

            // Add to container and show
            PopupContainer.Children.Clear();
            PopupContainer.Children.Add(_popup);
            PopupContainer.Visibility = Visibility.Visible;

            // Disable main content
            //MainContent.IsEnabled = false;
        }

        private void OnEventAdded(object sender, EventData e)
        {
            // Update TextBlocks with event data from static store
            LoadEventData();

            // Close popup
            ClosePopup();
        }

        private void OnPopupCancelled(object sender, EventArgs e)
        {
            ClosePopup();
        }

        private void ClosePopup()
        {
            PopupContainer.Children.Clear();
            PopupContainer.Visibility = Visibility.Collapsed;
            //MainContent.IsEnabled = true;

            if (_popup != null)
            {
                _popup.EventAdded -= OnEventAdded;
                _popup.Cancelled -= OnPopupCancelled;
                _popup = null;
            }
        }

        private void LoadAttendance()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amiel\source\repos\sentry\sentry\Attendance.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Attendance_List";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                AttendanceGrid.ItemsSource = table.DefaultView;
            }
        }

        private void btnConfirmAttendance_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}