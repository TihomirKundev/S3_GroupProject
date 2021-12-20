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
    public partial class AdminForm : Form
    {
        private StudentAuthority studentAuthority = new StudentAuthority();
        private AdminApartment adminApartments = new AdminApartment();
        private AdminComplaint adminComplaints = new AdminComplaint();
        private AdminAgreement adminAgreements = new AdminAgreement();
        private AdminSchedule adminSchedule = new AdminSchedule();
        private CheckData checkData = new CheckData();
        public AdminForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = studentAuthority.allUsersData.ToList();

        }
        private void ShowCreateUser(bool change)
        {
            firstName.Visible = change;
            secondName.Visible = change;
            fnLabel.Visible = change;
            snLabel.Visible = change;
            createUserBtn.Visible = change;
            userAddApartment.Visible = change;
            apLabel.Visible = change;
        }
        private void ShowUpdateUser(bool change)
        {
            oldOne.Visible = change;
            newOne.Visible = change;
            oldData.Visible = change;
            newData.Visible = change;
            updateUserBtn.Visible = change;
        }
        private void ShowUpdateFilters(bool change)
        {
            UptadeUserInfoBy.Visible = change;
            ChangeUpdateLabel.Visible = change;
        }
        private void TurnOffApartmentBtns(bool change)
        {
            //createApartmentBtn.Visible = change;
            //updateApartmentBtn.Visible = change;
        }
        private void TurnOffScheduleBtns(bool change)
        {
            //addScheduleBtn.Visible = change;
            //updateSchedule.Visible = change;
        }
        private void visibleFalse()
        {
            ShowCreateUser(false);
            ShowUpdateUser(false);
            ShowUpdateFilters(false);
            TurnOffApartmentBtns(false);
            TurnOffScheduleBtns(false);
        }
        #region Users
        private void updateUserDataBtn_Click(object sender, EventArgs e)
        {
            availableApartments.DataSource = null;
            availableApartments.DataSource = adminApartments.addApartmentIDstoComboBox();
            comboBoxApartIds();
            if (oldData.Visible == false)
                visibleFalse();
            if (dataGridView1.Rows.Count > 0)
            {
                ShowUpdateUser(true);
                ShowUpdateFilters(true);
            }
            else
                MessageBox.Show("There is no data");
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            Random rnd = new Random();
            if (String.IsNullOrEmpty(userAddApartment.Text) == false)
            {
                if (!String.IsNullOrEmpty(firstName.Text) || !String.IsNullOrEmpty(secondName.Text))
                {
                    if (!int.TryParse(firstName.Text.Substring(0, 1), out check))
                    {
                        
                        string email = firstName.Text.Substring(0, 1) + "." + secondName.Text + "@studentHousing.mail";
                        string password = studentAuthority.GeneratePassword(rnd.Next(7, 12));
                        User createUser = new User(0, email, password, Convert.ToInt32(userAddApartment.Text));
                        studentAuthority.ModifyUsersData("Insert", createUser);
                        dataGridView1.DataSource = studentAuthority.allUsersData.ToList();
                        MessageBox.Show($"You successfully created user with email: {email}");
                        comboBoxApartIds();
                    }
                    else
                        MessageBox.Show("First name cant start with numbers and the max characters for first or last name is 20!");
                }
                else
                    MessageBox.Show("Please fill all fields correctly");
            }
            else
                MessageBox.Show("No available apartments!!");
        }

        private void deleteUserDataBtn_Click(object sender, EventArgs e)
        {
            availableApartments.Visible = false;

            if (dataGridView1.Rows.Count > 0)
            {
                List<User> users = studentAuthority.allUsersData;
                studentAuthority.ModifyUsersData("Delete", (users[dataGridView1.CurrentRow.Index]));
                users.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.DataSource = users.ToList();
                comboBoxApartIds();
                MessageBox.Show("Successfully deleted");
            }
            else
                MessageBox.Show("There is no data");
        }

        private void createUserDataBtn_Click(object sender, EventArgs e)
        {
            availableApartments.Visible = false;
            if (firstName.Visible == false)
                visibleFalse();
            ShowCreateUser(true);
            comboBoxApartIds();


        }

        private void adminSettings_Tick(object sender, EventArgs e)
        {
            if (updateUserBtn.Visible == true)
            {
                if (changeUserName.Checked == true)
                {
                    oldData.Text = dataGridView1.Rows[getIndex()].Cells[1].Value.ToString();
                    oldOne.Text = "Old email";
                    newOne.Text = "New email";
                }
                if (changeUserPassword.Checked == true)
                {
                    oldData.Text = dataGridView1.Rows[getIndex()].Cells[2].Value.ToString();
                    oldOne.Text = "Old password";
                    newOne.Text = "New password";
                }
                if (changeUserApartment.Checked == true)
                {

                    newData.Visible = false;
                    availableApartments.Visible = true;
                    oldData.Text = dataGridView1.Rows[getIndex()].Cells[3].Value.ToString();
                    oldOne.Text = "Old apartment";
                    newOne.Text = "New apartment";
                }
                else
                {
                    newData.Visible = true;
                    availableApartments.Visible = false;
                }


            }
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            int id = Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value);
            string email = Convert.ToString(dataGridView1.Rows[getIndex()].Cells[1].Value);
            string password = Convert.ToString(dataGridView1.Rows[getIndex()].Cells[2].Value);
            int apartment=0;
            if (dataGridView1.Rows[getIndex()].Cells[2].Value != null)
            apartment = Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[3].Value);
            if (availableApartments.Visible == false)
            {
                if (!String.IsNullOrEmpty(newData.Text))
                {
                    string checkName = newData.Text.Substring(0, 1);
                    if (newData.Text.Length < 50)
                    {
                        if (changeUserName.Checked == true)
                        {
                            studentAuthority.ModifyUsersData("Update", new User(id, newData.Text, password, apartment));
                            MessageBox.Show("Successfully updated");
                        }
                        else

                        if (changeUserPassword.Checked == true)
                        {
                            studentAuthority.ModifyUsersData("Update", new User(id, email, newData.Text, apartment));
                            MessageBox.Show("Successfully updated");
                        }

                    }
                    else
                        MessageBox.Show("New email or password has to be less than 50 characters!");
                }
                else
                    MessageBox.Show("Please fill the field for new data correctly", "Error");
            }
            if (changeUserApartment.Checked == true)
            {
                if (availableApartments.Items.Count.ToString() != "0")
                {
             
                    studentAuthority.ModifyUsersData("Update", new User(id, email, password, Convert.ToInt32(availableApartments.Text)));
                    MessageBox.Show("Successfully updated");
                    availableApartments.DataSource = null;
                    availableApartments.DataSource = adminApartments.addApartmentIDstoComboBox();
                }
                else
                    MessageBox.Show("There is no available apartments!", "Error");
            }
            dataGridView1.DataSource = studentAuthority.allUsersData.ToList();



        }



        private void comboBoxApartIds()
        {
            userAddApartment.DataSource = null;
            userAddApartment.DataSource = adminApartments.addApartmentIDstoComboBox();
        }
        #endregion

        #region Apartments
        private void createApartmentBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(addressAp.Text) && priceNumeric.Value != 0 &&
                 !String.IsNullOrEmpty(propertyTypeComboBox.Text) && !String.IsNullOrEmpty(interiorComboBox.Text) &&
                 !String.IsNullOrEmpty(bedroomsComboBox.Text) && !String.IsNullOrEmpty(roomsQuantity.Text))
            {
                string address = addressAp.Text;
                double price = Convert.ToDouble(priceNumeric.Value);
                string propertyType = propertyTypeComboBox.Text;
                string interior = interiorComboBox.Text;
                int bedrooms = Convert.ToInt32(bedroomsComboBox.Text);
                int roomsInApartment = Convert.ToInt32(roomsQuantity.Value);
                comboBoxApartIds();
                Apartment createUser = new Apartment(0,address,price,propertyType,interior,bedrooms,roomsInApartment);
                adminApartments.ModifyApartmentData("Insert", createUser);
                dataGridView1.DataSource = adminApartments.allApartmentsData.ToList();
                dataGridView1.Columns.Remove("Email");
                dataGridView1.Columns.Remove("ApartmentID");
                MessageBox.Show("Succesfully added");
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error some field are empty");
            }
        }

        private void deleteApBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                List<Apartment> apartment= adminApartments.allApartmentsData.ToList();
                adminApartments.ModifyApartmentData("Delete", (apartment[dataGridView1.CurrentRow.Index]));
                apartment.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.DataSource = apartment.ToList();
                comboBoxApartIds();
                dataGridView1.DataSource = adminApartments.allApartmentsData.ToList();
                dataGridView1.Columns.Remove("Email");
                dataGridView1.Columns.Remove("ApartmentID");
                MessageBox.Show($"You successfully deleted this apartment");
            }
            else
                MessageBox.Show("There is no data");
        }

        private void createApBtn_Click(object sender, EventArgs e)
        {
            idTxtBox.Text = "";
            if (createApartmentBtn.Visible == false)
                visibleFalse();
            createApartmentBtn.Visible = true;
            updateApartmentBtn.Visible = false;

        }
        private void areYouSure()
        {
            List<Apartment> apartment = adminApartments.allApartmentsData.ToList();
            int quantityOfRooms = adminApartments.quantityOfRooms(apartment[dataGridView1.CurrentRow.Index]);
            if (Convert.ToInt32(roomsQuantity.Value) >= quantityOfRooms)
            {
                String[] data = { dataGridView1.Rows[getIndex()].Cells[0].Value.ToString(),
                addressAp.Text,
                priceNumeric.Value.ToString(),
                propertyTypeComboBox.Text,
                interiorComboBox.Text,
                bedroomsComboBox.Text,
                roomsQuantity.Value.ToString()};
                adminApartments.ModifyApartmentData("Update", new Apartment(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2]),
                data[3], data[4], Convert.ToInt32(data[5]), Convert.ToInt32(data[6])));
                dataGridView1.DataSource = adminApartments.allApartmentsData;
                dataGridView1.Columns.Remove("Email");
                dataGridView1.Columns.Remove("ApartmentID");
                MessageBox.Show("You successfully updated this apartment");
            }
            else
                MessageBox.Show($"The quantity of rooms should be more than {quantityOfRooms-1}", "Error");
        }
        private void updateApartmentBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (!String.IsNullOrEmpty(addressAp.Text) && priceNumeric.Value != 0 &&
               !String.IsNullOrEmpty(propertyTypeComboBox.Text) && !String.IsNullOrEmpty(interiorComboBox.Text) &&
               !String.IsNullOrEmpty(bedroomsComboBox.Text) && !String.IsNullOrEmpty(roomsQuantity.Text) && int.TryParse(roomsQuantity.Text, out check) == true)
            {
                areYouSure();
                comboBoxApartIds();
            }
            else
                MessageBox.Show("Please fill all fields", "Error some field are empty");
        }

        private void updateApDataBtn_Click(object sender, EventArgs e)
        {
            if (updateApartmentBtn.Visible == false)
                visibleFalse();
            if (dataGridView1.Rows.Count > 0)
            {
                updateApartmentBtn.Visible = true;
                updateApartmentInfo();
            }
            else
                MessageBox.Show("There is no data");
            createApartmentBtn.Visible = false;
            updateApartmentBtn.Visible = true;
        }

        private void deleteComplaint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                List<Complaint> deleteComplaint = adminComplaints.getComplaints;
                adminComplaints.DeleteComplaint(deleteComplaint[dataGridView1.CurrentRow.Index]);
                deleteComplaint.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.DataSource = deleteComplaint.ToList();

                MessageBox.Show("You successfully deleted the complaint");
            }
            else
                MessageBox.Show("Click on complaint to delete");
        }

        private void deleteAgrBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                List<Agreement> deleteAgreement = adminAgreements.getAgreements;
                adminAgreements.deleteAgreement(deleteAgreement[dataGridView1.CurrentRow.Index]);
                deleteAgreement.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.DataSource = deleteAgreement.ToList();
                MessageBox.Show("You successfully deleted the agreement");
            }
            else
                MessageBox.Show("Click on agreement to delete");
        }

        private void addScheduleBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(apartmentIDCB.Text) && !String.IsNullOrEmpty(UserIDCB.Text) && !String.IsNullOrEmpty(DayCB.Text) &&
                !String.IsNullOrEmpty(Job.Text))
            {
                int apartmentID = Convert.ToInt32(apartmentIDCB.Text), userID = Convert.ToInt32(UserIDCB.Text);
                string day = DayCB.Text, job = Job.Text;
                adminSchedule.ModifyUsersData("Insert", new Schedule(0, apartmentID, userID, day, job));
                dataGridView1.DataSource = adminSchedule.getSchedules.ToList();

                MessageBox.Show("Created event for apartment: " + apartmentIDCB.Text);
                apartmentIDCB.Text = "";UserIDCB.Text = "";DayCB.Text = "";Job.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void createScheduleBtn_Click(object sender, EventArgs e)
        {
            visibleFalse();
            updateSchedule.Visible = false;
            apartmentIDCB.Enabled = true;
            UserIDCB.Enabled = true;
            addScheduleBtn.Visible = true;
        }

        private void updateScheduleBtn_Click(object sender, EventArgs e)
        {
            visibleFalse();
            updateScheduleInfo();
            addScheduleBtn.Visible = false;
            apartmentIDCB.Enabled = false;
            UserIDCB.Enabled = false;
            updateSchedule.Visible = true;
        }
        private void updateScheduleInfo()
        {
            List<String> copy = adminSchedule.scheduleDataInfo(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value));
            ScheduleID.Text = copy[0];
            apartmentIDCB.Text = copy[1];
            UserIDCB.Text = copy[2];
            DayCB.Text = copy[3];
            Job.Text = copy[4];
        }

        private void addUserIds(object sender, EventArgs e)
        {
            if (updateSchedule.Visible == false)
            {
                UserIDCB.DataSource = null;
                if (apartmentIDCB.SelectedIndex != -1)
                    UserIDCB.DataSource = checkData.addUserIds(Convert.ToInt32(apartmentIDCB.Text));
            }
        }

        private void updateSchedule_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(apartmentIDCB.Text) && !String.IsNullOrEmpty(UserIDCB.Text) && !String.IsNullOrEmpty(DayCB.Text) &&
              !String.IsNullOrEmpty(Job.Text))
            {
                int id= Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value), 
                    apartmentID = Convert.ToInt32(apartmentIDCB.Text),
                    userID = Convert.ToInt32(UserIDCB.Text);
                string day = DayCB.Text, job = Job.Text;
                adminSchedule.ModifyUsersData("Update", new Schedule(id, apartmentID, userID, day, job));
                dataGridView1.DataSource = adminSchedule.getSchedules.ToList();
                MessageBox.Show("Created event for apartment: " + apartmentIDCB.Text);
                apartmentIDCB.Text = ""; UserIDCB.Text = ""; DayCB.Text = ""; Job.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void deleteScheduleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                int id =Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value);
                List<Schedule> deleteSchedule = adminSchedule.getSchedules;
                adminSchedule.ModifyUsersData("Delete", (deleteSchedule[dataGridView1.CurrentRow.Index]));
                deleteSchedule.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.DataSource = deleteSchedule.ToList();
                MessageBox.Show("You successfully deleted the complaint");
            }
            else
                MessageBox.Show("Click on complaint to delete");
        }

        private void updateApartmentInfo()
        {
            List<String> copy = adminApartments.apartmentDataInfo(Convert.ToInt32(dataGridView1.Rows[getIndex()].Cells[0].Value));
            idTxtBox.Text = copy[0];
            addressAp.Text = copy[1];
            priceNumeric.Value = Decimal.Parse(copy[2]);
            propertyTypeComboBox.Text = copy[3];
            interiorComboBox.Text = copy[4]; ;
            bedroomsComboBox.Text = copy[5];
            roomsQuantity.Text = copy[6];
        }
        #endregion


        private void onClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updateApartmentBtn.Visible == true)
                updateApartmentInfo();
            if (updateSchedule.Visible == true)
                updateScheduleInfo();

        }
       
        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            LoginForm openForm = new LoginForm();
            openForm.Visible = true;
        }
        private int getIndex()
        {
            int rc = dataGridView1.CurrentCell.RowIndex;
            return rc;
        }

        private void changeDataGrid(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (adminInterface.SelectedIndex == 0)
                dataGridView1.DataSource = studentAuthority.allUsersData.ToList();
            if (adminInterface.SelectedIndex == 1)
            {
                dataGridView1.DataSource = adminApartments.allApartmentsData.ToList();
                dataGridView1.Columns.Remove("Email");
                dataGridView1.Columns.Remove("ApartmentID");


            }
            if (adminInterface.SelectedIndex == 2)
                dataGridView1.DataSource = adminApartments.apartmentsAndUser.ToList();
                
            if (adminInterface.SelectedIndex == 3)
                dataGridView1.DataSource = adminComplaints.getComplaints.ToList();
            if (adminInterface.SelectedIndex == 4)
            {
                apartmentIDCB.DataSource = null;
                apartmentIDCB.DataSource = checkData.addApartmentIds();
                dataGridView1.DataSource = adminSchedule.getSchedules.ToList();
            }
            if (adminInterface.SelectedIndex == 5)
                dataGridView1.DataSource = adminAgreements.getAgreements.ToList();
            if (adminInterface.SelectedIndex == 6)
            {
                this.Visible = false;
                LoginForm openForm = new LoginForm();
                openForm.Visible = true;
            }


        }

       
    }
}
