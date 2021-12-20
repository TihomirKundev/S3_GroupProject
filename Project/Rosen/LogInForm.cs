using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            logInName.Text = "group04";
            logInPassword.Text = "1234";
        }
        public void sendMessage(string message)
        {
            if (message.Contains("Wrong"))
                MessageBox.Show(message, "Error");
            

        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logInName.Text) || !string.IsNullOrEmpty(logInPassword.Text))
            {
                Login checkAllData = new Login();
                checkAllData.setData(logInName.Text, logInPassword.Text);
                this.Visible = false ;
            }
            else
            {
                MessageBox.Show("Please fill all boxes");
            }
        }

        private void closeApplication(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
            System.Windows.Forms.Application.Exit();
        }
    }
}
