
namespace StudentHouse
{
    partial class studentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getApartment = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.complaintTxtBox = new System.Windows.Forms.TextBox();
            this.sendComplaint = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(569, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "dontHaveApartment";
            // 
            // getApartment
            // 
            this.getApartment.Location = new System.Drawing.Point(222, 380);
            this.getApartment.Name = "getApartment";
            this.getApartment.Size = new System.Drawing.Size(149, 46);
            this.getApartment.TabIndex = 2;
            this.getApartment.Tag = "dontHaveApartment";
            this.getApartment.Text = "Get apartment";
            this.getApartment.UseVisualStyleBackColor = true;
            this.getApartment.Click += new System.EventHandler(this.getApartment_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(697, 392);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(91, 46);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // complaintTxtBox
            // 
            this.complaintTxtBox.Location = new System.Drawing.Point(56, 88);
            this.complaintTxtBox.Multiline = true;
            this.complaintTxtBox.Name = "complaintTxtBox";
            this.complaintTxtBox.Size = new System.Drawing.Size(495, 215);
            this.complaintTxtBox.TabIndex = 8;
            this.complaintTxtBox.Tag = "complaint";
            this.complaintTxtBox.Visible = false;
            // 
            // sendComplaint
            // 
            this.sendComplaint.Location = new System.Drawing.Point(204, 320);
            this.sendComplaint.Name = "sendComplaint";
            this.sendComplaint.Size = new System.Drawing.Size(167, 42);
            this.sendComplaint.TabIndex = 9;
            this.sendComplaint.Tag = "complaint";
            this.sendComplaint.Text = "Send Complaint";
            this.sendComplaint.UseVisualStyleBackColor = true;
            this.sendComplaint.Visible = false;
            this.sendComplaint.Click += new System.EventHandler(this.sendComplaint_Click);
            // 
            // settings
            // 
            this.settings.FormattingEnabled = true;
            this.settings.Location = new System.Drawing.Point(545, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(243, 28);
            this.settings.TabIndex = 10;
            this.settings.Visible = false;
            this.settings.SelectedIndexChanged += new System.EventHandler(this.changeView);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.sendComplaint);
            this.Controls.Add(this.complaintTxtBox);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getApartment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentForm";
            this.Tag = "StudentForm";
            this.Text = "registerLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.logOut_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getApartment;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox complaintTxtBox;
        private System.Windows.Forms.Button sendComplaint;
        private System.Windows.Forms.ComboBox settings;
    }
}