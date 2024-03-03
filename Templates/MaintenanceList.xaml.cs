using AppEnergy.Models;
using AppEnergy.Services;
using AppEnergy.ViewModels;
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

namespace AppEnergy.Templates
{
    /// <summary>
    /// Logique d'interaction pour MaintenanceList.xaml
    /// </summary>
    public partial class MaintenanceListPage : Page
    {
        private MaintenanceService _maintenanceService;
        private List<MaintenanceVM> _allMaintenanceVM;

        public MaintenanceListPage()
        {
            InitializeComponent();

            _maintenanceService = new MaintenanceService();

            _allMaintenanceVM = _maintenanceService.GetAllMaintenancesVM();

            MaintenancesListBox.ItemsSource = _allMaintenanceVM;


        }

        private void AddMaintenanceButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new MaintenanceForm());
        }

        private void MaintenancesListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MaintenanceVM maintenanceVM = (MaintenanceVM)MaintenancesListBox.SelectedItem;

            if(maintenanceVM != null)
            {

                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new SingleMaintenancePage(maintenanceVM));
            }

        }
    }
}
