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
    /// Logique d'interaction pour IssuesList.xaml
    /// </summary>
    public partial class IssuesList : Page
    {
        private IssueService _issueService;
        private List<IssueVM> _issuesVM;

        public IssuesList()
        {
            InitializeComponent();

            _issueService = new IssueService();

            _issuesVM = _issueService.GetAllIssuesVM();

            IssuesListBox.ItemsSource = _issuesVM; 



        }

        private void AddIssueButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);

            ns.Navigate(new IssueForm());
        }

        private void IssuesListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            IssueVM selectedIssue = (IssueVM)IssuesListBox.SelectedItem;

            if(selectedIssue != null)
            {
                Issue issue = _issueService.ConvertToIssue(selectedIssue);
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new SingleIssuePage(issue));
            }
        }
    }
}
