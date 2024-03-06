using AppEnergy.Fixtures;
using AppEnergy.Helpers;
using AppEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppEnergy.Services
{
    public class UserService
    {
        /// <summary>
        /// Check input entries to log in 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns> </returns>
        public bool LoginUser (string login, string password)
        {

            // FIND USER WITH LOGIN

            User user =  UserFixture.GetUsers().Where(x => x.Login == login).FirstOrDefault(); 
            if(user == null)
            {
                return false;
            }



            // HASH INPUT PASSWORD 




            //COMPARED HASHED PASSWORDS 

            if(user.Password == password)
            {
                AppHelper.SetCurrenrUser(user);
                return true;
            }
            else
            {
                throw new Exception("Invalid credentials"); 
            }

            //RETURN TRUE OR FALSE 

            
        }



    }
}
