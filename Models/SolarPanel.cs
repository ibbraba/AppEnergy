﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Models
{
    public class SolarPanel : Equipment
    {
        public string Color { get; set; }

        public override string Type { get { return "Solar panel"; } }

    }
}
