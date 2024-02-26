﻿using AppEnergy.Fixtures;
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

        public List<Equipment> GetAllEquipments()
        {
            return EquipmentFixture.equipments; 
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
            EquipmentFixture.equipments.Remove(equipment); 
        }

    }
}