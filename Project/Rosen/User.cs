using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public static int UserID { get; private set; }
        public static int ApartmentID { get; private set; }
        public static string UserName { get; private set; }
        public static string Password { get; private set; }

        public int UserIdentity { get; private set; }
        public string UserEmail { get; private set; }
        public string UserPassword { get; private set; }
        public int UserApartmentID { get; private set; }

        public User(int userID2, string name2, string password2, int apartmentID2)
        {
            UserID = userID2;
            UserName = name2;
            Password = password2;
            ApartmentID = apartmentID2;
            this.UserIdentity= userID2;
            this.UserEmail = name2;
            this.UserPassword = password2;
            this.UserApartmentID = apartmentID2;
        }
       
    }
}
