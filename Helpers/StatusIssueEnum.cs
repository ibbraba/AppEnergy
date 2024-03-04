﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Helpers
{
     public static class StatusIssueEnum
    {
        public static string NotFixed = "Not fixed";

        public static string Fixed = "Fixed";

        public static List<string> GetIssueStatusList()
        {
            List <string> issues = new List<string>();
            issues.Add(NotFixed);
            issues.Add(Fixed);

            return issues; 
        }
    }
}
