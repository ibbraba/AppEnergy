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
    /// Logique d'interaction pour SingleIssuePage.xaml
    /// </summary>
    public partial class SingleIssuePage : Page
    {
        private Issue _issue;
        private IssueVM _issueVM;

        public SingleIssuePage(Issue issue)
        {
            InitializeComponent();

            IssueService issueService = new();
            _issue = issue;
            _issueVM = issueService.ConvertToIssueVM(issue);

            FullNameTextBlock.Text = _issueVM.ClientName;
            AdressTextBlock.Text = _issueVM.CLientAdress;
            
            DateTextBlock.Text = _issueVM.ReportDate.ToString("dd/MM/yyyy");
            EquipmentTextBlock.Text = _issueVM.EquipmentName;
            NoteTextBlock.Text = _issueVM.Description; 




        }

        private void IssueName_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate( new IssueForm(_issueVM));
        }
    }
}
