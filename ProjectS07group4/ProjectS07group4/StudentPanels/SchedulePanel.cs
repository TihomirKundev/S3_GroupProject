using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectS07group4.StudentPanels
{
    public partial class SchedulePanel : Form
    {
        private User user;
        private readonly String[] scheduleMessages;

        public SchedulePanel(User user)
        {
            InitializeComponent();
            this.user = user;
            scheduleMessages = new String[7];
            SetSchedule();
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
        private void SetSchedule()
        {
            foreach (Schedule x in user.GetSchedules)
            {
                if (x.Day == "Monday") { MondayBtn.Text = "*"; scheduleMessages[0] += x.Job + " | "; MondayBtn.Font = new Font(MondayBtn.Font.FontFamily, 18); MondayBtn.ForeColor = Color.Red; }
                if (x.Day == "Tuesday") { TuesdayBtn.Text = "*"; scheduleMessages[1] += x.Job + " | "; TuesdayBtn.Font = new Font(TuesdayBtn.Font.FontFamily, 18); TuesdayBtn.ForeColor = Color.Red; }
                if (x.Day == "Wednesday") { WednesdayBtn.Text = "*"; scheduleMessages[2] += x.Job + " | "; WednesdayBtn.Font = new Font(WednesdayBtn.Font.FontFamily, 18); WednesdayBtn.ForeColor = Color.Red; }
                if (x.Day == "Thursday") { ThursdayBtn.Text = "*"; scheduleMessages[3] += x.Job + " | "; ThursdayBtn.Font = new Font(ThursdayBtn.Font.FontFamily, 18); ThursdayBtn.ForeColor = Color.Red; }
                if (x.Day == "Friday") { FridayBtn.Text = "*"; scheduleMessages[4] += x.Job + " | "; FridayBtn.Font = new Font(FridayBtn.Font.FontFamily, 18); FridayBtn.ForeColor = Color.Red; }
                if (x.Day == "Saturday") { SaturdayBtn.Text = "*"; scheduleMessages[5] += x.Job + " | "; SaturdayBtn.Font = new Font(SaturdayBtn.Font.FontFamily, 18); SaturdayBtn.ForeColor = Color.Red; }
                if (x.Day == "Sunday") { SundayBtn.Text = "*"; scheduleMessages[6] += x.Job + " | "; SundayBtn.Font = new Font(SundayBtn.Font.FontFamily, 18); SundayBtn.ForeColor = Color.Red; }
            }
        }
        private void MondayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[0], "For Monday"); }
        private void TuesdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[1], "For Tuesday"); }
        private void WednesdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[2], "For Wednesday"); }
        private void ThursdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[3], "For Thursday"); }
        private void FridayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[4], "For Friday"); }
        private void SaturdayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[5], "For Saturday"); }
        private void SundayBtn_Click(object sender, EventArgs e) { Message(scheduleMessages[6], "For Sunday"); }
    }
}
