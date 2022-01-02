
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logInName = new System.Windows.Forms.TextBox();
            this.logInPassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerRadioBtn = new System.Windows.Forms.RadioButton();
            this.loginRadioBtn = new System.Windows.Forms.RadioButton();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Name or email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Tag = "Login";
            this.label3.Text = "Password:";
            // 
            // logInName
            // 
            this.logInName.Location = new System.Drawing.Point(159, 21);
            this.logInName.Name = "logInName";
            this.logInName.Size = new System.Drawing.Size(145, 26);
            this.logInName.TabIndex = 3;
            this.logInName.Tag = "Login";
            // 
            // logInPassword
            // 
            this.logInPassword.Location = new System.Drawing.Point(159, 72);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.registerRadioBtn);
            this.panel1.Controls.Add(this.loginRadioBtn);
            this.panel1.Location = new System.Drawing.Point(346, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 68);
            this.panel1.TabIndex = 11;
            this.panel1.Tag = "changeBy";
            // 
            // registerRadioBtn
            // 
            this.registerRadioBtn.AutoSize = true;
            this.registerRadioBtn.Location = new System.Drawing.Point(30, 43);
            this.registerRadioBtn.Name = "registerRadioBtn";
            this.registerRadioBtn.Size = new System.Drawing.Size(94, 24);
            this.registerRadioBtn.TabIndex = 1;
            this.registerRadioBtn.TabStop = true;
            this.registerRadioBtn.Tag = "";
            this.registerRadioBtn.Text = "Register";
            this.registerRadioBtn.UseVisualStyleBackColor = true;
            this.registerRadioBtn.CheckedChanged += new System.EventHandler(this.emptyTextBoxes);
            // 
            // loginRadioBtn
            // 
            this.loginRadioBtn.AutoSize = true;
            this.loginRadioBtn.Location = new System.Drawing.Point(30, 13);
            this.loginRadioBtn.Name = "loginRadioBtn";
            this.loginRadioBtn.Size = new System.Drawing.Size(73, 24);
            this.loginRadioBtn.TabIndex = 0;
            this.loginRadioBtn.TabStop = true;
            this.loginRadioBtn.Tag = "";
            this.loginRadioBtn.Text = "Login";
            this.loginRadioBtn.UseVisualStyleBackColor = true;
            this.loginRadioBtn.CheckedChanged += new System.EventHandler(this.emptyTextBoxes);
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(159, 121);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(145, 26);
            this.passwordConfirm.TabIndex = 13;
            this.passwordConfirm.Tag = "register";
            this.passwordConfirm.UseSystemPasswordChar = true;
            this.passwordConfirm.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 12;
            this.label2.Tag = "register";
            this.label2.Text = "Confirm Password:";
            this.label2.Visible = false;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(84, 169);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(114, 42);
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Tag = "register";
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Visible = false;
            this.registerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.loginOrRegister);
            // 
            // loginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 297);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logInPassword);
            this.Controls.Add(this.logInName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "loginRegister";
            this.Text = "Login / Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logInName;
        private System.Windows.Forms.TextBox logInPassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton registerRadioBtn;
        private System.Windows.Forms.RadioButton loginRadioBtn;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

