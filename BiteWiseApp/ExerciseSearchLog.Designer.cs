namespace BiteWiseApp
{
    partial class ExerciseSearchLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchNtn = new System.Windows.Forms.Button();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userWorklogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biteWiseDBDataSet1 = new BiteWiseApp.BiteWiseDBDataSet1();
            this.user_Work_logTableAdapter = new BiteWiseApp.User_ExerciseLog_ViewTableAdapters.User_Work_logTableAdapter();
            this.user_Work_logTableAdapter1 = new BiteWiseApp.BiteWiseDBDataSet1TableAdapters.User_Work_logTableAdapter();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCaloriesBurntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWorklogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biteWiseDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchNtn
            // 
            this.SearchNtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchNtn.AutoSize = true;
            this.SearchNtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchNtn.Location = new System.Drawing.Point(372, 94);
            this.SearchNtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchNtn.Name = "SearchNtn";
            this.SearchNtn.Size = new System.Drawing.Size(114, 29);
            this.SearchNtn.TabIndex = 1;
            this.SearchNtn.Text = "Search";
            this.SearchNtn.UseVisualStyleBackColor = true;
            this.SearchNtn.Click += new System.EventHandler(this.SearchNtn_Click);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchLbl.Location = new System.Drawing.Point(294, 60);
            this.SearchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(42, 15);
            this.SearchLbl.TabIndex = 2;
            this.SearchLbl.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 23);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.exerciseNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.totalCaloriesBurntDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userWorklogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 329);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // exerciseNameDataGridViewTextBoxColumn
            // 
            this.exerciseNameDataGridViewTextBoxColumn.DataPropertyName = "Exercise Name";
            this.exerciseNameDataGridViewTextBoxColumn.HeaderText = "Exercise Name";
            this.exerciseNameDataGridViewTextBoxColumn.Name = "exerciseNameDataGridViewTextBoxColumn";
            this.exerciseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCaloriesBurntDataGridViewTextBoxColumn
            // 
            this.totalCaloriesBurntDataGridViewTextBoxColumn.DataPropertyName = "Total Calories Burnt";
            this.totalCaloriesBurntDataGridViewTextBoxColumn.HeaderText = "Total Calories Burnt";
            this.totalCaloriesBurntDataGridViewTextBoxColumn.Name = "totalCaloriesBurntDataGridViewTextBoxColumn";
            this.totalCaloriesBurntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExerciseSearchLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SearchNtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExerciseSearchLog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ExerciseSearchLog";
            this.Load += new System.EventHandler(this.ExerciseSearchLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWorklogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biteWiseDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchNtn;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private User_ExerciseLog_ViewTableAdapters.User_Work_logTableAdapter user_Work_logTableAdapter;
        private BiteWiseDBDataSet1 biteWiseDBDataSet1;
        private System.Windows.Forms.BindingSource userWorklogBindingSource;
        private BiteWiseDBDataSet1TableAdapters.User_Work_logTableAdapter user_Work_logTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCaloriesBurntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}