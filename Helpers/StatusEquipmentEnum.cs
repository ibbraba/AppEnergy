using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Helpers
{
    public sealed class StatusEquipmentEnum
    {

        public static string Functional = "Functional";

        public static string OutOfService = "Out of service";

        public static List<string> GetStatus()
        {
            var status = new List<string>();
            status.Add(Functional); 
            status.Add(OutOfService);   

            return status;
        }

    }
}
