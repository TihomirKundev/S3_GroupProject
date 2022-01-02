using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouse
{
    class Student
    {
        private List<String> name = new List<String>();
        private List<String> password = new List<String>();
        private void setStudents()
        {
            name.Add("Rosen");
            password.Add("1111");

            name.Add("Tihomir");
            password.Add("2222");

            name.Add("Anna");
            password.Add("3333");
        }

       public void setStudentInfo(string name, string password)
        {
            this.name.Add(name);
            this.password.Add(password);
        }
        
        public List<String> getName()
        {
            setStudents();
            return name;
        }
        public List<String> getPasswords()
        {
            setStudents();
            return password;
        }
        public void changeName(int index, string newName)
        {
            setStudents();
            name[index] = newName;
        }
        public void changePasswords(int index, string newPassword)
        {
            setStudents();
            password[index] = newPassword;
        }

        public bool checkLogIn(string name, string password)
        {
            setStudents();
            bool check = false;
            for(int i = 0; i < this.name.Count; i++)
            {
                if(this.name[i] == name && this.password[i] == password)
                {
                    check= true;
                    break;
                }
            }
            return check;
           
        }

    }
    
}
