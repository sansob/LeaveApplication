using System;
using System.Windows;
using System.Windows.Controls;
using DataAccess.Models;
using LeaveApplication.UserInterfaceLeaveApp.UserControl;

namespace LeaveApplication.UserInterfaceLeaveApp {
    /// <summary>
    /// Interaction logic for DashboardUserWindow.xaml
    /// </summary>
    public partial class DashboardUserWindow : Window {
        private Employee _employee;
        public DashboardUserWindow() {
            InitializeComponent();
        }

        public DashboardUserWindow(Employee user) {
            InitializeComponent();
            this._employee = user;
            System.Windows.Controls.UserControl usc = null;
            GridMain.Children.Clear();
            usc = new DashboardControl();
            GridMain.Children.Add(usc);
            setup();
        }

        private void setup() {
            TextTopName.Text = "Hallo "+ _employee.UserName;

        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e) {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e) {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            System.Windows.Controls.UserControl usc;
            GridMain.Children.Clear();

            switch (((ListViewItem) ((ListView) sender).SelectedItem).Name) {
                case "ItemHome":
                    MessageBox.Show(_employee.Id.ToString());
                    usc = new DashboardControl();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemHistory":
                    usc = new HistoryControl();
                    GridMain.Children.Add(usc);
                    break;
            }
        }


        private void BtnIcon_Click(object sender, RoutedEventArgs e) {
           Application.Current.Shutdown();
        }
    }
}
