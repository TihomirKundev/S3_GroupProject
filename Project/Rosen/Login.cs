using System.Data.SqlClient;
using System.Data;
using System;
namespace Project
{
    class Login
    {
        //CheckLogin method using databases
        private string name, password;
        private readonly string adminU = "group04";
        private readonly string adminP = "1234";
        private bool CheckLogInAdmin(string name, string password)
        {
            if (this.adminU == name && this.adminP == password)
                return true;
            return false;
        }
        private bool CheckLogInUser(string username, string password)
        {
            bool check = false;
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UsersData a WHERE a.Username='" + username + "' AND a.Password='" + password + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
            new User(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), Convert.ToInt32(dr.GetValue(3)));
                _ = new StudentForm
                {
                    Visible = true
                };
                check = true;   
            }
            con.Close();
            return check;
        }
        public void SetData(string name, string password)
        {
            this.name = name;
            this.password = password;
            CheckData();
        }
        private void CheckData()
        {
                LoginForm sendMessage = new LoginForm();

                if (CheckLogInUser(name, password) == true)
                {
            
                }
                else
                {
                if (CheckLogInAdmin(name, password) == true)
                {
                    _ = new AdminForm
                    {
                        Visible = true,
                        Text = "Admin - " + name
                    };
                }
                else
                sendMessage.SendMessage("Wrong data");
                }
            }
        }
    }

