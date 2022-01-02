using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouse
{
    class Person
    {
        private string name,password;

        public void setData(string name,string password)
        {
            this.name = name;
            this.password = password;
            checkData();
        }

        private void checkData()
        {
            admin adminCheck = new admin();
            Student studentCheck = new Student();
            loginRegister sendMessage = new loginRegister();
            
            if (adminCheck.checkLogIn(name,password) == true)
            {
                adminForm openAdmin = new adminForm();
                openAdmin.Visible = true;
                openAdmin.Text = "Admin - " + name;
            }
            else
            {
                
                if(studentCheck.checkLogIn(name,password) == true)
                {
                    studentForm openStudent = new studentForm();
                    openStudent.Visible = true;
                    openStudent.Text = "Hello, " + name;
                }
                else
                {
                    sendMessage.sendMessage("Wrong data");
                }
            }

          
        }


    }
}
