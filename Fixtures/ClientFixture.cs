﻿using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Fixtures
{
    class ClientFixture
    {

        public Client client1()
        {

            Client client1 = new Client();  
            client1.Id = 1;
            client1.Name = 'Mickael'; 
            client1.LastName = "Ferrand";
            client1.Adress = "6 rue des vents";
            client1.ZipCode = 78100;
            client1.City = "Saint-Germain-en-Laye";
            client1.Mail = "mferrand@gmail.com"; 
            client1.PhoneNumber = "0701012020";


            return client1; 




        }


        public Client client2()
        {

            Client client2 = new Client();
            client2.Id = 2;
            client2.Name = 'Simon';
            client2.LastName = "Dury";
            client2.Adress = "11 rue de la vigne";
            client2.ZipCode = 92200;
            client2.City = "Neuilly-sur-Seine ";
            client2.Mail = "simondury@live.fr";
            client2.PhoneNumber = "0155000404";


            return client2;




        }


        public List<Client> GetClients()
        {
            Client client1 = client1();
            Client client2 = client2();


            List<Client> clients = new();

            clients.Add(client1); 
            clients.Add(client2);

            return clients;

        }


    }
}