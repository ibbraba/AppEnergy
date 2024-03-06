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
    /// Logique d'interaction pour IssueForm.xaml
    /// </summary>
    public partial class IssueForm : Page
    {
        private IssueService _issueService;
        private ClientService _clientService;
        private List<Client> _clients;
        private EquipmentService _equipmentService;
        private List<Equipment> _equipments;
        private IssueVM _issueVM;

        public IssueForm()
        {
            InitializeComponent();

            _issueService = new IssueService();

            _clientService = new ClientService();
            _clients = _clientService.GetAllClients(); 


            _equipmentService = new EquipmentService();
            _equipments = _equipmentService.GetAllEquipments();

            ClientComboBox.ItemsSource = _clients;
            EquipmentComboBox.ItemsSource = _equipments;


            StatusComboBox.ItemsSource = StatusIssueEnum.GetIssueStatusList();
                

        }

        public IssueForm(IssueVM issueVM) : this()
        {

            _issueVM = issueVM;

            //Display buttons
            EditIssueButton.Visibility = Visibility.Visible;
            DeleteIssueButton.Visibility = Visibility.Visible;
            AddIssueButton.Visibility = Visibility.Hidden;

            //Enable editable fields only 
            ClientComboBox.IsEnabled = false;


            //Find initial values
            Client client = _clients.Find(x => x.Id == issueVM.IdClient);
            Equipment equipment = _equipments.Find(x => x.Id == issueVM.IdEquipement);

            //Fill form fields
            ClientComboBox.SelectedItem = client;
            EquipmentComboBox.SelectedItem = equipment;
            if (!String.IsNullOrEmpty(issueVM.Description))
            {
            DescriptionTextBox.Text = issueVM.Description;  

            }
            StatusComboBox.Text = issueVM.Status;
        }

        private void ClientComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Client client = (Client)ClientComboBox.SelectedItem; 

            if(client != null)
            {
                EquipmentComboBox.IsEnabled = true;
                List<Equipment> clientEquipment = _equipmentService.GetEquipmentPerClient(client); 
                EquipmentComboBox.ItemsSource = clientEquipment;
            
            }
        }

        private void AddIssueButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Equipment selectedEquipment = (Equipment)EquipmentComboBox.SelectedItem; 
                

                // assign values
                Issue issue = new();

                if (selectedEquipment != null)
                {
                    issue.IdEquipment = selectedEquipment.Id;
                    issue.ReportDate = DateTime.Today;
                    if (!String.IsNullOrEmpty(DescriptionTextBox.Text))
                    {

                        issue.Description = DescriptionTextBox.Text;
                    }

                    issue.Status = StatusComboBox.SelectedItem.ToString();

                }
          

               
                //create issue
                _issueService.CreateIssue(issue);
                MessageBox.Show("Issue successfully created");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new IssuesList());


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EditIssueButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //Find issue already stored
                Issue issue = _issueService.GetAllIssues().Find(x => x.Id == _issueVM.Id);

                if (issue == null)
                {
                    MessageBox.Show(ExceptionHelper.GENERAL_EXCEPTION);
                    return;
                }

                //Assign values
                Equipment selectedEquipment = (Equipment)EquipmentComboBox.SelectedItem;

                if(selectedEquipment != null)
                {
                    issue.IdEquipment = selectedEquipment.Id;
                    issue.Status = StatusComboBox.Text;
                    if (!String.IsNullOrEmpty(DescriptionTextBox.Text))
                    {
                        issue.Description = DescriptionTextBox.Text;
                    }

                }
                

                //Edit issue
                _issueService.EditIssue(issue);
                MessageBox.Show("Issue successfully edited");
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new IssuesList());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
       
            
        }

        private void DeleteIssueButton_Click(object sender, RoutedEventArgs e)
        {
            Issue issue = _issueService.GetAllIssues().Find(x => x.Id == _issueVM.Id);

            if (issue != null) {
              
                MessageBoxResult messageBoxResult = MessageBox.Show("Delete issue ?", "Delete", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    _issueService.DeleteIssue(issue);
                    NavigationService ns = NavigationService.GetNavigationService(this);
                    ns.Navigate(new IssuesList());
                }

            }

     
        }
    }
}
