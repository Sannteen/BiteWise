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
            this.GoalsPgLogo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WeightTrackingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeightHistoryLabel = new System.Windows.Forms.Label();
            this.CurrentWeightBox = new System.Windows.Forms.TextBox();
            this.TargetWeightBox = new System.Windows.Forms.TextBox();
            this.CurrentDailyCaloriesBox = new System.Windows.Forms.TextBox();
            this.WeeklyWeightChangeGoalBox = new System.Windows.Forms.TextBox();
            this.DailyCaloricTargetBox = new System.Windows.Forms.TextBox();
            this.CurrentWeightLabel = new System.Windows.Forms.Label();
            this.TargetWeightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeeklyWeightChangeGoalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DailyCaloricTargetLabel = new System.Windows.Forms.Label();
            this.CurrentDailyCaloriesLabel = new System.Windows.Forms.Label();
            this.EditGoalsButton = new System.Windows.Forms.Button();
            this.RefreshProgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTrackingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GoalsPgLogo
            // 
            this.GoalsPgLogo.AutoSize = true;
            this.GoalsPgLogo.Font = new System.Drawing.Font("Juice ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalsPgLogo.ForeColor = System.Drawing.Color.Red;
            this.GoalsPgLogo.Location = new System.Drawing.Point(623, 440);
            this.GoalsPgLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoalsPgLogo.Name = "GoalsPgLogo";
            this.GoalsPgLogo.Size = new System.Drawing.Size(279, 109);
            this.GoalsPgLogo.TabIndex = 13;
            this.GoalsPgLogo.Text = "BiteWise";
            // 
            // WeightTrackingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.WeightTrackingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WeightTrackingChart.Legends.Add(legend1);
            this.WeightTrackingChart.Location = new System.Drawing.Point(29, 241);
            this.WeightTrackingChart.Name = "WeightTrackingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.WeightTrackingChart.Series.Add(series1);
            this.WeightTrackingChart.Size = new System.Drawing.Size(593, 274);
            this.WeightTrackingChart.TabIndex = 14;
            this.WeightTrackingChart.Text = "Weight";
            this.WeightTrackingChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // WeightHistoryLabel
            // 
            this.WeightHistoryLabel.AutoSize = true;
            this.WeightHistoryLabel.Location = new System.Drawing.Point(25, 218);
            this.WeightHistoryLabel.Name = "WeightHistoryLabel";
            this.WeightHistoryLabel.Size = new System.Drawing.Size(112, 20);
            this.WeightHistoryLabel.TabIndex = 15;
            this.WeightHistoryLabel.Text = "Weight History";
            // 
            // CurrentWeightBox
            // 
            this.CurrentWeightBox.Location = new System.Drawing.Point(29, 69);
            this.CurrentWeightBox.Name = "CurrentWeightBox";
            this.CurrentWeightBox.Size = new System.Drawing.Size(144, 26);
            this.CurrentWeightBox.TabIndex = 16;
            this.CurrentWeightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TargetWeightBox
            // 
            this.TargetWeightBox.Location = new System.Drawing.Point(237, 69);
            this.TargetWeightBox.Name = "TargetWeightBox";
            this.TargetWeightBox.Size = new System.Drawing.Size(144, 26);
            this.TargetWeightBox.TabIndex = 17;
            // 
            // CurrentDailyCaloriesBox
            // 
            this.CurrentDailyCaloriesBox.Location = new System.Drawing.Point(336, 155);
            this.CurrentDailyCaloriesBox.Name = "CurrentDailyCaloriesBox";
            this.CurrentDailyCaloriesBox.Size = new System.Drawing.Size(182, 26);
            this.CurrentDailyCaloriesBox.TabIndex = 18;
            // 
            // WeeklyWeightChangeGoalBox
            // 
            this.WeeklyWeightChangeGoalBox.Location = new System.Drawing.Point(653, 69);
            this.WeeklyWeightChangeGoalBox.Name = "WeeklyWeightChangeGoalBox";
            this.WeeklyWeightChangeGoalBox.Size = new System.Drawing.Size(144, 26);
            this.WeeklyWeightChangeGoalBox.TabIndex = 19;
            this.WeeklyWeightChangeGoalBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // DailyCaloricTargetBox
            // 
            this.DailyCaloricTargetBox.Location = new System.Drawing.Point(444, 69);
            this.DailyCaloricTargetBox.Name = "DailyCaloricTargetBox";
            this.DailyCaloricTargetBox.Size = new System.Drawing.Size(144, 26);
            this.DailyCaloricTargetBox.TabIndex = 21;
            this.DailyCaloricTargetBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CurrentWeightLabel
            // 
            this.CurrentWeightLabel.AutoSize = true;
            this.CurrentWeightLabel.Location = new System.Drawing.Point(25, 46);
            this.CurrentWeightLabel.Name = "CurrentWeightLabel";
            this.CurrentWeightLabel.Size = new System.Drawing.Size(116, 20);
            this.CurrentWeightLabel.TabIndex = 22;
            this.CurrentWeightLabel.Text = "Current Weight";
            this.CurrentWeightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TargetWeightLabel
            // 
            this.TargetWeightLabel.AutoSize = true;
            this.TargetWeightLabel.Location = new System.Drawing.Point(233, 46);
            this.TargetWeightLabel.Name = "TargetWeightLabel";
            this.TargetWeightLabel.Size = new System.Drawing.Size(109, 20);
            this.TargetWeightLabel.TabIndex = 23;
            this.TargetWeightLabel.Text = "Target Weight";
            this.TargetWeightLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 24;
            // 
            // WeeklyWeightChangeGoalLabel
            // 
            this.WeeklyWeightChangeGoalLabel.AutoSize = true;
            this.WeeklyWeightChangeGoalLabel.Location = new System.Drawing.Point(649, 46);
            this.WeeklyWeightChangeGoalLabel.Name = "WeeklyWeightChangeGoalLabel";
            this.WeeklyWeightChangeGoalLabel.Size = new System.Drawing.Size(212, 20);
            this.WeeklyWeightChangeGoalLabel.TabIndex = 25;
            this.WeeklyWeightChangeGoalLabel.Text = "Weekly Weight Change Goal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 26;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DailyCaloricTargetLabel
            // 
            this.DailyCaloricTargetLabel.AutoSize = true;
            this.DailyCaloricTargetLabel.Location = new System.Drawing.Point(443, 46);
            this.DailyCaloricTargetLabel.Name = "DailyCaloricTargetLabel";
            this.DailyCaloricTargetLabel.Size = new System.Drawing.Size(145, 20);
            this.DailyCaloricTargetLabel.TabIndex = 27;
            this.DailyCaloricTargetLabel.Text = "Daily Caloric Target";
            this.DailyCaloricTargetLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // CurrentDailyCaloriesLabel
            // 
            this.CurrentDailyCaloriesLabel.AutoSize = true;
            this.CurrentDailyCaloriesLabel.Location = new System.Drawing.Point(342, 132);
            this.CurrentDailyCaloriesLabel.Name = "CurrentDailyCaloriesLabel";
            this.CurrentDailyCaloriesLabel.Size = new System.Drawing.Size(165, 20);
            this.CurrentDailyCaloriesLabel.TabIndex = 28;
            this.CurrentDailyCaloriesLabel.Text = "Current Daily Calories ";
            this.CurrentDailyCaloriesLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // EditGoalsButton
            // 
            this.EditGoalsButton.Location = new System.Drawing.Point(669, 263);
            this.EditGoalsButton.Name = "EditGoalsButton";
            this.EditGoalsButton.Size = new System.Drawing.Size(181, 49);
            this.EditGoalsButton.TabIndex = 29;
            this.EditGoalsButton.Text = "Edit Goals";
            this.EditGoalsButton.UseVisualStyleBackColor = true;
            this.EditGoalsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshProgButton
            // 
            this.RefreshProgButton.Location = new System.Drawing.Point(674, 347);
            this.RefreshProgButton.Name = "RefreshProgButton";
            this.RefreshProgButton.Size = new System.Drawing.Size(176, 51);
            this.RefreshProgButton.TabIndex = 30;
            this.RefreshProgButton.Text = "Refresh Progress";
            this.RefreshProgButton.UseVisualStyleBackColor = true;
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 558);
            this.Controls.Add(this.RefreshProgButton);
            this.Controls.Add(this.EditGoalsButton);
            this.Controls.Add(this.CurrentDailyCaloriesLabel);
            this.Controls.Add(this.DailyCaloricTargetLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WeeklyWeightChangeGoalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TargetWeightLabel);
            this.Controls.Add(this.CurrentWeightLabel);
            this.Controls.Add(this.DailyCaloricTargetBox);
            this.Controls.Add(this.WeeklyWeightChangeGoalBox);
            this.Controls.Add(this.CurrentDailyCaloriesBox);
            this.Controls.Add(this.TargetWeightBox);
            this.Controls.Add(this.CurrentWeightBox);
            this.Controls.Add(this.WeightHistoryLabel);
            this.Controls.Add(this.WeightTrackingChart);
            this.Controls.Add(this.GoalsPgLogo);
            this.Name = "Goals";
            this.Text = "Goals";
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeightTrackingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoalsPgLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeightTrackingChart;
        private System.Windows.Forms.Label WeightHistoryLabel;
        private System.Windows.Forms.TextBox CurrentWeightBox;
        private System.Windows.Forms.TextBox TargetWeightBox;
        private System.Windows.Forms.TextBox CurrentDailyCaloriesBox;
        private System.Windows.Forms.TextBox WeeklyWeightChangeGoalBox;
        private System.Windows.Forms.TextBox DailyCaloricTargetBox;
        private System.Windows.Forms.Label CurrentWeightLabel;
        private System.Windows.Forms.Label TargetWeightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WeeklyWeightChangeGoalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DailyCaloricTargetLabel;
        private System.Windows.Forms.Label CurrentDailyCaloriesLabel;
        private System.Windows.Forms.Button EditGoalsButton;
        private System.Windows.Forms.Button RefreshProgButton;
    }
}