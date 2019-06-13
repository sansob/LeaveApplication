using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows;
using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace LeaveApplication.UserInterfaceLeaveApp {
    /// <summary>
    /// Interaction logic for CreateLeaveWindow.xaml
    /// </summary>
    public partial class EditLeaveWindow : Window {
        private Employee _employee;
        ILeaveRequestService iLeaveRequestService = new LeaveRequestService();
        ILeaveTypeService iLeaveTypeService = new LeaveTypeService();

        private int _userId;
        private int _fromRequestId;
        private string _reqName, _reqDate, _reqDateEnd, _reqLeaveType, _reqRequestDate, _reqStatusRequest, _reqManager, _reqHrd, _reqReason;

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            leaveRequestVM.Id = Convert.ToInt32(_fromRequestId);
            var setStatus = iLeaveRequestService.SetStatus(leaveRequestVM.Id, leaveRequestVM.Status_Id = Convert.ToInt32(7));
            if (setStatus) {
                MessageBox.Show("Rejected");
                Button_Approve.Visibility = Visibility.Collapsed;
                Button_Reject.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            var dialogResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo).ToString();
            if (dialogResult == "Yes") {
                var result = iLeaveRequestService.Delete(Convert.ToInt32(_fromRequestId));
                if (result) {
                    MessageBox.Show("Delete Successfully");
                } else {
                    MessageBox.Show("Delete Fail");
                }
            }
        }

        LeaveRequestVM leaveRequestVM = new LeaveRequestVM();
        LeaveTypeVM leaveTypeVM = new LeaveTypeVM();

        private void Button_Click(object sender, RoutedEventArgs e) {
            
            if (_employee.Role == "2") {
                leaveRequestVM.Id = Convert.ToInt32(_fromRequestId);
                
                var result = iLeaveRequestService.ApproveManager(leaveRequestVM.Id, leaveRequestVM.ApprovalManager_Id = Convert.ToInt32(_employee.Id));
                var setStatus = iLeaveRequestService.SetStatus(leaveRequestVM.Id, leaveRequestVM.Status_Id = Convert.ToInt32(1002));

                if (result) {
                    MessageBox.Show("Managerial Approved");
                }
            } else if (_employee.Role == "3") {

                if (string.IsNullOrWhiteSpace(_reqManager)) {
                    MessageBox.Show("Not Approved from Manager. Please wait till employee get approved from manager first");
                } else {
                    leaveRequestVM.Id = Convert.ToInt32(_fromRequestId);
                    var result = iLeaveRequestService.ApproveHrd(leaveRequestVM.Id, leaveRequestVM.ApprovalHrd_Id = Convert.ToInt32(_employee.Id));
                    var setStatus = iLeaveRequestService.SetStatus(leaveRequestVM.Id, leaveRequestVM.Status_Id = Convert.ToInt32(6));
                    if (result) {
                        MessageBox.Show("Leave Accepted");
                    }
                }
            }
            else {
                MessageBox.Show("Error");
            }
        }

        public EditLeaveWindow() {
        }

        public EditLeaveWindow(Employee userId, int reqIdUserId, string reqName, string reqDate, string reqDateEnd, string reqLeaveType, string reqRequestDate, string reqStatusRequest, string reqManager, string reqHrd, string reqReason) {
            InitializeComponent();
            _employee = userId;
            _fromRequestId = reqIdUserId;
            _reqName = reqName;
            _reqDate = reqDate;
            _reqDateEnd = reqDateEnd;
            _reqLeaveType = reqLeaveType;
            _reqRequestDate = reqRequestDate;
            _reqStatusRequest = reqStatusRequest;
            _reqManager = reqManager;
            _reqHrd = reqHrd;
            _reqReason = reqReason;
            //MessageBox.Show(_userId.ToString());
            LoadData();

            Txb_Req_Id.Text = reqIdUserId.ToString();
            Txb_Req_name.Text = _reqName;
            date_LeaveStarts.Text = _reqDate;
            date_LeaveEnds.Text = _reqDateEnd;
            cmb_LeaveType.Text = _reqLeaveType;
            txt_Req_Date.Text = _reqRequestDate;
            txt_Req_Status.Text = _reqStatusRequest;
            Txb_Hrd.Text = string.IsNullOrEmpty(_reqHrd) ? "Not yet approved" : _reqHrd;
            Txb_Manager.Text = string.IsNullOrEmpty(_reqManager) ? "Not yet approved" : _reqHrd;
            Txb_Reason.Text = _reqReason;
        }

        private void LoadData() {
            cmb_LeaveType.ItemsSource = iLeaveTypeService.Get();
            if (_employee.Role == "1") {
                Button_Approve.Visibility = Visibility.Collapsed;
                Button_Reject.Visibility = Visibility.Collapsed;
            }
            else if (_employee.Role == "2") {
                Button_Approve.Visibility = Visibility.Visible;
            } else if (_employee.Role == "3") {
                Button_Approve.Visibility = Visibility.Visible;
            }
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e) {
            Hide();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e) {
            var result = false;
//            var LeaveRequestParam = new LeaveRequestVM(Convert.ToInt32(cmb_LeaveType.SelectedValue),
//                Convert.ToDateTime(date_LeaveStarts.Text),
//                Convert.ToDateTime(date_LeaveEnds.Text), DateTimeOffset.Now, txt_Reason.Text,
//                _userId, "lampiran", 5);
//            result = iLeaveRequestService.Insert(LeaveRequestParam);
            MessageBox.Show(result ? "Insert Successfully" : "Insert Failed");
        }
    }

}