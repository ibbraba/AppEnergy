﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Models
{
    class Maintenance
    {
        public int Id { get; set; }
        public int IdMateriel { get; set; }

        public string Description { get; set; }    

        public string Status { get; set; }    

    }
}
