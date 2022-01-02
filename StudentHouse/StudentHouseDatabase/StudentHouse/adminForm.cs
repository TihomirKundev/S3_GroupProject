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
        private string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        public adminForm()
        {
     
            InitializeComponent();
            settings.Items.Add("None");
            settings.Items.Add("Change Data");
            settings.Items.Add("Delete data");
            settings.Items.Add("Apartments data-add,upload & delete");
            settings.Items.Add("Users with Apartment");
            settings.Items.Add("Users with no Apartments");
            settings.Items.Add("Complaint Messages");
            settings.Items.Add("Schedule for Apartments");
            settings.SelectedIndex = 0;

            AddDeleteUpdate.Items.Add("Add");
            AddDeleteUpdate.Items.Add("Update");
            AddDeleteUpdate.Items.Add("Delete");

            scheduleComboBox.Items.Add("Add");
            scheduleComboBox.Items.Add("Update");
            scheduleComboBox.Items.Add("Delete");

            uploadDataFromDatabaseUsers();
            addApartmentComboBox();



        }
        private void addApartmentComboBox()
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");

            propertyTypeComboBox.Items.Add("Apartment");
            propertyTypeComboBox.Items.Add("Studio");
            propertyTypeComboBox.Items.Add("Room");
            propertyTypeComboBox.Items.Add("House");

            interiorComboBox.Items.Add("Upholstered");
            interiorComboBox.Items.Add("Furnished");
            interiorComboBox.Items.Add("Shell");

            bedroomsComboBox.Items.Add("1");
            bedroomsComboBox.Items.Add("2");
            bedroomsComboBox.Items.Add("3");
            bedroomsComboBox.Items.Add("4+");

            roomsComboBox.Items.Add("1");
            roomsComboBox.Items.Add("2");
            roomsComboBox.Items.Add("3");
            roomsComboBox.Items.Add("4+");
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
        private void appartmentData(bool change)
        {
            foreach (Control x in Controls)
                if (Convert.ToString(x.Tag) == "Apartments")
                    x.Visible = change;
        }
        private void scheduleData(bool change)
        {
            foreach (Control x in Controls)
                if (Convert.ToString(x.Tag) == "scheduleInfo")
                    x.Visible = change;
        }

        private void setAllToFalse()
        {
            changeNameOrPassword(false);
            changeByExactData(false);
            removeData(false);
            appartmentData(false);
        }
        private void adminSettingsTimer(object sender, EventArgs e)
        {
        
            if (settings.SelectedIndex == 0)
            {
                setAllToFalse();
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
                if (radioButton3.Checked == true)
                {

                    if (dataGridView1.CurrentCell.RowIndex != -1)
                    {
                        oldData.Text = getApartment(getIndex());
                    }
                    else
                    {
                        oldData.Text = "Select student";
                    }
                    changeByExactData(true);
                    oldOne.Text = "Old apartment id:";
                    newOne.Text = "New apartment id:";
                }
            }
            if (settings.SelectedIndex == 2)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
                appartmentData(false);
                removeData(true);
                scheduleData(false);
            }
            if (settings.SelectedIndex == 3)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
                removeData(false);
                scheduleData(false);
                appartmentData(true);

                comboBoxForAddDeleteUpdateApartment();

            }
            if (settings.SelectedIndex == 4)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
                removeData(false);
                appartmentData(false);
                scheduleData(false);

            }
            

            if(settings.SelectedIndex == 6)
            {
                changeNameOrPassword(false);
                changeByExactData(false);
                removeData(false);
                appartmentData(false);
                scheduleData(false);
                addApartments.Visible = false;
                updateApartments.Visible = false;
                deleteApartments.Visible = false;
                deleteComplaint.Visible = true;
            }
            else
            {
                deleteComplaint.Visible = false;

            }
            if (settings.SelectedIndex == 7)
            {
             
            
                
            }
            else
            {
                scheduleAdd.Visible = false;
                scheduleUpdate.Visible = false;
                scheduleDelete.Visible = false;
            }

        }
        private void comboBoxForAddDeleteUpdateApartment()
        {
            if (AddDeleteUpdate.SelectedIndex == 0 && settings.SelectedIndex== 3)
            {
                addApartments.Visible = true;
                updateApartments.Visible = false;
                deleteApartments.Visible = false;
            }

            if (AddDeleteUpdate.SelectedIndex == 1 && settings.SelectedIndex == 3)
            {
                addApartments.Visible = false;
                updateApartments.Visible = true;
                deleteApartments.Visible = false;
            }

            if (AddDeleteUpdate.SelectedIndex == 2 && settings.SelectedIndex == 3)
            {
                addApartments.Visible = false;
                updateApartments.Visible = false;
                deleteApartments.Visible = true;
            }
       
        }
        private void comboBoxForAddDeleteUpdateSchedule()
        {
            if (scheduleComboBox.SelectedIndex == 0 && settings.SelectedIndex == 7)
            {
                scheduleAdd.Visible = true;
                scheduleUpdate.Visible = false;
                scheduleDelete.Visible = false;
            }

            if (scheduleComboBox.SelectedIndex == 1 && settings.SelectedIndex == 7)
            {
                scheduleAdd.Visible = false;
                scheduleUpdate.Visible = true;
                scheduleDelete.Visible = false;
            }

            if (scheduleComboBox.SelectedIndex == 2 && settings.SelectedIndex == 7)
            {
                scheduleAdd.Visible = false;
                scheduleUpdate.Visible = false;
                scheduleDelete.Visible = true;
            }

        }
        private void deleteUsersData()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UsersData WHERE Username = @Username", con);

            cmd.Parameters.AddWithValue("@Username", getName(getIndex()));
            cmd.ExecuteNonQuery();
            uploadDataFromDatabaseUsers();

            con.Close();
            MessageBox.Show("Succesfully Deleted");
        }
       
        private void filterSettings(object sender, EventArgs e)
        {
            if (settings.SelectedIndex == 3)
                uploadDataFromDatabaseApartments();
            if(settings.SelectedIndex==0 || settings.SelectedIndex == 1 || settings.SelectedIndex == 2)
                uploadDataFromDatabaseUsers();
            if(settings.SelectedIndex == 4)
                uploadDataFromDatabaseUsersWithApartment();
            if (settings.SelectedIndex == 5)
                uploadDataFromDatabaseUsersWithNoApartment();
            if (settings.SelectedIndex != 3)
            {
                addApartments.Visible = false;
                updateApartments.Visible = false;
                deleteApartments.Visible = false;
            }
            if (settings.SelectedIndex == 6)
            {
                uploadDataFromComplaintMessages();
                scheduleData(false);
            }
               
            if (settings.SelectedIndex == 7)
            {
                scheduleData(true);
                comboBoxForAddDeleteUpdateSchedule();
                uploadDataFromSchedule();
                addApartmentsIDsToComboBox();
            }
        }
        private void addApartmentsIDsToComboBox()
        {
            apartmentIds.Items.Clear();
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID from ApartmentsData", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                apartmentIds.Items.Add(dr.GetValue(0).ToString());
              
            }
            con.Close();
        }
        private void uploadDataFromComplaintMessages()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ComplaintMessages", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }
      
        private void change_Click(object sender, EventArgs e)
        {
            admin changeN = new admin();
            if (!String.IsNullOrEmpty(newData.Text))
            {
                if (radioButton1.Checked == true)
                    changeN.changeName(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value), newData.Text);
                if (radioButton2.Checked == true)
                    changeN.changePassword(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value), newData.Text);
                if (radioButton3.Checked == true)
                    changeN.changeApartment(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value), newData.Text);
            }
            else
            {
                MessageBox.Show("Please fill the new field");
            }
            uploadDataFromDatabaseUsers();



        }
        

        private void uploadDataFromDatabaseUsers()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("select ID, Username,Password,Apartment from UsersData", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void uploadDataFromDatabaseUsersWithApartment()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select u.ID,u.Username,u.Password,a.ID as Apartment," +
                "a.Gender, a.Price, a.Interior, a.Bedrooms, a.Rooms From UsersData u inner join ApartmentsData a ON u.Apartment = a.ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
           
                da.Fill(dt);
            
            dataGridView1.DataSource = dt;

           
            con.Close();
        }
        private void uploadDataFromDatabaseUsersWithNoApartment()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT u.ID,u.Username,u.Password,a.ID as Apartment,a.Gender, a.Price, a.Interior, a.Bedrooms, a.Rooms " +
                "FROM UsersData AS u LEFT JOIN ApartmentsData AS a ON a.ID = u.Apartment WHERE a.ID IS NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            con.Close();
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
        private void uploadDataFromSchedule()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Schedule", con);
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
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Username from UsersData", con);

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
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Password from UsersData", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            return str[index];
        }

        private string getApartment(int index)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Apartment from UsersData", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            return str[index];
        }




        private void deleteData_Click(object sender, EventArgs e)
        {
            if(getIndex() != -1)
            {
                deleteUsersData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Apartments a inner join Users u ON a.ID=u.ID WHERE a.ID='"+1+"'", con);
            SqlCommand cmd = new SqlCommand("Select * from Apartments a WHERE a.ID='" + 1 + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString()+ dr.GetValue(1).ToString()+ dr.GetValue(2).ToString()+ dr.GetValue(3).ToString()+
                    dr.GetValue(4).ToString()+ dr.GetValue(5).ToString()+ dr.GetValue(6).ToString());
            }
            con.Close();
            MessageBox.Show( str[0]);
        }

        private void addApartments_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(genderComboBox.Text) || !String.IsNullOrEmpty(priceNumeric.Value.ToString()) ||
                !String.IsNullOrEmpty(propertyTypeComboBox.Text) || !String.IsNullOrEmpty(interiorComboBox.Text) ||
                !String.IsNullOrEmpty(bedroomsComboBox.Text) || !String.IsNullOrEmpty(roomsComboBox.Text))
            {
                admin addApartment = new admin();
                addApartment.createApartmentData(genderComboBox.Text, priceNumeric.Value.ToString(), propertyTypeComboBox.Text,
                    interiorComboBox.Text, bedroomsComboBox.Text, roomsComboBox.Text);
                MessageBox.Show("Succesfully added");
                uploadDataFromDatabaseApartments();
                
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error some field are empty");
            }
            

        }

        private void updateApartments_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(genderComboBox.Text) || !String.IsNullOrEmpty(priceNumeric.Value.ToString()) ||
               !String.IsNullOrEmpty(propertyTypeComboBox.Text) || !String.IsNullOrEmpty(interiorComboBox.Text) ||
               !String.IsNullOrEmpty(bedroomsComboBox.Text) || !String.IsNullOrEmpty(roomsComboBox.Text))
            {
                int getID = Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value);
                admin addApartment = new admin();
                addApartment.updateApartmentData(getID, genderComboBox.Text, priceNumeric.Value.ToString(), propertyTypeComboBox.Text,
                    interiorComboBox.Text, bedroomsComboBox.Text, roomsComboBox.Text);
                MessageBox.Show("Succesfully updated");
                uploadDataFromDatabaseApartments();

            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error some field are empty");
            }

        }

   
        private void showDataInComboBoxesForApartments()
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Apartments a inner join Users u ON a.ID=u.ID WHERE a.ID='"+1+"'", con);
            int getID = Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value);
         
            SqlCommand cmd = new SqlCommand("Select * from ApartmentsData a WHERE a.ID='" + getID + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idTxtBox.Text = dr.GetValue(0).ToString();
                genderComboBox.Text= dr.GetValue(1).ToString();
                priceNumeric.Value = Decimal.Parse(dr.GetValue(2).ToString());
                propertyTypeComboBox.Text = dr.GetValue(3).ToString();
                interiorComboBox.Text = dr.GetValue(4).ToString();
                bedroomsComboBox.Text = dr.GetValue(5).ToString();
                roomsComboBox.Text = dr.GetValue(6).ToString();

            }
            con.Close();
        }
        private void showDataInComboBoxesForSchedule()
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Apartments a inner join Users u ON a.ID=u.ID WHERE a.ID='"+1+"'", con);
            int getID = Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value);

            SqlCommand cmd = new SqlCommand("Select * from Schedule a WHERE a.ID='" + getID + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scheduleID.Text = dr.GetValue(0).ToString();
                apartmentIds.Text = dr.GetValue(1).ToString();
                eventMessage.Text = dr.GetValue(2).ToString();
                timeForEvent.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }
        private void onClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if(AddDeleteUpdate.SelectedIndex == 1)
            {
                showDataInComboBoxesForApartments();
            }
            else
            {
                idTxtBox.Text = "";
                genderComboBox.Text = "";
                priceNumeric.Value = 0;
                propertyTypeComboBox.Text = "";
                interiorComboBox.Text = "";
                bedroomsComboBox.Text = "";
                roomsComboBox.Text = "";
            }
            if (scheduleComboBox.SelectedIndex == 1)
            {
                showDataInComboBoxesForSchedule();
            }
           
        }

     
        private void deleteApartments_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                int getID = Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value);
                admin deleteApartment = new admin();
                deleteApartment.deleteApartmentsData(getID);
                uploadDataFromDatabaseApartments();
            }
        }

        private void newOne_Click(object sender, EventArgs e)
        {

        }

        private void oldOne_Click(object sender, EventArgs e)
        {

        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginRegister open = new loginRegister();
            open.Visible = true;
        }
        private void deleteComplainMessages(int id)
        {

            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ComplaintMessages WHERE ID = @ID", con);
                
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();


                con.Close();

            
        }
        private void deleteComplaint_Click(object sender, EventArgs e)
        {
            deleteComplainMessages(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value));
            uploadDataFromComplaintMessages();
            MessageBox.Show("You deleted the message");
        }

        private void changeBtns(object sender, EventArgs e)
        {
            scheduleAdd.Visible = false;
                scheduleUpdate.Visible = false;
                scheduleDelete.Visible = false;
            if (scheduleComboBox.SelectedIndex == 0)
                scheduleAdd.Visible = true;
            if (scheduleComboBox.SelectedIndex == 1)
                scheduleUpdate.Visible = true;
            if (scheduleComboBox.SelectedIndex == 2)
                scheduleDelete.Visible = true;

        }

        private void scheduleAdd_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(apartmentIds.Text) || !String.IsNullOrEmpty(eventMessage.Text) || !String.IsNullOrEmpty(timeForEvent.Text))
            {
                admin addSchedule = new admin();
                addSchedule.createScheduleData(Convert.ToInt32(apartmentIds.Text), eventMessage.Text, timeForEvent.Text);
                MessageBox.Show("Created event for apartment: " + apartmentIds.Text);
                uploadDataFromSchedule();
                apartmentIds.Text = "";
                eventMessage.Text = "";
                timeForEvent.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void scheduleUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(apartmentIds.Text) || !String.IsNullOrEmpty(eventMessage.Text) || !String.IsNullOrEmpty(timeForEvent.Text))
            {
                admin addSchedule = new admin();
                addSchedule.updateScheduleData(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value), Convert.ToInt32(apartmentIds.Text), eventMessage.Text, timeForEvent.Text);
                uploadDataFromSchedule();
                MessageBox.Show("You updated apartment: " + apartmentIds.Text);
                apartmentIds.Text = "";
                eventMessage.Text = "";
                timeForEvent.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void scheduleDelete_Click(object sender, EventArgs e)
        {
            
                admin addSchedule = new admin();
                addSchedule.deleteScheduleData(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value));
                uploadDataFromSchedule();
                MessageBox.Show("You delete event for apartment: " + apartmentIds.Text);
                apartmentIds.Text = "";
                eventMessage.Text = "";
                timeForEvent.Text = "";
         
        }
    }
}
