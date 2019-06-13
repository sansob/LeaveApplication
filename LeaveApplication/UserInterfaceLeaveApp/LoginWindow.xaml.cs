using Common.Repository.Application;
using DataAccess.MyContext;
using System.Windows;

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
            var login = new LoginRepository();
            var temp = login.CekLogin(username.Text, password.Password);
            if (temp!=null)
            {
                MessageBox.Show("Login Berhasil", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                var home = new DashboardUserWindow(temp);
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