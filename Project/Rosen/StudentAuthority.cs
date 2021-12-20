using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Project
{
    class StudentAuthority
    {
        private UploadStudentData studentAuthority = new UploadStudentData();
        private const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NUMBERS = "123456789";
        private const string SPECIALS = @"!@£$%^&*()#€";
        public StudentAuthority()
        {
            allUsersData = studentAuthority.AllUsersCheck();
        }
        

        public List<User> allUsersData
        {
            get;
            private set;
        }
        public void ModifyUsersData(string option, User user)
        {
            studentAuthority.ModifyUsersData(option, user);
            allUsersData = studentAuthority.AllUsersCheck();
        }
        public string GeneratePassword(int passwordSize)
        {
            char[] _password = new char[passwordSize];
            string charSet = "";
            System.Random _random = new Random();
            int counter;

            if (true) charSet += UPPER_CAES.ToLower();

            if (true) charSet += UPPER_CAES;

            if (true) charSet += NUMBERS;

            if (true) charSet += SPECIALS;

            for (counter = 0; counter < passwordSize; counter++)
            {
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            }
            return String.Join(null, _password);
        }
    }
}
