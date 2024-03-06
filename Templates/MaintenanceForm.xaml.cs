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
        private MaintenanceVM _maintenanceVM;

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


            _maintenanceVM = maintenanceVM;

            TitleTextBox.Text = "Edit maintenance";


            //Enabling buttons

            EditMaintenanceButton.Visibility = Visibility.Visible; 
            DeleteMaintennaceButton.Visibility = Visibility.Visible;
            AddMaintenanceButton.Visibility = Visibility.Hidden;



            //Disable editing form fields

            ContactComboBox.IsEnabled = false;
            


            //Find the right client associated

            Client client = _clients.Find(x => x.Id == maintenanceVM.IdClient); 
            
            
            //Find the right equipment associated

            Equipment equipment =  _clientService.GetClientEquipment(client).Find(x => x.Id == maintenanceVM.IdEquipment);

            if (client == null || equipment == null)
            {
                MessageBox.Show(ExceptionHelper.GENERAL_EXCEPTION);
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new MaintenanceListPage());

            }


            // Fill form fields
            ContactComboBox.SelectedItem = client;
            EquipmentComboBox.SelectedItem = equipment;
            MainteanceDatePicker.SelectedDate = maintenanceVM.Date;
            StatusComboBox.SelectedItem = maintenanceVM.Status;





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
                //assign values
                Maintenance maintenance = new Maintenance();
                Equipment selectedEquipment = (Equipment)EquipmentComboBox.SelectedItem;

                if (selectedEquipment != null)
                {
                    maintenance.IdEquipment = selectedEquipment.Id;
                    maintenance.Status = StatusComboBox.SelectedItem.ToString();
                    maintenance.Date = (DateTime)MainteanceDatePicker.SelectedDate;

                }

                    //Create maintenance
                _maintenanceService.CreateMaintenance(maintenance);
                MessageBox.Show("Maintenance successfully added ");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new MaintenanceListPage());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void EditMaintenanceButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //assign new values

                Equipment selectedEquipment = (Equipment)EquipmentComboBox.SelectedItem;

                if(selectedEquipment  != null)
                {

                    _maintenanceVM.IdEquipment = selectedEquipment.Id;
                    _maintenanceVM.Date = (DateTime)MainteanceDatePicker.SelectedDate;
                    _maintenanceVM.Status = StatusComboBox.SelectedItem.ToString();

                }


                //Convert viewModel to maintenance object 
                Maintenance maintenance = _maintenanceService.ConvertToMaintenace(_maintenanceVM);


                //edit maintenance
                _maintenanceService.EditMaintenance(maintenance);
                MessageBox.Show("Maintenance successfully edited");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new MaintenanceListPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

            

        }

        private void DeleteMaintennaceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Delete maintenance ?", "Delete", MessageBoxButton.YesNo); 
               
                if(messageBoxResult == MessageBoxResult.Yes)
                {

                    Maintenance maintenance = _maintenanceService.GetAllMiantenances().Find(x => x.Id == _maintenanceVM.Id);

                    _maintenanceService.DeleteMaintenance(maintenance);

                    NavigationService ns = NavigationService.GetNavigationService(this);
                    ns.Navigate(new MaintenanceListPage());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            
        }
    }
}
