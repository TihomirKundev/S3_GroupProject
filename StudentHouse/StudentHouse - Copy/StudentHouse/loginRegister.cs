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
            radioButton1.Checked=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void changeVisibility(bool check)
        {
            foreach (Control x in Controls)
            {
                if (Convert.ToString(x.Tag) == "Register")
                    x.Visible = check;
                if (Convert.ToString(x.Tag) == "Login")
                    x.Visible = !check;
            }
        }
        private void checkChanged(object sender, EventArgs e)
        {
           if(radioButton1.Checked == true)
            {
                label1.Text = "Name or email:";
                changeVisibility(false);
            }
            if (radioButton1.Checked == false)
            {
                label1.Text = "Name:";
                changeVisibility(true);
            }
        }
    }
}
