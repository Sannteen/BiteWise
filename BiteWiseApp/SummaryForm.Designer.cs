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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DailySumarylabel = new System.Windows.Forms.Label();
            this.DatePickfordailysumry = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.foodloglabel = new System.Windows.Forms.Label();
            this.WoutoutLogLabel = new System.Windows.Forms.Label();
            this.FoodLogDataGridView = new System.Windows.Forms.DataGridView();
            this.WorkoutLogDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalCalBurned = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tltCaloriesconsumedchart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.FoodLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCalBurned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tltCaloriesconsumedchart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DailySumarylabel
            // 
            this.DailySumarylabel.AutoSize = true;
            this.DailySumarylabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySumarylabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DailySumarylabel.Location = new System.Drawing.Point(345, 7);
            this.DailySumarylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailySumarylabel.Name = "DailySumarylabel";
            this.DailySumarylabel.Size = new System.Drawing.Size(424, 56);
            this.DailySumarylabel.TabIndex = 14;
            this.DailySumarylabel.Text = "Daily Summary ";
            // 
            // DatePickfordailysumry
            // 
            this.DatePickfordailysumry.AllowDrop = true;
            this.DatePickfordailysumry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickfordailysumry.Location = new System.Drawing.Point(127, 73);
            this.DatePickfordailysumry.Margin = new System.Windows.Forms.Padding(2);
            this.DatePickfordailysumry.MaxDate = new System.DateTime(9998, 1, 12, 0, 0, 0, 0);
            this.DatePickfordailysumry.Name = "DatePickfordailysumry";
            this.DatePickfordailysumry.Size = new System.Drawing.Size(259, 31);
            this.DatePickfordailysumry.TabIndex = 15;
            this.DatePickfordailysumry.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(59, 73);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(64, 31);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date";
            // 
            // foodloglabel
            // 
            this.foodloglabel.AutoSize = true;
            this.foodloglabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodloglabel.Location = new System.Drawing.Point(60, 147);
            this.foodloglabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodloglabel.Name = "foodloglabel";
            this.foodloglabel.Size = new System.Drawing.Size(113, 30);
            this.foodloglabel.TabIndex = 18;
            this.foodloglabel.Text = "Food Log";
            // 
            // WoutoutLogLabel
            // 
            this.WoutoutLogLabel.AutoSize = true;
            this.WoutoutLogLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoutoutLogLabel.Location = new System.Drawing.Point(312, 147);
            this.WoutoutLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WoutoutLogLabel.Name = "WoutoutLogLabel";
            this.WoutoutLogLabel.Size = new System.Drawing.Size(156, 30);
            this.WoutoutLogLabel.TabIndex = 21;
            this.WoutoutLogLabel.Text = "Workout Log";
            // 
            // FoodLogDataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FoodLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FoodLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodLogDataGridView.Location = new System.Drawing.Point(53, 193);
            this.FoodLogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FoodLogDataGridView.Name = "FoodLogDataGridView";
            this.FoodLogDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FoodLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FoodLogDataGridView.RowTemplate.Height = 28;
            this.FoodLogDataGridView.Size = new System.Drawing.Size(241, 289);
            this.FoodLogDataGridView.TabIndex = 26;
            // 
            // WorkoutLogDataGridView
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.WorkoutLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkoutLogDataGridView.Location = new System.Drawing.Point(317, 193);
            this.WorkoutLogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.WorkoutLogDataGridView.Name = "WorkoutLogDataGridView";
            this.WorkoutLogDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WorkoutLogDataGridView.RowTemplate.Height = 28;
            this.WorkoutLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WorkoutLogDataGridView.Size = new System.Drawing.Size(241, 289);
            this.WorkoutLogDataGridView.TabIndex = 30;
            // 
            // TotalCalBurned
            // 
            chartArea1.Name = "ChartArea1";
            this.TotalCalBurned.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TotalCalBurned.Legends.Add(legend1);
            this.TotalCalBurned.Location = new System.Drawing.Point(708, 84);
            this.TotalCalBurned.Margin = new System.Windows.Forms.Padding(2);
            this.TotalCalBurned.Name = "TotalCalBurned";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Protein";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Fat";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "Carbs";
            this.TotalCalBurned.Series.Add(series1);
            this.TotalCalBurned.Series.Add(series2);
            this.TotalCalBurned.Series.Add(series3);
            this.TotalCalBurned.Size = new System.Drawing.Size(379, 204);
            this.TotalCalBurned.TabIndex = 7;
            this.TotalCalBurned.Text = "Body Measurement History ";
            title1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Total Calories Burned";
            this.TotalCalBurned.Titles.Add(title1);
            // 
            // tltCaloriesconsumedchart1
            // 
            chartArea2.Name = "ChartArea1";
            this.tltCaloriesconsumedchart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.tltCaloriesconsumedchart1.Legends.Add(legend2);
            this.tltCaloriesconsumedchart1.Location = new System.Drawing.Point(708, 303);
            this.tltCaloriesconsumedchart1.Margin = new System.Windows.Forms.Padding(2);
            this.tltCaloriesconsumedchart1.Name = "tltCaloriesconsumedchart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.tltCaloriesconsumedchart1.Series.Add(series4);
            this.tltCaloriesconsumedchart1.Size = new System.Drawing.Size(379, 179);
            this.tltCaloriesconsumedchart1.TabIndex = 26;
            this.tltCaloriesconsumedchart1.Text = "Total Calories Consumed";
            title2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Total Calories Consumed";
            title2.Text = "Total Calories Consumed";
            this.tltCaloriesconsumedchart1.Titles.Add(title2);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.tltCaloriesconsumedchart1);
            this.Controls.Add(this.TotalCalBurned);
            this.Controls.Add(this.WoutoutLogLabel);
            this.Controls.Add(this.WorkoutLogDataGridView);
            this.Controls.Add(this.FoodLogDataGridView);
            this.Controls.Add(this.foodloglabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DatePickfordailysumry);
            this.Controls.Add(this.DailySumarylabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCalBurned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tltCaloriesconsumedchart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DailySumarylabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label foodloglabel;
        private System.Windows.Forms.Label WoutoutLogLabel;
        private System.Windows.Forms.DataGridView FoodLogDataGridView;
        private System.Windows.Forms.DataGridView WorkoutLogDataGridView;
        public System.Windows.Forms.DateTimePicker DatePickfordailysumry;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalCalBurned;
        private System.Windows.Forms.DataVisualization.Charting.Chart tltCaloriesconsumedchart1;
    }
}