﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentHouse
{
   
    class Student
    {

        private List<String> username = new List<string>();
        private List<String> password = new List<string>();

        private List<String> getUserNames()
        {
        List<String> usernameCopy = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Username from Users", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usernameCopy.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            return usernameCopy;

        }
        private List<String> getPasswords()
        {
            List<String> passwordCopy = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Password from Users", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                passwordCopy.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            return passwordCopy;

        }








        public bool checkLogIn(string username, string password)
        {
            this.username = getUserNames();
            this.password = getPasswords();
            bool check = false;
            for (int i = 0; i < this.username.Count; i++)
            {
                if (this.username[i] == username && this.password[i] == password)
                {
                    check = true;
                    break;
                }
            }
            return check;

        }



    }
  

}
