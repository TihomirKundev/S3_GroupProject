
namespace ProjectS07group4.StudentPanels
{
    partial class MakeComplaintPanel
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
            this.sendComplaint = new System.Windows.Forms.Button();
            this.complaintTxtBox = new System.Windows.Forms.TextBox();
            this.wordCount = new System.Windows.Forms.Label();
            this.charCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.sendComplaint);
            this.panel1.Controls.Add(this.complaintTxtBox);
            this.panel1.Controls.Add(this.wordCount);
            this.panel1.Controls.Add(this.charCount);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 308);
            this.panel1.TabIndex = 0;
            // 
            // sendComplaint
            // 
            this.sendComplaint.Location = new System.Drawing.Point(161, 225);
            this.sendComplaint.Name = "sendComplaint";
            this.sendComplaint.Size = new System.Drawing.Size(143, 40);
            this.sendComplaint.TabIndex = 18;
            this.sendComplaint.Tag = "complaint";
            this.sendComplaint.Text = "Send Complaint";
            this.sendComplaint.UseVisualStyleBackColor = true;
            this.sendComplaint.Click += new System.EventHandler(this.sendComplaint_Click);
            // 
            // complaintTxtBox
            // 
            this.complaintTxtBox.Location = new System.Drawing.Point(15, 36);
            this.complaintTxtBox.MaxLength = 999;
            this.complaintTxtBox.Multiline = true;
            this.complaintTxtBox.Name = "complaintTxtBox";
            this.complaintTxtBox.Size = new System.Drawing.Size(449, 183);
            this.complaintTxtBox.TabIndex = 17;
            this.complaintTxtBox.Tag = "complaint";
            this.complaintTxtBox.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(11, 13);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(95, 20);
            this.wordCount.TabIndex = 19;
            this.wordCount.Tag = "complaint";
            this.wordCount.Text = "Word count:";
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(334, 13);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(127, 20);
            this.charCount.TabIndex = 20;
            this.charCount.Tag = "complaint";
            this.charCount.Text = "Character count:";
            // 
            // MakeComplaintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(479, 302);
            this.Controls.Add(this.panel1);
            this.Name = "MakeComplaintPanel";
            this.Text = "MakeComplaintPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendComplaint;
        private System.Windows.Forms.TextBox complaintTxtBox;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Label charCount;
    }
}