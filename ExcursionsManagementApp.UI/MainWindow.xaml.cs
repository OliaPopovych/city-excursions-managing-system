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
        private ScheduleView shView;
        private ToursView toursView;
        private SalesView salesView;
        private GuidesView guidesView;

        public MainWindow()
        {
            InitializeComponent();

            shView = new ScheduleView();
            toursView = new ToursView();
            salesView = new SalesView();
            guidesView = new GuidesView();

            DataContext = shView;
            //Height = SystemParameters.PrimaryScreenHeight * 0.75;
            //Width = SystemParameters.PrimaryScreenWidth * 0.75;
        }

        private void Schedule_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = shView;
        }

        private void Tours_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = toursView;
        }

        private void Sales_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = salesView;
        }

        private void Guides_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = guidesView;
        }
    }
}
