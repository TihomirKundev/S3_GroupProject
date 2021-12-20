
namespace Project
{
    partial class StudentForm
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.helloUserLabel = new System.Windows.Forms.Label();
            this.userInterface = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sundayBtn = new System.Windows.Forms.Button();
            this.saturdayBtn = new System.Windows.Forms.Button();
            this.mondayBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tuesdayBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.wednesdayBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.thursdayBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fridayBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sendComplaint = new System.Windows.Forms.Button();
            this.complaintTxtBox = new System.Windows.Forms.TextBox();
            this.charCount = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.startAndEndAgreement = new System.Windows.Forms.MonthCalendar();
            this.sendAgreement = new System.Windows.Forms.Button();
            this.agreementTxtBox = new System.Windows.Forms.TextBox();
            this.agreementForUser = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iApproveBtn = new System.Windows.Forms.Button();
            this.agrForUserBtn = new System.Windows.Forms.Button();
            this.iDontApproveBtn = new System.Windows.Forms.Button();
            this.agrUserMadeBtn = new System.Windows.Forms.Button();
            this.createAgrBtn = new System.Windows.Forms.Button();
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.userInterface.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(867, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(95, 40);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // helloUserLabel
            // 
            this.helloUserLabel.AutoSize = true;
            this.helloUserLabel.Location = new System.Drawing.Point(23, 22);
            this.helloUserLabel.Name = "helloUserLabel";
            this.helloUserLabel.Size = new System.Drawing.Size(51, 20);
            this.helloUserLabel.TabIndex = 6;
            this.helloUserLabel.Text = "label1";
            // 
            // userInterface
            // 
            this.userInterface.Controls.Add(this.tabPage1);
            this.userInterface.Controls.Add(this.tabPage2);
            this.userInterface.Controls.Add(this.tabPage3);
            this.userInterface.Controls.Add(this.tabPage4);
            this.userInterface.Location = new System.Drawing.Point(27, 353);
            this.userInterface.Name = "userInterface";
            this.userInterface.SelectedIndex = 0;
            this.userInterface.Size = new System.Drawing.Size(935, 367);
            this.userInterface.TabIndex = 7;
            this.userInterface.SelectedIndexChanged += new System.EventHandler(this.changeDataGrid);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apartment info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sundayBtn);
            this.tabPage2.Controls.Add(this.saturdayBtn);
            this.tabPage2.Controls.Add(this.mondayBtn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tuesdayBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.wednesdayBtn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.thursdayBtn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.fridayBtn);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sundayBtn
            // 
            this.sundayBtn.Location = new System.Drawing.Point(740, 56);
            this.sundayBtn.Name = "sundayBtn";
            this.sundayBtn.Size = new System.Drawing.Size(103, 88);
            this.sundayBtn.TabIndex = 33;
            this.sundayBtn.Tag = "scheduleForUser";
            this.sundayBtn.Text = "Nothing";
            this.sundayBtn.UseVisualStyleBackColor = true;
            this.sundayBtn.Click += new System.EventHandler(this.sundayBtn_Click);
            // 
            // saturdayBtn
            // 
            this.saturdayBtn.Location = new System.Drawing.Point(631, 56);
            this.saturdayBtn.Name = "saturdayBtn";
            this.saturdayBtn.Size = new System.Drawing.Size(103, 88);
            this.saturdayBtn.TabIndex = 32;
            this.saturdayBtn.Tag = "scheduleForUser";
            this.saturdayBtn.Text = "Nothing";
            this.saturdayBtn.UseVisualStyleBackColor = true;
            this.saturdayBtn.Click += new System.EventHandler(this.saturdayBtn_Click);
            // 
            // mondayBtn
            // 
            this.mondayBtn.Location = new System.Drawing.Point(86, 56);
            this.mondayBtn.Name = "mondayBtn";
            this.mondayBtn.Size = new System.Drawing.Size(103, 88);
            this.mondayBtn.TabIndex = 27;
            this.mondayBtn.Tag = "scheduleForUser";
            this.mondayBtn.Text = "Nothing";
            this.mondayBtn.UseVisualStyleBackColor = true;
            this.mondayBtn.Click += new System.EventHandler(this.mondayBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 38;
            this.label7.Tag = "scheduleForUser";
            this.label7.Text = "Friday";
            // 
            // tuesdayBtn
            // 
            this.tuesdayBtn.Location = new System.Drawing.Point(195, 56);
            this.tuesdayBtn.Name = "tuesdayBtn";
            this.tuesdayBtn.Size = new System.Drawing.Size(103, 88);
            this.tuesdayBtn.TabIndex = 28;
            this.tuesdayBtn.Tag = "scheduleForUser";
            this.tuesdayBtn.Text = "Nothing";
            this.tuesdayBtn.UseVisualStyleBackColor = true;
            this.tuesdayBtn.Click += new System.EventHandler(this.tuesdayBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 37;
            this.label4.Tag = "scheduleForUser";
            this.label4.Text = "Thursday";
            // 
            // wednesdayBtn
            // 
            this.wednesdayBtn.Location = new System.Drawing.Point(304, 56);
            this.wednesdayBtn.Name = "wednesdayBtn";
            this.wednesdayBtn.Size = new System.Drawing.Size(103, 88);
            this.wednesdayBtn.TabIndex = 29;
            this.wednesdayBtn.Tag = "scheduleForUser";
            this.wednesdayBtn.Text = "Nothing";
            this.wednesdayBtn.UseVisualStyleBackColor = true;
            this.wednesdayBtn.Click += new System.EventHandler(this.wednesdayBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 39;
            this.label6.Tag = "scheduleForUser";
            this.label6.Text = "Saturday";
            // 
            // thursdayBtn
            // 
            this.thursdayBtn.Location = new System.Drawing.Point(413, 56);
            this.thursdayBtn.Name = "thursdayBtn";
            this.thursdayBtn.Size = new System.Drawing.Size(103, 88);
            this.thursdayBtn.TabIndex = 30;
            this.thursdayBtn.Tag = "scheduleForUser";
            this.thursdayBtn.Text = "Nothing";
            this.thursdayBtn.UseVisualStyleBackColor = true;
            this.thursdayBtn.Click += new System.EventHandler(this.thursdayBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 36;
            this.label5.Tag = "scheduleForUser";
            this.label5.Text = "Wednesday";
            // 
            // fridayBtn
            // 
            this.fridayBtn.Location = new System.Drawing.Point(522, 56);
            this.fridayBtn.Name = "fridayBtn";
            this.fridayBtn.Size = new System.Drawing.Size(103, 88);
            this.fridayBtn.TabIndex = 31;
            this.fridayBtn.Tag = "scheduleForUser";
            this.fridayBtn.Text = "Nothing";
            this.fridayBtn.UseVisualStyleBackColor = true;
            this.fridayBtn.Click += new System.EventHandler(this.fridayBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 40;
            this.label8.Tag = "scheduleForUser";
            this.label8.Text = "Sunday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 35;
            this.label3.Tag = "scheduleForUser";
            this.label3.Text = "Tuesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 34;
            this.label2.Tag = "scheduleForUser";
            this.label2.Text = "Monday";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sendComplaint);
            this.tabPage3.Controls.Add(this.complaintTxtBox);
            this.tabPage3.Controls.Add(this.charCount);
            this.tabPage3.Controls.Add(this.wordCount);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(927, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Send complaint";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sendComplaint
            // 
            this.sendComplaint.Location = new System.Drawing.Point(372, 220);
            this.sendComplaint.Name = "sendComplaint";
            this.sendComplaint.Size = new System.Drawing.Size(143, 40);
            this.sendComplaint.TabIndex = 14;
            this.sendComplaint.Tag = "complaint";
            this.sendComplaint.Text = "Send Complaint";
            this.sendComplaint.UseVisualStyleBackColor = true;
            this.sendComplaint.Click += new System.EventHandler(this.sendComplaint_Click);
            // 
            // complaintTxtBox
            // 
            this.complaintTxtBox.Location = new System.Drawing.Point(226, 31);
            this.complaintTxtBox.MaxLength = 999;
            this.complaintTxtBox.Multiline = true;
            this.complaintTxtBox.Name = "complaintTxtBox";
            this.complaintTxtBox.Size = new System.Drawing.Size(449, 183);
            this.complaintTxtBox.TabIndex = 13;
            this.complaintTxtBox.Tag = "complaint";
            this.complaintTxtBox.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(545, 8);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(127, 20);
            this.charCount.TabIndex = 16;
            this.charCount.Tag = "complaint";
            this.charCount.Text = "Character count:";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(222, 8);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(95, 20);
            this.wordCount.TabIndex = 15;
            this.wordCount.Tag = "complaint";
            this.wordCount.Text = "Word count:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.startAndEndAgreement);
            this.tabPage4.Controls.Add(this.sendAgreement);
            this.tabPage4.Controls.Add(this.agreementTxtBox);
            this.tabPage4.Controls.Add(this.agreementForUser);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.iApproveBtn);
            this.tabPage4.Controls.Add(this.agrForUserBtn);
            this.tabPage4.Controls.Add(this.iDontApproveBtn);
            this.tabPage4.Controls.Add(this.agrUserMadeBtn);
            this.tabPage4.Controls.Add(this.createAgrBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(927, 334);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Agreements";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 42;
            this.label10.Tag = "createAgr";
            this.label10.Text = "Start and end date";
            // 
            // startAndEndAgreement
            // 
            this.startAndEndAgreement.Location = new System.Drawing.Point(536, 43);
            this.startAndEndAgreement.Name = "startAndEndAgreement";
            this.startAndEndAgreement.ScrollChange = 1;
            this.startAndEndAgreement.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 12, 6, 0, 0, 0, 0), new System.DateTime(2021, 12, 7, 0, 0, 0, 0));
            this.startAndEndAgreement.TabIndex = 41;
            this.startAndEndAgreement.Tag = "createAgr";
            // 
            // sendAgreement
            // 
            this.sendAgreement.Location = new System.Drawing.Point(332, 223);
            this.sendAgreement.Name = "sendAgreement";
            this.sendAgreement.Size = new System.Drawing.Size(140, 64);
            this.sendAgreement.TabIndex = 43;
            this.sendAgreement.Tag = "createAgr";
            this.sendAgreement.Text = "Send the agreement";
            this.sendAgreement.UseVisualStyleBackColor = true;
            this.sendAgreement.Click += new System.EventHandler(this.sendAgreement_Click);
            // 
            // agreementTxtBox
            // 
            this.agreementTxtBox.Location = new System.Drawing.Point(260, 107);
            this.agreementTxtBox.MaxLength = 299;
            this.agreementTxtBox.Multiline = true;
            this.agreementTxtBox.Name = "agreementTxtBox";
            this.agreementTxtBox.Size = new System.Drawing.Size(252, 101);
            this.agreementTxtBox.TabIndex = 39;
            this.agreementTxtBox.Tag = "createAgr";
            // 
            // agreementForUser
            // 
            this.agreementForUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agreementForUser.FormattingEnabled = true;
            this.agreementForUser.Location = new System.Drawing.Point(319, 43);
            this.agreementForUser.Name = "agreementForUser";
            this.agreementForUser.Size = new System.Drawing.Size(126, 28);
            this.agreementForUser.TabIndex = 37;
            this.agreementForUser.Tag = "createAgr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 40;
            this.label11.Tag = "createAgr";
            this.label11.Text = "Agreement ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 38;
            this.label9.Tag = "createAgr";
            this.label9.Text = "Agreement for";
            // 
            // iApproveBtn
            // 
            this.iApproveBtn.Location = new System.Drawing.Point(260, 29);
            this.iApproveBtn.Name = "iApproveBtn";
            this.iApproveBtn.Size = new System.Drawing.Size(165, 36);
            this.iApproveBtn.TabIndex = 40;
            this.iApproveBtn.Text = "I approve";
            this.iApproveBtn.UseVisualStyleBackColor = true;
            this.iApproveBtn.Visible = false;
            this.iApproveBtn.Click += new System.EventHandler(this.iApproveBtn_Click);
            // 
            // agrForUserBtn
            // 
            this.agrForUserBtn.Location = new System.Drawing.Point(25, 136);
            this.agrForUserBtn.Name = "agrForUserBtn";
            this.agrForUserBtn.Size = new System.Drawing.Size(184, 45);
            this.agrForUserBtn.TabIndex = 42;
            this.agrForUserBtn.Text = "Agreements for me";
            this.agrForUserBtn.UseVisualStyleBackColor = true;
            this.agrForUserBtn.Click += new System.EventHandler(this.agrForUserBtn_Click);
            // 
            // iDontApproveBtn
            // 
            this.iDontApproveBtn.Location = new System.Drawing.Point(451, 29);
            this.iDontApproveBtn.Name = "iDontApproveBtn";
            this.iDontApproveBtn.Size = new System.Drawing.Size(165, 36);
            this.iDontApproveBtn.TabIndex = 41;
            this.iDontApproveBtn.Text = "I dont approve";
            this.iDontApproveBtn.UseVisualStyleBackColor = true;
            this.iDontApproveBtn.Visible = false;
            this.iDontApproveBtn.Click += new System.EventHandler(this.iDontApproveBtn_Click);
            // 
            // agrUserMadeBtn
            // 
            this.agrUserMadeBtn.Location = new System.Drawing.Point(25, 80);
            this.agrUserMadeBtn.Name = "agrUserMadeBtn";
            this.agrUserMadeBtn.Size = new System.Drawing.Size(184, 45);
            this.agrUserMadeBtn.TabIndex = 41;
            this.agrUserMadeBtn.Text = "Agreement that i made";
            this.agrUserMadeBtn.UseVisualStyleBackColor = true;
            this.agrUserMadeBtn.Click += new System.EventHandler(this.agrUserMadeBtn_Click);
            // 
            // createAgrBtn
            // 
            this.createAgrBtn.Location = new System.Drawing.Point(25, 20);
            this.createAgrBtn.Name = "createAgrBtn";
            this.createAgrBtn.Size = new System.Drawing.Size(184, 45);
            this.createAgrBtn.TabIndex = 40;
            this.createAgrBtn.Text = "Create agreement";
            this.createAgrBtn.UseVisualStyleBackColor = true;
            this.createAgrBtn.Click += new System.EventHandler(this.createAgrBtn_Click);
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Location = new System.Drawing.Point(31, 54);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.ReadOnly = true;
            this.tableInfo.RowHeadersWidth = 62;
            this.tableInfo.RowTemplate.Height = 28;
            this.tableInfo.Size = new System.Drawing.Size(931, 293);
            this.tableInfo.TabIndex = 8;
            this.tableInfo.DataSourceChanged += new System.EventHandler(this.changeBtnsVisiblitity);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 719);
            this.Controls.Add(this.tableInfo);
            this.Controls.Add(this.userInterface);
            this.Controls.Add(this.helloUserLabel);
            this.Controls.Add(this.logOutBtn);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingForm);
            this.userInterface.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label helloUserLabel;
        private System.Windows.Forms.TabControl userInterface;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView tableInfo;
        private System.Windows.Forms.Button sundayBtn;
        private System.Windows.Forms.Button saturdayBtn;
        private System.Windows.Forms.Button mondayBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tuesdayBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wednesdayBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button thursdayBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fridayBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendComplaint;
        private System.Windows.Forms.TextBox complaintTxtBox;
        private System.Windows.Forms.Label charCount;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Button agrForUserBtn;
        private System.Windows.Forms.Button agrUserMadeBtn;
        private System.Windows.Forms.Button createAgrBtn;
        private System.Windows.Forms.Button iApproveBtn;
        private System.Windows.Forms.Button iDontApproveBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sendAgreement;
        private System.Windows.Forms.ComboBox agreementForUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox agreementTxtBox;
        private System.Windows.Forms.MonthCalendar startAndEndAgreement;
        private System.Windows.Forms.Label label11;
    }
}