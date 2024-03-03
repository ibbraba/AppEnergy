using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppEnergy.ViewModels
{
    public class MaintenanceVM
    {
        public int Id { get; set; }

        public int IdEquipment { get; set; }    

        public string ClientName { get; set; }

        public string EquipmentName { get; set; }       

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string ClientAdress { get; set; }    


        public override string ToString()
        {
            return "Maintenance #" + Id + " - " + ClientName ;
        }

    }
}
