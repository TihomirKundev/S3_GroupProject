using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ProjectS07group4.AdminManager;
namespace ProjectS07group4.FormPanels
{
    public partial class SchedulesPanel : Form
    {
        StudentAuthority studentAuthority;
        AdminApartment adminApartment;


        public SchedulesPanel(StudentAuthority users)
        {
            InitializeComponent();
            this.studentAuthority = users;
            adminApartment = new AdminApartment();
            tableInfo.DataSource = studentAuthority.UsersSchedule();
            AddApartmentIds();
            
        }
        private int GetIndex()
        {
            int rc = -1;
            if (this.Visible == true)
                rc = tableInfo.CurrentCell.RowIndex;
            return rc;
        }
        private void UpdateScheduleInfo()
        {
            apartmentIDCB.Items.Clear();
            UserIDCB.Items.Clear();
            List<String> copy = studentAuthority.ScheduleDataInfo(Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[0].Value));
            ScheduleID.Text = copy[0];
            apartmentIDCB.Items.Add(tableInfo.CurrentRow.Cells[1].Value.ToString());
            apartmentIDCB.Text = tableInfo.CurrentRow.Cells[1].Value.ToString();
            UserIDCB.Items.Add(tableInfo.CurrentRow.Cells[2].Value.ToString());

            UserIDCB.Text = tableInfo.CurrentRow.Cells[2].Value.ToString();
            DayCB.Text = copy[3];
            Job.Text = copy[4];
        }
        private void AddApartmentIds()
        {
            /* ------------------------------------------- NZ-------------------*/
            apartmentIDCB.Items.Clear();
            foreach (Apartment x in adminApartment.AllApartments)
                apartmentIDCB.Items.Add(x.ID);
        }
        private void createScheduleBtn_Click(object sender, EventArgs e)
        {
            updateSchedule.Visible = false;
            apartmentIDCB.Enabled = true;
            UserIDCB.Enabled = true;
            addScheduleBtn.Visible = true;

        }

        private void AddUserIds(object sender, EventArgs e)
        {
            UserIDCB.Items.Clear();
            foreach (Users x in studentAuthority.AllUsersData)
                if (x.UserApartmentID.ToString() == apartmentIDCB.Text)
                    UserIDCB.Items.Add(x.ID);
            if (UserIDCB.Items.Count == 0)
                UserIDCB.Items.Add("Empty apartment");
        }

        private void updateScheduleBtn_Click(object sender, EventArgs e)
        {
            UpdateScheduleInfo();
            addScheduleBtn.Visible = false;
            apartmentIDCB.Enabled = false;
            UserIDCB.Enabled = false;
            updateSchedule.Visible = true;
        }

        private void addScheduleBtn_Click(object sender, EventArgs e)
        {
            
                if (!String.IsNullOrEmpty(apartmentIDCB.Text) && !String.IsNullOrEmpty(UserIDCB.Text) && !String.IsNullOrEmpty(DayCB.Text))
                if (!String.IsNullOrEmpty(Job.Text) && UserIDCB.Text != "Empty apartment")
                {
                    int apartmentID = Convert.ToInt32(apartmentIDCB.Text), userID = Convert.ToInt32(UserIDCB.Text);
                    string day = DayCB.Text, job = Job.Text;
                    studentAuthority.CreateNewSchedule(apartmentID, userID, day, job);
                    MessageBox.Show("Created event for apartment: " + apartmentIDCB.Text);
                    tableInfo.DataSource = null;
                    tableInfo.DataSource = studentAuthority.UsersSchedule();
                    tableInfo.Sort(tableInfo.Columns["ID"], ListSortDirection.Ascending);
                    apartmentIDCB.Text = ""; UserIDCB.Text = ""; DayCB.Text = ""; Job.Text = "";
                }
                else
                    MessageBox.Show("Apartment is empty", "Error");
                else
                    MessageBox.Show("Please fill all fields");
        }
        private void updateSchedule_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(apartmentIDCB.Text) && !String.IsNullOrEmpty(UserIDCB.Text) && !String.IsNullOrEmpty(DayCB.Text) &&
           !String.IsNullOrEmpty(Job.Text))
            {
                int id = Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[0].Value),
                    apartmentID = Convert.ToInt32(apartmentIDCB.Text),
                    userID = Convert.ToInt32(UserIDCB.Text);
                string day = DayCB.Text, job = Job.Text;
                studentAuthority.UpdateScheduleData(id, apartmentID, userID, day, job);
                tableInfo.DataSource = null;
                tableInfo.DataSource = studentAuthority.UsersSchedule();
                MessageBox.Show("Updated event for apartment: " + apartmentIDCB.Text);
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void deleteScheduleBtn_Click(object sender, EventArgs e)
        {
            if (tableInfo.Rows.Count > 0)
            {
                studentAuthority.DeleteScheduleData(Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[0].Value));
                tableInfo.DataSource = null;
                tableInfo.DataSource = studentAuthority.UsersSchedule();
                MessageBox.Show($"You successfully deleted this schedule");
            }
            else
                MessageBox.Show("There is no data");
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (updateSchedule.Visible == true)
                UpdateScheduleInfo();

        }

        private void ScheduleForUserInfo(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Users x in studentAuthority.AllUsersData)
            {
                if (x.ID == Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[2].Value))
                {
                    MessageBox.Show($"ID:{x.ID}, Username: {x.UserEmail}, ApartmentID: {x.UserApartmentID}", $"Day: {tableInfo.Rows[GetIndex()].Cells[3].Value}, Job: {tableInfo.Rows[GetIndex()].Cells[3].Value}");
                    break;
                }
            }
        }
    }
}
