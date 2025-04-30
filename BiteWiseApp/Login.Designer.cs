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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EmailLB = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUpLb = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.LinkLabel();
            this.BiteWiseLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BiteWiseLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.BackColor = System.Drawing.Color.Transparent;
            this.EmailLB.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLB.ForeColor = System.Drawing.Color.White;
            this.EmailLB.Location = new System.Drawing.Point(193, 243);
            this.EmailLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(53, 21);
            this.EmailLB.TabIndex = 0;
            this.EmailLB.Text = "Email";
            //this.EmailLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.Passwordlabel.ForeColor = System.Drawing.Color.White;
            this.Passwordlabel.Location = new System.Drawing.Point(193, 278);
            this.Passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(86, 21);
            this.Passwordlabel.TabIndex = 1;
            this.Passwordlabel.Text = "Password";
            // 
            // UsernameTB
            // 
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UsernameTB.Location = new System.Drawing.Point(284, 245);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(146, 16);
            this.UsernameTB.TabIndex = 1;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Location = new System.Drawing.Point(285, 280);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(145, 16);
            this.PasswordTB.TabIndex = 2;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(258, 322);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(106, 42);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpLb
            // 
            this.SignUpLb.AutoSize = true;
            this.SignUpLb.BackColor = System.Drawing.Color.White;
            this.SignUpLb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLb.Location = new System.Drawing.Point(215, 402);
            this.SignUpLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpLb.Name = "SignUpLb";
            this.SignUpLb.Size = new System.Drawing.Size(147, 15);
            this.SignUpLb.TabIndex = 5;
            this.SignUpLb.Text = "No Account. Sign up here.";
           // this.SignUpLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // Signup
            // 
            this.Signup.AutoSize = true;
            this.Signup.BackColor = System.Drawing.Color.White;
            this.Signup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(358, 402);
            this.Signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(49, 15);
            this.Signup.TabIndex = 4;
            this.Signup.TabStop = true;
            this.Signup.Text = "Sign Up";
            this.Signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signup_LinkClicked);
            // 
            // BiteWiseLogo
            // 
            this.BiteWiseLogo.BackColor = System.Drawing.Color.Transparent;
            this.BiteWiseLogo.Image = ((System.Drawing.Image)(resources.GetObject("BiteWiseLogo.Image")));
            this.BiteWiseLogo.Location = new System.Drawing.Point(227, 50);
            this.BiteWiseLogo.Name = "BiteWiseLogo";
            this.BiteWiseLogo.Size = new System.Drawing.Size(168, 165);
            this.BiteWiseLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BiteWiseLogo.TabIndex = 6;
            this.BiteWiseLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.BackgroundImage = global::BiteWiseApp.Properties.Resources.blur_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 498);
            this.Controls.Add(this.BiteWiseLogo);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.SignUpLb);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.EmailLB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BiteWiseLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label SignUpLb;
        private System.Windows.Forms.LinkLabel Signup;
        private System.Windows.Forms.PictureBox BiteWiseLogo;
    }
}

