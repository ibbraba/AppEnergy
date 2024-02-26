using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEnergy.Helpers
{
    static class AppHelper
    {

        private static User currentUser;



        public static User? GetCurrentUser()
        {
            return currentUser;
        }

        public static void SetCurrenrUser(User user) {
        
            currentUser = user;
        
        }
    }
}
