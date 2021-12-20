using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public static int userID { get; private set; }
        public static int apartmentID { get; private set; }
        public static string userName { get; private set; }
        public static string password { get; private set; }

        public int userIdentity { get; private set; }
        public string userEmail { get; private set; }
        public string userPassword { get; private set; }
        public int userApartmentID { get; private set; }

        public User(int userID2, string name2, string password2, int apartmentID2)
        {
            userID = userID2;
            userName = name2;
            password = password2;
            apartmentID = apartmentID2;
            this.userIdentity= userID2;
            this.userEmail = name2;
            this.userPassword = password2;
            this.userApartmentID = apartmentID2;
        }
       
    }
}
