using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTDhruvRajpara
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {

        private Dictionary<String, Login> _personInfo;
        public LoginPage()
        {
            InitializeComponent();

            _personInfo = new Dictionary<string, Login>();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _personInfo.Add("rajparad", new Login(1, "rajparad", "pass"));
            _personInfo.Add("user1", new Login(2, "user1", "pass1"));
            _personInfo.Add("user2", new Login(3, "user2", "pass2"));
            _personInfo.Add("user3", new Login(4, "user3", "pass3"));
            _personInfo.Add("user4", new Login(5, "user4", "pass4"));

        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            String username = txtboxUsername.Text;
            String password = loginPassword.Password;

            Login personData = null;


       
            if (_personInfo.ContainsKey(username))
            {
                personData = _personInfo[username];
                if (personData.Password == password)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Password does not Match!!!", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Username not Found!!! ", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
            
           
        }
    }
}
