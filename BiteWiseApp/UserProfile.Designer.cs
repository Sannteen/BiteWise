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
            this.profilepicture = new System.Windows.Forms.PictureBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.savechangesbutn = new System.Windows.Forms.Button();
            this.UserProfilelabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.AgetxtBox = new System.Windows.Forms.TextBox();
            this.HeighttxtBox1 = new System.Windows.Forms.TextBox();
            this.WeighttxtBox = new System.Windows.Forms.TextBox();
            this.Goallabel = new System.Windows.Forms.Label();
            this.TargetWgtlabel = new System.Windows.Forms.Label();
            this.Targetwgttxtbx = new System.Windows.Forms.TextBox();
            this.DCaloricTgetLabel = new System.Windows.Forms.Label();
            this.DCaloricTgetTxtbx = new System.Windows.Forms.TextBox();
            this.WklyWgtgoalslabel = new System.Windows.Forms.Label();
            this.Sundaylabel = new System.Windows.Forms.Label();
            this.SaturdayLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.ThursdayLabel = new System.Windows.Forms.Label();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.SuntextBox = new System.Windows.Forms.TextBox();
            this.MontextBox = new System.Windows.Forms.TextBox();
            this.TuestextBox = new System.Windows.Forms.TextBox();
            this.WedtextBox = new System.Windows.Forms.TextBox();
            this.ThurstextBox = new System.Windows.Forms.TextBox();
            this.FritextBox = new System.Windows.Forms.TextBox();
            this.SattextBox = new System.Windows.Forms.TextBox();
            this.PicUploadbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Biometricdatalabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilepicture
            // 
            this.profilepicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.profilepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profilepicture.Location = new System.Drawing.Point(28, 83);
            this.profilepicture.Name = "profilepicture";
            this.profilepicture.Size = new System.Drawing.Size(256, 229);
            this.profilepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepicture.TabIndex = 5;
            this.profilepicture.TabStop = false;
            this.profilepicture.Click += new System.EventHandler(this.profilepicture_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(25, 427);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(206, 26);
            this.nametextBox.TabIndex = 6;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 399);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(23, 472);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(58, 25);
            this.Emaillabel.TabIndex = 8;
            this.Emaillabel.Text = "Email";
            this.Emaillabel.Click += new System.EventHandler(this.Emaillabel_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(25, 500);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(206, 26);
            this.EmailtextBox.TabIndex = 9;
            this.EmailtextBox.TextChanged += new System.EventHandler(this.EmailtextBox_TextChanged);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(23, 545);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(92, 25);
            this.Passwordlabel.TabIndex = 10;
            this.Passwordlabel.Text = "Password";
            this.Passwordlabel.Click += new System.EventHandler(this.Passwordlabel_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(24, 573);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(206, 26);
            this.PasswordtextBox.TabIndex = 11;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // savechangesbutn
            // 
            this.savechangesbutn.BackColor = System.Drawing.Color.White;
            this.savechangesbutn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savechangesbutn.Location = new System.Drawing.Point(68, 629);
            this.savechangesbutn.Name = "savechangesbutn";
            this.savechangesbutn.Size = new System.Drawing.Size(147, 33);
            this.savechangesbutn.TabIndex = 12;
            this.savechangesbutn.Text = "Save Changes";
            this.savechangesbutn.UseVisualStyleBackColor = false;
            this.savechangesbutn.Click += new System.EventHandler(this.savechangesbutn_Click);
            // 
            // UserProfilelabel
            // 
            this.UserProfilelabel.AutoSize = true;
            this.UserProfilelabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfilelabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserProfilelabel.Location = new System.Drawing.Point(325, 9);
            this.UserProfilelabel.Name = "UserProfilelabel";
            this.UserProfilelabel.Size = new System.Drawing.Size(314, 56);
            this.UserProfilelabel.TabIndex = 13;
            this.UserProfilelabel.Text = "User Profile";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(462, 139);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(46, 25);
            this.AgeLabel.TabIndex = 14;
            this.AgeLabel.Text = "Age";
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weightlabel.Location = new System.Drawing.Point(462, 238);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(74, 25);
            this.Weightlabel.TabIndex = 15;
            this.Weightlabel.Text = "Weight";
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlabel.Location = new System.Drawing.Point(462, 187);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(70, 25);
            this.Heightlabel.TabIndex = 16;
            this.Heightlabel.Text = "Height";
            // 
            // AgetxtBox
            // 
            this.AgetxtBox.Location = new System.Drawing.Point(557, 138);
            this.AgetxtBox.Name = "AgetxtBox";
            this.AgetxtBox.Size = new System.Drawing.Size(115, 26);
            this.AgetxtBox.TabIndex = 17;
            this.AgetxtBox.TextChanged += new System.EventHandler(this.AgetxtBox_TextChanged);
            // 
            // HeighttxtBox1
            // 
            this.HeighttxtBox1.Location = new System.Drawing.Point(557, 186);
            this.HeighttxtBox1.Name = "HeighttxtBox1";
            this.HeighttxtBox1.Size = new System.Drawing.Size(115, 26);
            this.HeighttxtBox1.TabIndex = 18;
            this.HeighttxtBox1.TextChanged += new System.EventHandler(this.HeighttxtBox1_TextChanged);
            // 
            // WeighttxtBox
            // 
            this.WeighttxtBox.Location = new System.Drawing.Point(557, 237);
            this.WeighttxtBox.Name = "WeighttxtBox";
            this.WeighttxtBox.Size = new System.Drawing.Size(115, 26);
            this.WeighttxtBox.TabIndex = 19;
            // 
            // Goallabel
            // 
            this.Goallabel.AutoSize = true;
            this.Goallabel.BackColor = System.Drawing.SystemColors.Control;
            this.Goallabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goallabel.Location = new System.Drawing.Point(389, 288);
            this.Goallabel.Name = "Goallabel";
            this.Goallabel.Size = new System.Drawing.Size(73, 30);
            this.Goallabel.TabIndex = 20;
            this.Goallabel.Text = "Goals";
            // 
            // TargetWgtlabel
            // 
            this.TargetWgtlabel.AutoSize = true;
            this.TargetWgtlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetWgtlabel.Location = new System.Drawing.Point(462, 332);
            this.TargetWgtlabel.Name = "TargetWgtlabel";
            this.TargetWgtlabel.Size = new System.Drawing.Size(154, 25);
            this.TargetWgtlabel.TabIndex = 21;
            this.TargetWgtlabel.Text = "Targeted Weight";
            // 
            // Targetwgttxtbx
            // 
            this.Targetwgttxtbx.Location = new System.Drawing.Point(624, 331);
            this.Targetwgttxtbx.Name = "Targetwgttxtbx";
            this.Targetwgttxtbx.Size = new System.Drawing.Size(127, 26);
            this.Targetwgttxtbx.TabIndex = 22;
            // 
            // DCaloricTgetLabel
            // 
            this.DCaloricTgetLabel.AutoSize = true;
            this.DCaloricTgetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCaloricTgetLabel.Location = new System.Drawing.Point(462, 378);
            this.DCaloricTgetLabel.Name = "DCaloricTgetLabel";
            this.DCaloricTgetLabel.Size = new System.Drawing.Size(177, 25);
            this.DCaloricTgetLabel.TabIndex = 23;
            this.DCaloricTgetLabel.Text = "Daily Caloric Target";
            this.DCaloricTgetLabel.Click += new System.EventHandler(this.DCaloricTgetLabel_Click);
            // 
            // DCaloricTgetTxtbx
            // 
            this.DCaloricTgetTxtbx.Location = new System.Drawing.Point(647, 379);
            this.DCaloricTgetTxtbx.Name = "DCaloricTgetTxtbx";
            this.DCaloricTgetTxtbx.Size = new System.Drawing.Size(104, 26);
            this.DCaloricTgetTxtbx.TabIndex = 24;
            // 
            // WklyWgtgoalslabel
            // 
            this.WklyWgtgoalslabel.AutoSize = true;
            this.WklyWgtgoalslabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WklyWgtgoalslabel.Location = new System.Drawing.Point(389, 452);
            this.WklyWgtgoalslabel.Name = "WklyWgtgoalslabel";
            this.WklyWgtgoalslabel.Size = new System.Drawing.Size(244, 30);
            this.WklyWgtgoalslabel.TabIndex = 25;
            this.WklyWgtgoalslabel.Text = "Weekly Weight Goals";
            // 
            // Sundaylabel
            // 
            this.Sundaylabel.AutoSize = true;
            this.Sundaylabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sundaylabel.Location = new System.Drawing.Point(458, 535);
            this.Sundaylabel.Name = "Sundaylabel";
            this.Sundaylabel.Size = new System.Drawing.Size(44, 25);
            this.Sundaylabel.TabIndex = 26;
            this.Sundaylabel.Text = "Sun";
            // 
            // SaturdayLabel
            // 
            this.SaturdayLabel.AutoSize = true;
            this.SaturdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayLabel.Location = new System.Drawing.Point(652, 606);
            this.SaturdayLabel.Name = "SaturdayLabel";
            this.SaturdayLabel.Size = new System.Drawing.Size(39, 25);
            this.SaturdayLabel.TabIndex = 27;
            this.SaturdayLabel.Text = "Sat";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayLabel.Location = new System.Drawing.Point(562, 606);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(33, 25);
            this.FridayLabel.TabIndex = 28;
            this.FridayLabel.Text = "Fri";
            // 
            // ThursdayLabel
            // 
            this.ThursdayLabel.AutoSize = true;
            this.ThursdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayLabel.Location = new System.Drawing.Point(448, 606);
            this.ThursdayLabel.Name = "ThursdayLabel";
            this.ThursdayLabel.Size = new System.Drawing.Size(60, 25);
            this.ThursdayLabel.TabIndex = 29;
            this.ThursdayLabel.Text = "Thurs";
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayLabel.Location = new System.Drawing.Point(738, 535);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(51, 25);
            this.WednesdayLabel.TabIndex = 30;
            this.WednesdayLabel.Text = "Wed";
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayLabel.Location = new System.Drawing.Point(642, 535);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(51, 25);
            this.TuesdayLabel.TabIndex = 31;
            this.TuesdayLabel.Text = "Tues";
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayLabel.Location = new System.Drawing.Point(552, 535);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(51, 25);
            this.MondayLabel.TabIndex = 32;
            this.MondayLabel.Text = "Mon";
            // 
            // SuntextBox
            // 
            this.SuntextBox.Location = new System.Drawing.Point(439, 500);
            this.SuntextBox.Name = "SuntextBox";
            this.SuntextBox.Size = new System.Drawing.Size(78, 26);
            this.SuntextBox.TabIndex = 33;
            // 
            // MontextBox
            // 
            this.MontextBox.Location = new System.Drawing.Point(538, 500);
            this.MontextBox.Name = "MontextBox";
            this.MontextBox.Size = new System.Drawing.Size(78, 26);
            this.MontextBox.TabIndex = 34;
            // 
            // TuestextBox
            // 
            this.TuestextBox.Location = new System.Drawing.Point(633, 500);
            this.TuestextBox.Name = "TuestextBox";
            this.TuestextBox.Size = new System.Drawing.Size(78, 26);
            this.TuestextBox.TabIndex = 35;
            // 
            // WedtextBox
            // 
            this.WedtextBox.Location = new System.Drawing.Point(726, 500);
            this.WedtextBox.Name = "WedtextBox";
            this.WedtextBox.Size = new System.Drawing.Size(78, 26);
            this.WedtextBox.TabIndex = 36;
            // 
            // ThurstextBox
            // 
            this.ThurstextBox.Location = new System.Drawing.Point(439, 577);
            this.ThurstextBox.Name = "ThurstextBox";
            this.ThurstextBox.Size = new System.Drawing.Size(78, 26);
            this.ThurstextBox.TabIndex = 37;
            // 
            // FritextBox
            // 
            this.FritextBox.Location = new System.Drawing.Point(538, 577);
            this.FritextBox.Name = "FritextBox";
            this.FritextBox.Size = new System.Drawing.Size(78, 26);
            this.FritextBox.TabIndex = 38;
            // 
            // SattextBox
            // 
            this.SattextBox.Location = new System.Drawing.Point(633, 577);
            this.SattextBox.Name = "SattextBox";
            this.SattextBox.Size = new System.Drawing.Size(78, 26);
            this.SattextBox.TabIndex = 39;
            // 
            // PicUploadbutton
            // 
            this.PicUploadbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicUploadbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicUploadbutton.Location = new System.Drawing.Point(102, 332);
            this.PicUploadbutton.Name = "PicUploadbutton";
            this.PicUploadbutton.Size = new System.Drawing.Size(113, 34);
            this.PicUploadbutton.TabIndex = 42;
            this.PicUploadbutton.Text = "Upload";
            this.PicUploadbutton.UseVisualStyleBackColor = true;
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(237, 429);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(47, 24);
            this.editbutton.TabIndex = 44;
            this.editbutton.Text = "edit cahnges";
            this.editbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 24);
            this.button1.TabIndex = 45;
            this.button1.Text = "edit cahnges";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 24);
            this.button2.TabIndex = 46;
            this.button2.Text = "edit cahnges";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 24);
            this.button3.TabIndex = 47;
            this.button3.Text = "edit cahnges";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 24);
            this.button4.TabIndex = 48;
            this.button4.Text = "edit cahnges";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(687, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 24);
            this.button5.TabIndex = 49;
            this.button5.Text = "edit cahnges";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Biometricdatalabel
            // 
            this.Biometricdatalabel.AutoSize = true;
            this.Biometricdatalabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biometricdatalabel.Location = new System.Drawing.Point(389, 83);
            this.Biometricdatalabel.Name = "Biometricdatalabel";
            this.Biometricdatalabel.Size = new System.Drawing.Size(175, 30);
            this.Biometricdatalabel.TabIndex = 50;
            this.Biometricdatalabel.Text = "Biometric Data";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(757, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 24);
            this.button6.TabIndex = 51;
            this.button6.Text = "edit cahnges";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(757, 381);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 24);
            this.button7.TabIndex = 52;
            this.button7.Text = "edit cahnges";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 686);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Biometricdatalabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PicUploadbutton);
            this.Controls.Add(this.profilepicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.WklyWgtgoalslabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.Sundaylabel);
            this.Controls.Add(this.SattextBox);
            this.Controls.Add(this.SaturdayLabel);
            this.Controls.Add(this.DCaloricTgetTxtbx);
            this.Controls.Add(this.FritextBox);
            this.Controls.Add(this.DCaloricTgetLabel);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.Targetwgttxtbx);
            this.Controls.Add(this.ThurstextBox);
            this.Controls.Add(this.TargetWgtlabel);
            this.Controls.Add(this.ThursdayLabel);
            this.Controls.Add(this.Goallabel);
            this.Controls.Add(this.WedtextBox);
            this.Controls.Add(this.WeighttxtBox);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.HeighttxtBox1);
            this.Controls.Add(this.TuestextBox);
            this.Controls.Add(this.AgetxtBox);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.MontextBox);
            this.Controls.Add(this.Weightlabel);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SuntextBox);
            this.Controls.Add(this.UserProfilelabel);
            this.Controls.Add(this.savechangesbutn);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Emaillabel);
            this.Name = "UserProfileForm";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox profilepicture;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button savechangesbutn;
        private System.Windows.Forms.Label UserProfilelabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.TextBox AgetxtBox;
        private System.Windows.Forms.TextBox HeighttxtBox1;
        private System.Windows.Forms.TextBox WeighttxtBox;
        private System.Windows.Forms.Label Goallabel;
        private System.Windows.Forms.Label TargetWgtlabel;
        private System.Windows.Forms.TextBox Targetwgttxtbx;
        private System.Windows.Forms.Label DCaloricTgetLabel;
        private System.Windows.Forms.TextBox DCaloricTgetTxtbx;
        private System.Windows.Forms.Label WklyWgtgoalslabel;
        private System.Windows.Forms.Label Sundaylabel;
        private System.Windows.Forms.Label SaturdayLabel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Label ThursdayLabel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.TextBox SuntextBox;
        private System.Windows.Forms.TextBox MontextBox;
        private System.Windows.Forms.TextBox TuestextBox;
        private System.Windows.Forms.TextBox WedtextBox;
        private System.Windows.Forms.TextBox ThurstextBox;
        private System.Windows.Forms.TextBox FritextBox;
        private System.Windows.Forms.TextBox SattextBox;
        private System.Windows.Forms.Button PicUploadbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Biometricdatalabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

