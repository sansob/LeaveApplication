using System.Windows;

namespace LeaveApplication.UserInterfaceLeaveApp.UserControl {
    /// <summary>
    /// Interaction logic for HistoryControl.xaml
    /// </summary>
    public partial class HistoryControl : System.Windows.Controls.UserControl {
        public HistoryControl() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var temp = new CreateLeaveWindow();
            temp.Show();
        }
    }
}
