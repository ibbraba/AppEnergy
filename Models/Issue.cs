using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AppEnergy.Models
{
    public class Issue
    {
        public int Id { get; set; } 
        public int IdEquipment { get; set; }

        public DateTime ReportDate { get; set; }

        public string Description { get; set; }

        public string Status {  get; set; }

        public override string ToString()
        {
            return "Issue #" + Id;
        }
    }
}
