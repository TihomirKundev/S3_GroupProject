﻿
namespace StudentHouse
{
    partial class loginRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logInName = new System.Windows.Forms.TextBox();
            this.logInPassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Name or email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Tag = "Login";
            this.label3.Text = "Password:";
            // 
            // logInName
            // 
            this.logInName.Location = new System.Drawing.Point(132, 18);
            this.logInName.Name = "logInName";
            this.logInName.Size = new System.Drawing.Size(145, 26);
            this.logInName.TabIndex = 3;
            this.logInName.Tag = "Login";
            // 
            // logInPassword
            // 
            this.logInPassword.Location = new System.Drawing.Point(132, 72);
            this.logInPassword.Name = "logInPassword";
            this.logInPassword.Size = new System.Drawing.Size(145, 26);
            this.logInPassword.TabIndex = 5;
            this.logInPassword.Tag = "Login";
            this.logInPassword.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(84, 111);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(114, 41);
            this.login.TabIndex = 6;
            this.login.Tag = "Login";
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 26);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logInPassword);
            this.Controls.Add(this.logInName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "loginRegister";
            this.Text = "Login / Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logInName;
        private System.Windows.Forms.TextBox logInPassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

