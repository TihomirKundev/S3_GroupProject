
namespace ProjectS07group4.FormPanels
{
    partial class SchedulesPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateScheduleBtn = new System.Windows.Forms.Button();
            this.Job = new System.Windows.Forms.TextBox();
            this.createScheduleBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteScheduleBtn = new System.Windows.Forms.Button();
            this.UserIDCB = new System.Windows.Forms.ComboBox();
            this.updateSchedule = new System.Windows.Forms.Button();
            this.apartmentIDCB = new System.Windows.Forms.ComboBox();
            this.addScheduleBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ScheduleID = new System.Windows.Forms.TextBox();
            this.ApartmentID = new System.Windows.Forms.Label();
            this.DayCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateScheduleBtn);
            this.panel1.Controls.Add(this.Job);
            this.panel1.Controls.Add(this.createScheduleBtn);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.deleteScheduleBtn);
            this.panel1.Controls.Add(this.UserIDCB);
            this.panel1.Controls.Add(this.updateSchedule);
            this.panel1.Controls.Add(this.apartmentIDCB);
            this.panel1.Controls.Add(this.addScheduleBtn);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.ScheduleID);
            this.panel1.Controls.Add(this.ApartmentID);
            this.panel1.Controls.Add(this.DayCB);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tableInfo);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 472);
            this.panel1.TabIndex = 0;
            // 
            // updateScheduleBtn
            // 
            this.updateScheduleBtn.Location = new System.Drawing.Point(537, 278);
            this.updateScheduleBtn.Name = "updateScheduleBtn";
            this.updateScheduleBtn.Size = new System.Drawing.Size(91, 36);
            this.updateScheduleBtn.TabIndex = 118;
            this.updateScheduleBtn.Text = "Update";
            this.updateScheduleBtn.UseVisualStyleBackColor = true;
            this.updateScheduleBtn.Click += new System.EventHandler(this.UpdateScheduleBtn_Click);
            // 
            // Job
            // 
            this.Job.Location = new System.Drawing.Point(793, 371);
            this.Job.MaxLength = 50;
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(132, 26);
            this.Job.TabIndex = 110;
            this.Job.Tag = "scheduleData";
            // 
            // createScheduleBtn
            // 
            this.createScheduleBtn.Location = new System.Drawing.Point(427, 278);
            this.createScheduleBtn.Name = "createScheduleBtn";
            this.createScheduleBtn.Size = new System.Drawing.Size(91, 36);
            this.createScheduleBtn.TabIndex = 117;
            this.createScheduleBtn.Text = "Create";
            this.createScheduleBtn.UseVisualStyleBackColor = true;
            this.createScheduleBtn.Click += new System.EventHandler(this.CreateScheduleBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(517, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 106;
            this.label14.Tag = "scheduleData";
            this.label14.Text = "UserID";
            // 
            // deleteScheduleBtn
            // 
            this.deleteScheduleBtn.Location = new System.Drawing.Point(648, 278);
            this.deleteScheduleBtn.Name = "deleteScheduleBtn";
            this.deleteScheduleBtn.Size = new System.Drawing.Size(89, 36);
            this.deleteScheduleBtn.TabIndex = 116;
            this.deleteScheduleBtn.Text = "Delete";
            this.deleteScheduleBtn.UseVisualStyleBackColor = true;
            this.deleteScheduleBtn.Click += new System.EventHandler(this.DeleteScheduleBtn_Click);
            // 
            // UserIDCB
            // 
            this.UserIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDCB.FormattingEnabled = true;
            this.UserIDCB.Location = new System.Drawing.Point(493, 370);
            this.UserIDCB.Name = "UserIDCB";
            this.UserIDCB.Size = new System.Drawing.Size(121, 28);
            this.UserIDCB.TabIndex = 107;
            this.UserIDCB.Tag = "scheduleData";
            // 
            // updateSchedule
            // 
            this.updateSchedule.Location = new System.Drawing.Point(570, 423);
            this.updateSchedule.Name = "updateSchedule";
            this.updateSchedule.Size = new System.Drawing.Size(89, 41);
            this.updateSchedule.TabIndex = 115;
            this.updateSchedule.Text = "Update";
            this.updateSchedule.UseVisualStyleBackColor = true;
            this.updateSchedule.Visible = false;
            this.updateSchedule.Click += new System.EventHandler(this.UpdateSchedule_Click);
            // 
            // apartmentIDCB
            // 
            this.apartmentIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartmentIDCB.FormattingEnabled = true;
            this.apartmentIDCB.Location = new System.Drawing.Point(351, 370);
            this.apartmentIDCB.Name = "apartmentIDCB";
            this.apartmentIDCB.Size = new System.Drawing.Size(121, 28);
            this.apartmentIDCB.TabIndex = 105;
            this.apartmentIDCB.Tag = "scheduleData";
            this.apartmentIDCB.TextChanged += new System.EventHandler(this.AddUserIds);
            // 
            // addScheduleBtn
            // 
            this.addScheduleBtn.Location = new System.Drawing.Point(475, 423);
            this.addScheduleBtn.Name = "addScheduleBtn";
            this.addScheduleBtn.Size = new System.Drawing.Size(89, 41);
            this.addScheduleBtn.TabIndex = 114;
            this.addScheduleBtn.Text = "Add";
            this.addScheduleBtn.UseVisualStyleBackColor = true;
            this.addScheduleBtn.Visible = false;
            this.addScheduleBtn.Click += new System.EventHandler(this.AddScheduleBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(663, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 108;
            this.label15.Tag = "scheduleData";
            this.label15.Text = "Day";
            // 
            // ScheduleID
            // 
            this.ScheduleID.Location = new System.Drawing.Point(199, 371);
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.ReadOnly = true;
            this.ScheduleID.Size = new System.Drawing.Size(130, 26);
            this.ScheduleID.TabIndex = 113;
            this.ScheduleID.Tag = "scheduleData";
            // 
            // ApartmentID
            // 
            this.ApartmentID.AutoSize = true;
            this.ApartmentID.Location = new System.Drawing.Point(362, 333);
            this.ApartmentID.Name = "ApartmentID";
            this.ApartmentID.Size = new System.Drawing.Size(101, 20);
            this.ApartmentID.TabIndex = 104;
            this.ApartmentID.Tag = "scheduleData";
            this.ApartmentID.Text = "ApartmentID";
            // 
            // DayCB
            // 
            this.DayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayCB.FormattingEnabled = true;
            this.DayCB.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.DayCB.Location = new System.Drawing.Point(639, 370);
            this.DayCB.Name = "DayCB";
            this.DayCB.Size = new System.Drawing.Size(121, 28);
            this.DayCB.TabIndex = 109;
            this.DayCB.Tag = "scheduleData";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(250, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 112;
            this.label13.Tag = "scheduleData";
            this.label13.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(817, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 111;
            this.label16.Tag = "scheduleData";
            this.label16.Text = "Job";
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.AllowUserToResizeColumns = false;
            this.tableInfo.AllowUserToResizeRows = false;
            this.tableInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Location = new System.Drawing.Point(0, 0);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.ReadOnly = true;
            this.tableInfo.RowHeadersVisible = false;
            this.tableInfo.RowHeadersWidth = 62;
            this.tableInfo.RowTemplate.Height = 28;
            this.tableInfo.Size = new System.Drawing.Size(1129, 264);
            this.tableInfo.TabIndex = 0;
            this.tableInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleForUserInfo);
            this.tableInfo.Click += new System.EventHandler(this.OnClick);
            // 
            // SchedulesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 490);
            this.Controls.Add(this.panel1);
            this.Name = "SchedulesPanel";
            this.Text = "SchedulesPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateScheduleBtn;
        private System.Windows.Forms.TextBox Job;
        private System.Windows.Forms.Button createScheduleBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button deleteScheduleBtn;
        private System.Windows.Forms.ComboBox UserIDCB;
        private System.Windows.Forms.Button updateSchedule;
        private System.Windows.Forms.ComboBox apartmentIDCB;
        private System.Windows.Forms.Button addScheduleBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ScheduleID;
        private System.Windows.Forms.Label ApartmentID;
        private System.Windows.Forms.ComboBox DayCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView tableInfo;
    }
}