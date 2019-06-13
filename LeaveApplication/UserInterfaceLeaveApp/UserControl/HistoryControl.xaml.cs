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
                var text = (HistoryDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                //MessageBox.Show(_employee.Role);
                EditLeaveWindow editLeaveWindow = new EditLeaveWindow(_employee);
                editLeaveWindow.Show();
                
            }
            catch (Exception) {

            }
        }
    }
}
