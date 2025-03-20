namespace BiteWiseApp
{
    partial class SignUp
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
            this.Savebtn = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoalLbl = new System.Windows.Forms.Label();
            this.ActivityLvlTB = new System.Windows.Forms.ComboBox();
            this.GoalTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Savebtn.Location = new System.Drawing.Point(376, 485);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(104, 44);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.Location = new System.Drawing.Point(138, 199);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(148, 20);
            this.NameTB.TabIndex = 1;
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(71, 204);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // EmailLbl
            // 
            this.EmailLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(330, 202);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 3;
            this.EmailLbl.Text = "Email";
            // 
            // EmailTB
            // 
            this.EmailTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTB.Location = new System.Drawing.Point(408, 197);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(148, 20);
            this.EmailTB.TabIndex = 4;
            // 
            // AgeTB
            // 
            this.AgeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeTB.Location = new System.Drawing.Point(138, 263);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(148, 20);
            this.AgeTB.TabIndex = 5;
            // 
            // AgeLbl
            // 
            this.AgeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(71, 270);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(26, 13);
            this.AgeLbl.TabIndex = 6;
            this.AgeLbl.Text = "Age";
            // 
            // GenderLbl
            // 
            this.GenderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(330, 270);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(42, 13);
            this.GenderLbl.TabIndex = 7;
            this.GenderLbl.Text = "Gender";
            // 
            // GenderCB
            // 
            this.GenderCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "",
            "Female",
            "Male",
            "Others"});
            this.GenderCB.Location = new System.Drawing.Point(408, 262);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(148, 21);
            this.GenderCB.TabIndex = 8;
            // 
            // WeightTB
            // 
            this.WeightTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTB.Location = new System.Drawing.Point(138, 326);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(148, 20);
            this.WeightTB.TabIndex = 1;
            // 
            // WeightLbl
            // 
            this.WeightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(71, 333);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(41, 13);
            this.WeightLbl.TabIndex = 2;
            this.WeightLbl.Text = "Weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(582, 270);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(38, 13);
            this.HeightLbl.TabIndex = 3;
            this.HeightLbl.Text = "Height";
            // 
            // HeightTB
            // 
            this.HeightTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTB.Location = new System.Drawing.Point(665, 262);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(148, 20);
            this.HeightTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Activity Lvl";
            // 
            // GoalLbl
            // 
            this.GoalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalLbl.AutoSize = true;
            this.GoalLbl.Location = new System.Drawing.Point(330, 333);
            this.GoalLbl.Name = "GoalLbl";
            this.GoalLbl.Size = new System.Drawing.Size(29, 13);
            this.GoalLbl.TabIndex = 7;
            this.GoalLbl.Text = "Goal";
            // 
            // ActivityLvlTB
            // 
            this.ActivityLvlTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivityLvlTB.FormattingEnabled = true;
            this.ActivityLvlTB.Items.AddRange(new object[] {
            "",
            "High",
            "Medium",
            "Low"});
            this.ActivityLvlTB.Location = new System.Drawing.Point(665, 325);
            this.ActivityLvlTB.Name = "ActivityLvlTB";
            this.ActivityLvlTB.Size = new System.Drawing.Size(148, 21);
            this.ActivityLvlTB.TabIndex = 8;
            // 
            // GoalTB
            // 
            this.GoalTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalTB.Location = new System.Drawing.Point(408, 326);
            this.GoalTB.Name = "GoalTB";
            this.GoalTB.Size = new System.Drawing.Size(148, 20);
            this.GoalTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(281, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Registration";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(582, 197);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTB.Location = new System.Drawing.Point(665, 194);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(148, 20);
            this.PasswordTB.TabIndex = 10;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 541);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActivityLvlTB);
            this.Controls.Add(this.GoalLbl);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.GoalTB);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.HeightTB);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.WeightTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.Savebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.TextBox WeightTB;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GoalLbl;
        private System.Windows.Forms.ComboBox ActivityLvlTB;
        private System.Windows.Forms.TextBox GoalTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTB;
    }
}