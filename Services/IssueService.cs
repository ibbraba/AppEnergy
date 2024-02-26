using AppEnergy.Fixtures;
using AppEnergy.Helpers;
using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Services
{
    class IssueService
    {

        public List<Issue> GetEquipmentIssues(int idEquipment)
        {
            List<Issue> issues = IssueFixture.Issues.Where(x => x.IdEquipment == idEquipment).ToList();

            return issues;
        }


        private void ValidateIsssue( Issue issue) { 
        
            if(issue.IdEquipment ==0 || issue.ReportDate < DateTime.MinValue.AddDays(2) || String.IsNullOrEmpty(issue.Status) || String.IsNullOrEmpty(issue.Description) {

                throw new ArgumentException("Please fill all the field to save the issue");


            }
        
        }    


        public void CreateIssue(Issue issue)
        {
            //Validate entries 

            ValidateIsssue(issue); 

            //Check max number of issue 

            if(GetEquipmentIssues(issue.IdEquipment).Count > 1)
            {
                throw new Exception("The max number of issues per equipment is already reached");
            }

            // Add issue 

            IssueFixture.Issues.Add(issue);

        }

        public void EditIssue(Issue issue)
        {
            Issue DBIssue = IssueFixture.Issues.Find(x => x.Id == issue.Id);
            ValidateIsssue(issue); 

            if(DBIssue == null)
            {
                throw new Exception(ExceptionHelper.GENERAL_EXCEPTION);
            }

            IssueFixture.Issues.Remove(DBIssue);
            IssueFixture.Issues.Add(issue);

        }


        public void DeleteIssue(Issue issue)
        {
            IssueFixture.Issues.Remove(issue);  
        }
    }
}
