using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StudentHouse
{
    public partial class loginRegister : Form
    {
        private string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        public loginRegister()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearTextBoxes()
        {
            logInName.Text = "";
            logInPassword.Text = "";
        }
        
     
        public void sendMessage(string message)
        {
            if (message.Contains("Wrong"))
            MessageBox.Show(message, "Error");

        }
     
        private void login_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(logInName.Text) || !string.IsNullOrEmpty(logInPassword.Text))
            {
                Person checkAllData = new Person();
                checkAllData.setData(logInName.Text, logInPassword.Text);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please fill all boxes");
            }
        }
        private void hideRegister(bool onOff)
        {
            foreach (Control x in Controls)
            {
                if (Convert.ToString(x.Tag) == "register")
                    x.Visible = onOff;
                if (x.Text == "Login")
                    x.Visible = !onOff;
            }
                
        }
      
     
        private void addData(string username, string password)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UsersData values (@Username,@Password, @Apartment)", con);
           
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Apartment", 0);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
