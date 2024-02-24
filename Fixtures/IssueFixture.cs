using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Fixtures
{
    class IssueFixture
    {
        public Issue Client1Issue()
        {
            Issue issue = new();
            issue.Id = 1;



            return issue;
        }


    }
}
