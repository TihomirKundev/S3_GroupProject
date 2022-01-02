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
       
        public loginRegister()
        {
            InitializeComponent();
            loginRadioBtn.Checked = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearTextBoxes()
        {
            logInName.Text = "";
            logInPassword.Text = "";
            passwordConfirm.Text = "";
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
        private void loginOrRegister(object sender, EventArgs e)
        {
            if(loginRadioBtn.Checked == true)
            {
                hideRegister(false);
                
            }
            else
            {
                hideRegister(true);
            }
        }
        private void addData(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values (@Username,@Password)", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(logInName.Text) && !String.IsNullOrEmpty(logInPassword.Text) &&
                !String.IsNullOrEmpty(passwordConfirm.Text)){
                if(logInPassword.Text == passwordConfirm.Text)
                {
                    addData(logInName.Text, passwordConfirm.Text);
                    MessageBox.Show("You are now registered, log in", "Congratulations");
                  
                    loginRadioBtn.Checked = true;
                }
                else
                {
                    MessageBox.Show("Passwords dont match");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void emptyTextBoxes(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}
