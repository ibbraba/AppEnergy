using AppEnergy.Helpers;
using AppEnergy.Models;
using AppEnergy.Services;
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
    /// Logique d'interaction pour AddEquipmentForm.xaml
    /// </summary>
    public partial class AddEquipmentForm : Page
    {
        private Client _client;
        private ClientService _clientService;
        private EquipmentService _equipmentService;

        public AddEquipmentForm(Client client)
        {
            InitializeComponent();
            _client = client;
            _clientService = new ClientService();

            _equipmentService = new EquipmentService();


            ClientNameTextBlock.Text = client.FullName;
            EquipmentComboBox.ItemsSource = EquipmentTypeEnum.GetEquipmentTypes();

            EquipmentColorComboBox.Items.Add("Full black"); 
            EquipmentColorComboBox.Items.Add("Gray"); 
         
        }

     

        private void EquipmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedEquipment = (string)EquipmentComboBox.SelectedItem;

            if (!String.IsNullOrEmpty(selectedEquipment) && selectedEquipment == EquipmentTypeEnum.SOLAR_PANEL)
            {
                EquipmentColorComboBox.IsEnabled = true;


            }
            else
            {
                EquipmentColorComboBox.IsEnabled = false;
                EquipmentColorComboBox.Text= "";
                
            }
        }

        private void AddEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (EquipmentComboBox.SelectedItem == EquipmentTypeEnum.SOLAR_PANEL)
                {

                    SolarPanel solarPanel = new();
                    solarPanel.IdClient = _client.Id;
                    solarPanel.Color = EquipmentColorComboBox.Text;
                    solarPanel.Date = DateTime.Now;
                    solarPanel.Status = StatusEquipmentEnum.Functional;

                    _equipmentService.CreateEquipment(solarPanel);

                }
                if (EquipmentComboBox.SelectedItem == EquipmentTypeEnum.THERMODYNAMIC_BALOON)
                {

                    ThermodynamicBaloon thermodynamicBaloon = new();
                    thermodynamicBaloon.IdClient = _client.Id;
                    thermodynamicBaloon.Date = DateTime.Now;
                    thermodynamicBaloon.Status = StatusEquipmentEnum.Functional;

                    _equipmentService.CreateEquipment(thermodynamicBaloon);
                }
                if (EquipmentComboBox.SelectedItem == EquipmentTypeEnum.HEAT_PUMP)
                {

                    HeatPump heatPump = new();
                    heatPump.IdClient = _client.Id;
                    heatPump.Date = DateTime.Now;
                    heatPump.Status = StatusEquipmentEnum.Functional;
                    _equipmentService.CreateEquipment(heatPump);
                }

                MessageBox.Show("Equipment successfully added");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new ClientPage(_client));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           


            
        }
    }
}
