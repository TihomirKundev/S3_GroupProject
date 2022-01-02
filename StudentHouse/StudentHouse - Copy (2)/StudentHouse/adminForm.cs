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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            settings.Items.Add("None");
            settings.Items.Add("Change Data");
            settings.SelectedIndex = 0;
          
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void studentsSelectIndex(object sender, EventArgs e)
        {

        }
        private void changeNameOrPassword(bool change)
        {
            foreach (Control x in Controls)
                if (Convert.ToString(x.Tag) == "changeBy")
                    x.Visible = change;
        }
        private void changeByExactData(bool change)
        {
            foreach (Control x in Controls)
                if (Convert.ToString(x.Tag) == "changeByX")
                    x.Visible = change;
        }
       
        private void setDataToList()
        {
            students.Items.Clear();
            List<String> names = getNames();
            List<String> passwords = getPasswords();

            for (int i = 0; i < names.Count; i++)
                students.Items.Add("Name: " + names[i] + " Password: " + passwords[i]);
        }
        private List<String> getNames()
        {
            Student studentData = new Student();
            List<String> names = studentData.getName();
            return names;
        }
        private List<String> getPasswords()
        {
            Student studentData = new Student();
            List<String> passwords = studentData.getPasswords();
            return passwords;
        }
        private void adminSettingsTimer(object sender, EventArgs e)
        {
            if (settings.SelectedIndex == 0)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
            }
            if (settings.SelectedIndex == 1)
            {
                
                changeNameOrPassword(true);
                if(radioButton1.Checked == true)
                {
                    List<String> names = getNames();
                    if(students.SelectedIndex != -1)
                    {
                        oldData.Text = names[students.SelectedIndex];
                    }
                    else
                    {
                        oldData.Text = "Select student";
                    }
                    changeByExactData(true);
                    oldOne.Text = "Old name:";
                    newOne.Text = "New name:";
                }
                if (radioButton2.Checked == true)
                {
                    List<String> passwords = getPasswords();
                    if (students.SelectedIndex != -1)
                    {
                        oldData.Text = passwords[students.SelectedIndex];
                    }
                    else
                    {
                        oldData.Text = "Select student";
                    }
                    changeByExactData(true);
                    oldOne.Text = "Old password:";
                    newOne.Text = "New password:";
                }
            }
        }

        private void filterSettings(object sender, EventArgs e)
        {
            setDataToList();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Student changeData = new Student();
            if (!string.IsNullOrEmpty(newData.Text))
            {
                if(radioButton1.Checked == true)
                {
                    changeData.changeName(students.SelectedIndex, newData.Text);
                }
                if (radioButton2.Checked == true)
                {
                    changeData.changePasswords(students.SelectedIndex, newData.Text);
                }
            }
            else
            {
                MessageBox.Show("Please fill new");
            }
        }
    }
}
