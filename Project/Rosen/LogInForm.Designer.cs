
namespace Project
{
    partial class LoginForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.logInPassword = new System.Windows.Forms.TextBox();
            this.logInName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(159, 139);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(114, 41);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Tag = "Login";
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // logInPassword
            // 
            this.logInPassword.Location = new System.Drawing.Point(140, 84);
            this.logInPassword.Name = "logInPassword";
            this.logInPassword.Size = new System.Drawing.Size(145, 26);
            this.logInPassword.TabIndex = 10;
            this.logInPassword.Tag = "Login";
            this.logInPassword.UseSystemPasswordChar = true;
            // 
            // logInName
            // 
            this.logInName.Location = new System.Drawing.Point(140, 33);
            this.logInName.Name = "logInName";
            this.logInName.Size = new System.Drawing.Size(145, 26);
            this.logInName.TabIndex = 9;
            this.logInName.Tag = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Tag = "Login";
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Tag = "";
            this.label1.Text = "Email:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 230);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.logInPassword);
            this.Controls.Add(this.logInName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeApplication);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox logInPassword;
        private System.Windows.Forms.TextBox logInName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

