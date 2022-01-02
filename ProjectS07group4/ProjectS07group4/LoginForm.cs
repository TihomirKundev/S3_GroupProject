using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectS07group4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            logInName.Text = "group04";
            logInPassword.Text = "1234";

        }
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logInName.Text) || !string.IsNullOrEmpty(logInPassword.Text))
            {
                Login checkAllData = new Login();
                if (checkAllData.SetData(logInName.Text, logInPassword.Text) == true)
                    this.Hide();
                else
                    MessageBox.Show("Incorrect email or password", "Login failed");
            }
            else
                MessageBox.Show("Please fill all boxes");
        }

        private void ClosingApplication(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
            System.Windows.Forms.Application.Exit();
        }
    }
}
