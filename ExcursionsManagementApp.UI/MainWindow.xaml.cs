using ExcursionsManagementApp.UI.ViewModels;
using ExcursionsManagementApp.UI.Views;
using System.Windows;

namespace ExcursionsManagementApp.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Height = SystemParameters.PrimaryScreenHeight * 0.75;
            //Width = SystemParameters.PrimaryScreenWidth * 0.75;
        }

        private void Schedule_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ScheduleView();
        }

        private void Tours_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ToursView();
        }

        private void Sales_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new SalesView();
        }

        private void Guides_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new GuidesView();
        }
    }
}
