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
    public partial class StudentForm : Form
    {
        private userSchAprCompl userSchAprCompl = new userSchAprCompl();
        private StudentAgreement studentAgreements = new StudentAgreement(); //0 is for Agrement that user has created and 1 is agreements for user
        private Apartment userApartment;
        private List<Schedule> schedule;
        private List<Agreement> agreements;
        private List<int> agreementForUserID = new List<int>();
        private String[] scheduleMessages;
        #region generalFunctions
        public StudentForm()
        {
            InitializeComponent();
            userApartment = userSchAprCompl.userApartment();
            addDataToTable(userApartment.Address, userApartment.Price, userApartment.PropertyType, userApartment.Interior);
            startUpSettings();
            scheduleMessages = new String[7];
        }
        private void startUpSettings()
        {
            schedule = userSchAprCompl.scheduleForUser();
            helloUserLabel.Text = $"Hello, {User.userName}";
        }
        private void addDataToTable(string address,double price, string propertyType,string interior)
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            dt.Columns.Add("Address", typeof(string)); dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("PropertyType", typeof(string)); dt.Columns.Add("Interior", typeof(string));
            workRow = dt.NewRow();
            workRow[0] = address; workRow[1] = price;workRow[2] = propertyType; workRow[3] = interior;
            dt.Rows.Add(workRow);
            tableInfo.DataSource = dt;
        }
        private void addDataToTable(int fromOrForUser)
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            dt.Columns.Add("ID", typeof(int));
            if (fromOrForUser == 0)
            dt.Columns.Add("ForUser", typeof(string)); 
            else
            dt.Columns.Add("FromUser", typeof(string));
            dt.Columns.Add("Process", typeof(string)); dt.Columns.Add("StartDate", typeof(string)); dt.Columns.Add("EndDate", typeof(string));
            foreach (Agreement x in studentAgreements.agreementConnectedToUser(fromOrForUser))
            {
                workRow = dt.NewRow();
                workRow[0] = x.ID; workRow[1] = x.CreatedUserID;workRow[2] = x.Process; workRow[3] = x.StartDate; workRow[4] = x.EndDate;
                dt.Rows.Add(workRow);
                tableInfo.DataSource = dt;
            }
            
            
        }

        private void changeDataGrid(object sender, EventArgs e)
        {
            if (userInterface.SelectedIndex == 0)
                addDataToTable(userApartment.Address, userApartment.Price, userApartment.PropertyType, userApartment.Interior);
            else if (userInterface.SelectedIndex == 1)
            {
                tableInfo.DataSource = schedule.ToList();
                setSchedule();
            }
            else
                tableInfo.DataSource = null;
        }
        private void closingForm(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            LoginForm openForm = new LoginForm();
            openForm.Visible = true;
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm openForm = new LoginForm();
            openForm.Visible = true;
        }
        #endregion
        #region Complaint
        private void sendComplaint_Click(object sender, EventArgs e)
        {
            if (complaintTxtBox.Text.Split(' ').Count() > 25 && complaintTxtBox.Text.Length < 1000)
            {
                userSchAprCompl.sendComplaint(new Complaint(0,User.apartmentID,complaintTxtBox.Text));
                MessageBox.Show("We are going to fix the problem", "Message send");
                complaintTxtBox.Text = "";
            }
            else
                MessageBox.Show("A complaint must be more than 25 words and less than 1000 characters!", "Error");
        }
        private void UpdateLabels(object sender, EventArgs e)
        {
            wordCount.Text = "Word count: " + complaintTxtBox.Text.Split(' ').Count().ToString();
            charCount.Text = "Character count: " + complaintTxtBox.Text.Length;
        }
        #endregion
        #region ScheduleForUser
        private void setSchedule()
        {
            foreach (Schedule x in schedule)
            {
                if (x.Day == "Monday"){mondayBtn.Text = "*"; scheduleMessages[0] +=x.Job+ " | "; }
                if (x.Day == "Tuesday") { tuesdayBtn.Text = "*"; scheduleMessages[1] += x.Job + " | "; }
                if (x.Day == "Wednesday") { wednesdayBtn.Text = "*"; scheduleMessages[2] += x.Job + " | "; }
                if (x.Day == "Thursday") { thursdayBtn.Text = "*"; scheduleMessages[3] += x.Job + " | "; }
                if (x.Day == "Friday") { fridayBtn.Text = "*"; scheduleMessages[4] += x.Job + " | "; }
                if (x.Day == "Saturday") { saturdayBtn.Text = "*"; scheduleMessages[5] += x.Job + " | "; }
                if (x.Day == "Sunday") { sundayBtn.Text = "*"; scheduleMessages[6] += x.Job + " | "; }
            }
        }
        private void message(string message, string message2)
        {
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialogResult = MessageBox.Show(message, message2, MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Nothing, just chill", message2, MessageBoxButtons.OK);
            }
        }
        private void mondayBtn_Click(object sender, EventArgs e){ message(scheduleMessages[0], "For Monday"); }
        private void tuesdayBtn_Click(object sender, EventArgs e){ message(scheduleMessages[1], "For Tuesday"); }
        private void wednesdayBtn_Click(object sender, EventArgs e) { message(scheduleMessages[2], "For Wednesday"); }
        private void thursdayBtn_Click(object sender, EventArgs e) { message(scheduleMessages[3], "For Thursday"); }
        private void fridayBtn_Click(object sender, EventArgs e) { message(scheduleMessages[4], "For Friday"); }
        private void saturdayBtn_Click(object sender, EventArgs e) { message(scheduleMessages[5], "For Saturday"); }
        private void sundayBtn_Click(object sender, EventArgs e) { message(scheduleMessages[6], "For Sunday"); }
        #endregion
        #region AgreementsWithUser
        private void agrUserMadeBtn_Click(object sender, EventArgs e)
        {
            tableInfo.DataSource = null;
            addDataToTable(0);
        }
        private void agrForUserBtn_Click(object sender, EventArgs e)
        {
            tableInfo.DataSource = null;
            addDataToTable(1);
            approveDontApprove(true);
        }
        private void approveDontApprove(bool check)
        {
            iDontApproveBtn.Visible = check;
            iApproveBtn.Visible = check;
        }
        private void changeBtnsVisiblitity(object sender, EventArgs e)
        {
            approveDontApprove(false);
            createAgr(false);
        }
        private int getIndex()
        {
            int rc = tableInfo.CurrentCell.RowIndex;
            return rc;
        }
        private bool checkDataTableProcess()
        {
            bool check = false;
            if (tableInfo.Rows[getIndex()].Cells[2].Value.ToString() == "Waiting for respond")
                check = true;
            return check;
        }
        private void iApproveBtn_Click(object sender, EventArgs e)
        {
            if (checkDataTableProcess() == true)
            {
                studentAgreements.approveAgreement(Convert.ToInt32(tableInfo.Rows[getIndex()].Cells[0].Value), "Approved");
                MessageBox.Show($"You successfully approved agreement with: {tableInfo.Rows[getIndex()].Cells[1].Value.ToString()}");
                addDataToTable(1);
            }
            else
                MessageBox.Show("The process is already Approved/Not approved you cannot change it!", "Error");
        }
        private void iDontApproveBtn_Click(object sender, EventArgs e)
        {
            if (checkDataTableProcess() == true)
            {
                studentAgreements.approveAgreement(Convert.ToInt32(tableInfo.Rows[getIndex()].Cells[0].Value), "Not approved");
                MessageBox.Show($"You didnt approve agreement with: {tableInfo.Rows[getIndex()].Cells[1].Value.ToString()}");
                addDataToTable(1);
            }
            else
                MessageBox.Show("The process is already Approved/Not approved you cannot change it!", "Error");
        }
        #endregion
        #region CreateAgreement
        private void createAgrBtn_Click(object sender, EventArgs e)
        {
            tableInfo.DataSource = null;
            studentAgrName();
            createAgr(true);
        }
        private void createAgr(bool change)
        {
            label9.Visible = change;
            agreementForUser.Visible = change;
            label11.Visible = change;
            agreementTxtBox.Visible = change;
            label10.Visible = change;
            startAndEndAgreement.Visible = change;
            sendAgreement.Visible = change;
        }
        private void sendAgreement_Click(object sender, EventArgs e)
        {
            string startDate = startAndEndAgreement.SelectionRange.Start.Year + "-" + startAndEndAgreement.SelectionRange.Start.Month + "-" + startAndEndAgreement.SelectionRange.Start.Day;
            string endDate = startAndEndAgreement.SelectionRange.End.Year + "-" + startAndEndAgreement.SelectionRange.End.Month + "-" + startAndEndAgreement.SelectionRange.End.Day;
            if (!String.IsNullOrEmpty(agreementForUser.Text) && !String.IsNullOrEmpty(agreementTxtBox.Text))
            {
                if (agreementForUser.SelectedIndex != -1 && !String.IsNullOrEmpty(agreementTxtBox.Text))
                    if (startDate != endDate)
                    {
                        MessageBox.Show($"The agreement was send to user - {agreementForUser.Text}");
                        studentAgreements.createAgreement(new Agreement(0, "", 0, agreementForUserID[agreementForUser.SelectedIndex].ToString(), agreementTxtBox.Text, "", startDate, endDate));
                    }
                    else
                        MessageBox.Show("The agreement should be at least 1 day:", "Error");
            }
            else
                MessageBox.Show("Please fill all fields!", "Error");
        }
        private void studentAgrName()
        {
            agreementForUser.Items.Clear();
            foreach (DataRow x in studentAgreements.usersInTheSameApartment().Rows)
            {
                agreementForUser.Items.Add(x[0].ToString().Substring(0, x[0].ToString().IndexOf("@")));
                agreementForUserID.Add(Convert.ToInt32(x[1]));
            }
        }
        #endregion
    }
}
