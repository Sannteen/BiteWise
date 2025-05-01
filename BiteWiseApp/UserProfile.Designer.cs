namespace BiteWiseApp
{
    partial class UserProfileForm
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.UserProfilelabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.Goallabel = new System.Windows.Forms.Label();
            this.TargetWgtlabel = new System.Windows.Forms.Label();
            this.DCaloricTgetLabel = new System.Windows.Forms.Label();
            this.UploadImageButton = new System.Windows.Forms.Button();
            this.Biometricdatalabel = new System.Windows.Forms.Label();
            this.PasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.Editbutton = new System.Windows.Forms.Button();
            this.AgenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TargetWeightnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DailyCalTarnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UpdatePasswordbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.DeleteProfilebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetWeightnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyCalTarnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(143, 311);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(174, 31);
            this.nametextBox.TabIndex = 6;
            
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(80, 319);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(80, 356);
            this.Emaillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(58, 25);
            this.Emaillabel.TabIndex = 8;
            this.Emaillabel.Text = "Email";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(143, 348);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(173, 31);
            this.EmailtextBox.TabIndex = 9;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(80, 393);
            this.Passwordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(92, 25);
            this.Passwordlabel.TabIndex = 10;
            this.Passwordlabel.Text = "Password";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(143, 385);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(176, 31);
            this.PasswordtextBox.TabIndex = 11;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SaveChangesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveChangesButton.Location = new System.Drawing.Point(674, 479);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(154, 31);
            this.SaveChangesButton.TabIndex = 12;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // UserProfilelabel
            // 
            this.UserProfilelabel.AutoSize = true;
            this.UserProfilelabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfilelabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.UserProfilelabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserProfilelabel.Location = new System.Drawing.Point(354, 7);
            this.UserProfilelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserProfilelabel.Name = "UserProfilelabel";
            this.UserProfilelabel.Size = new System.Drawing.Size(314, 56);
            this.UserProfilelabel.TabIndex = 13;
            this.UserProfilelabel.Text = "User Profile";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(411, 127);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(46, 25);
            this.AgeLabel.TabIndex = 14;
            this.AgeLabel.Text = "Age";
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weightlabel.Location = new System.Drawing.Point(411, 202);
            this.Weightlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(114, 25);
            this.Weightlabel.TabIndex = 15;
            this.Weightlabel.Text = "Weight (kg)";
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlabel.Location = new System.Drawing.Point(411, 164);
            this.Heightlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(114, 25);
            this.Heightlabel.TabIndex = 16;
            this.Heightlabel.Text = "Height (cm)";
            // 
            // Goallabel
            // 
            this.Goallabel.AutoSize = true;
            this.Goallabel.BackColor = System.Drawing.SystemColors.Control;
            this.Goallabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goallabel.Location = new System.Drawing.Point(484, 292);
            this.Goallabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Goallabel.Name = "Goallabel";
            this.Goallabel.Size = new System.Drawing.Size(73, 30);
            this.Goallabel.TabIndex = 20;
            this.Goallabel.Text = "Goals";
            // 
            // TargetWgtlabel
            // 
            this.TargetWgtlabel.AutoSize = true;
            this.TargetWgtlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetWgtlabel.Location = new System.Drawing.Point(411, 338);
            this.TargetWgtlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TargetWgtlabel.Name = "TargetWgtlabel";
            this.TargetWgtlabel.Size = new System.Drawing.Size(154, 25);
            this.TargetWgtlabel.TabIndex = 21;
            this.TargetWgtlabel.Text = "Targeted Weight";
            // 
            // DCaloricTgetLabel
            // 
            this.DCaloricTgetLabel.AutoSize = true;
            this.DCaloricTgetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCaloricTgetLabel.Location = new System.Drawing.Point(411, 380);
            this.DCaloricTgetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DCaloricTgetLabel.Name = "DCaloricTgetLabel";
            this.DCaloricTgetLabel.Size = new System.Drawing.Size(177, 25);
            this.DCaloricTgetLabel.TabIndex = 23;
            this.DCaloricTgetLabel.Text = "Daily Caloric Target";
            // 
            // UploadImageButton
            // 
            this.UploadImageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UploadImageButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImageButton.Location = new System.Drawing.Point(159, 268);
            this.UploadImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadImageButton.Name = "UploadImageButton";
            this.UploadImageButton.Size = new System.Drawing.Size(89, 22);
            this.UploadImageButton.TabIndex = 42;
            this.UploadImageButton.Text = "Upload ";
            this.UploadImageButton.UseVisualStyleBackColor = true;
            this.UploadImageButton.Click += new System.EventHandler(this.UploadImageButton_Click);
            // 
            // Biometricdatalabel
            // 
            this.Biometricdatalabel.AutoSize = true;
            this.Biometricdatalabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biometricdatalabel.Location = new System.Drawing.Point(438, 89);
            this.Biometricdatalabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Biometricdatalabel.Name = "Biometricdatalabel";
            this.Biometricdatalabel.Size = new System.Drawing.Size(175, 30);
            this.Biometricdatalabel.TabIndex = 50;
            this.Biometricdatalabel.Text = "Biometric Data";
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.AutoSize = true;
            this.PasswordcheckBox.Location = new System.Drawing.Point(325, 394);
            this.PasswordcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(22, 21);
            this.PasswordcheckBox.TabIndex = 53;
            this.PasswordcheckBox.UseVisualStyleBackColor = true;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.PasswordcheckBox_CheckedChanged);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.DarkCyan;
            this.Editbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Editbutton.Location = new System.Drawing.Point(504, 479);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(123, 31);
            this.Editbutton.TabIndex = 61;
            this.Editbutton.Text = "Edit Profile";
            this.Editbutton.UseVisualStyleBackColor = false;
            // 
            // AgenumericUpDown
            // 
            this.AgenumericUpDown.AllowDrop = true;
            this.AgenumericUpDown.Location = new System.Drawing.Point(504, 128);
            this.AgenumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.AgenumericUpDown.Name = "AgenumericUpDown";
            this.AgenumericUpDown.Size = new System.Drawing.Size(74, 31);
            this.AgenumericUpDown.TabIndex = 62;
            // 
            // WeightnumericUpDown
            // 
            this.WeightnumericUpDown.AllowDrop = true;
            this.WeightnumericUpDown.DecimalPlaces = 1;
            this.WeightnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.WeightnumericUpDown.Location = new System.Drawing.Point(504, 201);
            this.WeightnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.WeightnumericUpDown.Name = "WeightnumericUpDown";
            this.WeightnumericUpDown.Size = new System.Drawing.Size(74, 31);
            this.WeightnumericUpDown.TabIndex = 63;
            // 
            // HeightnumericUpDown
            // 
            this.HeightnumericUpDown.AllowDrop = true;
            this.HeightnumericUpDown.Location = new System.Drawing.Point(504, 163);
            this.HeightnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.HeightnumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.HeightnumericUpDown.Name = "HeightnumericUpDown";
            this.HeightnumericUpDown.Size = new System.Drawing.Size(74, 31);
            this.HeightnumericUpDown.TabIndex = 64;
            // 
            // TargetWeightnumericUpDown
            // 
            this.TargetWeightnumericUpDown.DecimalPlaces = 1;
            this.TargetWeightnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TargetWeightnumericUpDown.Location = new System.Drawing.Point(526, 330);
            this.TargetWeightnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.TargetWeightnumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TargetWeightnumericUpDown.Name = "TargetWeightnumericUpDown";
            this.TargetWeightnumericUpDown.Size = new System.Drawing.Size(68, 31);
            this.TargetWeightnumericUpDown.TabIndex = 65;
            // 
            // DailyCalTarnumericUpDown
            // 
            this.DailyCalTarnumericUpDown.AllowDrop = true;
            this.DailyCalTarnumericUpDown.DecimalPlaces = 1;
            this.DailyCalTarnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DailyCalTarnumericUpDown.Location = new System.Drawing.Point(528, 372);
            this.DailyCalTarnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.DailyCalTarnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DailyCalTarnumericUpDown.Name = "DailyCalTarnumericUpDown";
            this.DailyCalTarnumericUpDown.Size = new System.Drawing.Size(68, 31);
            this.DailyCalTarnumericUpDown.TabIndex = 66;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePictureBox.Image = global::BiteWiseApp.Properties.Resources.Profile_pic_ph2;
            this.ProfilePictureBox.Location = new System.Drawing.Point(116, 79);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(185, 185);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfilePictureBox.TabIndex = 67;
            this.ProfilePictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdatePasswordbutton
            // 
            this.UpdatePasswordbutton.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePasswordbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePasswordbutton.ForeColor = System.Drawing.Color.Black;
            this.UpdatePasswordbutton.Location = new System.Drawing.Point(714, 199);
            this.UpdatePasswordbutton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdatePasswordbutton.Name = "UpdatePasswordbutton";
            this.UpdatePasswordbutton.Size = new System.Drawing.Size(174, 31);
            this.UpdatePasswordbutton.TabIndex = 69;
            this.UpdatePasswordbutton.Text = "Update Password";
            this.UpdatePasswordbutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 70;
            this.label1.Text = "Settings ";
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.Transparent;
            this.Helpbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.ForeColor = System.Drawing.Color.Black;
            this.Helpbutton.Location = new System.Drawing.Point(714, 146);
            this.Helpbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(114, 31);
            this.Helpbutton.TabIndex = 71;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = false;
            // 
            // DeleteProfilebutton
            // 
            this.DeleteProfilebutton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteProfilebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProfilebutton.ForeColor = System.Drawing.Color.Black;
            this.DeleteProfilebutton.Location = new System.Drawing.Point(714, 259);
            this.DeleteProfilebutton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteProfilebutton.Name = "DeleteProfilebutton";
            this.DeleteProfilebutton.Size = new System.Drawing.Size(174, 31);
            this.DeleteProfilebutton.TabIndex = 72;
            this.DeleteProfilebutton.Text = "Delete Profile ";
            this.DeleteProfilebutton.UseVisualStyleBackColor = false;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 542);
            this.Controls.Add(this.DeleteProfilebutton);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdatePasswordbutton);
            this.Controls.Add(this.ProfilePictureBox);
            this.Controls.Add(this.DailyCalTarnumericUpDown);
            this.Controls.Add(this.TargetWeightnumericUpDown);
            this.Controls.Add(this.HeightnumericUpDown);
            this.Controls.Add(this.WeightnumericUpDown);
            this.Controls.Add(this.AgenumericUpDown);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.Biometricdatalabel);
            this.Controls.Add(this.UploadImageButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.DCaloricTgetLabel);
            this.Controls.Add(this.TargetWgtlabel);
            this.Controls.Add(this.Goallabel);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.Weightlabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.UserProfilelabel);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserProfileForm";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetWeightnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyCalTarnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label UserProfilelabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label Goallabel;
        private System.Windows.Forms.Label TargetWgtlabel;
        private System.Windows.Forms.Label DCaloricTgetLabel;
        private System.Windows.Forms.Button UploadImageButton;
        private System.Windows.Forms.Label Biometricdatalabel;
        private System.Windows.Forms.CheckBox PasswordcheckBox;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.NumericUpDown AgenumericUpDown;
        private System.Windows.Forms.NumericUpDown WeightnumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightnumericUpDown;
        private System.Windows.Forms.NumericUpDown TargetWeightnumericUpDown;
        private System.Windows.Forms.NumericUpDown DailyCalTarnumericUpDown;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UpdatePasswordbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button DeleteProfilebutton;
    }
}

