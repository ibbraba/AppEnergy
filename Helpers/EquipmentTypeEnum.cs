using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Helpers
{
    public sealed class EquipmentTypeEnum
    {

        public static string SOLAR_PANEL = "Solar Panel"; 
        public static string THERMODYNAMIC_BALOON= "Thermodynamic baloon"; 
        public static string HEAT_PUMP = "Heat Pump"; 

        public static List<string> GetEquipmentTypes()
        {
            List<string> types = new ();
            types.Add(SOLAR_PANEL);
            types.Add(THERMODYNAMIC_BALOON);
            types.Add(HEAT_PUMP);

            return types;

        }



    }
}
