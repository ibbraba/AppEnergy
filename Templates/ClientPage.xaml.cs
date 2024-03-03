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

        public ClientPage( Client client)
        {
            InitializeComponent();
            _client = client;
            _clientService = new ClientService(); 

            

            FullNameTextBox.Text = client.LastName + " " + client.Name;
            AdressTextBox.Text = client.Adress + " " + client.ZipCode + " " + client.City;
            PhoneNumberTextBox.Text = client.PhoneNumber;
            MailTextBox.Text = client.Mail;

            List<Equipment> equipments = _clientService.GetClientEquipment(_client);

            ClientEquipmentComboBox.ItemsSource = equipments;

            

        }



        private void EditClientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new ClientForm(_client)); 
        }
    }
}
