using Common.Repository.Application;
using DataAccess.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LeaveApplication.UserInterfaceLeaveApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        MyContext myContext = new MyContext();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            LoginRepository login = new LoginRepository(); 
            if(login.cekLogin(username.Text, password.Password) == true)
            {
                MessageBox.Show("Login Berhasil", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                DashboardUserWindow home = new DashboardUserWindow();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Gagal", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Information);
                password.Clear();
                password.Focus();
            }
        }
    }
}
