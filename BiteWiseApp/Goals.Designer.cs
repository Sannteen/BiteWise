namespace BiteWiseApp
{
    partial class Goals
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
            this.label5 = new System.Windows.Forms.Label();
            this.WeightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeightHistoryTxtBx = new System.Windows.Forms.Label();
            this.CurrentWeightTxtBx = new System.Windows.Forms.TextBox();
            this.TargetWeightTxtBx = new System.Windows.Forms.TextBox();
            this.CurrentDailyCalTxtBx = new System.Windows.Forms.TextBox();
            this.WklyWeightChangeGoalTxtBx = new System.Windows.Forms.TextBox();
            this.DailyCalTargetTxtBx = new System.Windows.Forms.TextBox();
            this.CurrentWeightLabel = new System.Windows.Forms.Label();
            this.TargetWeightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DailyCalTargetLabel = new System.Windows.Forms.Label();
            this.CurrentDailyCalLabel = new System.Windows.Forms.Label();
            this.EditWeightBtn = new System.Windows.Forms.Button();
            this.RefreshProgBtn = new System.Windows.Forms.Button();
            this.WeeklyWeightChangeGoalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeightChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Juice ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(690, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 72);
            this.label5.TabIndex = 13;
            this.label5.Text = "BiteWise";
            // 
            // WeightChart
            // 
            chartArea1.Name = "ChartArea1";
            this.WeightChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WeightChart.Legends.Add(legend1);
            this.WeightChart.Location = new System.Drawing.Point(22, 181);
            this.WeightChart.Margin = new System.Windows.Forms.Padding(2);
            this.WeightChart.Name = "WeightChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.WeightChart.Series.Add(series1);
            this.WeightChart.Size = new System.Drawing.Size(639, 255);
            this.WeightChart.TabIndex = 14;
            this.WeightChart.Text = "Weight";
            this.WeightChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // WeightHistoryTxtBx
            // 
            this.WeightHistoryTxtBx.AutoSize = true;
            this.WeightHistoryTxtBx.Location = new System.Drawing.Point(20, 164);
            this.WeightHistoryTxtBx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightHistoryTxtBx.Name = "WeightHistoryTxtBx";
            this.WeightHistoryTxtBx.Size = new System.Drawing.Size(86, 15);
            this.WeightHistoryTxtBx.TabIndex = 15;
            this.WeightHistoryTxtBx.Text = "Weight History";
            // 
            // CurrentWeightTxtBx
            // 
            this.CurrentWeightTxtBx.Location = new System.Drawing.Point(22, 52);
            this.CurrentWeightTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentWeightTxtBx.Name = "CurrentWeightTxtBx";
            this.CurrentWeightTxtBx.Size = new System.Drawing.Size(112, 23);
            this.CurrentWeightTxtBx.TabIndex = 16;
            this.CurrentWeightTxtBx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TargetWeightTxtBx
            // 
            this.TargetWeightTxtBx.Location = new System.Drawing.Point(184, 52);
            this.TargetWeightTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.TargetWeightTxtBx.Name = "TargetWeightTxtBx";
            this.TargetWeightTxtBx.Size = new System.Drawing.Size(112, 23);
            this.TargetWeightTxtBx.TabIndex = 17;
            // 
            // CurrentDailyCalTxtBx
            // 
            this.CurrentDailyCalTxtBx.Location = new System.Drawing.Point(709, 53);
            this.CurrentDailyCalTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentDailyCalTxtBx.Name = "CurrentDailyCalTxtBx";
            this.CurrentDailyCalTxtBx.Size = new System.Drawing.Size(143, 23);
            this.CurrentDailyCalTxtBx.TabIndex = 18;
            // 
            // WklyWeightChangeGoalTxtBx
            // 
            this.WklyWeightChangeGoalTxtBx.Location = new System.Drawing.Point(507, 52);
            this.WklyWeightChangeGoalTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.WklyWeightChangeGoalTxtBx.Name = "WklyWeightChangeGoalTxtBx";
            this.WklyWeightChangeGoalTxtBx.Size = new System.Drawing.Size(154, 23);
            this.WklyWeightChangeGoalTxtBx.TabIndex = 19;
            this.WklyWeightChangeGoalTxtBx.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // DailyCalTargetTxtBx
            // 
            this.DailyCalTargetTxtBx.Location = new System.Drawing.Point(345, 52);
            this.DailyCalTargetTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.DailyCalTargetTxtBx.Name = "DailyCalTargetTxtBx";
            this.DailyCalTargetTxtBx.Size = new System.Drawing.Size(112, 23);
            this.DailyCalTargetTxtBx.TabIndex = 21;
            this.DailyCalTargetTxtBx.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CurrentWeightLabel
            // 
            this.CurrentWeightLabel.AutoSize = true;
            this.CurrentWeightLabel.Location = new System.Drawing.Point(20, 35);
            this.CurrentWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentWeightLabel.Name = "CurrentWeightLabel";
            this.CurrentWeightLabel.Size = new System.Drawing.Size(88, 15);
            this.CurrentWeightLabel.TabIndex = 22;
            this.CurrentWeightLabel.Text = "Current Weight";
            this.CurrentWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrentWeightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TargetWeightLabel
            // 
            this.TargetWeightLabel.AutoSize = true;
            this.TargetWeightLabel.Location = new System.Drawing.Point(181, 35);
            this.TargetWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TargetWeightLabel.Name = "TargetWeightLabel";
            this.TargetWeightLabel.Size = new System.Drawing.Size(81, 15);
            this.TargetWeightLabel.TabIndex = 23;
            this.TargetWeightLabel.Text = "Target Weight";
            this.TargetWeightLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 26;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DailyCalTargetLabel
            // 
            this.DailyCalTargetLabel.AutoSize = true;
            this.DailyCalTargetLabel.Location = new System.Drawing.Point(344, 35);
            this.DailyCalTargetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailyCalTargetLabel.Name = "DailyCalTargetLabel";
            this.DailyCalTargetLabel.Size = new System.Drawing.Size(109, 15);
            this.DailyCalTargetLabel.TabIndex = 27;
            this.DailyCalTargetLabel.Text = "Daily Caloric Target";
            this.DailyCalTargetLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // CurrentDailyCalLabel
            // 
            this.CurrentDailyCalLabel.AutoSize = true;
            this.CurrentDailyCalLabel.Location = new System.Drawing.Point(714, 35);
            this.CurrentDailyCalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentDailyCalLabel.Name = "CurrentDailyCalLabel";
            this.CurrentDailyCalLabel.Size = new System.Drawing.Size(124, 15);
            this.CurrentDailyCalLabel.TabIndex = 28;
            this.CurrentDailyCalLabel.Text = "Current Daily Calories ";
            this.CurrentDailyCalLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // EditWeightBtn
            // 
            this.EditWeightBtn.Location = new System.Drawing.Point(709, 194);
            this.EditWeightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditWeightBtn.Name = "EditWeightBtn";
            this.EditWeightBtn.Size = new System.Drawing.Size(141, 37);
            this.EditWeightBtn.TabIndex = 29;
            this.EditWeightBtn.Text = "Update Weight";
            this.EditWeightBtn.UseVisualStyleBackColor = true;
            this.EditWeightBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshProgBtn
            // 
            this.RefreshProgBtn.Location = new System.Drawing.Point(713, 258);
            this.RefreshProgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshProgBtn.Name = "RefreshProgBtn";
            this.RefreshProgBtn.Size = new System.Drawing.Size(136, 38);
            this.RefreshProgBtn.TabIndex = 30;
            this.RefreshProgBtn.Text = "Refresh Progress";
            this.RefreshProgBtn.UseVisualStyleBackColor = true;
            this.RefreshProgBtn.Click += new System.EventHandler(this.RefreshProgBtn_Click);
            // 
            // WeeklyWeightChangeGoalLabel
            // 
            this.WeeklyWeightChangeGoalLabel.AutoSize = true;
            this.WeeklyWeightChangeGoalLabel.Location = new System.Drawing.Point(504, 35);
            this.WeeklyWeightChangeGoalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeeklyWeightChangeGoalLabel.Name = "WeeklyWeightChangeGoalLabel";
            this.WeeklyWeightChangeGoalLabel.Size = new System.Drawing.Size(157, 15);
            this.WeeklyWeightChangeGoalLabel.TabIndex = 31;
            this.WeeklyWeightChangeGoalLabel.Text = "Weekly Weight Change Goal";
            this.WeeklyWeightChangeGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 480);
            this.Controls.Add(this.WeeklyWeightChangeGoalLabel);
            this.Controls.Add(this.RefreshProgBtn);
            this.Controls.Add(this.EditWeightBtn);
            this.Controls.Add(this.CurrentDailyCalLabel);
            this.Controls.Add(this.DailyCalTargetLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TargetWeightLabel);
            this.Controls.Add(this.CurrentWeightLabel);
            this.Controls.Add(this.DailyCalTargetTxtBx);
            this.Controls.Add(this.WklyWeightChangeGoalTxtBx);
            this.Controls.Add(this.CurrentDailyCalTxtBx);
            this.Controls.Add(this.TargetWeightTxtBx);
            this.Controls.Add(this.CurrentWeightTxtBx);
            this.Controls.Add(this.WeightHistoryTxtBx);
            this.Controls.Add(this.WeightChart);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Goals";
            this.Text = "Goals";
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeightChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeightChart;
        private System.Windows.Forms.Label WeightHistoryTxtBx;
        private System.Windows.Forms.TextBox CurrentWeightTxtBx;
        private System.Windows.Forms.TextBox TargetWeightTxtBx;
        private System.Windows.Forms.TextBox CurrentDailyCalTxtBx;
        private System.Windows.Forms.TextBox WklyWeightChangeGoalTxtBx;
        private System.Windows.Forms.TextBox DailyCalTargetTxtBx;
        private System.Windows.Forms.Label CurrentWeightLabel;
        private System.Windows.Forms.Label TargetWeightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DailyCalTargetLabel;
        private System.Windows.Forms.Label CurrentDailyCalLabel;
        private System.Windows.Forms.Button EditWeightBtn;
        private System.Windows.Forms.Button RefreshProgBtn;
        private System.Windows.Forms.Label WeeklyWeightChangeGoalLabel;
    }
}