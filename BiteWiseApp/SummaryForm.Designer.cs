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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NetCaloriesLabel = new System.Windows.Forms.Label();
            this.NetCaloriesProgressBar = new CircularProgressBar.CircularProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FoodLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCalBurned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tltCaloriesconsumedchart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DailySumarylabel
            // 
            this.DailySumarylabel.AutoSize = true;
            this.DailySumarylabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySumarylabel.ForeColor = System.Drawing.Color.DarkCyan;
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
            this.foodloglabel.Location = new System.Drawing.Point(31, 6);
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
            this.WoutoutLogLabel.Location = new System.Drawing.Point(31, 296);
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
            this.FoodLogDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FoodLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodLogDataGridView.Location = new System.Drawing.Point(36, 47);
            this.FoodLogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FoodLogDataGridView.Name = "FoodLogDataGridView";
            this.FoodLogDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FoodLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FoodLogDataGridView.RowTemplate.Height = 28;
            this.FoodLogDataGridView.Size = new System.Drawing.Size(240, 225);
            this.FoodLogDataGridView.TabIndex = 26;
            // 
            // WorkoutLogDataGridView
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.WorkoutLogDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkoutLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkoutLogDataGridView.Location = new System.Drawing.Point(12, 328);
            this.WorkoutLogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.WorkoutLogDataGridView.Name = "WorkoutLogDataGridView";
            this.WorkoutLogDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WorkoutLogDataGridView.RowTemplate.Height = 28;
            this.WorkoutLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WorkoutLogDataGridView.Size = new System.Drawing.Size(303, 156);
            this.WorkoutLogDataGridView.TabIndex = 30;
            // 
            // TotalCalBurned
            // 
            chartArea1.Name = "ChartArea1";
            this.TotalCalBurned.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TotalCalBurned.Legends.Add(legend1);
            this.TotalCalBurned.Location = new System.Drawing.Point(2, 6);
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
            this.TotalCalBurned.Size = new System.Drawing.Size(427, 234);
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
            this.tltCaloriesconsumedchart1.Location = new System.Drawing.Point(2, 258);
            this.tltCaloriesconsumedchart1.Margin = new System.Windows.Forms.Padding(2);
            this.tltCaloriesconsumedchart1.Name = "tltCaloriesconsumedchart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.tltCaloriesconsumedchart1.Series.Add(series4);
            this.tltCaloriesconsumedchart1.Size = new System.Drawing.Size(427, 234);
            this.tltCaloriesconsumedchart1.TabIndex = 26;
            this.tltCaloriesconsumedchart1.Text = "Total Calories Consumed";
            title2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Total Calories Consumed";
            title2.Text = "Total Calories Consumed";
            this.tltCaloriesconsumedchart1.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalCalBurned);
            this.panel1.Controls.Add(this.tltCaloriesconsumedchart1);
            this.panel1.Location = new System.Drawing.Point(390, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 494);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NetCaloriesLabel);
            this.panel2.Controls.Add(this.NetCaloriesProgressBar);
            this.panel2.Location = new System.Drawing.Point(856, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 487);
            this.panel2.TabIndex = 32;
            // 
            // NetCaloriesLabel
            // 
            this.NetCaloriesLabel.AutoSize = true;
            this.NetCaloriesLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCaloriesLabel.Location = new System.Drawing.Point(2, 1);
            this.NetCaloriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NetCaloriesLabel.Name = "NetCaloriesLabel";
            this.NetCaloriesLabel.Size = new System.Drawing.Size(145, 30);
            this.NetCaloriesLabel.TabIndex = 33;
            this.NetCaloriesLabel.Text = "Net Calories";
            // 
            // NetCaloriesProgressBar
            // 
            this.NetCaloriesProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.NetCaloriesProgressBar.AnimationSpeed = 500;
            this.NetCaloriesProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.NetCaloriesProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.NetCaloriesProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NetCaloriesProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NetCaloriesProgressBar.InnerMargin = 2;
            this.NetCaloriesProgressBar.InnerWidth = -1;
            this.NetCaloriesProgressBar.Location = new System.Drawing.Point(7, 62);
            this.NetCaloriesProgressBar.MarqueeAnimationSpeed = 2000;
            this.NetCaloriesProgressBar.Name = "NetCaloriesProgressBar";
            this.NetCaloriesProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.NetCaloriesProgressBar.OuterMargin = -25;
            this.NetCaloriesProgressBar.OuterWidth = 26;
            this.NetCaloriesProgressBar.ProgressColor = System.Drawing.Color.DarkCyan;
            this.NetCaloriesProgressBar.ProgressWidth = 25;
            this.NetCaloriesProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.NetCaloriesProgressBar.Size = new System.Drawing.Size(270, 259);
            this.NetCaloriesProgressBar.StartAngle = 270;
            this.NetCaloriesProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NetCaloriesProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.NetCaloriesProgressBar.SubscriptText = ".23";
            this.NetCaloriesProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NetCaloriesProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.NetCaloriesProgressBar.SuperscriptText = "°C";
            this.NetCaloriesProgressBar.TabIndex = 0;
            this.NetCaloriesProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.NetCaloriesProgressBar.Value = 68;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel3.Controls.Add(this.FoodLogDataGridView);
            this.panel3.Controls.Add(this.WorkoutLogDataGridView);
            this.panel3.Controls.Add(this.WoutoutLogLabel);
            this.panel3.Controls.Add(this.foodloglabel);
            this.panel3.Location = new System.Drawing.Point(29, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 491);
            this.panel3.TabIndex = 33;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NetCaloriesLabel;
        private CircularProgressBar.CircularProgressBar NetCaloriesProgressBar;
        private System.Windows.Forms.Panel panel3;
    }
}