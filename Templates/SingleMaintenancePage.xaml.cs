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
    /// Logique d'interaction pour SingleMaintenancePgaexaml.xaml
    /// </summary>
    public partial class SingleMaintenancePage : Page
    {
        private MaintenanceVM _maintenanceVM;
        private MaintenanceService _maintenanceService;

        public SingleMaintenancePage(MaintenanceVM maintenanceVM)
        {
            InitializeComponent();



            _maintenanceVM = maintenanceVM;

            _maintenanceService = new MaintenanceService();

            FullnameTextBlock.Text = (_maintenanceVM.ClientName);
            DateTextBlock.Text = _maintenanceVM.Date.ToString("dd/MM/yyyy");
            AdressTextBlock.Text = _maintenanceVM.ClientAdress; 
            EquipmentTextBlock.Text = _maintenanceVM.EquipmentName; 
            if(!String.IsNullOrEmpty(_maintenanceVM.Description))
            {
                DescriptionTextBlock.Text = _maintenanceVM.Description; 
            }



        }

        private void EditEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new MaintenanceForm(_maintenanceVM));
        }
    }
}
