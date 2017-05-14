using System.Windows;

namespace ExcursionsManagementApp.UI
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            Height = SystemParameters.PrimaryScreenHeight * 0.25;
            Width = SystemParameters.PrimaryScreenWidth * 0.35;
        }
    }
}
