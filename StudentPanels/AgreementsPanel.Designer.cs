
namespace ProjectS07group4.StudentPanels
{
    partial class AgreementsPanel
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
            this.tableInfo = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.tableInfo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.startAndEndAgreement);
            this.panel1.Controls.Add(this.sendAgreement);
            this.panel1.Controls.Add(this.agreementTxtBox);
            this.panel1.Controls.Add(this.agreementForUser);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.iApproveBtn);
            this.panel1.Controls.Add(this.agrForUserBtn);
            this.panel1.Controls.Add(this.iDontApproveBtn);
            this.panel1.Controls.Add(this.agrUserMadeBtn);
            this.panel1.Controls.Add(this.createAgrBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 609);
            this.panel1.TabIndex = 0;
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.AllowUserToResizeColumns = false;
            this.tableInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Location = new System.Drawing.Point(3, 3);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.ReadOnly = true;
            this.tableInfo.RowHeadersWidth = 62;
            this.tableInfo.RowTemplate.Height = 28;
            this.tableInfo.Size = new System.Drawing.Size(879, 293);
            this.tableInfo.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 53;
            this.label10.Tag = "createAgr";
            this.label10.Text = "Start and end date";
            this.label10.Visible = false;
            // 
            // startAndEndAgreement
            // 
            this.startAndEndAgreement.Location = new System.Drawing.Point(524, 341);
            this.startAndEndAgreement.Name = "startAndEndAgreement";
            this.startAndEndAgreement.ScrollChange = 1;
            this.startAndEndAgreement.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 12, 6, 0, 0, 0, 0), new System.DateTime(2021, 12, 7, 0, 0, 0, 0));
            this.startAndEndAgreement.TabIndex = 50;
            this.startAndEndAgreement.Tag = "createAgr";
            this.startAndEndAgreement.Visible = false;
            // 
            // sendAgreement
            // 
            this.sendAgreement.Location = new System.Drawing.Point(320, 521);
            this.sendAgreement.Name = "sendAgreement";
            this.sendAgreement.Size = new System.Drawing.Size(140, 64);
            this.sendAgreement.TabIndex = 55;
            this.sendAgreement.Tag = "createAgr";
            this.sendAgreement.Text = "Send the agreement";
            this.sendAgreement.UseVisualStyleBackColor = true;
            this.sendAgreement.Visible = false;
            this.sendAgreement.Click += new System.EventHandler(this.sendAgreement_Click);
            // 
            // agreementTxtBox
            // 
            this.agreementTxtBox.Location = new System.Drawing.Point(248, 405);
            this.agreementTxtBox.MaxLength = 299;
            this.agreementTxtBox.Multiline = true;
            this.agreementTxtBox.Name = "agreementTxtBox";
            this.agreementTxtBox.Size = new System.Drawing.Size(252, 101);
            this.agreementTxtBox.TabIndex = 46;
            this.agreementTxtBox.Tag = "createAgr";
            this.agreementTxtBox.Visible = false;
            // 
            // agreementForUser
            // 
            this.agreementForUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agreementForUser.FormattingEnabled = true;
            this.agreementForUser.Location = new System.Drawing.Point(307, 341);
            this.agreementForUser.Name = "agreementForUser";
            this.agreementForUser.Size = new System.Drawing.Size(126, 28);
            this.agreementForUser.TabIndex = 44;
            this.agreementForUser.Tag = "createAgr";
            this.agreementForUser.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 47;
            this.label11.Tag = "createAgr";
            this.label11.Text = "Agreement ";
            this.label11.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 45;
            this.label9.Tag = "createAgr";
            this.label9.Text = "Agreement for";
            this.label9.Visible = false;
            // 
            // iApproveBtn
            // 
            this.iApproveBtn.Location = new System.Drawing.Point(248, 327);
            this.iApproveBtn.Name = "iApproveBtn";
            this.iApproveBtn.Size = new System.Drawing.Size(165, 36);
            this.iApproveBtn.TabIndex = 48;
            this.iApproveBtn.Text = "I approve";
            this.iApproveBtn.UseVisualStyleBackColor = true;
            this.iApproveBtn.Visible = false;
            this.iApproveBtn.Click += new System.EventHandler(this.iApproveBtn_Click);
            // 
            // agrForUserBtn
            // 
            this.agrForUserBtn.Location = new System.Drawing.Point(13, 434);
            this.agrForUserBtn.Name = "agrForUserBtn";
            this.agrForUserBtn.Size = new System.Drawing.Size(184, 45);
            this.agrForUserBtn.TabIndex = 54;
            this.agrForUserBtn.Text = "Agreements for me";
            this.agrForUserBtn.UseVisualStyleBackColor = true;
            this.agrForUserBtn.Click += new System.EventHandler(this.agrForUserBtn_Click);
            // 
            // iDontApproveBtn
            // 
            this.iDontApproveBtn.Location = new System.Drawing.Point(439, 327);
            this.iDontApproveBtn.Name = "iDontApproveBtn";
            this.iDontApproveBtn.Size = new System.Drawing.Size(165, 36);
            this.iDontApproveBtn.TabIndex = 51;
            this.iDontApproveBtn.Text = "I dont approve";
            this.iDontApproveBtn.UseVisualStyleBackColor = true;
            this.iDontApproveBtn.Visible = false;
            this.iDontApproveBtn.Click += new System.EventHandler(this.iDontApproveBtn_Click);
            // 
            // agrUserMadeBtn
            // 
            this.agrUserMadeBtn.Location = new System.Drawing.Point(13, 378);
            this.agrUserMadeBtn.Name = "agrUserMadeBtn";
            this.agrUserMadeBtn.Size = new System.Drawing.Size(184, 45);
            this.agrUserMadeBtn.TabIndex = 52;
            this.agrUserMadeBtn.Text = "Agreement that i made";
            this.agrUserMadeBtn.UseVisualStyleBackColor = true;
            this.agrUserMadeBtn.Click += new System.EventHandler(this.agrUserMadeBtn_Click);
            // 
            // createAgrBtn
            // 
            this.createAgrBtn.Location = new System.Drawing.Point(13, 318);
            this.createAgrBtn.Name = "createAgrBtn";
            this.createAgrBtn.Size = new System.Drawing.Size(184, 45);
            this.createAgrBtn.TabIndex = 49;
            this.createAgrBtn.Text = "Create agreement";
            this.createAgrBtn.UseVisualStyleBackColor = true;
            this.createAgrBtn.Click += new System.EventHandler(this.createAgrBtn_Click);
            // 
            // AgreementsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(896, 603);
            this.Controls.Add(this.panel1);
            this.Name = "AgreementsPanel";
            this.Text = "AgreementsPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar startAndEndAgreement;
        private System.Windows.Forms.Button sendAgreement;
        private System.Windows.Forms.TextBox agreementTxtBox;
        private System.Windows.Forms.ComboBox agreementForUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button iApproveBtn;
        private System.Windows.Forms.Button agrForUserBtn;
        private System.Windows.Forms.Button iDontApproveBtn;
        private System.Windows.Forms.Button agrUserMadeBtn;
        private System.Windows.Forms.Button createAgrBtn;
        private System.Windows.Forms.DataGridView tableInfo;
    }
}