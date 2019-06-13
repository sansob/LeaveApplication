using System.Windows;
using System.Windows.Input;

namespace LeaveApplication.UserInterfaceLeaveApp.UserControl {
    /// <summary>
    /// Interaction logic for DashboardControl.xaml
    /// </summary>
    public partial class DashboardControl : System.Windows.Controls.UserControl {
        public DashboardControl() {
            InitializeComponent();
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e) {
            CreateLeaveWindow createLeaveWindow = new CreateLeaveWindow();
            createLeaveWindow.Show();
        }

    }
}
