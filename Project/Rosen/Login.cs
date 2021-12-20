using System.Data.SqlClient;
using System.Data;
using System;
namespace Project
{
    class Login
    {
        //CheckLogin method using databases
        private string name, password;
        private string adminU = "group04", adminP = "1234";
        private string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";

        private bool checkLogInAdmin(string name, string password)
        {
            if (this.adminU == name && this.adminP == password)
                return true;
            return false;
        }
        private bool checkLogInUser(string username, string password)
        {
            bool check = false;
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UsersData a WHERE a.Username='" + username + "' AND a.Password='" + password + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
            new User(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), Convert.ToInt32(dr.GetValue(3)));
            StudentForm openStudent = new StudentForm();
            openStudent.Visible = true;
            check = true;   
            }
            con.Close();
            return check;
        }
        public void setData(string name, string password)
        {
            this.name = name;
            this.password = password;
            CheckData();
        }
        private void CheckData()
        {
                LoginForm sendMessage = new LoginForm();

                if (checkLogInUser(name, password) == true)
                {
            
                }
                else
                {
                if (checkLogInAdmin(name, password) == true)
                {
                    AdminForm openAdmin = new AdminForm();
                    openAdmin.Visible = true;
                    openAdmin.Text = "Admin - " + name;
                }else
                sendMessage.sendMessage("Wrong data");
                }
            }


        }
    }

