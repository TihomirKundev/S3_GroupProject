
namespace StudentHouse
{
    partial class AdminFormO
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.change = new System.Windows.Forms.Button();
            this.newOne = new System.Windows.Forms.Label();
            this.newData = new System.Windows.Forms.TextBox();
            this.oldOne = new System.Windows.Forms.Label();
            this.oldData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "User data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Apartments data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Users with apartments";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(523, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Users with no apartments";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(764, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "Complaint messages";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(989, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(201, 37);
            this.button7.TabIndex = 6;
            this.button7.Text = "Schedule for apartments";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(20, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 97);
            this.panel1.TabIndex = 17;
            this.panel1.Tag = "changeBy";
            this.panel1.Visible = false;
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
            // change
            // 
            this.change.Location = new System.Drawing.Point(696, 136);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(101, 33);
            this.change.TabIndex = 16;
            this.change.Tag = "changeByX";
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Visible = false;
            // 
            // newOne
            // 
            this.newOne.AutoSize = true;
            this.newOne.Location = new System.Drawing.Point(360, 161);
            this.newOne.Name = "newOne";
            this.newOne.Size = new System.Drawing.Size(51, 20);
            this.newOne.TabIndex = 15;
            this.newOne.Tag = "changeByX";
            this.newOne.Text = "label3";
            this.newOne.Visible = false;
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(528, 161);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(140, 26);
            this.newData.TabIndex = 14;
            this.newData.Tag = "changeByX";
            this.newData.Visible = false;
            // 
            // oldOne
            // 
            this.oldOne.AutoSize = true;
            this.oldOne.Location = new System.Drawing.Point(360, 119);
            this.oldOne.Name = "oldOne";
            this.oldOne.Size = new System.Drawing.Size(51, 20);
            this.oldOne.TabIndex = 13;
            this.oldOne.Tag = "changeByX";
            this.oldOne.Text = "label2";
            this.oldOne.Visible = false;
            // 
            // oldData
            // 
            this.oldData.Enabled = false;
            this.oldData.Location = new System.Drawing.Point(528, 119);
            this.oldData.Name = "oldData";
            this.oldData.Size = new System.Drawing.Size(140, 26);
            this.oldData.TabIndex = 12;
            this.oldData.Tag = "changeByX";
            this.oldData.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 11;
            this.label1.Tag = "changeBy";
            this.label1.Text = "Change student name or password";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "List of datas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 316);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Tag = "";
            // 
            // AdminFormO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 734);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.newOne);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.oldOne);
            this.Controls.Add(this.oldData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminFormO";
            this.Text = "AdminFormO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label newOne;
        private System.Windows.Forms.TextBox newData;
        private System.Windows.Forms.Label oldOne;
        private System.Windows.Forms.TextBox oldData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}