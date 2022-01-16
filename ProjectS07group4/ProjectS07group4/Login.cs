using System;
using System.Data.SqlClient;
namespace ProjectS07group4
{
    class Login
    {
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

                _ = new StudentForm(new User(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), Convert.ToInt32(dr.GetValue(3))))
                {
                    Visible = true
                };
                check = true;
            }
            con.Close();
            return check;
        }
        public bool SetData(string name, string password)
        {
            this.name = name;
            this.password = password;
            return CheckData();
        }
        private bool CheckData()
        {
            bool check = false;
            LoginForm sendMessage = new LoginForm();
            if (CheckLogInUser(name, password) == true)
            {
                check = true;
            }
            else
            {
                if (CheckLogInAdmin(name, password) == true)
                {
                    check = true;
                    _ = new AdminForm
                    {
                        Visible = true,
                        Text = "Admin - " + name
                    };
                }
            }
            return check;
        }
    }
}
