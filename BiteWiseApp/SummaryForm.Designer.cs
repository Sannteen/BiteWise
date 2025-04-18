namespace BiteWiseApp
{
    partial class SummaryForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DailySumarylabel = new System.Windows.Forms.Label();
            this.DatePickfordailysumry = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.foodloglabel = new System.Windows.Forms.Label();
            this.WoutoutLogLabel = new System.Windows.Forms.Label();
            this.totalCalConsulabel = new System.Windows.Forms.Label();
            this.FoodLogDataGridView = new System.Windows.Forms.DataGridView();
            this.WorkoutLogDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tltCaloriesconsumedchart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalCalBurned = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.FoodLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutLogDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tltCaloriesconsumedchart1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCalBurned)).BeginInit();
            this.SuspendLayout();
            // 
            // DailySumarylabel
            // 
            this.DailySumarylabel.AutoSize = true;
            this.DailySumarylabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySumarylabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DailySumarylabel.Location = new System.Drawing.Point(8, 6);
            this.DailySumarylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailySumarylabel.Name = "DailySumarylabel";
            this.DailySumarylabel.Size = new System.Drawing.Size(286, 38);
            this.DailySumarylabel.TabIndex = 14;
            this.DailySumarylabel.Text = "Daily Summary ";
            // 
            // DatePickfordailysumry
            // 
            this.DatePickfordailysumry.AllowDrop = true;
            this.DatePickfordailysumry.Location = new System.Drawing.Point(49, 63);
            this.DatePickfordailysumry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatePickfordailysumry.MaxDate = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            this.DatePickfordailysumry.Name = "DatePickfordailysumry";
            this.DatePickfordailysumry.Size = new System.Drawing.Size(199, 20);
            this.DatePickfordailysumry.TabIndex = 15;
            this.DatePickfordailysumry.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(15, 63);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date";
            // 
            // foodloglabel
            // 
            this.foodloglabel.AutoSize = true;
            this.foodloglabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodloglabel.Location = new System.Drawing.Point(46, 111);
            this.foodloglabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodloglabel.Name = "foodloglabel";
            this.foodloglabel.Size = new System.Drawing.Size(79, 20);
            this.foodloglabel.TabIndex = 18;
            this.foodloglabel.Text = "Food Log";
            // 
            // WoutoutLogLabel
            // 
            this.WoutoutLogLabel.AutoSize = true;
            this.WoutoutLogLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoutoutLogLabel.Location = new System.Drawing.Point(199, 111);
            this.WoutoutLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WoutoutLogLabel.Name = "WoutoutLogLabel";
            this.WoutoutLogLabel.Size = new System.Drawing.Size(108, 20);
            this.WoutoutLogLabel.TabIndex = 21;
            this.WoutoutLogLabel.Text = "Workout Log";
            // 
            // totalCalConsulabel
            // 
            this.totalCalConsulabel.AutoSize = true;
            this.totalCalConsulabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalCalConsulabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalConsulabel.ForeColor = System.Drawing.Color.Black;
            this.totalCalConsulabel.Location = new System.Drawing.Point(371, 42);
            this.totalCalConsulabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCalConsulabel.Name = "totalCalConsulabel";
            this.totalCalConsulabel.Size = new System.Drawing.Size(191, 20);
            this.totalCalConsulabel.TabIndex = 24;
            this.totalCalConsulabel.Text = "Total Calories Consumed";
            // 
            // FoodLogDataGridView
            // 
            this.FoodLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodLogDataGridView.Location = new System.Drawing.Point(15, 133);
            this.FoodLogDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FoodLogDataGridView.Name = "FoodLogDataGridView";
            this.FoodLogDataGridView.RowHeadersWidth = 62;
            this.FoodLogDataGridView.RowTemplate.Height = 28;
            this.FoodLogDataGridView.Size = new System.Drawing.Size(157, 141);
            this.FoodLogDataGridView.TabIndex = 26;
            this.FoodLogDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodLogDataGridView_CellContentClick);
            // 
            // WorkoutLogDataGridView
            // 
            this.WorkoutLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkoutLogDataGridView.Location = new System.Drawing.Point(191, 133);
            this.WorkoutLogDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkoutLogDataGridView.Name = "WorkoutLogDataGridView";
            this.WorkoutLogDataGridView.RowHeadersWidth = 62;
            this.WorkoutLogDataGridView.RowTemplate.Height = 28;
            this.WorkoutLogDataGridView.Size = new System.Drawing.Size(156, 141);
            this.WorkoutLogDataGridView.TabIndex = 30;
            this.WorkoutLogDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkoutLogDataGridView_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.31818F));
            this.tableLayoutPanel1.Controls.Add(this.tltCaloriesconsumedchart1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(366, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.36201F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.637982F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 380);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // tltCaloriesconsumedchart1
            // 
            chartArea5.Name = "ChartArea1";
            this.tltCaloriesconsumedchart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.tltCaloriesconsumedchart1.Legends.Add(legend5);
            this.tltCaloriesconsumedchart1.Location = new System.Drawing.Point(2, 2);
            this.tltCaloriesconsumedchart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tltCaloriesconsumedchart1.Name = "tltCaloriesconsumedchart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.tltCaloriesconsumedchart1.Series.Add(series9);
            this.tltCaloriesconsumedchart1.Size = new System.Drawing.Size(228, 177);
            this.tltCaloriesconsumedchart1.TabIndex = 26;
            this.tltCaloriesconsumedchart1.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TotalCalBurned, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 289);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(329, 153);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // TotalCalBurned
            // 
            chartArea6.Name = "ChartArea1";
            this.TotalCalBurned.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.TotalCalBurned.Legends.Add(legend6);
            this.TotalCalBurned.Location = new System.Drawing.Point(2, 2);
            this.TotalCalBurned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalCalBurned.Name = "TotalCalBurned";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series10.Legend = "Legend1";
            series10.Name = "Protein";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series11.Legend = "Legend1";
            series11.Name = "Fat";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series12.Legend = "Legend1";
            series12.Name = "Carbs";
            this.TotalCalBurned.Series.Add(series10);
            this.TotalCalBurned.Series.Add(series11);
            this.TotalCalBurned.Series.Add(series12);
            this.TotalCalBurned.Size = new System.Drawing.Size(325, 149);
            this.TotalCalBurned.TabIndex = 7;
            this.TotalCalBurned.Text = "Body Measurement History ";
            title3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Total Calories Burned";
            this.TotalCalBurned.Titles.Add(title3);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 466);
            this.Controls.Add(this.WoutoutLogLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.totalCalConsulabel);
            this.Controls.Add(this.WorkoutLogDataGridView);
            this.Controls.Add(this.FoodLogDataGridView);
            this.Controls.Add(this.foodloglabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DatePickfordailysumry);
            this.Controls.Add(this.DailySumarylabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutLogDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tltCaloriesconsumedchart1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TotalCalBurned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DailySumarylabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label foodloglabel;
        private System.Windows.Forms.Label WoutoutLogLabel;
        private System.Windows.Forms.Label totalCalConsulabel;
        private System.Windows.Forms.DataGridView FoodLogDataGridView;
        private System.Windows.Forms.DataGridView WorkoutLogDataGridView;
        public System.Windows.Forms.DateTimePicker DatePickfordailysumry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart tltCaloriesconsumedchart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalCalBurned;
    }
}