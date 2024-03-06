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
    /// Logique d'interaction pour ClientForm.xaml
    /// </summary>
    public partial class ClientForm : Page
    {
        private ClientService _clientService;
        private Client _client;

        public ClientForm()
        {
            InitializeComponent();
            _clientService = new ClientService();
        }

        public ClientForm(Client client) : this()
        {

            _client = client;
            
            AddCLientButton.Visibility = Visibility.Hidden;
            EditCLientButton.Visibility = Visibility.Visible;
            DeleteClientButton.Visibility = Visibility.Visible;

            FirstNameTextBox.Text = client.Name;        
            LastNameTextBox.Text = client.LastName;
            AdressextBox.Text = client.Adress;
            ZipCodeTextBox.Text = client.ZipCode.ToString();
            CityTextBox.Text = client.City; 
            PhoneNumberTextBox.Text = client.PhoneNumber;
            MailTextBox.Text = client.Mail;
        }

        private void AddCLientButton_Click(object sender, RoutedEventArgs e)
        {
            Client client = new();
            client.Name = FirstNameTextBox.Text;
            client.LastName = LastNameTextBox.Text;
            client.Adress = AdressextBox.Text;
            if (!String.IsNullOrEmpty(ZipCodeTextBox.Text))
            {
                client.ZipCode = Int32.Parse(ZipCodeTextBox.Text);

            }
            client.City = CityTextBox.Text;
            client.PhoneNumber = PhoneNumberTextBox.Text;
            client.Mail = MailTextBox.Text;

            try
            {
    
                _clientService.AddClient(client);
                MessageBox.Show("Client successfully added");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new ClientListPage());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void EditCLientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _client.Name = FirstNameTextBox.Text;
                _client.LastName = LastNameTextBox.Text;
                _client.Adress = AdressextBox.Text;
                if (!String.IsNullOrEmpty(ZipCodeTextBox.Text))
                {
                    _client.ZipCode = Int32.Parse(ZipCodeTextBox.Text);
                }
                _client.City = CityTextBox.Text;
                _client.PhoneNumber = PhoneNumberTextBox.Text;
                _client.Mail = MailTextBox.Text;

                _clientService.EditClient(_client);

                MessageBox.Show("Client successfully edited");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new ClientListPage());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteClientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Delete clientt ?", "Delete", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                _clientService.DeleteClient(_client);

                }

                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new ClientListPage());

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
