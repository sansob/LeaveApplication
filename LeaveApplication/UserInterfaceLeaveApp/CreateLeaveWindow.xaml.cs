using System.Windows;

namespace LeaveApplication.UserInterfaceLeaveApp {
    /// <summary>
    /// Interaction logic for CreateLeaveWindow.xaml
    /// </summary>
    public partial class CreateLeaveWindow : Window {
        public CreateLeaveWindow() {
            InitializeComponent();
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e) {
            this.Hide();
        }
    }
}
