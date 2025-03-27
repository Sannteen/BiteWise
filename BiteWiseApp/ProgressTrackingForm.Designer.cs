namespace BiteWiseApp
{
    partial class ProgressTrackingForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.weightprogresschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DailySumarylabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BdyMeasurementHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.weightprogresschart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdyMeasurementHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // weightprogresschart
            // 
            chartArea1.Name = "ChartArea1";
            this.weightprogresschart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weightprogresschart.Legends.Add(legend1);
            this.weightprogresschart.Location = new System.Drawing.Point(2, 2);
            this.weightprogresschart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightprogresschart.Name = "weightprogresschart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.weightprogresschart.Series.Add(series1);
            this.weightprogresschart.Size = new System.Drawing.Size(312, 151);
            this.weightprogresschart.TabIndex = 2;
            this.weightprogresschart.Text = "Weight Progress overtime";
            title1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Weekly Weight Progress ";
            this.weightprogresschart.Titles.Add(title1);
            // 
            // DailySumarylabel
            // 
            this.DailySumarylabel.AutoSize = true;
            this.DailySumarylabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySumarylabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DailySumarylabel.Location = new System.Drawing.Point(187, 6);
            this.DailySumarylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailySumarylabel.Name = "DailySumarylabel";
            this.DailySumarylabel.Size = new System.Drawing.Size(320, 38);
            this.DailySumarylabel.TabIndex = 15;
            this.DailySumarylabel.Text = "Progress Tracking";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(328, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Calories ";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(343, 151);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Daily Calories Trend ";
            this.chart1.Titles.Add(title2);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.73736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.262643F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tableLayoutPanel1.Controls.Add(this.weightprogresschart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BdyMeasurementHistory, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 340);
            this.tableLayoutPanel1.TabIndex = 17;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BdyMeasurementHistory
            // 
            chartArea3.Name = "ChartArea1";
            this.BdyMeasurementHistory.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BdyMeasurementHistory.Legends.Add(legend3);
            this.BdyMeasurementHistory.Location = new System.Drawing.Point(2, 164);
            this.BdyMeasurementHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BdyMeasurementHistory.Name = "BdyMeasurementHistory";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Waist";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Hip";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Legend = "Legend1";
            series5.Name = "Chest";
            this.BdyMeasurementHistory.Series.Add(series3);
            this.BdyMeasurementHistory.Series.Add(series4);
            this.BdyMeasurementHistory.Series.Add(series5);
            this.BdyMeasurementHistory.Size = new System.Drawing.Size(312, 174);
            this.BdyMeasurementHistory.TabIndex = 6;
            this.BdyMeasurementHistory.Text = "Body Measurement History ";
            title3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "My Body Measurement";
            this.BdyMeasurementHistory.Titles.Add(title3);
            // 
            // ProgressTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DailySumarylabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProgressTrackingForm";
            this.Text = "ProgressTrackingForm";
            ((System.ComponentModel.ISupportInitialize)(this.weightprogresschart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BdyMeasurementHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart weightprogresschart;
        private System.Windows.Forms.Label DailySumarylabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BdyMeasurementHistory;
    }
}