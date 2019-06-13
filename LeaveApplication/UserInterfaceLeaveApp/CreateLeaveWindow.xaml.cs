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
using System.Windows.Shapes;

namespace LeaveApplication.UserInterfaceLeaveApp
{
    /// <summary>
    /// Interaction logic for CreateLeaveWindow.xaml
    /// </summary>
    public partial class CreateLeaveWindow : Window
    {
        ILeaveRequestService iLeaveRequestService = new LeaveRequestService();
        ILeaveTypeService iLeaveTypeService = new LeaveTypeService();

        LeaveRequestVM leaveRequestVM = new LeaveRequestVM();
        LeaveTypeVM leaveTypeVM = new LeaveTypeVM();


        public CreateLeaveWindow()
        {
            InitializeComponent();
            
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GetData()
        {

        }

        private void LoadCombo()
        {
            cmb_LeaveType.ItemsSource = iLeaveTypeService.Get();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCombo();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            
            bool result;
            if (string.IsNullOrWhiteSpace(leaveRequestVM.Id.ToString()))
            {
                var LeaveRequestParam = new LeaveRequestVM(Convert.ToDateTime(date_LeaveStarts.Text), Convert.ToDateTime(date_LeaveEnds.Text), DateTimeOffset.Now, txt_Reason.Text, Convert.ToInt16(cmb_LeaveType.SelectedValue), 1, 1, "lampiran", 1);
                result = iLeaveRequestService.Insert(LeaveRequestParam);
                MessageBox.Show(result ? "Insert Successfully" : "Insert Failed");
            }
        }
    }
}
