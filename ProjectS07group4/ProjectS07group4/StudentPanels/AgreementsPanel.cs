using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectS07group4.StudentPanels
{
    partial class AgreementsPanel : Form
    {
        private User user;
        public AgreementsPanel(User user)
        {
            InitializeComponent();
            this.user = user;
        }
       
        private void ShowCreateAgreement(bool change)
        {
            label9.Visible = change;
            agreementForUser.Visible = change;
            label11.Visible = change;
            agreementTxtBox.Visible = change;
            label10.Visible = change;
            startAndEndAgreement.Visible = change;
            sendAgreement.Visible = change;
        }
        private void ShowApproveDontApprove(bool check)
        {
            iDontApproveBtn.Visible = check;
            iApproveBtn.Visible = check;
        }
        private void CreateAgrBtn_Click(object sender, EventArgs e)
        {
            ShowApproveDontApprove(false);
            tableInfo.DataSource = null;
            if (agreementForUser.Items.Count == 0)
                foreach (User x in user.UsersInTheSameApartment)
                {
                    agreementForUser.Items.Add(x.UserEmail.Substring(0, x.UserEmail.IndexOf("@")));
                }
            ShowCreateAgreement(true);
        }
        private void ShowAgreementsUserMade()
        {
            tableInfo.DataSource = null;
            tableInfo.DataSource = user.GetAgreementsUserMade.ToList();
            tableInfo.Columns[1].HeaderText = "For user";
            tableInfo.Columns.Remove("ID");
        }
        private void ShowAgreementsForUser()
        {
            tableInfo.DataSource = null;
            tableInfo.DataSource = user.GetAgreementsForUser.ToList();
            tableInfo.Columns[1].HeaderText = "From user";
            tableInfo.Columns.Remove("ID");
         
        }
        private void AgrUserMadeBtn_Click(object sender, EventArgs e)
        {
            ShowApproveDontApprove(false);
            ShowCreateAgreement(false);
            ShowAgreementsUserMade();
        }
        private void AgrForUserBtn_Click(object sender, EventArgs e)
        {
            ShowApproveDontApprove(true);
            ShowCreateAgreement(false);
            ShowAgreementsForUser();
        }
        private void SendAgreement_Click(object sender, EventArgs e)
        {
            string startDate = startAndEndAgreement.SelectionRange.Start.Year + "-" + startAndEndAgreement.SelectionRange.Start.Month + "-" + startAndEndAgreement.SelectionRange.Start.Day;
            string endDate = startAndEndAgreement.SelectionRange.End.Year + "-" + startAndEndAgreement.SelectionRange.End.Month + "-" + startAndEndAgreement.SelectionRange.End.Day;
            if (!String.IsNullOrEmpty(agreementForUser.Text) && !String.IsNullOrEmpty(agreementTxtBox.Text))
            {
                if (startAndEndAgreement.TodayDate.Year <= startAndEndAgreement.SelectionRange.Start.Year &&
                    startAndEndAgreement.TodayDate.Month <= startAndEndAgreement.SelectionRange.Start.Month &&
                    startAndEndAgreement.TodayDate.Day <= startAndEndAgreement.SelectionRange.Start.Day)
                {
                    if (agreementForUser.SelectedIndex != -1 && !String.IsNullOrEmpty(agreementTxtBox.Text))
                        if (startDate != endDate)
                        {
                            MessageBox.Show($"The agreement was send to user - {agreementForUser.Text}");
                            string forUser = user.UsersInTheSameApartment[agreementForUser.SelectedIndex].UserIdentity.ToString();
                            string forUserName = user.UsersInTheSameApartment[agreementForUser.SelectedIndex].UserEmail.Substring(0, user.UsersInTheSameApartment[agreementForUser.SelectedIndex].UserEmail.IndexOf("@"));
                            string agreement = agreementTxtBox.Text;
                            user.SendAgreement(forUser, agreement, startDate, endDate, forUserName);
                        }
                        else
                            MessageBox.Show("The agreement should be at least 1 day:", "Error");
                }
                else
                    MessageBox.Show($"The start date can't be before {startAndEndAgreement.TodayDate.ToString().Substring(0, startAndEndAgreement.TodayDate.ToString().IndexOf(" "))}");
               
            }
            else
                MessageBox.Show("Please fill all fields!", "Error");
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
                int id = user.GetAgreementsForUser[GetIndex()].ID;
                string createdUserID = user.GetAgreementsForUser[GetIndex()].CreatedUserID;
                string agreement = user.GetAgreementsForUser[GetIndex()].AgreementText;
                string startDate = user.GetAgreementsForUser[GetIndex()].StartDate;
                string endDate = user.GetAgreementsForUser[GetIndex()].EndDate;
                
                user.ApproveDontApproveAgreement(new Agreement(id, createdUserID, agreement, "Approved", startDate, endDate));
                tableInfo.DataSource = null;
                tableInfo.DataSource = user.GetAgreementsForUser;
                tableInfo.Columns.Remove("ID");
                MessageBox.Show($"You successfully approved agreement with: {tableInfo.Rows[GetIndex()].Cells[1].Value.ToString()}");
            }
            else
                MessageBox.Show("The process is already Approved/Not approved you cannot change it!", "Error");
        }
        private void IDontApproveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDataTableProcess() == true)
            {
                int id = user.GetAgreementsForUser[GetIndex()].ID;
                string createdUserID = user.GetAgreementsForUser[GetIndex()].CreatedUserID;
                string agreement = user.GetAgreementsForUser[GetIndex()].AgreementText;
                string startDate = user.GetAgreementsForUser[GetIndex()].StartDate;
                string endDate = user.GetAgreementsForUser[GetIndex()].EndDate;
                user.ApproveDontApproveAgreement(new Agreement(id, createdUserID, agreement, "Not Approved", startDate, endDate));
                tableInfo.DataSource = null;
                tableInfo.DataSource = user.GetAgreementsForUser;
                tableInfo.Columns.Remove("ID");
                MessageBox.Show($"You successfully approved agreement with: {tableInfo.Rows[GetIndex()].Cells[1].Value.ToString()}");
            }
            else
                MessageBox.Show("The process is already Approved/Not approved you cannot change it!", "Error");
        }

        
    }
}
