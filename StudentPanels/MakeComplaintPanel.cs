using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectS07group4.StudentPanels
{
    public partial class MakeComplaintPanel : Form
    {
        private User user;
        public MakeComplaintPanel(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UpdateLabels(object sender, EventArgs e)
        {
            wordCount.Text = "Word count: " + complaintTxtBox.Text.Split(' ').Count().ToString();
            charCount.Text = "Character count: " + complaintTxtBox.Text.Length;
        }
        private void sendComplaint_Click(object sender, EventArgs e)
        {
            if (complaintTxtBox.Text.Split(' ').Count() > 25 && complaintTxtBox.Text.Length < 1000)
            {
                user.SendComplaint(complaintTxtBox.Text);
                MessageBox.Show("We are going to fix the problem", "Message send");
                complaintTxtBox.Text = "";
            }
            else
                MessageBox.Show("A complaint must be more than 25 words and less than 1000 characters!", "Error");
        }

        
    }
}
