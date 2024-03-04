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
    /// Logique d'interaction pour CalendarPage.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
        private MaintenanceService _maintenanceService;
        private IssueService _issueService;
        private List<Maintenance> _maintenances;
        private List<Issue> _issues;

        public CalendarPage()
        {
            InitializeComponent();
            _maintenanceService = new MaintenanceService();
            _issueService = new IssueService();

            _maintenances= _maintenanceService.GetAllMiantenances();
            _issues = _issueService.GetAllIssues();

            Calendar.SelectedDate = DateTime.Today;

            foreach(Maintenance mainteanance in _maintenances)
            {
                Calendar.SelectedDates.Add(mainteanance.Date);
            }

            foreach(Issue issue in _issues)
            {
                Calendar.SelectedDates.Add(issue.ReportDate);
            }

        }
    }
}
