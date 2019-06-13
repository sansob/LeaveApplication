using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeaveApplication.UserInterfaceLeaveApp.UserControl
{
    /// <summary>
    /// Interaction logic for HistoryControl.xaml
    /// </summary>
    public partial class HistoryControl : System.Windows.Controls.UserControl
    {
        ILeaveRequestService iLeaveRequestService = new LeaveRequestService();
        ILeaveTypeService iLeaveTypeService = new LeaveTypeService();

        LeaveRequestVM leaveRequestVM = new LeaveRequestVM();
        LeaveTypeVM leaveTypeVM = new LeaveTypeVM();

        public HistoryControl()
        {
            InitializeComponent();
            getData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void getData()
        {
            dataGridRequest.ItemsSource = iLeaveRequestService.Get();
        }

        private void dataGridRequest_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            
                
            
        }
    }
}
