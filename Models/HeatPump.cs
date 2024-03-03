using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Models
{
    public class HeatPump : Equipment
    {
        public override string Type { get { return "Heat Pump"; } } 
    }
}
