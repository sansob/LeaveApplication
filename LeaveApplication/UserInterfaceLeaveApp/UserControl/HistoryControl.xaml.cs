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
