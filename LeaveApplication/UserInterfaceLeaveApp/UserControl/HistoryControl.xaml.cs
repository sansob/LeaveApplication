using System;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;
using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.Models;

namespace LeaveApplication.UserInterfaceLeaveApp.UserControl {
    /// <summary>
    /// Interaction logic for HistoryControl.xaml
    /// </summary>
    public partial class HistoryControl : System.Windows.Controls.UserControl {
        private int _userId;
        private int _roleId;
        private Employee _employee;
        private ILeaveRequestService iLeaveRequestService = new LeaveRequestService();
        public HistoryControl() {
            InitializeComponent();
        }
        public HistoryControl(Employee userId) {
            InitializeComponent();
            this._employee = userId;
            //this._roleId = Convert.ToInt32(userId.Role);
            LoadGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var temp = new CreateLeaveWindow(_userId);
            temp.Show();
        }

        private void LoadGrid() {
            HistoryDataGrid.ItemsSource = iLeaveRequestService.Get();
        }
         
        private void HistoryDataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e) {
            try {
                object item = HistoryDataGrid.SelectedItem;
                var reqidText = Convert.ToInt32((HistoryDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                var reqName = (HistoryDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                var reqDate = (HistoryDataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                var reqDateEnd = (HistoryDataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                var reqLeaveType = (HistoryDataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                var reqRequestDate = (HistoryDataGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                var reqStatusRequest = (HistoryDataGrid.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text;
                var reqManager = (HistoryDataGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                var reqHrd = (HistoryDataGrid.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
                var reqReason = (HistoryDataGrid.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
                //MessageBox.Show(_employee.Role);
                EditLeaveWindow editLeaveWindow = new EditLeaveWindow(_employee, reqidText, reqName, reqDate, reqDateEnd, reqLeaveType, reqRequestDate, reqStatusRequest, reqManager, reqHrd, reqReason);
                editLeaveWindow.Show();
                
            }
            catch (Exception) {

            }
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e) {
            LoadGrid();
        }
    }
}
