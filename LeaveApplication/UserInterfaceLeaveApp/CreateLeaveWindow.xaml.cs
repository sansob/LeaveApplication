using System;
using System.Windows;
using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.ViewModels;

namespace LeaveApplication.UserInterfaceLeaveApp {
    /// <summary>
    /// Interaction logic for CreateLeaveWindow.xaml
    /// </summary>
    public partial class CreateLeaveWindow : Window {
        ILeaveRequestService iLeaveRequestService = new LeaveRequestService();
        ILeaveTypeService iLeaveTypeService = new LeaveTypeService();
        private int _userId;

        LeaveRequestVM leaveRequestVM = new LeaveRequestVM();
        LeaveTypeVM leaveTypeVM = new LeaveTypeVM();
        public CreateLeaveWindow() {
            
        }

        public CreateLeaveWindow(int userId) {
            InitializeComponent();
            this._userId = userId;
            //MessageBox.Show(_userId.ToString());
            LoadCombo();
            
        }

        private void LoadCombo() {
            cmb_LeaveType.ItemsSource = iLeaveTypeService.Get();
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e) {
            this.Hide();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e) {
            var result = false;
            var LeaveRequestParam = new LeaveRequestVM(Convert.ToInt32(cmb_LeaveType.SelectedValue),
                Convert.ToDateTime(date_LeaveStarts.Text),
                Convert.ToDateTime(date_LeaveEnds.Text), DateTimeOffset.Now, txt_Reason.Text,
                _userId, "lampiran", 5);
            result = iLeaveRequestService.Insert(LeaveRequestParam);
            MessageBox.Show(result ? "Insert Successfully" : "Insert Failed");
        }
    }
}
