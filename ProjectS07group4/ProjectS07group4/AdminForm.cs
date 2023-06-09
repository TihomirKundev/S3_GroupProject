﻿using ProjectS07group4.AdminManager;
using ProjectS07group4.FormPanels;
using System;
using System.Windows.Forms;
using System.Drawing;
namespace ProjectS07group4 
{
    public partial class AdminForm : Form 
    {
        private StudentAuthority studentAuthority;
        private AdminApartment adminApartment;
        private DataGridView dataGrid = new DataGridView();
        public AdminForm()
        {
            InitializeComponent();
            studentAuthority = new StudentAuthority();
            adminApartment = new AdminApartment();
        }
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ChangeData(new UsersPanel(studentAuthority));

        }
        private void ApartmentsBtn_Click(object sender, EventArgs e)
        {
            ChangeData(new ApartmentsPanel(studentAuthority));

        }
        private void ChangeData(Form panel)
        {
           
            showData.Controls.Clear();
            panel.TopLevel = false;
            panel.Top = 0;
            this.showData.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Show();
            
        }
        private void UserAndApartmentBtn_Click(object sender, EventArgs e)
        {
            showData.Controls.Clear();
            int basex = showData.Location.X;
            int basey = showData.Location.Y;
            DataGridView usersAndApartment = new DataGridView();
            usersAndApartment.RowHeadersVisible = false;
            usersAndApartment.Left = basex - 100;
            usersAndApartment.Top = basey;
            usersAndApartment.Width = 700;
            usersAndApartment.Height = 300;
            usersAndApartment.AllowUserToAddRows = false;
            usersAndApartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            usersAndApartment.Name = String.Format("showUserAndApartment", 1);
            usersAndApartment.DataSource = studentAuthority.UsersWithApartment();
            usersAndApartment.ScrollBars = ScrollBars.Both;
            showData.Controls.Add(usersAndApartment);
        }


