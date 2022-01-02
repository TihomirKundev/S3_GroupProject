using ProjectS07group4.AdminManager;
using ProjectS07group4.FormPanels;
using System;
using System.Windows.Forms;

namespace ProjectS07group4
{
    public partial class AdminForm : Form
    {
        StudentAuthority studentAuthority;
        AdminComplaint adminComplaint;
        private DataGridView dataGrid = new DataGridView();
        public AdminForm()
        {
            InitializeComponent();
            studentAuthority = new StudentAuthority();
            adminComplaint = new AdminComplaint();
        }
        private void changeData(Form panel)
        {
            showData.Controls.Clear();
            panel.TopLevel = false;
            panel.Top = 0;
            this.showData.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Show();
        }
        private void usersBtn_Click(object sender, EventArgs e)
        {
            changeData(new UsersPanel(studentAuthority));
        }
        private void userAndApartmentBtn_Click(object sender, EventArgs e)
        {
            showData.Controls.Clear();
            int basex = showData.Location.X;
            int basey = showData.Location.Y;
            DataGridView usersAndApartment = new DataGridView();
            usersAndApartment.Left = basex - 100;
            usersAndApartment.Top = basey;
            usersAndApartment.Width = 700;
            usersAndApartment.Height = 300;

            usersAndApartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            usersAndApartment.Name = String.Format("showUserAndApartment", 1);
            usersAndApartment.DataSource = studentAuthority.UsersWithApartment();
            usersAndApartment.ScrollBars = ScrollBars.Both;
            showData.Controls.Add(usersAndApartment);
        }
        private void apartmentsBtn_Click(object sender, EventArgs e)
        {
            changeData(new ApartmentsPanel(studentAuthority));
        }
        private void complaintBtn_Click(object sender, EventArgs e)
        {
            showData.Controls.Clear();
            int basex = showData.Location.X;
            int basey = showData.Location.Y;
            DataGridView complaint = new DataGridView();
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
            complaint.DataSource = adminComplaint.AllComplaints;
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
            btn.Click += new EventHandler(deleteComplaint_Click);
            showData.Controls.Add(btn);
        }
        private void deleteComplaint_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 0)
            {
                adminComplaint.DeleteComplaintData(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));
                MessageBox.Show("Successfully deleted");
                complaintBtn.PerformClick();
            }
            else
                MessageBox.Show("There is no more complaints", "No more data");
        }
        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            changeData(new SchedulesPanel(studentAuthority));
        }
        private void agreementsBtn_Click(object sender, EventArgs e)
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

            agreementsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            agreementsGrid.ScrollBars = ScrollBars.Both;
            agreementsGrid.AllowUserToAddRows = false;
            agreementsGrid.AllowUserToDeleteRows = false;
            agreementsGrid.AllowUserToResizeColumns = false;
            agreementsGrid.AllowUserToOrderColumns = false;

            dataGrid = agreementsGrid;
            showData.Controls.Add(agreementsGrid);

            Button btn = new Button();
            btn.Width = 100;
            btn.Text = "Delete Agreement";
            btn.Name = String.Format("deleteAgreement");
            btn.Top = agreementsGrid.Bottom + 20;
            btn.Left = this.showData.Width / 2 - 30;
            btn.BringToFront();
            btn.Click += new EventHandler(deleteAgreement_Click);
            showData.Controls.Add(btn);
        }
        private void deleteAgreement_Click(object sender, EventArgs e)
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
        private void closeForm(object sender, FormClosingEventArgs e)
        {
            _ = new LoginForm
            {
                Visible = true
            };
            
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
