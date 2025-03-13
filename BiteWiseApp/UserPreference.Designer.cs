namespace BiteWiseApp
{
    partial class UserPreferences
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
            this.SetNewCalorieGoalBox = new System.Windows.Forms.TextBox();
            this.ChangeUserPasswordButton = new System.Windows.Forms.Button();
            this.UpdateFoodPrefencesLabel = new System.Windows.Forms.Label();
            this.UpdateFoodAllergiesLabel = new System.Windows.Forms.Label();
            this.UpdateDietTypeLabel = new System.Windows.Forms.Label();
            this.SetNewCalorieGoalLabel = new System.Windows.Forms.Label();
            this.UpdateFoodPreferencesBox = new System.Windows.Forms.ComboBox();
            this.UpdateFoodAllergiesBox = new System.Windows.Forms.ComboBox();
            this.UpdateDietTypeBox = new System.Windows.Forms.ComboBox();
            this.UserPreferencesPgLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetNewCalorieGoalBox
            // 
            this.SetNewCalorieGoalBox.Location = new System.Drawing.Point(75, 259);
            this.SetNewCalorieGoalBox.Name = "SetNewCalorieGoalBox";
            this.SetNewCalorieGoalBox.Size = new System.Drawing.Size(210, 26);
            this.SetNewCalorieGoalBox.TabIndex = 3;
            // 
            // ChangeUserPasswordButton
            // 
            this.ChangeUserPasswordButton.Location = new System.Drawing.Point(75, 332);
            this.ChangeUserPasswordButton.Name = "ChangeUserPasswordButton";
            this.ChangeUserPasswordButton.Size = new System.Drawing.Size(228, 50);
            this.ChangeUserPasswordButton.TabIndex = 4;
            this.ChangeUserPasswordButton.Text = "Change User Password";
            this.ChangeUserPasswordButton.UseVisualStyleBackColor = true;
            // 
            // UpdateFoodPrefencesLabel
            // 
            this.UpdateFoodPrefencesLabel.AutoSize = true;
            this.UpdateFoodPrefencesLabel.Location = new System.Drawing.Point(73, 74);
            this.UpdateFoodPrefencesLabel.Name = "UpdateFoodPrefencesLabel";
            this.UpdateFoodPrefencesLabel.Size = new System.Drawing.Size(193, 20);
            this.UpdateFoodPrefencesLabel.TabIndex = 5;
            this.UpdateFoodPrefencesLabel.Text = "Update Food Preferences";
            this.UpdateFoodPrefencesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateFoodAllergiesLabel
            // 
            this.UpdateFoodAllergiesLabel.AllowDrop = true;
            this.UpdateFoodAllergiesLabel.AutoSize = true;
            this.UpdateFoodAllergiesLabel.Location = new System.Drawing.Point(433, 74);
            this.UpdateFoodAllergiesLabel.Name = "UpdateFoodAllergiesLabel";
            this.UpdateFoodAllergiesLabel.Size = new System.Drawing.Size(167, 20);
            this.UpdateFoodAllergiesLabel.TabIndex = 6;
            this.UpdateFoodAllergiesLabel.Text = "Update Food Allergies";
            // 
            // UpdateDietTypeLabel
            // 
            this.UpdateDietTypeLabel.AllowDrop = true;
            this.UpdateDietTypeLabel.AutoSize = true;
            this.UpdateDietTypeLabel.Location = new System.Drawing.Point(71, 152);
            this.UpdateDietTypeLabel.Name = "UpdateDietTypeLabel";
            this.UpdateDietTypeLabel.Size = new System.Drawing.Size(133, 20);
            this.UpdateDietTypeLabel.TabIndex = 7;
            this.UpdateDietTypeLabel.Text = "Update Diet Type";
            // 
            // SetNewCalorieGoalLabel
            // 
            this.SetNewCalorieGoalLabel.AutoSize = true;
            this.SetNewCalorieGoalLabel.Location = new System.Drawing.Point(75, 238);
            this.SetNewCalorieGoalLabel.Name = "SetNewCalorieGoalLabel";
            this.SetNewCalorieGoalLabel.Size = new System.Drawing.Size(196, 20);
            this.SetNewCalorieGoalLabel.TabIndex = 8;
            this.SetNewCalorieGoalLabel.Text = "Set new Daily Calorie Goal";
            this.SetNewCalorieGoalLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // UpdateFoodPreferencesBox
            // 
            this.UpdateFoodPreferencesBox.FormattingEnabled = true;
            this.UpdateFoodPreferencesBox.Location = new System.Drawing.Point(75, 95);
            this.UpdateFoodPreferencesBox.Name = "UpdateFoodPreferencesBox";
            this.UpdateFoodPreferencesBox.Size = new System.Drawing.Size(210, 28);
            this.UpdateFoodPreferencesBox.TabIndex = 9;
            // 
            // UpdateFoodAllergiesBox
            // 
            this.UpdateFoodAllergiesBox.FormattingEnabled = true;
            this.UpdateFoodAllergiesBox.Location = new System.Drawing.Point(437, 95);
            this.UpdateFoodAllergiesBox.Name = "UpdateFoodAllergiesBox";
            this.UpdateFoodAllergiesBox.Size = new System.Drawing.Size(226, 28);
            this.UpdateFoodAllergiesBox.TabIndex = 10;
            // 
            // UpdateDietTypeBox
            // 
            this.UpdateDietTypeBox.FormattingEnabled = true;
            this.UpdateDietTypeBox.Location = new System.Drawing.Point(75, 185);
            this.UpdateDietTypeBox.Name = "UpdateDietTypeBox";
            this.UpdateDietTypeBox.Size = new System.Drawing.Size(209, 28);
            this.UpdateDietTypeBox.TabIndex = 11;
            // 
            // UserPreferencesPgLogo
            // 
            this.UserPreferencesPgLogo.AutoSize = true;
            this.UserPreferencesPgLogo.Font = new System.Drawing.Font("Juice ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPreferencesPgLogo.ForeColor = System.Drawing.Color.Red;
            this.UserPreferencesPgLogo.Location = new System.Drawing.Point(418, 294);
            this.UserPreferencesPgLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserPreferencesPgLogo.Name = "UserPreferencesPgLogo";
            this.UserPreferencesPgLogo.Size = new System.Drawing.Size(279, 109);
            this.UserPreferencesPgLogo.TabIndex = 12;
            this.UserPreferencesPgLogo.Text = "BiteWise";
            // 
            // UserPreferences
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserPreferencesPgLogo);
            this.Controls.Add(this.UpdateDietTypeBox);
            this.Controls.Add(this.UpdateFoodAllergiesBox);
            this.Controls.Add(this.UpdateFoodPreferencesBox);
            this.Controls.Add(this.SetNewCalorieGoalLabel);
            this.Controls.Add(this.UpdateDietTypeLabel);
            this.Controls.Add(this.UpdateFoodAllergiesLabel);
            this.Controls.Add(this.UpdateFoodPrefencesLabel);
            this.Controls.Add(this.ChangeUserPasswordButton);
            this.Controls.Add(this.SetNewCalorieGoalBox);
            this.Name = "UserPreferences";
            this.Text = "User Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SetNewCalorieGoalBox;
        private System.Windows.Forms.Button ChangeUserPasswordButton;
        private System.Windows.Forms.Label UpdateFoodPrefencesLabel;
        private System.Windows.Forms.Label UpdateFoodAllergiesLabel;
        private System.Windows.Forms.Label UpdateDietTypeLabel;
        private System.Windows.Forms.Label SetNewCalorieGoalLabel;
        private System.Windows.Forms.ComboBox UpdateFoodPreferencesBox;
        private System.Windows.Forms.ComboBox UpdateFoodAllergiesBox;
        private System.Windows.Forms.ComboBox UpdateDietTypeBox;
        private System.Windows.Forms.Label UserPreferencesPgLogo;
    }
}