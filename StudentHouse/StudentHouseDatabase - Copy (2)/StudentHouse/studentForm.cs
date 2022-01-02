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
    

    public partial class studentForm : Form
    {
        private string userID = "";
        private string username = "";
        private int userApartmentID = 0;
        private bool doesTheUserHaveApartment = false;
        private string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";

        public studentForm()
        {
         
            InitializeComponent();
            settings.Items.Add("None");
            settings.Items.Add("Send complaint");
            settings.Items.Add("Schedule for cleaning");
        }
        
     
        private void button3_Click(object sender, EventArgs e) //Complaint
        {

        }

       
   
        private void uploadDataFromDatabaseApartments()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ApartmentsData", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void changeInterface()
        {
            if (doesTheUserHaveApartment == true)
            {
                getApartment.Visible = false;
                label1.Text = "Hello, "+username+" Here is the data for your apartment";
                settings.Visible = true;
            }
            else
            {
           
                label1.Text = "Hello, " + username + " You dont have apartment yet. Here is the list of available apartments";
                uploadDataFromDatabaseApartments();

            }
        }
        private void uploadDataFromDatabaseUsersWithApartment()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
          
            SqlCommand cmd = new SqlCommand("SELECT * FROM ApartmentsData WHERE ID = '"+userApartmentID+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

           
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                doesTheUserHaveApartment = true;
                dataGridView1.DataSource = dt;
            }
            else
            {
                doesTheUserHaveApartment = false;
            }
                
          
            changeInterface();


            con.Close();
        }
        private void getData()
        {
           
            Form f = Application.OpenForms["StudentForm"];
            string m = f.Tag.ToString();
            string[] values = m.Split(' ');
            username = values[1];
            userID = (getID(values[1], values[2])).ToString();
        }
        private int getID(string username, string password)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID from UsersData a WHERE a.Username='" + username + "' AND a.Password='" + password + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
               
            }
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Apartment from UsersData a WHERE a.Username='" + username + "' AND a.Password='" + password + "'", con);

            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                str.Add(dr2.GetValue(0).ToString());
                userApartmentID = Convert.ToInt32(dr2.GetValue(0).ToString());
            }
            con.Close();

            return Convert.ToInt32(str[0]);
        }

       
        
        //private int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (count == 0)
            {
                getData();
                uploadDataFromDatabaseUsersWithApartment();
                studentForm changeTag = new studentForm();
                count++;
            }
           */

        }

        private void studentForm_Load(object sender, EventArgs e)
        {
        }
        private void updateChanges()
        {
            getData();
            uploadDataFromDatabaseUsersWithApartment();
            studentForm changeTag = new studentForm();
            changeTag.Tag = "StudentForm";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            updateChanges();
        }

      
        private int getIndex()
        {
            int rc = dataGridView1.CurrentCell.RowIndex;
            return rc;
        }
        private void getApartmentFirst(int apartmentID)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UsersData set Apartment=@Apartment where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", userID);
            cmd.Parameters.AddWithValue("@Apartment", apartmentID);
            MessageBox.Show("You bought apartment: "+apartmentID);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void getApartment_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell.RowIndex != -1)
            {
                getApartmentFirst(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value));
                doesTheUserHaveApartment = true;
                uploadDataFromDatabaseUsersWithApartment();
                updateChanges();
      
            }
            else
            {
                MessageBox.Show("Please first choose apartment");
            }
        
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Visible = false ;
            loginRegister open = new loginRegister();
            open.Visible = true;
            
        }

      

     

        private void FormClose(object sender, FormClosingEventArgs e)
        {
        }
        private void changeFromComplaintToNormal(bool change)
        {
            foreach (Control x in Controls)
            {
                if (Convert.ToString(x.Tag) == "complaint")
                    x.Visible = change;
                if (Convert.ToString(x.Tag) == "dontHaveApartment")
                    x.Visible = !change;
            }

        }
        private void changeView(object sender, EventArgs e)
        {
            if (settings.SelectedIndex == 0)
            {
                changeFromComplaintToNormal(false);
                getApartment.Visible=false;
            }
            if (settings.SelectedIndex == 1)
                changeFromComplaintToNormal(true);
            if (settings.SelectedIndex == 2)
            {
                changeFromComplaintToNormal(false);
                uploadSchedule();
            }

        }
        private void uploadSchedule()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE ApartmentID = '" + userApartmentID + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            da.Fill(dt);
          
                dataGridView1.DataSource = dt;
         


            con.Close();
        }
        private void sendComplaint_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ComplaintMessages values (@ApartmentID,@Complaint)", con);
            cmd.Parameters.AddWithValue("@ApartmentID", userApartmentID);
            cmd.Parameters.AddWithValue("@Complaint", complaintTxtBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("We are going to fix the problem", "Message send");
            changeFromComplaintToNormal(false);
        }
    }
}
