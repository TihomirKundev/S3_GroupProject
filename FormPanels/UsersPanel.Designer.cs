
namespace ProjectS07group4.FormPanels
{
    partial class UsersPanel
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.hideUpdateUser = new System.Windows.Forms.Panel();
            this.availableApartments = new System.Windows.Forms.ComboBox();
            this.newData = new System.Windows.Forms.TextBox();
            this.oldData = new System.Windows.Forms.TextBox();
            this.oldOne = new System.Windows.Forms.Label();
            this.newOne = new System.Windows.Forms.Label();
            this.updateUserBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.userAddApartment = new System.Windows.Forms.ComboBox();
            this.fnLabel = new System.Windows.Forms.Label();
            this.apLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.TextBox();
            this.snLabel = new System.Windows.Forms.Label();
            this.ChangeUpdateLabel = new System.Windows.Forms.Label();
            this.UptadeUserInfoBy = new System.Windows.Forms.Panel();
            this.changeUserApartment = new System.Windows.Forms.RadioButton();
            this.changeUserPassword = new System.Windows.Forms.RadioButton();
            this.changeUserName = new System.Windows.Forms.RadioButton();
            this.deleteUserDataBtn = new System.Windows.Forms.Button();
            this.updateUserDataBtn = new System.Windows.Forms.Button();
            this.createUserDataBtn = new System.Windows.Forms.Button();
            this.adminSettings = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.hideUpdateUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UptadeUserInfoBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableInfo);
            this.panel1.Controls.Add(this.hideUpdateUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ChangeUpdateLabel);
            this.panel1.Controls.Add(this.UptadeUserInfoBy);
            this.panel1.Controls.Add(this.deleteUserDataBtn);
            this.panel1.Controls.Add(this.updateUserDataBtn);
            this.panel1.Controls.Add(this.createUserDataBtn);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 490);
            this.panel1.TabIndex = 0;
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
            this.tableInfo.RowHeadersWidth = 62;
            this.tableInfo.RowTemplate.Height = 28;
            this.tableInfo.Size = new System.Drawing.Size(908, 264);
            this.tableInfo.TabIndex = 97;
            // 
            // hideUpdateUser
            // 
            this.hideUpdateUser.Controls.Add(this.availableApartments);
            this.hideUpdateUser.Controls.Add(this.newData);
            this.hideUpdateUser.Controls.Add(this.oldData);
            this.hideUpdateUser.Controls.Add(this.oldOne);
            this.hideUpdateUser.Controls.Add(this.newOne);
            this.hideUpdateUser.Controls.Add(this.updateUserBtn);
            this.hideUpdateUser.Location = new System.Drawing.Point(445, 355);
            this.hideUpdateUser.Name = "hideUpdateUser";
            this.hideUpdateUser.Size = new System.Drawing.Size(432, 132);
            this.hideUpdateUser.TabIndex = 96;
            // 
            // availableApartments
            // 
            this.availableApartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableApartments.FormattingEnabled = true;
            this.availableApartments.Location = new System.Drawing.Point(160, 95);
            this.availableApartments.Name = "availableApartments";
            this.availableApartments.Size = new System.Drawing.Size(140, 28);
            this.availableApartments.TabIndex = 87;
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(160, 97);
            this.newData.MaxLength = 50;
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(140, 26);
            this.newData.TabIndex = 25;
            this.newData.Tag = "changeBy";
            this.newData.Visible = false;
            // 
            // oldData
            // 
            this.oldData.Enabled = false;
            this.oldData.Location = new System.Drawing.Point(160, 52);
            this.oldData.MaxLength = 50;
            this.oldData.Name = "oldData";
            this.oldData.Size = new System.Drawing.Size(140, 26);
            this.oldData.TabIndex = 23;
            this.oldData.Tag = "changeBy";
            // 
            // oldOne
            // 
            this.oldOne.AutoSize = true;
            this.oldOne.Location = new System.Drawing.Point(27, 55);
            this.oldOne.Name = "oldOne";
            this.oldOne.Size = new System.Drawing.Size(51, 20);
            this.oldOne.TabIndex = 24;
            this.oldOne.Tag = "changeBy";
            this.oldOne.Text = "label2";
            // 
            // newOne
            // 
            this.newOne.AutoSize = true;
            this.newOne.Location = new System.Drawing.Point(27, 97);
            this.newOne.Name = "newOne";
            this.newOne.Size = new System.Drawing.Size(51, 20);
            this.newOne.TabIndex = 26;
            this.newOne.Tag = "changeBy";
            this.newOne.Text = "label3";
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.Location = new System.Drawing.Point(309, 65);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Size = new System.Drawing.Size(100, 32);
            this.updateUserBtn.TabIndex = 27;
            this.updateUserBtn.Tag = "changeBy";
            this.updateUserBtn.Text = "Change";
            this.updateUserBtn.UseVisualStyleBackColor = true;
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.createUserBtn);
            this.panel2.Controls.Add(this.userAddApartment);
            this.panel2.Controls.Add(this.fnLabel);
            this.panel2.Controls.Add(this.apLabel);
            this.panel2.Controls.Add(this.firstName);
            this.panel2.Controls.Add(this.secondName);
            this.panel2.Controls.Add(this.snLabel);
            this.panel2.Location = new System.Drawing.Point(32, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 146);
            this.panel2.TabIndex = 93;
            // 
            // createUserBtn
            // 
            this.createUserBtn.Location = new System.Drawing.Point(251, 64);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(100, 32);
            this.createUserBtn.TabIndex = 76;
            this.createUserBtn.Tag = "createUser";
            this.createUserBtn.Text = "Add";
            this.createUserBtn.UseVisualStyleBackColor = true;
            this.createUserBtn.Visible = false;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // userAddApartment
            // 
            this.userAddApartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAddApartment.FormattingEnabled = true;
            this.userAddApartment.Location = new System.Drawing.Point(133, 107);
            this.userAddApartment.Name = "userAddApartment";
            this.userAddApartment.Size = new System.Drawing.Size(100, 28);
            this.userAddApartment.TabIndex = 84;
            this.userAddApartment.Tag = "createUser";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(23, 31);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(84, 20);
            this.fnLabel.TabIndex = 74;
            this.fnLabel.Tag = "createUser";
            this.fnLabel.Text = "First name";
            // 
            // apLabel
            // 
            this.apLabel.AutoSize = true;
            this.apLabel.Location = new System.Drawing.Point(23, 107);
            this.apLabel.Name = "apLabel";
            this.apLabel.Size = new System.Drawing.Size(84, 20);
            this.apLabel.TabIndex = 83;
            this.apLabel.Tag = "createUser";
            this.apLabel.Text = "Apartment";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(133, 25);
            this.firstName.MaxLength = 20;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 26);
            this.firstName.TabIndex = 72;
            this.firstName.Tag = "createUser";
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(133, 67);
            this.secondName.MaxLength = 20;
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(100, 26);
            this.secondName.TabIndex = 73;
            this.secondName.Tag = "createUser";
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.Location = new System.Drawing.Point(23, 70);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(108, 20);
            this.snLabel.TabIndex = 75;
            this.snLabel.Tag = "createUser";
            this.snLabel.Text = "Second name";
            // 
            // ChangeUpdateLabel
            // 
            this.ChangeUpdateLabel.AutoSize = true;
            this.ChangeUpdateLabel.Location = new System.Drawing.Point(575, 291);
            this.ChangeUpdateLabel.Name = "ChangeUpdateLabel";
            this.ChangeUpdateLabel.Size = new System.Drawing.Size(160, 20);
            this.ChangeUpdateLabel.TabIndex = 94;
            this.ChangeUpdateLabel.Tag = "changeBy";
            this.ChangeUpdateLabel.Text = "Change user data by:";
            // 
            // UptadeUserInfoBy
            // 
            this.UptadeUserInfoBy.Controls.Add(this.changeUserApartment);
            this.UptadeUserInfoBy.Controls.Add(this.changeUserPassword);
            this.UptadeUserInfoBy.Controls.Add(this.changeUserName);
            this.UptadeUserInfoBy.Location = new System.Drawing.Point(453, 317);
            this.UptadeUserInfoBy.Name = "UptadeUserInfoBy";
            this.UptadeUserInfoBy.Size = new System.Drawing.Size(424, 32);
            this.UptadeUserInfoBy.TabIndex = 95;
            this.UptadeUserInfoBy.Tag = "changeBy";
            // 
            // changeUserApartment
            // 
            this.changeUserApartment.AutoSize = true;
            this.changeUserApartment.Location = new System.Drawing.Point(286, 5);
            this.changeUserApartment.Name = "changeUserApartment";
            this.changeUserApartment.Size = new System.Drawing.Size(109, 24);
            this.changeUserApartment.TabIndex = 22;
            this.changeUserApartment.Text = "Apartment";
            this.changeUserApartment.UseVisualStyleBackColor = true;
            // 
            // changeUserPassword
            // 
            this.changeUserPassword.AutoSize = true;
            this.changeUserPassword.Location = new System.Drawing.Point(146, 3);
            this.changeUserPassword.Name = "changeUserPassword";
            this.changeUserPassword.Size = new System.Drawing.Size(103, 24);
            this.changeUserPassword.TabIndex = 21;
            this.changeUserPassword.Text = "Password";
            this.changeUserPassword.UseVisualStyleBackColor = true;
            // 
            // changeUserName
            // 
            this.changeUserName.AutoSize = true;
            this.changeUserName.Checked = true;
            this.changeUserName.Location = new System.Drawing.Point(3, 2);
            this.changeUserName.Name = "changeUserName";
            this.changeUserName.Size = new System.Drawing.Size(76, 24);
            this.changeUserName.TabIndex = 20;
            this.changeUserName.TabStop = true;
            this.changeUserName.Text = "Name";
            this.changeUserName.UseVisualStyleBackColor = true;
            // 
            // deleteUserDataBtn
            // 
            this.deleteUserDataBtn.Location = new System.Drawing.Point(252, 291);
            this.deleteUserDataBtn.Name = "deleteUserDataBtn";
            this.deleteUserDataBtn.Size = new System.Drawing.Size(90, 43);
            this.deleteUserDataBtn.TabIndex = 92;
            this.deleteUserDataBtn.Text = "Delete";
            this.deleteUserDataBtn.UseVisualStyleBackColor = true;
            this.deleteUserDataBtn.Click += new System.EventHandler(this.deleteUserDataBtn_Click);
            // 
            // updateUserDataBtn
            // 
            this.updateUserDataBtn.Location = new System.Drawing.Point(143, 291);
            this.updateUserDataBtn.Name = "updateUserDataBtn";
            this.updateUserDataBtn.Size = new System.Drawing.Size(90, 43);
            this.updateUserDataBtn.TabIndex = 91;
            this.updateUserDataBtn.Text = "Update";
            this.updateUserDataBtn.UseVisualStyleBackColor = true;
            this.updateUserDataBtn.Click += new System.EventHandler(this.updateUserDataBtn_Click);
            // 
            // createUserDataBtn
            // 
            this.createUserDataBtn.Location = new System.Drawing.Point(32, 291);
            this.createUserDataBtn.Name = "createUserDataBtn";
            this.createUserDataBtn.Size = new System.Drawing.Size(90, 43);
            this.createUserDataBtn.TabIndex = 90;
            this.createUserDataBtn.Text = "Create";
            this.createUserDataBtn.UseVisualStyleBackColor = true;
            this.createUserDataBtn.Click += new System.EventHandler(this.createUserDataBtn_Click);
            // 
            // adminSettings
            // 
            this.adminSettings.Enabled = true;
            this.adminSettings.Tick += new System.EventHandler(this.AdminSettings_Tick);
            // 
            // UsersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 496);
            this.Controls.Add(this.panel1);
            this.Name = "UsersPanel";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.hideUpdateUser.ResumeLayout(false);
            this.hideUpdateUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.UptadeUserInfoBy.ResumeLayout(false);
            this.UptadeUserInfoBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel hideUpdateUser;
        private System.Windows.Forms.ComboBox availableApartments;
        private System.Windows.Forms.TextBox newData;
        private System.Windows.Forms.TextBox oldData;
        private System.Windows.Forms.Label oldOne;
        private System.Windows.Forms.Label newOne;
        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createUserBtn;
        private System.Windows.Forms.ComboBox userAddApartment;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label apLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.Label snLabel;
        private System.Windows.Forms.Label ChangeUpdateLabel;
        private System.Windows.Forms.Panel UptadeUserInfoBy;
        private System.Windows.Forms.RadioButton changeUserApartment;
        private System.Windows.Forms.RadioButton changeUserPassword;
        private System.Windows.Forms.RadioButton changeUserName;
        private System.Windows.Forms.Button deleteUserDataBtn;
        private System.Windows.Forms.Button updateUserDataBtn;
        private System.Windows.Forms.Button createUserDataBtn;
        private System.Windows.Forms.Timer adminSettings;
        private System.Windows.Forms.DataGridView tableInfo;
    }
}