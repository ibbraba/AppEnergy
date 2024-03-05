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
    class EquipmentService
    {
        private List<Equipment> _equipments;
        private MaintenanceService _maintenancesService;
        private IssueService _IssueService;

        public EquipmentService()
        {
            _equipments = GetAllEquipments();
            _maintenancesService = new MaintenanceService();
            _IssueService = new IssueService(); 
        }

        public List<Equipment> GetAllEquipments()
        {
            return EquipmentFixture.equipments; 
        }

        public List<Equipment> GetEquipmentPerClient(Client client)
        {
            return GetAllEquipments().Where(x => x.IdClient == client.Id).ToList();

        }



        public void CreateEquipment(Equipment equipment)
        {
           //Validate entries 

            List<Client> clients = ClientFixture.clients;

            Client client = clients.Find(x => x.Id == equipment.IdClient);
            if (client == null) {

                throw new ArgumentException("An error has occured with the selected client");
            }

            if (String.IsNullOrEmpty(equipment.Status))
            {
                throw new ArgumentException("Please enter the equipment status");
            } 

            if(equipment.Date < DateTime.MinValue.AddDays(3))
            {
                throw new ArgumentException("Please enter a valid installation date");
            }



            //Check number of equipment for selected user 

            ClientService clientService = new();

            if(clientService.GetClientEquipment(client).Count > 2)
            {
                throw new Exception("Client has reached the number of equimpment available"); 
            }


            equipment.Id = _equipments.OrderBy(x => x.Id).Last().Id + 1;

            //Add Equipment

            EquipmentFixture.equipments.Add(equipment);

        }


        public void EditEquipment(Equipment equipment)
        {
            Equipment equipmentInDB = EquipmentFixture.equipments.Find(x => x.Id == equipment.Id); 
            if(equipmentInDB == null)
            {
                throw new Exception(ExceptionHelper.GENERAL_EXCEPTION); 
            }

            
            EquipmentFixture.equipments.Remove(equipmentInDB);

            EquipmentFixture.equipments.Add(equipment);

        }


        public void RemoveEquipment(Equipment equipment)
        {
            //Remove maintenances linked to equipment
            List<Maintenance> maintenances = _maintenancesService.GetMaintenanceForEquipment(equipment.Id);
            foreach (Maintenance maintenance in maintenances)
            {
                _maintenancesService.DeleteMaintenance(maintenance);
            }



            //Remove issues linked to equipment 
            List<Issue> issues = _IssueService.GetEquipmentIssues(equipment.Id);
            foreach (Issue issue in issues)
            {
                _IssueService.DeleteIssue(issue);
            }


            //REMOVE EQUIPMENT
            EquipmentFixture.equipments.Remove(equipment); 
        }

    }
}
