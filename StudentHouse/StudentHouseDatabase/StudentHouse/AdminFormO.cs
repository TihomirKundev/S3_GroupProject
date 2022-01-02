using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHouse
{
    public partial class AdminFormO : Form
    {
        public AdminFormO()
        {
            InitializeComponent();
        }
        private void changeNameOrPassword(bool change)
        {
            foreach (Control x in Controls)
                if (Convert.ToString(x.Tag) == "changeBy")
                    x.Visible = change;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            changeNameOrPassword(true);
        }
    }
}
