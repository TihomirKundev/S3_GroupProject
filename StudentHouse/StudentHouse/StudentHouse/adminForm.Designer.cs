
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
            this.students = new System.Windows.Forms.ListBox();
            this.oldData = new System.Windows.Forms.TextBox();
            this.oldOne = new System.Windows.Forms.Label();
            this.newOne = new System.Windows.Forms.Label();
            this.newData = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.ComboBox();
            this.adminSettings = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "changeBy";
            this.label1.Text = "Change student name or password";
            this.label1.Visible = false;
            // 
            // students
            // 
            this.students.FormattingEnabled = true;
            this.students.ItemHeight = 20;
            this.students.Location = new System.Drawing.Point(491, 64);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(297, 124);
            this.students.TabIndex = 1;
            this.students.Tag = "changeBy";
            this.students.Visible = false;
            this.students.SelectedIndexChanged += new System.EventHandler(this.studentsSelectIndex);
            // 
            // oldData
            // 
            this.oldData.Enabled = false;
            this.oldData.Location = new System.Drawing.Point(619, 267);
            this.oldData.Name = "oldData";
            this.oldData.Size = new System.Drawing.Size(140, 26);
            this.oldData.TabIndex = 4;
            this.oldData.Tag = "changeByX";
            this.oldData.Visible = false;
            // 
            // oldOne
            // 
            this.oldOne.AutoSize = true;
            this.oldOne.Location = new System.Drawing.Point(487, 267);
            this.oldOne.Name = "oldOne";
            this.oldOne.Size = new System.Drawing.Size(51, 20);
            this.oldOne.TabIndex = 5;
            this.oldOne.Tag = "changeByX";
            this.oldOne.Text = "label2";
            this.oldOne.Visible = false;
            // 
            // newOne
            // 
            this.newOne.AutoSize = true;
            this.newOne.Location = new System.Drawing.Point(487, 309);
            this.newOne.Name = "newOne";
            this.newOne.Size = new System.Drawing.Size(51, 20);
            this.newOne.TabIndex = 7;
            this.newOne.Tag = "changeByX";
            this.newOne.Text = "label3";
            this.newOne.Visible = false;
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(619, 309);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(140, 26);
            this.newData.TabIndex = 6;
            this.newData.Tag = "changeByX";
            this.newData.Visible = false;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(578, 341);
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
            this.settings.Location = new System.Drawing.Point(166, 30);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(190, 28);
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
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(491, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 68);
            this.panel1.TabIndex = 10;
            this.panel1.Tag = "changeBy";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(182, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "changeBy";
            this.radioButton2.Text = "Change by password";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(73, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(154, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "changeBy";
            this.radioButton1.Text = "Change by name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.change);
            this.Controls.Add(this.newOne);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.oldOne);
            this.Controls.Add(this.oldData);
            this.Controls.Add(this.students);
            this.Controls.Add(this.label1);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox students;
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
    }
}