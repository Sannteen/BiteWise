namespace BiteWiseApp
{
    partial class ExerciseAndFoodLog
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
            this.userWorklogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FoodLoglb = new System.Windows.Forms.Label();
            this.AddLogfoodBT = new System.Windows.Forms.Button();
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.ServingtextBox = new System.Windows.Forms.TextBox();
            this.TypeLB = new System.Windows.Forms.Label();
            this.ServingLB = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FoodSelectLB = new System.Windows.Forms.Label();
            this.ExeLogLb = new System.Windows.Forms.Label();
            this.AddLogExeBT = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BurnedCalLB = new System.Windows.Forms.Label();
            this.DurationLB = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SelectExeLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userWorklogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userWorklogBindingSource
            // 
            this.userWorklogBindingSource.DataMember = "User_Work_log";
            this.userWorklogBindingSource.CurrentChanged += new System.EventHandler(this.userWorklogBindingSource_CurrentChanged);
            // 
            // FoodLoglb
            // 
            this.FoodLoglb.AutoSize = true;
            this.FoodLoglb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodLoglb.Location = new System.Drawing.Point(101, 17);
            this.FoodLoglb.Name = "FoodLoglb";
            this.FoodLoglb.Size = new System.Drawing.Size(89, 21);
            this.FoodLoglb.TabIndex = 19;
            this.FoodLoglb.Text = "FOOD LOG";
            // 
            // AddLogfoodBT
            // 
            this.AddLogfoodBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.AddLogfoodBT.ForeColor = System.Drawing.Color.White;
            this.AddLogfoodBT.Location = new System.Drawing.Point(109, 153);
            this.AddLogfoodBT.Name = "AddLogfoodBT";
            this.AddLogfoodBT.Size = new System.Drawing.Size(75, 23);
            this.AddLogfoodBT.TabIndex = 18;
            this.AddLogfoodBT.Text = "Add to Log";
            this.AddLogfoodBT.UseVisualStyleBackColor = false;
            // 
            // TypetextBox
            // 
            this.TypetextBox.Location = new System.Drawing.Point(122, 117);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(121, 20);
            this.TypetextBox.TabIndex = 17;
            // 
            // ServingtextBox
            // 
            this.ServingtextBox.Location = new System.Drawing.Point(122, 86);
            this.ServingtextBox.Name = "ServingtextBox";
            this.ServingtextBox.Size = new System.Drawing.Size(121, 20);
            this.ServingtextBox.TabIndex = 16;
            // 
            // TypeLB
            // 
            this.TypeLB.AutoSize = true;
            this.TypeLB.Location = new System.Drawing.Point(48, 125);
            this.TypeLB.Name = "TypeLB";
            this.TypeLB.Size = new System.Drawing.Size(61, 15);
            this.TypeLB.TabIndex = 15;
            this.TypeLB.Text = "Meal Type";
            // 
            // ServingLB
            // 
            this.ServingLB.AutoSize = true;
            this.ServingLB.Location = new System.Drawing.Point(48, 94);
            this.ServingLB.Name = "ServingLB";
            this.ServingLB.Size = new System.Drawing.Size(46, 15);
            this.ServingLB.TabIndex = 14;
            this.ServingLB.Text = "Serving";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // FoodSelectLB
            // 
            this.FoodSelectLB.AutoSize = true;
            this.FoodSelectLB.Location = new System.Drawing.Point(48, 63);
            this.FoodSelectLB.Name = "FoodSelectLB";
            this.FoodSelectLB.Size = new System.Drawing.Size(68, 15);
            this.FoodSelectLB.TabIndex = 12;
            this.FoodSelectLB.Text = "Select Food";
            this.FoodSelectLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExeLogLb
            // 
            this.ExeLogLb.AutoSize = true;
            this.ExeLogLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExeLogLb.Location = new System.Drawing.Point(36, 17);
            this.ExeLogLb.Name = "ExeLogLb";
            this.ExeLogLb.Size = new System.Drawing.Size(116, 21);
            this.ExeLogLb.TabIndex = 25;
            this.ExeLogLb.Text = "EXERCISE LOG";
            // 
            // AddLogExeBT
            // 
            this.AddLogExeBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(199)))), ((int)(((byte)(181)))));
            this.AddLogExeBT.ForeColor = System.Drawing.Color.White;
            this.AddLogExeBT.Location = new System.Drawing.Point(117, 151);
            this.AddLogExeBT.Name = "AddLogExeBT";
            this.AddLogExeBT.Size = new System.Drawing.Size(75, 23);
            this.AddLogExeBT.TabIndex = 24;
            this.AddLogExeBT.Text = "Add to Log";
            this.AddLogExeBT.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 22;
            // 
            // BurnedCalLB
            // 
            this.BurnedCalLB.AutoSize = true;
            this.BurnedCalLB.Location = new System.Drawing.Point(37, 122);
            this.BurnedCalLB.Name = "BurnedCalLB";
            this.BurnedCalLB.Size = new System.Drawing.Size(90, 15);
            this.BurnedCalLB.TabIndex = 21;
            this.BurnedCalLB.Text = "Calories Burned";
            // 
            // DurationLB
            // 
            this.DurationLB.AutoSize = true;
            this.DurationLB.Location = new System.Drawing.Point(37, 90);
            this.DurationLB.Name = "DurationLB";
            this.DurationLB.Size = new System.Drawing.Size(53, 15);
            this.DurationLB.TabIndex = 20;
            this.DurationLB.Text = "Duration";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // SelectExeLB
            // 
            this.SelectExeLB.AutoSize = true;
            this.SelectExeLB.Location = new System.Drawing.Point(37, 58);
            this.SelectExeLB.Name = "SelectExeLB";
            this.SelectExeLB.Size = new System.Drawing.Size(82, 15);
            this.SelectExeLB.TabIndex = 18;
            this.SelectExeLB.Text = "Select Exercise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "FOOD AND WORK OUT LOG";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ExerciseAndFoodLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 596);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExerciseAndFoodLog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "id ";
            this.Load += new System.EventHandler(this.ExerciseSearchLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userWorklogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private User_ExerciseLog_ViewTableAdapters.User_Work_logTableAdapter user_Work_logTableAdapter;
        //private BiteWiseDBDataSet1 biteWiseDBDataSet1;
        private System.Windows.Forms.BindingSource userWorklogBindingSource;
       // private BiteWiseDBDataSet1TableAdapters.User_Work_logTableAdapter user_Work_logTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label FoodSelectLB;
        private System.Windows.Forms.TextBox TypetextBox;
        private System.Windows.Forms.TextBox ServingtextBox;
        private System.Windows.Forms.Label TypeLB;
        private System.Windows.Forms.Label ServingLB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddLogfoodBT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label BurnedCalLB;
        private System.Windows.Forms.Label DurationLB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label SelectExeLB;
        private System.Windows.Forms.Button AddLogExeBT;
        private System.Windows.Forms.Label FoodLoglb;
        private System.Windows.Forms.Label ExeLogLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCaloriesBurntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}