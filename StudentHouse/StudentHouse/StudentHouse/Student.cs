using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouse
{
   
    class Student
    {
   List<string> name = new List<string>()
                    {"Rosen", "Tihomir", "Anna" };
            List<string> password = new List<string>()
                    {"1111", "2222", "3333" };
        
           
        
       

        

        public List<String> getName()
        {

            return name;
        }
        public List<String> getPasswords()
        {
            return password;
        }
        public void changeName(int index, string newName)
        {
            adminForm m = new adminForm();

            name[index] = newName;
            m.sendM(newName);
        }
        public void changePasswords(int index, string newPassword)
        {
            password[index] = newPassword;
        }

        public bool checkLogIn(string name, string password)
        {

            bool check = false;
            for (int i = 0; i < this.name.Count; i++)
            {
                if (this.name[i] == name && this.password[i] == password)
                {
                    check = true;
                    break;
                }
            }
            return check;

        }



    }
  

}
