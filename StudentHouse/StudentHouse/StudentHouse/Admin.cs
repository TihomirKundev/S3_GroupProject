using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouse
{
    class admin
    {
        private string name="group04", password="1234";

        public bool checkLogIn(string name, string password)
        {
            if (this.name == name && this.password == password)
                return true;
            return false;
        }
    }
}
