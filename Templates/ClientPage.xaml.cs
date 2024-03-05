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
    /// Logique d'interaction pour ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        private Client _client;
        private ClientService _clientService;
        private EquipmentService _equipmentService;
        private List<Equipment> _clientEquipments;

        public ClientPage( Client client)
        {
            InitializeComponent();
            _client = client;
            _clientService = new ClientService();

            _equipmentService = new EquipmentService();

            FullNameTextBox.Text = client.LastName + " " + client.Name;
            AdressTextBox.Text = client.Adress + " " + client.ZipCode + " " + client.City;
            PhoneNumberTextBox.Text = client.PhoneNumber;
            MailTextBox.Text = client.Mail;

            _clientEquipments = _clientService.GetClientEquipment(_client);
             

            ClientEquipmentListBox.ItemsSource = _clientEquipments;

            

        }



        private void EditClientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new ClientForm(_client)); 
        }

        private void AddEquipmentClientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new AddEquipmentForm(_client));
        }

        private void ClientEquipmentListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Equipment equipment = (Equipment)ClientEquipmentListBox.SelectedItem;
            if(equipment != null)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Delete equipment ?", "Delete", MessageBoxButton.YesNo); 
                if(messageBoxResult == MessageBoxResult.Yes)
                {
                    try
                    {
                        _equipmentService.RemoveEquipment(equipment);
                        ClientEquipmentListBox.ItemsSource = _equipmentService.GetEquipmentPerClient(_client);
                        ClientEquipmentListBox.Items.Refresh();
                      
                      
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }


                }
                
            }
        }
    }
}
