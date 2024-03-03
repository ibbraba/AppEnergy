using AppEnergy.Templates;
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

namespace AppEnergy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new HomePage();
        }

        private void HomeMenuButtton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();
        }

        private void ClientsMenuButtton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ClientListPage();
        }

        private void MaintenanceMenuButtton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MaintenanceListPage();
        }

        private void CustomerSupportMenuButtton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new IssuesList();
        }

        private void PlanningsMenuButtton_Click(object sender, RoutedEventArgs e)
        {
            new CalendarPage();
        }

        private void ExitMenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (this is Window window)
            {
                MessageBoxResult result = MessageBox.Show("Exit application ?", "Exit", MessageBoxButton.YesNo );
                if (result == MessageBoxResult.Yes)
                {
                    window.Close();

                }
                else
                {
                    return;
                }
            }
        }
    }
}
