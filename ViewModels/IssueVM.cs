using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.ViewModels
{
    class IssueVM
    {
        public int Id { get; set; } 

        public int IdEquipement { get; set; }

        public string EquipmentName { get; set; }   

        public string ClientName { get; set; }
        public string Description { get; set; }
        public DateTime ReportDate { get; set; }    

        public string Status { get; set; }
    }
}
