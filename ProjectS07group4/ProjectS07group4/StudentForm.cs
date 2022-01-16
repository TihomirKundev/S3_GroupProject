using System;
using System.Windows.Forms;
using ProjectS07group4.StudentPanels;
namespace ProjectS07group4
{
    public partial class StudentForm : Form
    {
        private User user;
        public StudentForm(User user)
        {
            InitializeComponent();
            this.user = user;
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
        private void HomePage(object sender, EventArgs e)
        {
            ChangeData(new HomePagePanel(user));
        }
        private void MakeComplaintBtn_Click(object sender, EventArgs e)
        {
            ChangeData(new MakeComplaintPanel(user));

        }
        private void MyScheduleBtn_Click(object sender, EventArgs e)
        {
            ChangeData(new SchedulePanel(user));

        }
        private void AgreementsBtn_Click(object sender, EventArgs e)
        {
            ChangeData(new AgreementsPanel(user));
        }
        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            _ = new LoginForm
            {
                Visible = true
            };
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
