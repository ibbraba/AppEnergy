using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Fixtures
{
    class MaintenanceFixture
    {

       private static List<Maintenance> maintenances = new List<Maintenance>();    


        public static List<Maintenance> Maintenances { get {  return maintenances; } }

        


    }
}
