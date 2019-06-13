using System.Windows;
using System.Windows.Input;
using DataAccess.Models;

namespace LeaveApplication.UserInterfaceLeaveApp.UserControl {
    /// <summary>
    /// Interaction logic for DashboardControl.xaml
    /// </summary>
    public partial class DashboardControl : System.Windows.Controls.UserControl {
        private int _userId;
        public DashboardControl() {
            InitializeComponent();
        }

        public DashboardControl(Employee userId) {
            InitializeComponent();
            this._userId = userId.Id;
//            MessageBox.Show(_userId.ToString());
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e) {
            var createLeaveWindow = new CreateLeaveWindow(_userId);
            createLeaveWindow.Show();
        }

    }
}
