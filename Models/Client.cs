using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public string LastName { get; set; }

        public string Adress { get; set; }

        public int ZipCode { get; set; }   

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public string Mail { get; set; }

        public string FullName
        {
            get { return LastName + " " + Name; }
        }


        public string FullAdress
        {
            get
            {
                return Adress + " " + ZipCode + " " + City; 
            }
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}
