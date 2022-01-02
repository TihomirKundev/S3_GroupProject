
namespace ProjectS07group4
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersBtn = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Panel();
            this.userAndApartmentBtn = new System.Windows.Forms.Button();
            this.apartmentsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.complaintBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.agreementsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersBtn
            // 
            this.usersBtn.Location = new System.Drawing.Point(22, 80);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(129, 43);
            this.usersBtn.TabIndex = 0;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(174, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(1128, 561);
            this.showData.TabIndex = 1;
            // 
            // userAndApartmentBtn
            // 
            this.userAndApartmentBtn.Location = new System.Drawing.Point(22, 214);
            this.userAndApartmentBtn.Name = "userAndApartmentBtn";
            this.userAndApartmentBtn.Size = new System.Drawing.Size(129, 65);
            this.userAndApartmentBtn.TabIndex = 2;
            this.userAndApartmentBtn.Text = "Users and apartment";
            this.userAndApartmentBtn.UseVisualStyleBackColor = true;
            this.userAndApartmentBtn.Click += new System.EventHandler(this.userAndApartmentBtn_Click);
            // 
            // apartmentsBtn
            // 
            this.apartmentsBtn.Location = new System.Drawing.Point(22, 149);
            this.apartmentsBtn.Name = "apartmentsBtn";
            this.apartmentsBtn.Size = new System.Drawing.Size(129, 43);
            this.apartmentsBtn.TabIndex = 3;
            this.apartmentsBtn.Text = "Apartments";
            this.apartmentsBtn.UseVisualStyleBackColor = true;
            this.apartmentsBtn.Click += new System.EventHandler(this.apartmentsBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(22, 521);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(129, 42);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // complaintBtn
            // 
            this.complaintBtn.Location = new System.Drawing.Point(22, 302);
            this.complaintBtn.Name = "complaintBtn";
            this.complaintBtn.Size = new System.Drawing.Size(129, 45);
            this.complaintBtn.TabIndex = 0;
            this.complaintBtn.Text = "Complaints";
            this.complaintBtn.UseVisualStyleBackColor = true;
            this.complaintBtn.Click += new System.EventHandler(this.complaintBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(22, 369);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(129, 45);
            this.scheduleBtn.TabIndex = 4;
            this.scheduleBtn.Text = "Schedules";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // agreementsBtn
            // 
            this.agreementsBtn.Location = new System.Drawing.Point(22, 436);
            this.agreementsBtn.Name = "agreementsBtn";
            this.agreementsBtn.Size = new System.Drawing.Size(129, 45);
            this.agreementsBtn.TabIndex = 5;
            this.agreementsBtn.Text = "Agreements";
            this.agreementsBtn.UseVisualStyleBackColor = true;
            this.agreementsBtn.Click += new System.EventHandler(this.agreementsBtn_Click);
            // 
            // AdminFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 575);
            this.Controls.Add(this.agreementsBtn);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.complaintBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.apartmentsBtn);
            this.Controls.Add(this.userAndApartmentBtn);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.usersBtn);
            this.Name = "AdminFormTest";
            this.Text = "AdminFormTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Panel showData;
        private System.Windows.Forms.Button userAndApartmentBtn;
        private System.Windows.Forms.Button apartmentsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button complaintBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button agreementsBtn;
    }
}