        private void ComplaintBtn_Click(object sender, EventArgs e)
        {
            showData.Controls.Clear();
            int basex = showData.Location.X;
            int basey = showData.Location.Y;
            DataGridView complaint = new DataGridView();
            complaint.RowHeadersVisible = false;
            complaint.Left = basex - 100;
            complaint.Top = basey;
            complaint.Width = 700;
            complaint.Height = 300;
            complaint.AllowUserToAddRows = false;
            complaint.AllowUserToDeleteRows = false;
            complaint.AllowUserToResizeColumns = false;
            complaint.AllowUserToOrderColumns = false;
            complaint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            complaint.Name = String.Format("showUserAndApartment", 1);
            complaint.DataSource = adminApartment.GetAllComplaints();
            complaint.ScrollBars = ScrollBars.Both;
            dataGrid = complaint;
            showData.Controls.Add(complaint);

            Button btn = new Button();
            btn.Width = 100;
            btn.Text = "Delete Complaint";
            btn.Name = String.Format("deleteComplaint");
            btn.Top = complaint.Bottom + 20;
            btn.Left = this.showData.Width / 2 - 30;
            btn.BringToFront();
            btn.Click += new EventHandler(DeleteComplaint_Click);
            showData.Controls.Add(btn);
        }
        private void DeleteComplaint_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 0)
            {
                adminApartment.DeleteComplaint(adminApartment.GetComplaint(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value)));
                MessageBox.Show("Successfully deleted");
                ComplaintBtn.PerformClick();
            }
            else
                MessageBox.Show("There is no more complaints", "No more data");
        }
        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            ChangeData(new SchedulesPanel(studentAuthority));
        }
        private void AgreementsBtn_Click(object sender, EventArgs e)
        {
            showData.Controls.Clear();
            int basex = showData.Location.X;
            int basey = showData.Location.Y;
            DataGridView agreementsGrid = new DataGridView();
            agreementsGrid.Left = basex - 100;
            agreementsGrid.Top = basey;
            agreementsGrid.Width = 700;
            agreementsGrid.Height = 300;
            agreementsGrid.Name = String.Format("agreementsGrid", 1);
            agreementsGrid.DataSource = studentAuthority.UsersAgreement();

            agreementsGrid.RowHeadersVisible = false;
            agreementsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            agreementsGrid.ScrollBars = ScrollBars.Both;
            agreementsGrid.AllowUserToAddRows = false;
            agreementsGrid.AllowUserToDeleteRows = false;
            agreementsGrid.AllowUserToResizeColumns = false;
            agreementsGrid.AllowUserToOrderColumns = false;
            agreementsGrid.ReadOnly = true;

            dataGrid = agreementsGrid;
            dataGrid.CellDoubleClick += new DataGridViewCellEventHandler(Check_Click);
            dataGrid.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(CheckForExpiredAgreements_Click);
            showData.Controls.Add(agreementsGrid);

            Button btn = new Button();
            btn.Width = 100;
            btn.Text = "Delete Agreement";
            btn.Name = String.Format("deleteAgreement");
            btn.Top = agreementsGrid.Bottom + 20;
            btn.Left = this.showData.Width / 2 - 30;
            btn.BringToFront();
            btn.Click += new EventHandler(DeleteAgreement_Click);
            showData.Controls.Add(btn);

            Button btn2 = new Button();
            btn2.Width = 150;
            btn2.Text = "Delete expired agreements";
            btn2.Name = String.Format("deleteOldAgreements");
            btn2.Top = agreementsGrid.Bottom + 20;
            btn2.Left = showData.Left;
            btn2.BringToFront();
            btn2.Click += new EventHandler(DeleteOldAgreement_Click);
            showData.Controls.Add(btn2);
            ShowExpiredAgreements();

        }
      
        private void ShowExpiredAgreements()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string[] todayDate = dateTime.ToString().Substring(0, dateTime.ToString().IndexOf(" ")).Split('/');
            DateTime todayDateTime = new DateTime(Convert.ToInt32(todayDate[2]), Convert.ToInt32(todayDate[0]), Convert.ToInt32(todayDate[1]));

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                var parsedDate = DateTime.Parse(row.Cells[7].Value.ToString());
                string[] checkDate = parsedDate.ToString().Substring(0, parsedDate.ToString().IndexOf(" ")).Split('/');
                DateTime endDate = new DateTime(Convert.ToInt32(checkDate[2]), Convert.ToInt32(checkDate[0]), Convert.ToInt32(checkDate[1]));
                if (endDate > todayDateTime)
                    row.Cells[7].Style.BackColor = Color.Green;
                else
                    row.Cells[7].Style.BackColor = Color.Red;

            }

        }
        private void CheckForExpiredAgreements_Click(object sender, EventArgs e)
        {
            ShowExpiredAgreements();
        }
        private void DeleteAgreement_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 0)
            {
                studentAuthority.DeleteAgreement(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));
                MessageBox.Show("Successfully deleted");
                agreementsBtn.PerformClick();
            }
            else
                MessageBox.Show("There is no more agreements", "No more data");
        }
        private void DeleteOldAgreement_Click(object sender, EventArgs e)
        {

            if (dataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[7].Style.BackColor == Color.Red)
                    {
                        studentAuthority.DeleteAgreement(Convert.ToInt32(row.Cells[0].Value));
                    }
                }
                MessageBox.Show("Expired agreements successfully deleted");

                agreementsBtn.PerformClick();

            }
            else
                MessageBox.Show("There is no more agreements", "No more data");
        }
        private void Check_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 0)
            {
                int createdUserID = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[1].Value);
                int forUserID = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[3].Value);
                MessageBox.Show(studentAuthority.GetAgreementInfo(createdUserID, forUserID),
               $"Agreement: {dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[4].Value.ToString()}");
            }
        }
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            _ = new LoginForm
            {
                Visible = true
            };

        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
