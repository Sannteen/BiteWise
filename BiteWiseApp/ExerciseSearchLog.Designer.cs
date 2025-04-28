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
            System.Windows.Forms.DataGridView dataGridView1;
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCaloriesBurntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userWorklogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biteWiseDBDataSet1 = new BiteWiseApp.BiteWiseDBDataSet1();
            this.user_Work_logTableAdapter = new BiteWiseApp.User_ExerciseLog_ViewTableAdapters.User_Work_logTableAdapter();
            this.user_Work_logTableAdapter1 = new BiteWiseApp.BiteWiseDBDataSet1TableAdapters.User_Work_logTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SearchNtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWorklogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biteWiseDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exerciseNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.totalCaloriesBurntDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridView1.DataSource = this.userWorklogBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new System.Drawing.Size(618, 327);
            dataGridView1.TabIndex = 21;
            // 
            // exerciseNameDataGridViewTextBoxColumn
            // 
            this.exerciseNameDataGridViewTextBoxColumn.DataPropertyName = "Exercise Name";
            this.exerciseNameDataGridViewTextBoxColumn.HeaderText = "Exercise Name";
            this.exerciseNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.exerciseNameDataGridViewTextBoxColumn.Name = "exerciseNameDataGridViewTextBoxColumn";
            this.exerciseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCaloriesBurntDataGridViewTextBoxColumn
            // 
            this.totalCaloriesBurntDataGridViewTextBoxColumn.DataPropertyName = "Total Calories Burnt";
            this.totalCaloriesBurntDataGridViewTextBoxColumn.HeaderText = "Total Calories Burnt";
            this.totalCaloriesBurntDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalCaloriesBurntDataGridViewTextBoxColumn.Name = "totalCaloriesBurntDataGridViewTextBoxColumn";
            this.totalCaloriesBurntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userWorklogBindingSource
            // 
            this.userWorklogBindingSource.DataMember = "User_Work_log";
            this.userWorklogBindingSource.DataSource = this.biteWiseDBDataSet1;
            // 
            // biteWiseDBDataSet1
            // 
            this.biteWiseDBDataSet1.DataSetName = "BiteWiseDBDataSet1";
            this.biteWiseDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_Work_logTableAdapter
            // 
            this.user_Work_logTableAdapter.ClearBeforeFill = true;
            // 
            // user_Work_logTableAdapter1
            // 
            this.user_Work_logTableAdapter1.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(29, 94);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FoodLoglb);
            this.splitContainer1.Panel1.Controls.Add(this.AddLogfoodBT);
            this.splitContainer1.Panel1.Controls.Add(this.TypetextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ServingtextBox);
            this.splitContainer1.Panel1.Controls.Add(this.TypeLB);
            this.splitContainer1.Panel1.Controls.Add(this.ServingLB);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.FoodSelectLB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExeLogLb);
            this.splitContainer1.Panel2.Controls.Add(this.AddLogExeBT);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.BurnedCalLB);
            this.splitContainer1.Panel2.Controls.Add(this.DurationLB);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.SelectExeLB);
            this.splitContainer1.Size = new System.Drawing.Size(291, 412);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 11;
            // 
            // FoodLoglb
            // 
            this.FoodLoglb.AutoSize = true;
            this.FoodLoglb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodLoglb.Location = new System.Drawing.Point(101, 17);
            this.FoodLoglb.Name = "FoodLoglb";
            this.FoodLoglb.Size = new System.Drawing.Size(133, 32);
            this.FoodLoglb.TabIndex = 19;
            this.FoodLoglb.Text = "FOOD LOG";
            // 
            // AddLogfoodBT
            // 
            this.AddLogfoodBT.Location = new System.Drawing.Point(109, 153);
            this.AddLogfoodBT.Name = "AddLogfoodBT";
            this.AddLogfoodBT.Size = new System.Drawing.Size(75, 23);
            this.AddLogfoodBT.TabIndex = 18;
            this.AddLogfoodBT.Text = "Add to Log";
            this.AddLogfoodBT.UseVisualStyleBackColor = true;
            // 
            // TypetextBox
            // 
            this.TypetextBox.Location = new System.Drawing.Point(122, 117);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(121, 31);
            this.TypetextBox.TabIndex = 17;
            // 
            // ServingtextBox
            // 
            this.ServingtextBox.Location = new System.Drawing.Point(122, 86);
            this.ServingtextBox.Name = "ServingtextBox";
            this.ServingtextBox.Size = new System.Drawing.Size(121, 31);
            this.ServingtextBox.TabIndex = 16;
            // 
            // TypeLB
            // 
            this.TypeLB.AutoSize = true;
            this.TypeLB.Location = new System.Drawing.Point(48, 125);
            this.TypeLB.Name = "TypeLB";
            this.TypeLB.Size = new System.Drawing.Size(92, 25);
            this.TypeLB.TabIndex = 15;
            this.TypeLB.Text = "Meal Type";
            // 
            // ServingLB
            // 
            this.ServingLB.AutoSize = true;
            this.ServingLB.Location = new System.Drawing.Point(48, 94);
            this.ServingLB.Name = "ServingLB";
            this.ServingLB.Size = new System.Drawing.Size(71, 25);
            this.ServingLB.TabIndex = 14;
            this.ServingLB.Text = "Serving";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // FoodSelectLB
            // 
            this.FoodSelectLB.AutoSize = true;
            this.FoodSelectLB.Location = new System.Drawing.Point(48, 63);
            this.FoodSelectLB.Name = "FoodSelectLB";
            this.FoodSelectLB.Size = new System.Drawing.Size(105, 25);
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
            this.ExeLogLb.Size = new System.Drawing.Size(174, 32);
            this.ExeLogLb.TabIndex = 25;
            this.ExeLogLb.Text = "EXERCISE LOG";
            // 
            // AddLogExeBT
            // 
            this.AddLogExeBT.Location = new System.Drawing.Point(117, 151);
            this.AddLogExeBT.Name = "AddLogExeBT";
            this.AddLogExeBT.Size = new System.Drawing.Size(75, 23);
            this.AddLogExeBT.TabIndex = 24;
            this.AddLogExeBT.Text = "Add to Log";
            this.AddLogExeBT.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 31);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 31);
            this.textBox3.TabIndex = 22;
            // 
            // BurnedCalLB
            // 
            this.BurnedCalLB.AutoSize = true;
            this.BurnedCalLB.Location = new System.Drawing.Point(37, 122);
            this.BurnedCalLB.Name = "BurnedCalLB";
            this.BurnedCalLB.Size = new System.Drawing.Size(135, 25);
            this.BurnedCalLB.TabIndex = 21;
            this.BurnedCalLB.Text = "Calories Burned";
            // 
            // DurationLB
            // 
            this.DurationLB.AutoSize = true;
            this.DurationLB.Location = new System.Drawing.Point(37, 90);
            this.DurationLB.Name = "DurationLB";
            this.DurationLB.Size = new System.Drawing.Size(81, 25);
            this.DurationLB.TabIndex = 20;
            this.DurationLB.Text = "Duration";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 19;
            // 
            // SelectExeLB
            // 
            this.SelectExeLB.AutoSize = true;
            this.SelectExeLB.Location = new System.Drawing.Point(37, 58);
            this.SelectExeLB.Name = "SelectExeLB";
            this.SelectExeLB.Size = new System.Drawing.Size(124, 25);
            this.SelectExeLB.TabIndex = 18;
            this.SelectExeLB.Text = "Select Exercise";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(351, 94);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SearchNtn);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.SearchLbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(618, 412);
            this.splitContainer2.SplitterDistance = 81;
            this.splitContainer2.TabIndex = 12;
            // 
            // SearchNtn
            // 
            this.SearchNtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchNtn.AutoSize = true;
            this.SearchNtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchNtn.Location = new System.Drawing.Point(518, 27);
            this.SearchNtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchNtn.Name = "SearchNtn";
            this.SearchNtn.Size = new System.Drawing.Size(74, 35);
            this.SearchNtn.TabIndex = 20;
            this.SearchNtn.Text = "Search";
            this.SearchNtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(79, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 31);
            this.textBox1.TabIndex = 19;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.Location = new System.Drawing.Point(14, 27);
            this.SearchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(85, 32);
            this.SearchLbl.TabIndex = 18;
            this.SearchLbl.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 65);
            this.label1.TabIndex = 20;
            this.label1.Text = "FOOD AND WORK OUT LOG";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ExerciseAndFoodLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExerciseAndFoodLog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ExerciseSearchLog";
            this.Load += new System.EventHandler(this.ExerciseSearchLog_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWorklogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biteWiseDBDataSet1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private User_ExerciseLog_ViewTableAdapters.User_Work_logTableAdapter user_Work_logTableAdapter;
        private BiteWiseDBDataSet1 biteWiseDBDataSet1;
        private System.Windows.Forms.BindingSource userWorklogBindingSource;
        private BiteWiseDBDataSet1TableAdapters.User_Work_logTableAdapter user_Work_logTableAdapter1;
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button SearchNtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCaloriesBurntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}