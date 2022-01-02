
namespace StudentHouse
{
    partial class adminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.oldData = new System.Windows.Forms.TextBox();
            this.oldOne = new System.Windows.Forms.Label();
            this.newOne = new System.Windows.Forms.Label();
            this.newData = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.ComboBox();
            this.adminSettings = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.propertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.interiorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bedroomsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addApartments = new System.Windows.Forms.Button();
            this.updateApartments = new System.Windows.Forms.Button();
            this.deleteApartments = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.AddDeleteUpdate = new System.Windows.Forms.ComboBox();
            this.logOut = new System.Windows.Forms.Button();
            this.deleteComplaint = new System.Windows.Forms.Button();
            this.apartmentIds = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.eventMessage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timeForEvent = new System.Windows.Forms.TextBox();
            this.scheduleComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleAdd = new System.Windows.Forms.Button();
            this.scheduleUpdate = new System.Windows.Forms.Button();
            this.scheduleDelete = new System.Windows.Forms.Button();
            this.scheduleID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "changeBy";
            this.label1.Text = "Change student name or password";
            this.label1.Visible = false;
            // 
            // oldData
            // 
            this.oldData.Enabled = false;
            this.oldData.Location = new System.Drawing.Point(564, 72);
            this.oldData.Name = "oldData";
            this.oldData.Size = new System.Drawing.Size(140, 26);
            this.oldData.TabIndex = 4;
            this.oldData.Tag = "changeByX";
            this.oldData.Visible = false;
            // 
            // oldOne
            // 
            this.oldOne.AutoSize = true;
            this.oldOne.Location = new System.Drawing.Point(396, 72);
            this.oldOne.Name = "oldOne";
            this.oldOne.Size = new System.Drawing.Size(51, 20);
            this.oldOne.TabIndex = 5;
            this.oldOne.Tag = "changeByX";
            this.oldOne.Text = "label2";
            this.oldOne.Visible = false;
            this.oldOne.Click += new System.EventHandler(this.oldOne_Click);
            // 
            // newOne
            // 
            this.newOne.AutoSize = true;
            this.newOne.Location = new System.Drawing.Point(396, 114);
            this.newOne.Name = "newOne";
            this.newOne.Size = new System.Drawing.Size(51, 20);
            this.newOne.TabIndex = 7;
            this.newOne.Tag = "changeByX";
            this.newOne.Text = "label3";
            this.newOne.Visible = false;
            this.newOne.Click += new System.EventHandler(this.newOne_Click);
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(564, 114);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(140, 26);
            this.newData.TabIndex = 6;
            this.newData.Tag = "changeByX";
            this.newData.Visible = false;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(732, 89);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(101, 33);
            this.change.TabIndex = 8;
            this.change.Tag = "changeByX";
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Visible = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // settings
            // 
            this.settings.FormattingEnabled = true;
            this.settings.Location = new System.Drawing.Point(526, 30);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(344, 28);
            this.settings.TabIndex = 9;
            this.settings.SelectedIndexChanged += new System.EventHandler(this.filterSettings);
            // 
            // adminSettings
            // 
            this.adminSettings.Enabled = true;
            this.adminSettings.Tick += new System.EventHandler(this.adminSettingsTimer);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(56, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 97);
            this.panel1.TabIndex = 10;
            this.panel1.Tag = "changeBy";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(73, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(167, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "changeBy";
            this.radioButton3.Text = "Change apartment";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "changeBy";
            this.radioButton2.Text = "Change password";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(73, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "changeBy";
            this.radioButton1.Text = "Change name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 316);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "List of datas";
            // 
            // deleteData
            // 
            this.deleteData.Location = new System.Drawing.Point(21, 176);
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(116, 33);
            this.deleteData.TabIndex = 13;
            this.deleteData.Tag = "delete";
            this.deleteData.Text = "Delete";
            this.deleteData.UseVisualStyleBackColor = true;
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1042, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 16;
            this.label3.Tag = "Apartments";
            this.label3.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(167, 600);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 28);
            this.genderComboBox.TabIndex = 17;
            this.genderComboBox.Tag = "Apartments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 18;
            this.label4.Tag = "Apartments";
            this.label4.Text = "Price";
            // 
            // priceNumeric
            // 
            this.priceNumeric.DecimalPlaces = 1;
            this.priceNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priceNumeric.Location = new System.Drawing.Point(335, 601);
            this.priceNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(93, 26);
            this.priceNumeric.TabIndex = 19;
            this.priceNumeric.Tag = "Apartments";
            // 
            // propertyTypeComboBox
            // 
            this.propertyTypeComboBox.FormattingEnabled = true;
            this.propertyTypeComboBox.Location = new System.Drawing.Point(480, 601);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.propertyTypeComboBox.TabIndex = 21;
            this.propertyTypeComboBox.Tag = "Apartments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 20;
            this.label5.Tag = "Apartments";
            this.label5.Text = "Property Type";
            // 
            // interiorComboBox
            // 
            this.interiorComboBox.FormattingEnabled = true;
            this.interiorComboBox.Location = new System.Drawing.Point(652, 600);
            this.interiorComboBox.Name = "interiorComboBox";
            this.interiorComboBox.Size = new System.Drawing.Size(121, 28);
            this.interiorComboBox.TabIndex = 23;
            this.interiorComboBox.Tag = "Apartments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 22;
            this.label6.Tag = "Apartments";
            this.label6.Text = "Interior";
            // 
            // bedroomsComboBox
            // 
            this.bedroomsComboBox.FormattingEnabled = true;
            this.bedroomsComboBox.Location = new System.Drawing.Point(826, 600);
            this.bedroomsComboBox.Name = "bedroomsComboBox";
            this.bedroomsComboBox.Size = new System.Drawing.Size(121, 28);
            this.bedroomsComboBox.TabIndex = 25;
            this.bedroomsComboBox.Tag = "Apartments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(850, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 24;
            this.label7.Tag = "Apartments";
            this.label7.Text = "Bedrooms";
            // 
            // roomsComboBox
            // 
            this.roomsComboBox.FormattingEnabled = true;
            this.roomsComboBox.Location = new System.Drawing.Point(999, 600);
            this.roomsComboBox.Name = "roomsComboBox";
            this.roomsComboBox.Size = new System.Drawing.Size(121, 28);
            this.roomsComboBox.TabIndex = 27;
            this.roomsComboBox.Tag = "Apartments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1023, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 26;
            this.label8.Tag = "Apartments";
            this.label8.Text = "Rooms";
            // 
            // addApartments
            // 
            this.addApartments.Location = new System.Drawing.Point(499, 641);
            this.addApartments.Name = "addApartments";
            this.addApartments.Size = new System.Drawing.Size(102, 37);
            this.addApartments.TabIndex = 28;
            this.addApartments.Tag = "";
            this.addApartments.Text = "Add";
            this.addApartments.UseVisualStyleBackColor = true;
            this.addApartments.Visible = false;
            this.addApartments.Click += new System.EventHandler(this.addApartments_Click);
            // 
            // updateApartments
            // 
            this.updateApartments.Location = new System.Drawing.Point(499, 641);
            this.updateApartments.Name = "updateApartments";
            this.updateApartments.Size = new System.Drawing.Size(102, 37);
            this.updateApartments.TabIndex = 29;
            this.updateApartments.Tag = "";
            this.updateApartments.Text = "Update";
            this.updateApartments.UseVisualStyleBackColor = true;
            this.updateApartments.Visible = false;
            this.updateApartments.Click += new System.EventHandler(this.updateApartments_Click);
            // 
            // deleteApartments
            // 
            this.deleteApartments.Location = new System.Drawing.Point(499, 641);
            this.deleteApartments.Name = "deleteApartments";
            this.deleteApartments.Size = new System.Drawing.Size(102, 37);
            this.deleteApartments.TabIndex = 30;
            this.deleteApartments.Tag = "";
            this.deleteApartments.Text = "Delete";
            this.deleteApartments.UseVisualStyleBackColor = true;
            this.deleteApartments.Visible = false;
            this.deleteApartments.Click += new System.EventHandler(this.deleteApartments_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 31;
            this.label9.Tag = "Apartments";
            this.label9.Text = "ID";
            this.label9.Visible = false;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(25, 602);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 26);
            this.idTxtBox.TabIndex = 32;
            this.idTxtBox.Tag = "Apartments";
            this.idTxtBox.Visible = false;
            // 
            // AddDeleteUpdate
            // 
            this.AddDeleteUpdate.FormattingEnabled = true;
            this.AddDeleteUpdate.Location = new System.Drawing.Point(913, 30);
            this.AddDeleteUpdate.Name = "AddDeleteUpdate";
            this.AddDeleteUpdate.Size = new System.Drawing.Size(121, 28);
            this.AddDeleteUpdate.TabIndex = 33;
            this.AddDeleteUpdate.Tag = "Apartments";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(1062, 22);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(91, 46);
            this.logOut.TabIndex = 34;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // deleteComplaint
            // 
            this.deleteComplaint.Location = new System.Drawing.Point(467, 562);
            this.deleteComplaint.Name = "deleteComplaint";
            this.deleteComplaint.Size = new System.Drawing.Size(218, 33);
            this.deleteComplaint.TabIndex = 35;
            this.deleteComplaint.Text = "Delete complaint";
            this.deleteComplaint.UseVisualStyleBackColor = true;
            this.deleteComplaint.Visible = false;
            this.deleteComplaint.Click += new System.EventHandler(this.deleteComplaint_Click);
            // 
            // apartmentIds
            // 
            this.apartmentIds.FormattingEnabled = true;
            this.apartmentIds.Location = new System.Drawing.Point(175, 587);
            this.apartmentIds.Name = "apartmentIds";
            this.apartmentIds.Size = new System.Drawing.Size(121, 28);
            this.apartmentIds.TabIndex = 36;
            this.apartmentIds.Tag = "scheduleInfo";
            this.apartmentIds.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 37;
            this.label10.Tag = "scheduleInfo";
            this.label10.Text = "Apartment ID";
            this.label10.Visible = false;
            // 
            // eventMessage
            // 
            this.eventMessage.Location = new System.Drawing.Point(385, 580);
            this.eventMessage.Multiline = true;
            this.eventMessage.Name = "eventMessage";
            this.eventMessage.Size = new System.Drawing.Size(339, 98);
            this.eventMessage.TabIndex = 38;
            this.eventMessage.Tag = "scheduleInfo";
            this.eventMessage.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 39;
            this.label11.Tag = "scheduleInfo";
            this.label11.Text = "Event";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(790, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 41;
            this.label12.Tag = "scheduleInfo";
            this.label12.Text = "Time";
            this.label12.Visible = false;
            // 
            // timeForEvent
            // 
            this.timeForEvent.Location = new System.Drawing.Point(761, 603);
            this.timeForEvent.Name = "timeForEvent";
            this.timeForEvent.Size = new System.Drawing.Size(100, 26);
            this.timeForEvent.TabIndex = 40;
            this.timeForEvent.Tag = "scheduleInfo";
            this.timeForEvent.Visible = false;
            // 
            // scheduleComboBox
            // 
            this.scheduleComboBox.FormattingEnabled = true;
            this.scheduleComboBox.Location = new System.Drawing.Point(913, 69);
            this.scheduleComboBox.Name = "scheduleComboBox";
            this.scheduleComboBox.Size = new System.Drawing.Size(121, 28);
            this.scheduleComboBox.TabIndex = 42;
            this.scheduleComboBox.Tag = "scheduleInfo";
            this.scheduleComboBox.SelectedIndexChanged += new System.EventHandler(this.changeBtns);
            // 
            // scheduleAdd
            // 
            this.scheduleAdd.Location = new System.Drawing.Point(65, 665);
            this.scheduleAdd.Name = "scheduleAdd";
            this.scheduleAdd.Size = new System.Drawing.Size(93, 40);
            this.scheduleAdd.TabIndex = 43;
            this.scheduleAdd.Text = "Add";
            this.scheduleAdd.UseVisualStyleBackColor = true;
            this.scheduleAdd.Visible = false;
            this.scheduleAdd.Click += new System.EventHandler(this.scheduleAdd_Click);
            // 
            // scheduleUpdate
            // 
            this.scheduleUpdate.Location = new System.Drawing.Point(115, 634);
            this.scheduleUpdate.Name = "scheduleUpdate";
            this.scheduleUpdate.Size = new System.Drawing.Size(93, 40);
            this.scheduleUpdate.TabIndex = 44;
            this.scheduleUpdate.Text = "Update";
            this.scheduleUpdate.UseVisualStyleBackColor = true;
            this.scheduleUpdate.Visible = false;
            this.scheduleUpdate.Click += new System.EventHandler(this.scheduleUpdate_Click);
            // 
            // scheduleDelete
            // 
            this.scheduleDelete.Location = new System.Drawing.Point(175, 674);
            this.scheduleDelete.Name = "scheduleDelete";
            this.scheduleDelete.Size = new System.Drawing.Size(93, 40);
            this.scheduleDelete.TabIndex = 45;
            this.scheduleDelete.Text = "Delete";
            this.scheduleDelete.UseVisualStyleBackColor = true;
            this.scheduleDelete.Visible = false;
            this.scheduleDelete.Click += new System.EventHandler(this.scheduleDelete_Click);
            // 
            // scheduleID
            // 
            this.scheduleID.Enabled = false;
            this.scheduleID.Location = new System.Drawing.Point(37, 589);
            this.scheduleID.Name = "scheduleID";
            this.scheduleID.Size = new System.Drawing.Size(100, 26);
            this.scheduleID.TabIndex = 47;
            this.scheduleID.Tag = "scheduleInfo";
            this.scheduleID.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 46;
            this.label13.Tag = "scheduleInfo";
            this.label13.Text = "ID";
            this.label13.Visible = false;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 784);
            this.Controls.Add(this.scheduleID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.scheduleDelete);
            this.Controls.Add(this.scheduleUpdate);
            this.Controls.Add(this.scheduleAdd);
            this.Controls.Add(this.scheduleComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.timeForEvent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.eventMessage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.apartmentIds);
            this.Controls.Add(this.deleteComplaint);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.AddDeleteUpdate);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteApartments);
            this.Controls.Add(this.updateApartments);
            this.Controls.Add(this.addApartments);
            this.Controls.Add(this.roomsComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bedroomsComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.interiorComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.propertyTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.change);
            this.Controls.Add(this.newOne);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.oldOne);
            this.Controls.Add(this.oldData);
            this.Controls.Add(this.label1);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldData;
        private System.Windows.Forms.Label oldOne;
        private System.Windows.Forms.Label newOne;
        private System.Windows.Forms.TextBox newData;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.ComboBox settings;
        private System.Windows.Forms.Timer adminSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.ComboBox propertyTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox interiorComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bedroomsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox roomsComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addApartments;
        private System.Windows.Forms.Button updateApartments;
        private System.Windows.Forms.Button deleteApartments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.ComboBox AddDeleteUpdate;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button deleteComplaint;
        private System.Windows.Forms.ComboBox apartmentIds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox eventMessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox timeForEvent;
        private System.Windows.Forms.ComboBox scheduleComboBox;
        private System.Windows.Forms.Button scheduleAdd;
        private System.Windows.Forms.Button scheduleUpdate;
        private System.Windows.Forms.Button scheduleDelete;
        private System.Windows.Forms.TextBox scheduleID;
        private System.Windows.Forms.Label label13;
    }
}