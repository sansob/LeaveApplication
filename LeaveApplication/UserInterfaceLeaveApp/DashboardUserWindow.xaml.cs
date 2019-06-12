using System;
using System.Windows;
using System.Windows.Controls;
using LeaveApplication.UserInterfaceLeaveApp.UserControl;

namespace LeaveApplication.UserInterfaceLeaveApp {
    /// <summary>
    /// Interaction logic for DashboardUserWindow.xaml
    /// </summary>
    public partial class DashboardUserWindow : Window {
        public DashboardUserWindow() {
            InitializeComponent();
            System.Windows.Controls.UserControl usc = null;
            GridMain.Children.Clear();
            usc = new DashboardControl();
            GridMain.Children.Add(usc);
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