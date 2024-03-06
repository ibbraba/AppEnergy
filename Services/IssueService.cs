using AppEnergy.Fixtures;
using AppEnergy.Helpers;
using AppEnergy.Models;
using AppEnergy.Templates;
using AppEnergy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Services
{
    public class IssueService
    {
       

        public List<Issue> GetEquipmentIssues(int idEquipment)
        {
            List<Issue> issues = IssueFixture.Issues.Where(x => x.IdEquipment == idEquipment).ToList();

            return issues;
        }


        public List<Issue> GetAllIssues()
        {
            List<Issue> issues = IssueFixture.Issues;

            // Make sure the associated equipment exists
          


            return issues;
        }

        public List<IssueVM> GetAllIssuesVM()
        {
            List<Issue> issues = GetAllIssues();

            List<IssueVM> issueVMs = new();

            foreach (Issue issue in issues)
            {

                IssueVM issueVM = ConvertToIssueVM(issue);
                issueVMs.Add(issueVM);

            }

            return issueVMs;

        }



        private void ValidateIsssue( Issue issue) { 
        
            if(issue.IdEquipment == 0 || issue.ReportDate < DateTime.MinValue.AddDays(2) || String.IsNullOrEmpty(issue.Status) || String.IsNullOrEmpty(issue.Description)) {

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


            

            //Add 1 to highest issue Id

            issue.Id = IssueFixture.Issues.OrderBy(x => x.Id).Last().Id + 1 ;
            

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

        public IssueVM ConvertToIssueVM (Issue issue)
        {
            Equipment equipment = EquipmentFixture.equipments.Find(x => x.Id == issue.IdEquipment);
            Client client = ClientFixture.clients.Find(x => x.Id == equipment.IdClient);

            if(equipment == null || client == null)
            {

                throw new Exception(ExceptionHelper.GENERAL_EXCEPTION);

            }




            IssueVM issueVM = new(); 
            issueVM.Id = issue.Id;
            issueVM.IdClient = client.Id;
            issueVM.IdEquipement = equipment.Id;
            issueVM.EquipmentName = equipment.Type + "#" + equipment.Id;

            issueVM.ClientName = client.FullName;
            issueVM.Description = issue.Description; 
            issueVM.Status = issue.Status;  
            issueVM.ReportDate = issue.ReportDate;
            issueVM.CLientAdress = client.FullAdress;
            return issueVM;

        }



        public Issue ConvertToIssue(IssueVM issueVM)
        {
            Issue issue = new();
            issue.Id = issueVM.Id;
            issue.IdEquipment = issueVM.IdEquipement;
            issue.ReportDate = issueVM.ReportDate; 
            issue.Description = issueVM.Description;
            issue.Status = issueVM.Status;

            return issue;
            


        }

        //Delete all issues related to client
        public void RemoveClientIssues(Client client)
        {
            // GET Client Equipments 
            EquipmentService equipmentService = new();
            List<Equipment> equipments = equipmentService.GetEquipmentPerClient(client); 


            // GET equipments issues 
            
            foreach( Equipment equipment in equipments)
            {
                if(equipment.IdClient == client.Id)  {

                    List<Issue> issues = GetEquipmentIssues(equipment.Id);


                    //RemoveIssues
                    foreach ( Issue issue in issues)
                    {
                        DeleteIssue(issue);
                    }
                }
            }



        }
    }
}
