using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.ViewModels
{
    public class IssueVM
    {
        public int Id { get; set; } 

        public int IdEquipement { get; set; }

        public int IdClient { get; set; }

        public string EquipmentName { get; set; }   



        public string ClientName { get; set; }

        public string CLientAdress { get; set; }
        public string Description { get; set; }
        public DateTime ReportDate { get; set; }    

        public string Status { get; set; }
    }
}
