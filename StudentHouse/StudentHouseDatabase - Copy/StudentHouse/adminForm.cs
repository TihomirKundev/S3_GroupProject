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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            settings.Items.Add("None");
            settings.Items.Add("Change Data");
            settings.Items.Add("Delete data");
            settings.SelectedIndex = 0;
            uploadDataFromDatabase();
            
        }

        private void adminForm_Load(object sender, EventArgs e)
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
        private void removeData(bool change)
        {
            foreach (Control x in Controls)
                if (Convert.ToString(x.Tag) == "delete")
                    x.Visible = change;
        }

     
     
        private void adminSettingsTimer(object sender, EventArgs e)
        {
        
            if (settings.SelectedIndex == 0)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
                removeData(false);
            }
            if (settings.SelectedIndex == 1)
            {
                
                changeNameOrPassword(true);
                if(radioButton1.Checked == true)
                {
                   
                    if(dataGridView1.CurrentCell.RowIndex != -1)
                    {
                        oldData.Text = getName(getIndex());
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
                   
                    if (dataGridView1.CurrentCell.RowIndex != -1)
                    {
                        oldData.Text = getPassword(getIndex());
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
            if (settings.SelectedIndex == 2)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
                removeData(true);
              

            }
        }
        private void deleteUsernamePassword()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Username = @Username", con);

            cmd.Parameters.AddWithValue("@Username", getName(getIndex()));
            cmd.ExecuteNonQuery();
            uploadDataFromDatabase();

            con.Close();
            MessageBox.Show("Succesfully Deleted");
        }
        private void filterSettings(object sender, EventArgs e)
        {
           
        }
      
        public void sendM(string m)
        {
            MessageBox.Show(m);
        }
        private void change_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newData.Text))
            {
                if (radioButton1.Checked == true)
                    changeName();
                if (radioButton2.Checked == true)
                    changePassword();
            }
            else
            {
                MessageBox.Show("Please fill the new field");
            }
            uploadDataFromDatabase();



        }


        private void uploadDataFromDatabase()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }
        private int getIndex()
        {
         
                int rc = dataGridView1.CurrentCell.RowIndex;
            return rc;
        }
        private string getName(int index)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Username from Users", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            return str[index];
        }
        private string getPassword(int index)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Password from Users", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            return str[index];
        }
        private void changePassword()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Users set Password=@Password where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", getName(getIndex()));
            cmd.Parameters.AddWithValue("@Password", newData.Text);
        
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully updated");

        }
        private void changeName()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TAVNN38\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Users set Username=@Username where Password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", newData.Text);
            cmd.Parameters.AddWithValue("@Password", getPassword(getIndex()));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully updated");

        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            if(getIndex() != -1)
            {
                deleteUsernamePassword();
            }
        }
    }
}
