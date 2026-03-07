using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace sentry
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Loaded += MainWindow_Loaded;
        }

        public void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DashboardBtn.IsChecked = true;
            ContentArea.Content = new Dashboard();

        }

        public void DashboardBtn_Checked(object sender, RoutedEventArgs e) 
        {
            ContentArea.Content = new Dashboard();
        }

        public void AdminBtn_Checked(object sender, RoutedEventArgs e) 
        {
            ContentArea.Content = new Admin();
        }

        public void AboutBtn_Checked(object sender, RoutedEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Images/abt.png", UriKind.Relative));
            img.Stretch = Stretch.Uniform;

            Border container = new Border();
            container.Background = Brushes.White;
            container.Child = img;

            ContentArea.Content = container;
        }


        public void ExitBtn_Checked(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();

            MessageBoxResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirm Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }

        public void NavButton_Click(object sender, RoutedEventArgs e)
        {
            // Uncheck all buttons first
            DashboardBtn.IsChecked = false;
            AdminBtn.IsChecked = false;
            AboutBtn.IsChecked = false;
            ExitBtn.IsChecked = false;

            // Only check the clicked one
            ((ToggleButton)sender).IsChecked = true;

        }

        


    }
}