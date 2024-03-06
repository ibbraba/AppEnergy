using AppEnergy.Fixtures;
using AppEnergy.Helpers;
using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Services
{
    public class ClientService
    {
        private EquipmentService _equipmentService;
        private MaintenanceService _maintenanceService;
        private IssueService _issueService;
        private List<Equipment> _equipments;
        private List<Maintenance> _maintenances;
        private List<Issue> _issues;

        public ClientService()
        {
            _equipmentService = new EquipmentService();
            _maintenanceService = new MaintenanceService();
            _issueService = new IssueService();
            _issues = _issueService.GetAllIssues();

            _equipments = _equipmentService.GetAllEquipments();
            _maintenances = _maintenanceService.GetAllMiantenances();
;
        }




        public List<Client> GetAllClients()
        {
            return ClientFixture.clients;
        }


        public void AddClient(Client client)
        {
            //CHECK IF CLIENT'S RREGISTERED LIMIT IS REACHED
            if (ClientFixture.clients.Count > 2)
            {
                throw new Exception("You have reached the limit of client's in the registry");
            }

            //VERIFY ENTRIES
            ValidateClient(client);


            //AddClient
            ClientFixture.clients.Add(client);
        }



        public List<Equipment> GetClientEquipment(Client client)
        {
            List<Equipment> equipments = EquipmentFixture.equipments.Where(x => x.IdClient == client.Id).ToList();
            return equipments;
        }

        private void ValidateClient(Client client) {

            if (String.IsNullOrEmpty(client.Name) || String.IsNullOrEmpty(client.LastName))
            {
                throw new ArgumentNullException(" Please enter the client's name");
            }

            if (String.IsNullOrEmpty(client.Adress) || String.IsNullOrEmpty(client.City) || client.ZipCode == 0)
            {
                throw new ArgumentNullException("Please enter a full adress");
            }


            if (String.IsNullOrEmpty(client.PhoneNumber) || String.IsNullOrEmpty(client.Mail))
            {
                throw new ArgumentNullException("Please enter client's phone number and mail");
            }

           
        }

        public void DeleteClient(Client client)
        {

           

            //Remove all MAINTENANCES linked to client

            _maintenanceService.RemoveClientMaintenances(client);

            //Remove all issues linked to client
            _issueService.RemoveClientIssues(client); 


            //Remove all equipment linked to client

            List<Equipment> clientEquipments = _equipmentService.GetEquipmentPerClient(client);
            _equipments.RemoveAll(x => x.IdClient == client.Id);

            //Remove client
            ClientFixture.clients.Remove(client);



        }


        public void EditClient(Client client)
        {

            Client clientInDB = ClientFixture.clients.Find(x => x.Id == client.Id);

            if (clientInDB == null) {

                throw new Exception(ExceptionHelper.GENERAL_EXCEPTION);
            
            }
            ClientFixture.clients.Remove(clientInDB);
            ClientFixture.clients.Add(client);
        }
        
        
        

    }
}
