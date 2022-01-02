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
        private void changeData(Form panel)
        {
            showData.Controls.Clear();
            panel.TopLevel = false;
            panel.Top = 0;
            this.showData.Controls.Add(panel);
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Show();
        }
        private void homePage(object sender, EventArgs e)
        {
            changeData(new HomePagePanel(user));
        }
        private void makeComplaintBtn_Click(object sender, EventArgs e)
        {
            changeData(new MakeComplaintPanel(user));

        }
        private void myScheduleBtn_Click(object sender, EventArgs e)
        {
            changeData(new SchedulePanel(user));

        }
        private void agreementsBtn_Click(object sender, EventArgs e)
        {
            changeData(new AgreementsPanel(user));
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
