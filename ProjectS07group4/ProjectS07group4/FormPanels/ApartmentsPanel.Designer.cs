
namespace ProjectS07group4.FormPanels
{
    partial class ApartmentsPanel
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
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.apartmentPanel = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.apartmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.AllowUserToResizeColumns = false;
            this.tableInfo.AllowUserToResizeRows = false;
            this.tableInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Location = new System.Drawing.Point(3, 3);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.RowHeadersVisible = false;
            this.tableInfo.RowHeadersWidth = 62;
            this.tableInfo.RowTemplate.Height = 28;
            this.tableInfo.Size = new System.Drawing.Size(1067, 341);
            this.tableInfo.TabIndex = 98;
            this.tableInfo.Click += new System.EventHandler(this.OnClick);
            // 
            // apartmentPanel
            // 
            this.apartmentPanel.Controls.Add(this.roomsQuantity);
            this.apartmentPanel.Controls.Add(this.updateApartmentBtn);
            this.apartmentPanel.Controls.Add(this.deleteApBtn);
            this.apartmentPanel.Controls.Add(this.label10);
            this.apartmentPanel.Controls.Add(this.addressAp);
            this.apartmentPanel.Controls.Add(this.propertyTypeComboBox);
            this.apartmentPanel.Controls.Add(this.updateApDataBtn);
            this.apartmentPanel.Controls.Add(this.priceNumeric);
            this.apartmentPanel.Controls.Add(this.createApBtn);
            this.apartmentPanel.Controls.Add(this.label6);
            this.apartmentPanel.Controls.Add(this.label11);
            this.apartmentPanel.Controls.Add(this.createApartmentBtn);
            this.apartmentPanel.Controls.Add(this.label7);
            this.apartmentPanel.Controls.Add(this.idTxtBox);
            this.apartmentPanel.Controls.Add(this.label12);
            this.apartmentPanel.Controls.Add(this.label9);
            this.apartmentPanel.Controls.Add(this.bedroomsComboBox);
            this.apartmentPanel.Controls.Add(this.label8);
            this.apartmentPanel.Controls.Add(this.interiorComboBox);
            this.apartmentPanel.Controls.Add(this.tableInfo);
            this.apartmentPanel.Location = new System.Drawing.Point(12, 12);
            this.apartmentPanel.Name = "apartmentPanel";
            this.apartmentPanel.Size = new System.Drawing.Size(1073, 552);
            this.apartmentPanel.TabIndex = 99;
            // 
            // roomsQuantity
            // 
            this.roomsQuantity.Location = new System.Drawing.Point(937, 446);
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
            this.roomsQuantity.TabIndex = 131;
            this.roomsQuantity.Tag = "apartmentTxtBoxes";
            this.roomsQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updateApartmentBtn
            // 
            this.updateApartmentBtn.Location = new System.Drawing.Point(523, 494);
            this.updateApartmentBtn.Name = "updateApartmentBtn";
            this.updateApartmentBtn.Size = new System.Drawing.Size(96, 42);
            this.updateApartmentBtn.TabIndex = 126;
            this.updateApartmentBtn.Text = "Update";
            this.updateApartmentBtn.UseVisualStyleBackColor = true;
            this.updateApartmentBtn.Visible = false;
            this.updateApartmentBtn.Click += new System.EventHandler(this.updateApartmentBtn_Click);
            // 
            // deleteApBtn
            // 
            this.deleteApBtn.Location = new System.Drawing.Point(634, 355);
            this.deleteApBtn.Name = "deleteApBtn";
            this.deleteApBtn.Size = new System.Drawing.Size(95, 36);
            this.deleteApBtn.TabIndex = 130;
            this.deleteApBtn.Text = "Delete";
            this.deleteApBtn.UseVisualStyleBackColor = true;
            this.deleteApBtn.Click += new System.EventHandler(this.deleteApBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(534, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 116;
            this.label10.Tag = "apartmentTxtBoxes";
            this.label10.Text = "Property Type";
            // 
            // addressAp
            // 
            this.addressAp.Location = new System.Drawing.Point(139, 439);
            this.addressAp.MaxLength = 100;
            this.addressAp.Multiline = true;
            this.addressAp.Name = "addressAp";
            this.addressAp.Size = new System.Drawing.Size(262, 97);
            this.addressAp.TabIndex = 129;
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
            this.propertyTypeComboBox.Location = new System.Drawing.Point(528, 441);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.propertyTypeComboBox.TabIndex = 117;
            this.propertyTypeComboBox.Tag = "apartmentTxtBoxes";
            // 
            // updateApDataBtn
            // 
            this.updateApDataBtn.Location = new System.Drawing.Point(524, 355);
            this.updateApDataBtn.Name = "updateApDataBtn";
            this.updateApDataBtn.Size = new System.Drawing.Size(95, 36);
            this.updateApDataBtn.TabIndex = 128;
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
            this.priceNumeric.Location = new System.Drawing.Point(429, 442);
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
            this.priceNumeric.TabIndex = 115;
            this.priceNumeric.Tag = "apartmentTxtBoxes";
            this.priceNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // createApBtn
            // 
            this.createApBtn.Location = new System.Drawing.Point(412, 355);
            this.createApBtn.Name = "createApBtn";
            this.createApBtn.Size = new System.Drawing.Size(95, 36);
            this.createApBtn.TabIndex = 127;
            this.createApBtn.Text = "Create";
            this.createApBtn.UseVisualStyleBackColor = true;
            this.createApBtn.Click += new System.EventHandler(this.createApBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 118;
            this.label6.Tag = "apartmentTxtBoxes";
            this.label6.Text = "Interior";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 114;
            this.label11.Tag = "apartmentTxtBoxes";
            this.label11.Text = "Price";
            // 
            // createApartmentBtn
            // 
            this.createApartmentBtn.Location = new System.Drawing.Point(426, 494);
            this.createApartmentBtn.Name = "createApartmentBtn";
            this.createApartmentBtn.Size = new System.Drawing.Size(96, 42);
            this.createApartmentBtn.TabIndex = 125;
            this.createApartmentBtn.Text = "Add";
            this.createApartmentBtn.UseVisualStyleBackColor = true;
            this.createApartmentBtn.Click += new System.EventHandler(this.createApartmentBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 120;
            this.label7.Tag = "apartmentTxtBoxes";
            this.label7.Text = "Bedrooms";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(16, 442);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(100, 26);
            this.idTxtBox.TabIndex = 124;
            this.idTxtBox.Tag = "apartmentTxtBoxes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 113;
            this.label12.Tag = "apartmentTxtBoxes";
            this.label12.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 123;
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
            this.bedroomsComboBox.Location = new System.Drawing.Point(810, 444);
            this.bedroomsComboBox.Name = "bedroomsComboBox";
            this.bedroomsComboBox.Size = new System.Drawing.Size(121, 28);
            this.bedroomsComboBox.TabIndex = 121;
            this.bedroomsComboBox.Tag = "apartmentTxtBoxes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(939, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 122;
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
            this.interiorComboBox.Location = new System.Drawing.Point(655, 444);
            this.interiorComboBox.Name = "interiorComboBox";
            this.interiorComboBox.Size = new System.Drawing.Size(121, 28);
            this.interiorComboBox.TabIndex = 119;
            this.interiorComboBox.Tag = "apartmentTxtBoxes";
            // 
            // ApartmentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 570);
            this.Controls.Add(this.apartmentPanel);
            this.Name = "ApartmentsPanel";
            this.Text = "ApartmentsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.apartmentPanel.ResumeLayout(false);
            this.apartmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableInfo;
        private System.Windows.Forms.Panel apartmentPanel;
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
    }
}