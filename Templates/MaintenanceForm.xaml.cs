using AppEnergy.Helpers;
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
    /// Logique d'interaction pour MaintenanceForm.xaml
    /// </summary>
    public partial class MaintenanceForm : Page
    {
        private ClientService _clientService;
        private List<Client> _clients;
        private List<string> _equipmentStatus;
        private MaintenanceService _maintenanceService;

        public MaintenanceForm()
        {
            InitializeComponent();

            _clientService = new ClientService();
            
            // Get all clients 
            _clients = _clientService.GetAllClients();
            ContactComboBox.ItemsSource = _clients;

       

            //Get equipment Status 
            _equipmentStatus = StatusEquipmentEnum.GetStatus();
            StatusComboBox.ItemsSource = _equipmentStatus;


            _maintenanceService = new MaintenanceService();
        }


        public MaintenanceForm(MaintenanceVM maintenanceVM) : this()
        {

            ContactComboBox.SelectedItem = maintenanceVM;


        }


        private void ContactComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Client selectedClient = (Client)ContactComboBox.SelectedItem; 

            if(selectedClient != null)
            {
                List<Equipment> clientEquipment = _clientService.GetClientEquipment(selectedClient);
                EquipmentComboBox.IsEnabled = true;
                EquipmentComboBox.ItemsSource = clientEquipment; 
                


                
            }
        }

        private void AddMaintenanceButton_Click(object sender, RoutedEventArgs e)
        {
           

            try
            {

                Maintenance maintenance = new Maintenance();
                Equipment selectedEquipment = (Equipment)EquipmentComboBox.SelectedItem;
                maintenance.IdEquipment = selectedEquipment.Id;
                maintenance.Status = StatusComboBox.SelectedItem.ToString();
                maintenance.Date = (DateTime)MainteanceDatePicker.SelectedDate;


                _maintenanceService.CreateMaintenance(maintenance);
                MessageBox.Show("Maintenance successfully added ");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new MaintenanceListPage());

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
