using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Models
{
    abstract class Equipment
    {
        public int Id { get; set; } 

        public int IdClient { get; set; }

        public DateTime Date {  get; set; }

        public string Status { get; set; }
    }
}
