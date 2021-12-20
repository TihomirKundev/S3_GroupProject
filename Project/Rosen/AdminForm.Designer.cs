
namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.adminInterface = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hideUpdateUser = new System.Windows.Forms.Panel();
            this.availableApartments = new System.Windows.Forms.ComboBox();
            this.newData = new System.Windows.Forms.TextBox();
            this.oldData = new System.Windows.Forms.TextBox();
            this.oldOne = new System.Windows.Forms.Label();
            this.newOne = new System.Windows.Forms.Label();
            this.updateUserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomsQuantity = new System.Windows.Forms.NumericUpDown();
            this.updateApartmentBtn = new System.Windows.Forms.Button();
            this.deleteApBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.addressAp = new System.Windows.Forms.TextBox();
            this.propertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.updateApDataBtn = new System.Windows.Forms.Button();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.createApBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.createApartmentBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bedroomsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.interiorComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteComplaint = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.deleteAgrBtn = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminSettings = new System.Windows.Forms.Timer(this.components);
            this.adminInterface.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.hideUpdateUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UptadeUserInfoBy.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminInterface
            // 
            this.adminInterface.Controls.Add(this.tabPage1);
            this.adminInterface.Controls.Add(this.tabPage2);
            this.adminInterface.Controls.Add(this.tabPage3);
            this.adminInterface.Controls.Add(this.tabPage4);
            this.adminInterface.Controls.Add(this.tabPage5);
            this.adminInterface.Controls.Add(this.tabPage6);
            this.adminInterface.Controls.Add(this.tabPage7);
            this.adminInterface.Location = new System.Drawing.Point(12, 329);
            this.adminInterface.Name = "adminInterface";
            this.adminInterface.SelectedIndex = 0;
            this.adminInterface.Size = new System.Drawing.Size(1172, 270);
            this.adminInterface.TabIndex = 0;
            this.adminInterface.SelectedIndexChanged += new System.EventHandler(this.changeDataGrid);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hideUpdateUser);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ChangeUpdateLabel);
            this.tabPage1.Controls.Add(this.UptadeUserInfoBy);
            this.tabPage1.Controls.Add(this.deleteUserDataBtn);
            this.tabPage1.Controls.Add(this.updateUserDataBtn);
            this.tabPage1.Controls.Add(this.createUserDataBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1164, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hideUpdateUser
            // 
            this.hideUpdateUser.Controls.Add(this.availableApartments);
            this.hideUpdateUser.Controls.Add(this.newData);
            this.hideUpdateUser.Controls.Add(this.oldData);
            this.hideUpdateUser.Controls.Add(this.oldOne);
            this.hideUpdateUser.Controls.Add(this.newOne);
            this.hideUpdateUser.Controls.Add(this.updateUserBtn);
            this.hideUpdateUser.Location = new System.Drawing.Point(444, 84);
            this.hideUpdateUser.Name = "hideUpdateUser";
            this.hideUpdateUser.Size = new System.Drawing.Size(432, 132);
            this.hideUpdateUser.TabIndex = 89;
            // 
            // availableApartments
            // 
            this.availableApartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableApartments.FormattingEnabled = true;
            this.availableApartments.Location = new System.Drawing.Point(160, 95);
            this.availableApartments.Name = "availableApartments";
            this.availableApartments.Size = new System.Drawing.Size(140, 28);
            this.availableApartments.TabIndex = 87;
            this.availableApartments.Visible = false;
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
            this.oldData.Visible = false;
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
            this.oldOne.Visible = false;
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
            this.newOne.Visible = false;
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
            this.updateUserBtn.Visible = false;
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createUserBtn);
            this.panel1.Controls.Add(this.userAddApartment);
            this.panel1.Controls.Add(this.fnLabel);
            this.panel1.Controls.Add(this.apLabel);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.secondName);
            this.panel1.Controls.Add(this.snLabel);
            this.panel1.Location = new System.Drawing.Point(31, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 146);
            this.panel1.TabIndex = 86;
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
            this.userAddApartment.Visible = false;
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
            this.fnLabel.Visible = false;
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
            this.apLabel.Visible = false;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(133, 25);
            this.firstName.MaxLength = 20;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 26);
            this.firstName.TabIndex = 72;
            this.firstName.Tag = "createUser";
            this.firstName.Visible = false;
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(133, 67);
            this.secondName.MaxLength = 20;
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(100, 26);
            this.secondName.TabIndex = 73;
            this.secondName.Tag = "createUser";
            this.secondName.Visible = false;
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
            this.snLabel.Visible = false;
            // 
            // ChangeUpdateLabel
            // 
            this.ChangeUpdateLabel.AutoSize = true;
            this.ChangeUpdateLabel.Location = new System.Drawing.Point(574, 20);
            this.ChangeUpdateLabel.Name = "ChangeUpdateLabel";
            this.ChangeUpdateLabel.Size = new System.Drawing.Size(160, 20);
            this.ChangeUpdateLabel.TabIndex = 87;
            this.ChangeUpdateLabel.Tag = "changeBy";
            this.ChangeUpdateLabel.Text = "Change user data by:";
            this.ChangeUpdateLabel.Visible = false;
            // 
            // UptadeUserInfoBy
            // 
            this.UptadeUserInfoBy.Controls.Add(this.changeUserApartment);
            this.UptadeUserInfoBy.Controls.Add(this.changeUserPassword);
            this.UptadeUserInfoBy.Controls.Add(this.changeUserName);
            this.UptadeUserInfoBy.Location = new System.Drawing.Point(452, 46);
            this.UptadeUserInfoBy.Name = "UptadeUserInfoBy";
            this.UptadeUserInfoBy.Size = new System.Drawing.Size(424, 32);
            this.UptadeUserInfoBy.TabIndex = 88;
            this.UptadeUserInfoBy.Tag = "changeBy";
            this.UptadeUserInfoBy.Visible = false;
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
            this.deleteUserDataBtn.Location = new System.Drawing.Point(251, 20);
            this.deleteUserDataBtn.Name = "deleteUserDataBtn";
            this.deleteUserDataBtn.Size = new System.Drawing.Size(90, 43);
            this.deleteUserDataBtn.TabIndex = 84;
            this.deleteUserDataBtn.Text = "Delete";
            this.deleteUserDataBtn.UseVisualStyleBackColor = true;
            this.deleteUserDataBtn.Click += new System.EventHandler(this.deleteUserDataBtn_Click);
            // 
            // updateUserDataBtn
            // 
            this.updateUserDataBtn.Location = new System.Drawing.Point(142, 20);
            this.updateUserDataBtn.Name = "updateUserDataBtn";
            this.updateUserDataBtn.Size = new System.Drawing.Size(90, 43);
            this.updateUserDataBtn.TabIndex = 83;
            this.updateUserDataBtn.Text = "Update";
            this.updateUserDataBtn.UseVisualStyleBackColor = true;
            this.updateUserDataBtn.Click += new System.EventHandler(this.updateUserDataBtn_Click);
            // 
            // createUserDataBtn
            // 
            this.createUserDataBtn.Location = new System.Drawing.Point(31, 20);
            this.createUserDataBtn.Name = "createUserDataBtn";
            this.createUserDataBtn.Size = new System.Drawing.Size(90, 43);
            this.createUserDataBtn.TabIndex = 82;
            this.createUserDataBtn.Text = "Create";
            this.createUserDataBtn.UseVisualStyleBackColor = true;
            this.createUserDataBtn.Click += new System.EventHandler(this.createUserDataBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomsQuantity);
            this.tabPage2.Controls.Add(this.updateApartmentBtn);
            this.tabPage2.Controls.Add(this.deleteApBtn);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.addressAp);
            this.tabPage2.Controls.Add(this.propertyTypeComboBox);
            this.tabPage2.Controls.Add(this.updateApDataBtn);
            this.tabPage2.Controls.Add(this.priceNumeric);
            this.tabPage2.Controls.Add(this.createApBtn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.createApartmentBtn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.idTxtBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.bedroomsComboBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.interiorComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1164, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Apartments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomsQuantity
            // 
            this.roomsQuantity.Location = new System.Drawing.Point(998, 110);
            this.roomsQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.roomsQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsQuantity.Name = "roomsQuantity";
            this.roomsQuantity.Size = new System.Drawing.Size(120, 26);
            this.roomsQuantity.TabIndex = 112;
            this.roomsQuantity.Tag = "apartmentTxtBoxes";
            this.roomsQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updateApartmentBtn
            // 
            this.updateApartmentBtn.Location = new System.Drawing.Point(537, 157);
            this.updateApartmentBtn.Name = "updateApartmentBtn";
            this.updateApartmentBtn.Size = new System.Drawing.Size(96, 42);
            this.updateApartmentBtn.TabIndex = 107;
            this.updateApartmentBtn.Text = "Update";
            this.updateApartmentBtn.UseVisualStyleBackColor = true;
            this.updateApartmentBtn.Visible = false;
            this.updateApartmentBtn.Click += new System.EventHandler(this.updateApartmentBtn_Click);
            // 
            // deleteApBtn
            // 
            this.deleteApBtn.Location = new System.Drawing.Point(643, 22);
            this.deleteApBtn.Name = "deleteApBtn";
            this.deleteApBtn.Size = new System.Drawing.Size(95, 36);
            this.deleteApBtn.TabIndex = 111;
            this.deleteApBtn.Text = "Delete";
            this.deleteApBtn.UseVisualStyleBackColor = true;
            this.deleteApBtn.Click += new System.EventHandler(this.deleteApBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 97;
            this.label10.Tag = "apartmentTxtBoxes";
            this.label10.Text = "Property Type";
            // 
            // addressAp
            // 
            this.addressAp.Location = new System.Drawing.Point(146, 109);
            this.addressAp.MaxLength = 100;
            this.addressAp.Multiline = true;
            this.addressAp.Name = "addressAp";
            this.addressAp.Size = new System.Drawing.Size(262, 97);
            this.addressAp.TabIndex = 110;
            // 
            // propertyTypeComboBox
            // 
            this.propertyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyTypeComboBox.FormattingEnabled = true;
            this.propertyTypeComboBox.Items.AddRange(new object[] {
            "Apartment",
            "Studio",
            "Room",
            "House"});
            this.propertyTypeComboBox.Location = new System.Drawing.Point(553, 110);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.propertyTypeComboBox.TabIndex = 98;
            this.propertyTypeComboBox.Tag = "apartmentTxtBoxes";
            // 
            // updateApDataBtn
            // 
            this.updateApDataBtn.Location = new System.Drawing.Point(533, 22);
            this.updateApDataBtn.Name = "updateApDataBtn";
            this.updateApDataBtn.Size = new System.Drawing.Size(95, 36);
            this.updateApDataBtn.TabIndex = 109;
            this.updateApDataBtn.Text = "Update";
            this.updateApDataBtn.UseVisualStyleBackColor = true;
            this.updateApDataBtn.Click += new System.EventHandler(this.updateApDataBtn_Click);
            // 
            // priceNumeric
            // 
            this.priceNumeric.DecimalPlaces = 1;
            this.priceNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priceNumeric.Location = new System.Drawing.Point(432, 110);
            this.priceNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.ReadOnly = true;
            this.priceNumeric.Size = new System.Drawing.Size(93, 26);
            this.priceNumeric.TabIndex = 96;
            this.priceNumeric.Tag = "apartmentTxtBoxes";
            this.priceNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // createApBtn
            // 
            this.createApBtn.Location = new System.Drawing.Point(421, 22);
            this.createApBtn.Name = "createApBtn";
            this.createApBtn.Size = new System.Drawing.Size(95, 36);
            this.createApBtn.TabIndex = 108;
            this.createApBtn.Text = "Create";
            this.createApBtn.UseVisualStyleBackColor = true;
            this.createApBtn.Click += new System.EventHandler(this.createApBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 99;
            this.label6.Tag = "apartmentTxtBoxes";
            this.label6.Text = "Interior";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 95;
            this.label11.Tag = "apartmentTxtBoxes";
            this.label11.Text = "Price";
            // 
            // createApartmentBtn
            // 
            this.createApartmentBtn.Location = new System.Drawing.Point(435, 157);
            this.createApartmentBtn.Name = "createApartmentBtn";
            this.createApartmentBtn.Size = new System.Drawing.Size(96, 42);
            this.createApartmentBtn.TabIndex = 106;
            this.createApartmentBtn.Text = "Add";
            this.createApartmentBtn.UseVisualStyleBackColor = true;
            this.createApartmentBtn.Click += new System.EventHandler(this.createApartmentBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(881, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 101;
            this.label7.Tag = "apartmentTxtBoxes";
            this.label7.Text = "Bedrooms";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(23, 112);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(100, 26);
            this.idTxtBox.TabIndex = 105;
            this.idTxtBox.Tag = "apartmentTxtBoxes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 94;
            this.label12.Tag = "apartmentTxtBoxes";
            this.label12.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 104;
            this.label9.Tag = "apartmentTxtBoxes";
            this.label9.Text = "ID";
            // 
            // bedroomsComboBox
            // 
            this.bedroomsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedroomsComboBox.FormattingEnabled = true;
            this.bedroomsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.bedroomsComboBox.Location = new System.Drawing.Point(857, 110);
            this.bedroomsComboBox.Name = "bedroomsComboBox";
            this.bedroomsComboBox.Size = new System.Drawing.Size(121, 28);
            this.bedroomsComboBox.TabIndex = 102;
            this.bedroomsComboBox.Tag = "apartmentTxtBoxes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1000, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 103;
            this.label8.Tag = "apartmentTxtBoxes";
            this.label8.Text = "People quantity";
            // 
            // interiorComboBox
            // 
            this.interiorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interiorComboBox.FormattingEnabled = true;
            this.interiorComboBox.Items.AddRange(new object[] {
            "Upholstered",
            "Furnished",
            "Shell"});
            this.interiorComboBox.Location = new System.Drawing.Point(707, 110);
            this.interiorComboBox.Name = "interiorComboBox";
            this.interiorComboBox.Size = new System.Drawing.Size(121, 28);
            this.interiorComboBox.TabIndex = 100;
            this.interiorComboBox.Tag = "apartmentTxtBoxes";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1164, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User & apartments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteComplaint);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1164, 237);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Complaint messages";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteComplaint
            // 
            this.deleteComplaint.Location = new System.Drawing.Point(540, 23);
            this.deleteComplaint.Name = "deleteComplaint";
            this.deleteComplaint.Size = new System.Drawing.Size(146, 43);
            this.deleteComplaint.TabIndex = 2;
            this.deleteComplaint.Text = "Delete complaint";
            this.deleteComplaint.UseVisualStyleBackColor = true;
            this.deleteComplaint.Click += new System.EventHandler(this.deleteComplaint_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.updateScheduleBtn);
            this.tabPage5.Controls.Add(this.Job);
            this.tabPage5.Controls.Add(this.createScheduleBtn);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.deleteScheduleBtn);
            this.tabPage5.Controls.Add(this.UserIDCB);
            this.tabPage5.Controls.Add(this.updateSchedule);
            this.tabPage5.Controls.Add(this.apartmentIDCB);
            this.tabPage5.Controls.Add(this.addScheduleBtn);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.ScheduleID);
            this.tabPage5.Controls.Add(this.ApartmentID);
            this.tabPage5.Controls.Add(this.DayCB);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1164, 237);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Schedule for apartments";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // updateScheduleBtn
            // 
            this.updateScheduleBtn.Location = new System.Drawing.Point(529, 18);
            this.updateScheduleBtn.Name = "updateScheduleBtn";
            this.updateScheduleBtn.Size = new System.Drawing.Size(91, 36);
            this.updateScheduleBtn.TabIndex = 103;
            this.updateScheduleBtn.Text = "Update";
            this.updateScheduleBtn.UseVisualStyleBackColor = true;
            this.updateScheduleBtn.Click += new System.EventHandler(this.updateScheduleBtn_Click);
            // 
            // Job
            // 
            this.Job.Location = new System.Drawing.Point(785, 111);
            this.Job.MaxLength = 50;
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(132, 26);
            this.Job.TabIndex = 95;
            this.Job.Tag = "scheduleData";
            // 
            // createScheduleBtn
            // 
            this.createScheduleBtn.Location = new System.Drawing.Point(419, 18);
            this.createScheduleBtn.Name = "createScheduleBtn";
            this.createScheduleBtn.Size = new System.Drawing.Size(91, 36);
            this.createScheduleBtn.TabIndex = 102;
            this.createScheduleBtn.Text = "Create";
            this.createScheduleBtn.UseVisualStyleBackColor = true;
            this.createScheduleBtn.Click += new System.EventHandler(this.createScheduleBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 91;
            this.label14.Tag = "scheduleData";
            this.label14.Text = "UserID";
            // 
            // deleteScheduleBtn
            // 
            this.deleteScheduleBtn.Location = new System.Drawing.Point(640, 18);
            this.deleteScheduleBtn.Name = "deleteScheduleBtn";
            this.deleteScheduleBtn.Size = new System.Drawing.Size(89, 36);
            this.deleteScheduleBtn.TabIndex = 101;
            this.deleteScheduleBtn.Text = "Delete";
            this.deleteScheduleBtn.UseVisualStyleBackColor = true;
            this.deleteScheduleBtn.Click += new System.EventHandler(this.deleteScheduleBtn_Click);
            // 
            // UserIDCB
            // 
            this.UserIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDCB.FormattingEnabled = true;
            this.UserIDCB.Location = new System.Drawing.Point(485, 110);
            this.UserIDCB.Name = "UserIDCB";
            this.UserIDCB.Size = new System.Drawing.Size(121, 28);
            this.UserIDCB.TabIndex = 92;
            this.UserIDCB.Tag = "scheduleData";
            // 
            // updateSchedule
            // 
            this.updateSchedule.Location = new System.Drawing.Point(562, 163);
            this.updateSchedule.Name = "updateSchedule";
            this.updateSchedule.Size = new System.Drawing.Size(89, 41);
            this.updateSchedule.TabIndex = 100;
            this.updateSchedule.Text = "Update";
            this.updateSchedule.UseVisualStyleBackColor = true;
            this.updateSchedule.Visible = false;
            this.updateSchedule.Click += new System.EventHandler(this.updateSchedule_Click);
            // 
            // apartmentIDCB
            // 
            this.apartmentIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartmentIDCB.FormattingEnabled = true;
            this.apartmentIDCB.Location = new System.Drawing.Point(343, 110);
            this.apartmentIDCB.Name = "apartmentIDCB";
            this.apartmentIDCB.Size = new System.Drawing.Size(121, 28);
            this.apartmentIDCB.TabIndex = 90;
            this.apartmentIDCB.Tag = "scheduleData";
            this.apartmentIDCB.TextChanged += new System.EventHandler(this.addUserIds);
            // 
            // addScheduleBtn
            // 
            this.addScheduleBtn.Location = new System.Drawing.Point(467, 163);
            this.addScheduleBtn.Name = "addScheduleBtn";
            this.addScheduleBtn.Size = new System.Drawing.Size(89, 41);
            this.addScheduleBtn.TabIndex = 99;
            this.addScheduleBtn.Text = "Add";
            this.addScheduleBtn.UseVisualStyleBackColor = true;
            this.addScheduleBtn.Click += new System.EventHandler(this.addScheduleBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(655, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 93;
            this.label15.Tag = "scheduleData";
            this.label15.Text = "Day";
            // 
            // ScheduleID
            // 
            this.ScheduleID.Location = new System.Drawing.Point(191, 111);
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.ReadOnly = true;
            this.ScheduleID.Size = new System.Drawing.Size(130, 26);
            this.ScheduleID.TabIndex = 98;
            this.ScheduleID.Tag = "scheduleData";
            // 
            // ApartmentID
            // 
            this.ApartmentID.AutoSize = true;
            this.ApartmentID.Location = new System.Drawing.Point(354, 73);
            this.ApartmentID.Name = "ApartmentID";
            this.ApartmentID.Size = new System.Drawing.Size(101, 20);
            this.ApartmentID.TabIndex = 89;
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
            this.DayCB.Location = new System.Drawing.Point(631, 110);
            this.DayCB.Name = "DayCB";
            this.DayCB.Size = new System.Drawing.Size(121, 28);
            this.DayCB.TabIndex = 94;
            this.DayCB.Tag = "scheduleData";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(242, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 97;
            this.label13.Tag = "scheduleData";
            this.label13.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(809, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 96;
            this.label16.Tag = "scheduleData";
            this.label16.Text = "Job";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.deleteAgrBtn);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1164, 237);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Student agreements";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // deleteAgrBtn
            // 
            this.deleteAgrBtn.Location = new System.Drawing.Point(523, 24);
            this.deleteAgrBtn.Name = "deleteAgrBtn";
            this.deleteAgrBtn.Size = new System.Drawing.Size(158, 45);
            this.deleteAgrBtn.TabIndex = 2;
            this.deleteAgrBtn.Text = "Delete agreement";
            this.deleteAgrBtn.UseVisualStyleBackColor = true;
            this.deleteAgrBtn.Click += new System.EventHandler(this.deleteAgrBtn_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1164, 237);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Log out";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 311);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onClick);
            // 
            // adminSettings
            // 
            this.adminSettings.Enabled = true;
            this.adminSettings.Tick += new System.EventHandler(this.adminSettings_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminInterface);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.adminInterface.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.hideUpdateUser.ResumeLayout(false);
            this.hideUpdateUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UptadeUserInfoBy.ResumeLayout(false);
            this.UptadeUserInfoBy.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminInterface;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel hideUpdateUser;
        private System.Windows.Forms.ComboBox availableApartments;
        private System.Windows.Forms.TextBox newData;
        private System.Windows.Forms.TextBox oldData;
        private System.Windows.Forms.Label oldOne;
        private System.Windows.Forms.Label newOne;
        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.NumericUpDown roomsQuantity;
        private System.Windows.Forms.Button updateApartmentBtn;
        private System.Windows.Forms.Button deleteApBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addressAp;
        private System.Windows.Forms.ComboBox propertyTypeComboBox;
        private System.Windows.Forms.Button updateApDataBtn;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.Button createApBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button createApartmentBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bedroomsComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox interiorComboBox;
        private System.Windows.Forms.Button deleteComplaint;
        private System.Windows.Forms.Button deleteAgrBtn;
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
        private System.Windows.Forms.TabPage tabPage7;
    }
}