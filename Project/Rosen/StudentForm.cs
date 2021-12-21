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
        private readonly UserSchAprCompl userSchAprCompl = new UserSchAprCompl();
        private readonly StudentAgreement studentAgreements = new StudentAgreement(); //0 is for Agrement that user has created and 1 is agreements for user
        private readonly Apartment userApartment;
        private List<Schedule> schedule;
        private readonly List<int> agreementForUserID = new List<int>();
        private readonly String[] scheduleMessages;
        #region generalFunctions
        public StudentForm()
        {
            InitializeComponent();
            userApartment = userSchAprCompl.UserApartment();
            AddDataToTable(userApartment.Address, userApartment.Price, userApartment.PropertyType, userApartment.Interior);
            StartUpSettings();
            scheduleMessages = new String[7];
        }
        private void StartUpSettings()
        {
            schedule = userSchAprCompl.ScheduleForUser();
            helloUserLabel.Text = $"Hello, {User.UserName}";
        }
        private void AddDataToTable(string address,double price, string propertyType,string interior)
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
        private void AddDataToTable(int fromOrForUser)
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            dt.Columns.Add("ID", typeof(int));
            if (fromOrForUser == 0)
            dt.Columns.Add("ForUser", typeof(string)); 
            else
            dt.Columns.Add("FromUser", typeof(string));
            dt.Columns.Add("Process", typeof(string)); dt.Columns.Add("StartDate", typeof(string)); dt.Columns.Add("EndDate", typeof(string));
            foreach (Agreement x in studentAgreements.AgreementConnectedToUser(fromOrForUser))
            {
                workRow = dt.NewRow();
                workRow[0] = x.ID; workRow[1] = x.CreatedUserID;workRow[2] = x.Process; workRow[3] = x.StartDate; workRow[4] = x.EndDate;
                dt.Rows.Add(workRow);
                tableInfo.DataSource = dt;
            }
        }
        private void ChangeDataGrid(object sender, EventArgs e)
        {
            if (userInterface.SelectedIndex == 0)
                AddDataToTable(userApartment.Address, userApartment.Price, userApartment.PropertyType, userApartment.Interior);
            else if (userInterface.SelectedIndex == 1)
            {
                tableInfo.DataSource = schedule.ToList();
                SetSchedule();
            }
            else
                tableInfo.DataSource = null;
        }
        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            _ = new LoginForm
            {
                Visible = true
            };
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _ = new LoginForm
            {
                Visible = true
            };
        }
        #endregion
        #region Complaint
        private void SendComplaint_Click(object sender, EventArgs e)
        {
            if (complaintTxtBox.Text.Split(' ').Count() > 25 && complaintTxtBox.Text.Length < 1000)
            {
                userSchAprCompl.SendComplaint(new Complaint(0,User.ApartmentID,complaintTxtBox.Text));
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
        private void SetSchedule()
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
        private void Message(string message, string message2)
        {
            if (!String.IsNullOrEmpty(message))
            {
                _ = MessageBox.Show(message, message2, MessageBoxButtons.OK);
            }
            else
            {
                _ = MessageBox.Show("Nothing, just chill", message2, MessageBoxButtons.OK);
            }
        }
        private void MondayBtn_Click(object sender, EventArgs e){ Message(scheduleMessages[0], "For Monday"); }
        private void TuesdayBtn_Click(object sender, EventArgs e){ Message(scheduleMessages[1], "For Tuesday"); }
        private void WednesdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[2], "For Wednesday"); }
        private void ThursdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[3], "For Thursday"); }
        private void FridayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[4], "For Friday"); }
        private void SaturdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[5], "For Saturday"); }
        private void SundayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[6], "For Sunday"); }
        #endregion
        #region AgreementsWithUser
        private void AgrUserMadeBtn_Click(object sender, EventArgs e)
        {
            tableInfo.DataSource = null;
            AddDataToTable(0);
        }
        private void AgrForUserBtn_Click(object sender, EventArgs e)
        {
            tableInfo.DataSource = null;
            AddDataToTable(1);
            ApproveDontApprove(true);
        }
        private void ApproveDontApprove(bool check)
        {
            iDontApproveBtn.Visible = check;
            iApproveBtn.Visible = check;
        }
        private void ChangeBtnsVisiblitity(object sender, EventArgs e)
        {
            ApproveDontApprove(false);
            CreateAgr(false);
        }
        private int GetIndex()
        {
            int rc = tableInfo.CurrentCell.RowIndex;
            return rc;
        }
        private bool CheckDataTableProcess()
        {
            bool check = false;
            if (tableInfo.Rows[GetIndex()].Cells[2].Value.ToString() == "Waiting for respond")
                check = true;
            return check;
        }
        private void IApproveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDataTableProcess() == true)
            {
                studentAgreements.ApproveAgreement(Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[0].Value), "Approved");
                MessageBox.Show($"You successfully approved agreement with: {tableInfo.Rows[GetIndex()].Cells[1].Value.ToString()}");
                AddDataToTable(1);
            }
            else
                MessageBox.Show("The process is already Approved/Not approved you cannot change it!", "Error");
        }
        private void IDontApproveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDataTableProcess() == true)
            {
                studentAgreements.ApproveAgreement(Convert.ToInt32(tableInfo.Rows[GetIndex()].Cells[0].Value), "Not approved");
                MessageBox.Show($"You didnt approve agreement with: {tableInfo.Rows[GetIndex()].Cells[1].Value.ToString()}");
                AddDataToTable(1);
            }
            else
                MessageBox.Show("The process is already Approved/Not approved you cannot change it!", "Error");
        }
        #endregion
        #region CreateAgreement
        private void CreateAgrBtn_Click(object sender, EventArgs e)
        {
            tableInfo.DataSource = null;
            StudentAgrName();
            CreateAgr(true);
        }
        private void CreateAgr(bool change)
        {
            label9.Visible = change;
            agreementForUser.Visible = change;
            label11.Visible = change;
            agreementTxtBox.Visible = change;
            label10.Visible = change;
            startAndEndAgreement.Visible = change;
            sendAgreement.Visible = change;
        }
        private void SendAgreement_Click(object sender, EventArgs e)
        {
            string startDate = startAndEndAgreement.SelectionRange.Start.Year + "-" + startAndEndAgreement.SelectionRange.Start.Month + "-" + startAndEndAgreement.SelectionRange.Start.Day;
            string endDate = startAndEndAgreement.SelectionRange.End.Year + "-" + startAndEndAgreement.SelectionRange.End.Month + "-" + startAndEndAgreement.SelectionRange.End.Day;
            if (!String.IsNullOrEmpty(agreementForUser.Text) && !String.IsNullOrEmpty(agreementTxtBox.Text))
            {
                if (agreementForUser.SelectedIndex != -1 && !String.IsNullOrEmpty(agreementTxtBox.Text))
                    if (startDate != endDate)
                    {
                        MessageBox.Show($"The agreement was send to user - {agreementForUser.Text}");
                        studentAgreements.CreateAgreement(new Agreement(0, "", 0, agreementForUserID[agreementForUser.SelectedIndex].ToString(), agreementTxtBox.Text, "", startDate, endDate));
                    }
                    else
                        MessageBox.Show("The agreement should be at least 1 day:", "Error");
            }
            else
                MessageBox.Show("Please fill all fields!", "Error");
        }
        private void StudentAgrName()
        {
            agreementForUser.Items.Clear();
            foreach (DataRow x in studentAgreements.UsersInTheSameApartment().Rows)
            {
                agreementForUser.Items.Add(x[0].ToString().Substring(0, x[0].ToString().IndexOf("@")));
                agreementForUserID.Add(Convert.ToInt32(x[1]));
            }
        }
        #endregion
    }
}
