using ExcursionsManagementApp.DomainModel.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using ExcursionsManagementApp.BL;

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
            
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            IBusinessLayer businessLayer = new BusinessLayer();

            var login = textBoxLogin.Text;

            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));

            byte[] hash = md5.Hash;

            StringBuilder password = new StringBuilder();
            for(int i = 0; i < hash.Length; i++)
            {
                password.Append(hash[i].ToString("x2"));
            }
            //textBoxLogin.Text = password.ToString();

            User user = businessLayer.GetUserByLoginAndPassword(login, password.ToString());

            if (user == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error");
            }
            else
            {
                //CurrentUser.Initialize(user);
                MainWindow mW = new MainWindow();
                mW.Show();
                this.Close();
            }
        }
    }
}
