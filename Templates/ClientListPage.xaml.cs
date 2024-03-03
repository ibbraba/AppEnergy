using AppEnergy.Models;
using AppEnergy.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    /// Logique d'interaction pour ClientListPage.xaml
    /// </summary>
    public partial class ClientListPage : Page
    {
        private ClientService _clientService;
        private List<Client> _allClients;

        public ClientListPage()
        {
            InitializeComponent();

            //Get list of clients  
            _clientService = new ClientService();

            _allClients = _clientService.GetAllClients();

            ClientListBox.ItemsSource = _allClients;
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new ClientForm());
        }

        private void ClientListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Client selectedClient = (Client)ClientListBox.SelectedItem; 

            if(selectedClient != null)
            {

                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new ClientPage(selectedClient));

            }
        }
    }
}
