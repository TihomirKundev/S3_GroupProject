using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHouse
{
    public partial class loginRegister : Form
    {
       
        public loginRegister()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
     
        public void sendMessage(string message)
        {
            if (message.Contains("Wrong"))
            MessageBox.Show(message, "Error");

        }
      private void change22()
        {
            adminForm nextForm = new adminForm();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Student m = new Student();
        }
    }
}
