
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
            this.UsersBtn = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Panel();
            this.UserAndApartmentBtn = new System.Windows.Forms.Button();
            this.ApartmentsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.ComplaintBtn = new System.Windows.Forms.Button();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.agreementsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersBtn
            // 
            this.UsersBtn.Location = new System.Drawing.Point(22, 80);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(129, 43);
            this.UsersBtn.TabIndex = 0;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(174, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(1128, 561);
            this.showData.TabIndex = 1;
            // 
            // UserAndApartmentBtn
            // 
            this.UserAndApartmentBtn.Location = new System.Drawing.Point(22, 214);
            this.UserAndApartmentBtn.Name = "UserAndApartmentBtn";
            this.UserAndApartmentBtn.Size = new System.Drawing.Size(129, 65);
            this.UserAndApartmentBtn.TabIndex = 2;
            this.UserAndApartmentBtn.Text = "Users and apartment";
            this.UserAndApartmentBtn.UseVisualStyleBackColor = true;
            this.UserAndApartmentBtn.Click += new System.EventHandler(this.UserAndApartmentBtn_Click);
            // 
            // ApartmentsBtn
            // 
            this.ApartmentsBtn.Location = new System.Drawing.Point(22, 149);
            this.ApartmentsBtn.Name = "ApartmentsBtn";
            this.ApartmentsBtn.Size = new System.Drawing.Size(129, 43);
            this.ApartmentsBtn.TabIndex = 3;
            this.ApartmentsBtn.Text = "Apartments";
            this.ApartmentsBtn.UseVisualStyleBackColor = true;
            this.ApartmentsBtn.Click += new System.EventHandler(this.ApartmentsBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(22, 521);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(129, 42);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ComplaintBtn
            // 
            this.ComplaintBtn.Location = new System.Drawing.Point(22, 302);
            this.ComplaintBtn.Name = "ComplaintBtn";
            this.ComplaintBtn.Size = new System.Drawing.Size(129, 45);
            this.ComplaintBtn.TabIndex = 0;
            this.ComplaintBtn.Text = "Complaints";
            this.ComplaintBtn.UseVisualStyleBackColor = true;
            this.ComplaintBtn.Click += new System.EventHandler(this.ComplaintBtn_Click);
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.Location = new System.Drawing.Point(22, 369);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(129, 45);
            this.ScheduleBtn.TabIndex = 4;
            this.ScheduleBtn.Text = "Schedules";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // agreementsBtn
            // 
            this.agreementsBtn.Location = new System.Drawing.Point(22, 436);
            this.agreementsBtn.Name = "agreementsBtn";
            this.agreementsBtn.Size = new System.Drawing.Size(129, 45);
            this.agreementsBtn.TabIndex = 5;
            this.agreementsBtn.Text = "Agreements";
            this.agreementsBtn.UseVisualStyleBackColor = true;
            this.agreementsBtn.Click += new System.EventHandler(this.AgreementsBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 575);
            this.Controls.Add(this.agreementsBtn);
            this.Controls.Add(this.ScheduleBtn);
            this.Controls.Add(this.ComplaintBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.ApartmentsBtn);
            this.Controls.Add(this.UserAndApartmentBtn);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.UsersBtn);
            this.Name = "AdminForm";
            this.Text = "AdminFormTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Panel showData;
        private System.Windows.Forms.Button UserAndApartmentBtn;
        private System.Windows.Forms.Button ApartmentsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button ComplaintBtn;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button agreementsBtn;
    }
}