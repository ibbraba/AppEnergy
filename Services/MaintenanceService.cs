using AppEnergy.Fixtures;
using AppEnergy.Helpers;
using AppEnergy.Models;
using AppEnergy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Services
{
    class MaintenanceService
    {

        public List<Maintenance> GetMaintenanceForEquipment(int idEquipment)
        {
            List<Maintenance> maintenances = MaintenanceFixture.Maintenances.Where(x => x.IdEquipment == idEquipment).ToList();
            return maintenances;            

        }


        private void ValidateMaintenance(Maintenance maintenance)
        {
           

            if (maintenance.IdEquipment == 0 || maintenance.Date < DateTime.MinValue.AddDays(5) || String.IsNullOrEmpty(maintenance.Status))
            {
                throw new Exception("Please enter all the information about the maiintenance");
            }


        }

        public void CreateMaintenance( Maintenance newMaintenance)
        {
            // Validate entries 

            ValidateMaintenance(newMaintenance);    

            //Check if no maintenance have been made for this year 
            List<Maintenance> maintenances = GetMaintenanceForEquipment(newMaintenance.IdEquipment); 

            foreach(Maintenance maintance in maintenances)
            {
                if(newMaintenance.Date.AddYears(1) > newMaintenance.Date)
                {
                    throw new Exception("At the scheduled date, a maintenance has already been made during the year.");
                }

            }

            // add maintenance
            MaintenanceFixture.Maintenances.Add(newMaintenance);

        }


        public void EditMaintenance(Maintenance maintenance)
        {
            ValidateMaintenance(maintenance);

            Maintenance DbMaintenance = MaintenanceFixture.Maintenances.Find(x => x.Id == maintenance.Id); 

            if(DbMaintenance == null)
            {
                throw new Exception(ExceptionHelper.GENERAL_EXCEPTION);
            }

            MaintenanceFixture.Maintenances.Remove(DbMaintenance);
            MaintenanceFixture.Maintenances.Add(maintenance);
        }


        public void DeleteMaintenance(Maintenance maintenance)
        {
            MaintenanceFixture.Maintenances.Remove(maintenance);
        }

        public MaintenanceVM ConvertToMaintenanceVM(Maintenance maintenance)
        {
            Equipment equipment = EquipmentFixture.equipments.Find(x => x.Id == maintenance.IdEquipment);
            Client client = ClientFixture.clients.Find(x => x.Id == equipment.IdClient);

            if(client == null || equipment == null)
            {
                throw new Exception(ExceptionHelper.GENERAL_EXCEPTION);
            }  


            MaintenanceVM maintenanceVM = new(); 
            maintenanceVM.Id = maintenance.Id;
            maintenanceVM.IdEquipment = maintenance.IdEquipment; 
            maintenanceVM.EquipmentName= equipment.Type + "#" + maintenanceVM.IdEquipment;
            maintenanceVM.ClientName = client.FullName;
            maintenanceVM.Date = maintenance.Date;

            if (!String.IsNullOrEmpty(maintenance.Description))
            {
            maintenanceVM.Description = maintenance.Description; 

            }
            maintenanceVM.Status = maintenance.Status;


            return maintenanceVM;

        } 


        public Maintenance ConvertToMaintenace(MaintenanceVM maintenanceVM)
        {
            Maintenance maintenance = new(); 
            maintenance.Id = maintenanceVM.Id;
            maintenance.IdEquipment = maintenanceVM.IdEquipment;

            if (!String.IsNullOrEmpty(maintenanceVM.Description))
            {
                maintenance.Description = maintenanceVM.Description;
            }

            maintenance.Date = maintenanceVM.Date;
            maintenance.Status = maintenanceVM.Status; 
            
            return maintenance;
        }


    }
}
