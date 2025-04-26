namespace BiteWiseApp
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUpLb = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(268, 172);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(168, 23);
            this.UsernameTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(270, 208);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(167, 23);
            this.PasswordTB.TabIndex = 2;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(270, 253);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(128, 57);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpLb
            // 
            this.SignUpLb.AutoSize = true;
            this.SignUpLb.Location = new System.Drawing.Point(209, 333);
            this.SignUpLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpLb.Name = "SignUpLb";
            this.SignUpLb.Size = new System.Drawing.Size(146, 15);
            this.SignUpLb.TabIndex = 5;
            this.SignUpLb.Text = "No Account. Sign up here.";
            this.SignUpLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // Signup
            // 
            this.Signup.AutoSize = true;
            this.Signup.Location = new System.Drawing.Point(371, 333);
            this.Signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(48, 15);
            this.Signup.TabIndex = 4;
            this.Signup.TabStop = true;
            this.Signup.Text = "Sign Up";
            this.Signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signup_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Juice ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(208, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 72);
            this.label3.TabIndex = 0;
            this.label3.Text = "BiteWise";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.SignUpLb);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label SignUpLb;
        private System.Windows.Forms.LinkLabel Signup;
        private System.Windows.Forms.Label label3;
    }
}

