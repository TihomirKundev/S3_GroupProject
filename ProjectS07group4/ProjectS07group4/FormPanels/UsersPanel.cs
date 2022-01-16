using System;
using System.Windows.Forms;
using ProjectS07group4.AdminManager;
namespace ProjectS07group4.FormPanels
{
    public partial class UsersPanel : Form
    {
        private StudentAuthority studentAuthority;
        private AdminApartment adminApartment;

        public UsersPanel(StudentAuthority users)
        {
            InitializeComponent();
            this.studentAuthority = users;
            tableInfo.DataSource = this.studentAuthority.AllUsersData;
            adminApartment = new AdminApartment();
            CreateUserAddAvailableApartment();
            tableInfo.AllowUserToAddRows = false;
            tableInfo.AllowUserToDeleteRows = false;
            tableInfo.AllowUserToResizeColumns = false;
            tableInfo.AllowUserToOrderColumns = false;

        }
        private int GetIndex()
        {
            int rc = -1;
            if (this.Visible == true)
                rc = tableInfo.CurrentCell.RowIndex;
            return rc;
        }
        #region Users
        private void CreateUserAddAvailableApartment()
        {
            userAddApartment.DataSource = null;
            userAddApartment.DataSource = adminApartment.AddApartmentIDstoComboBox(studentAuthority.AllUsersData);
            availableApartments.DataSource = userAddApartment.DataSource;
        }
        private void CreateUserDataBtn_Click(object sender, EventArgs e)
        {
            createUserBtn.Visible = true;
            updateUserBtn.Visible = false;
        }
        private void UpdateUserDataBtn_Click(object sender, EventArgs e)
        {
            createUserBtn.Visible = false;
            updateUserBtn.Visible = true;
        }
        private void AdminSettings_Tick(object sender, EventArgs e)
        {
            if (tableInfo.Rows.Count > 0 && updateUserBtn.Visible == true)
            {
                if (changeUserName.Checked == true)
                {
                    oldData.Text = tableInfo.Rows[GetIndex()].Cells[1].Value.ToString();
                    oldOne.Text = "Old email";
                    newOne.Text = "New email";
                }
                if (changeUserPassword.Checked == true)
                {
                    oldData.Text = tableInfo.Rows[GetIndex()].Cells[2].Value.ToString();
                    oldOne.Text = "Old password";
                    newOne.Text = "New password";
                }
                if (changeUserApartment.Checked == true)
                {
                    newData.Visible = false;
                    availableApartments.Visible = true;
                    oldData.Text = tableInfo.Rows[GetIndex()].Cells[3].Value.ToString();
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
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (!String.IsNullOrEmpty(firstName.Text) && !String.IsNullOrEmpty(secondName.Text) &&
                !String.IsNullOrEmpty(userAddApartment.Text))
            {
                string email = firstName.Text.Substring(0, 1) + "." + secondName.Text + "@studentHousing.mail";
                if (studentAuthority.CheckForDuplicateEmails(email) == false)
                {
                    string password = studentAuthority.GeneratePassword(rnd.Next(7, 12));
                    int apartment = Convert.ToInt32(userAddApartment.Text);
                    studentAuthority.CreateUser(email, password, apartment);
                    tableInfo.DataSource = null;
                    tableInfo.DataSource = studentAuthority.AllUsersData;
                    MessageBox.Show("Succesfully added");
                    CreateUserAddAvailableApartment();
                }
                else
                    MessageBox.Show("This email already exists try changing it.");

            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error some field are empty");
            }

        }
        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentAuthority.AllUsersData[GetIndex()].ID);
            string email = Convert.ToString(studentAuthority.AllUsersData[GetIndex()].UserEmail);
            string password = Convert.ToString(studentAuthority.AllUsersData[GetIndex()].UserPassword);
            int apartment = Convert.ToInt32(studentAuthority.AllUsersData[GetIndex()].UserApartmentID);
            if (!String.IsNullOrEmpty(newData.Text))
            {
                if (changeUserName.Checked)
                {
                    studentAuthority.UpdateUserData(id, newData.Text, password, apartment);
                    MessageBox.Show("Successfully updated");
                }
                if (changeUserPassword.Checked)
                {
                    studentAuthority.UpdateUserData(id, email, newData.Text, apartment);
                    MessageBox.Show("Successfully updated");
                }
                tableInfo.DataSource = null;
                tableInfo.DataSource = studentAuthority.AllUsersData;
            }
            else
                if (!changeUserApartment.Checked)
                MessageBox.Show("Please fill the field for new data correctly", "Error");

            if (changeUserApartment.Checked)
            {
                if (availableApartments.Items.Count.ToString() != "0")
                {
                    studentAuthority.UpdateUserData(id, email, password, Convert.ToInt32(availableApartments.Text));
                    MessageBox.Show("Successfully updated");
                    CreateUserAddAvailableApartment();
                    tableInfo.DataSource = null;
                    tableInfo.DataSource = studentAuthority.AllUsersData;

                }
                else
                    MessageBox.Show("There is no available apartments");
            }
        }
        private void DeleteUserDataBtn_Click(object sender, EventArgs e)
        {
            adminSettings.Stop();
            createUserBtn.Visible = false;
            updateUserBtn.Visible = false;
            if (tableInfo.Rows.Count > 0)
            {
                int id = Convert.ToInt32(Convert.ToInt32(tableInfo.Rows[tableInfo.CurrentRow.Index].Cells[0].Value));
                studentAuthority.DeleteUserData(id);
                tableInfo.DataSource = null;
                tableInfo.DataSource = studentAuthority.AllUsersData;
                CreateUserAddAvailableApartment();

                MessageBox.Show("Successfully deleted");
            }
            else
                MessageBox.Show("There is no data");
            adminSettings.Start();
        }





        #endregion

        private void ShowApartmentInfo2Click(object sender, DataGridViewCellEventArgs e)
        {
            foreach(Apartment x in adminApartment.AllApartments)
            {
                if (x.ID == Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[3].Value))
                {
                    MessageBox.Show($"Address: {x.Address}, Price: {x.Price}, {x.PropertyType}, {x.Interior}, Available rooms: {x.RoomsInApartment-adminApartment.QuantityOfRooms(x, studentAuthority.AllUsersData)}");
                    break;
                }
            }
        }
    }
}
