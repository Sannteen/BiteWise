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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DailySumarylabel = new System.Windows.Forms.Label();
            this.DatePickfordailysumry = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.foodloglabel = new System.Windows.Forms.Label();
            this.WoutoutLogLabel = new System.Windows.Forms.Label();
            this.FoodLogDataGridView = new System.Windows.Forms.DataGridView();
            this.WorkoutLogDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalCalBurned = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalCalConsumedcircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.TotalCalConsumedLabel = new System.Windows.Forms.Label();
            this.NetCaloriesLabel = new System.Windows.Forms.Label();
            this.NetCaloriesProgressBar = new CircularProgressBar.CircularProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FoodExeContainer1 = new System.Windows.Forms.SplitContainer();
            this.ExeNameLbl = new System.Windows.Forms.Label();
            this.CaloriesBrnLbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CaloriesBrnTb = new System.Windows.Forms.TextBox();
            this.BtnLogExercise = new System.Windows.Forms.Button();
            this.ExeDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FooddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.CalConsumedtextBox2 = new System.Windows.Forms.TextBox();
            this.FoodNameTb = new System.Windows.Forms.TextBox();
            this.FoodDate = new System.Windows.Forms.Label();
            this.CalConsumedLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FoodLogLb = new System.Windows.Forms.Label();
            this.ExelogLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FoodLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCalBurned)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodExeContainer1)).BeginInit();
            this.FoodExeContainer1.Panel1.SuspendLayout();
            this.FoodExeContainer1.Panel2.SuspendLayout();
            this.FoodExeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DailySumarylabel
            // 
            this.DailySumarylabel.AutoSize = true;
            this.DailySumarylabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySumarylabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.DailySumarylabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DailySumarylabel.Location = new System.Drawing.Point(345, 15);
            this.DailySumarylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DailySumarylabel.Name = "DailySumarylabel";
            this.DailySumarylabel.Size = new System.Drawing.Size(445, 38);
            this.DailySumarylabel.TabIndex = 14;
            this.DailySumarylabel.Text = "Logs and Daily Summary ";
            this.DailySumarylabel.Click += new System.EventHandler(this.DailySumarylabel_Click);
            // 
            // DatePickfordailysumry
            // 
            this.DatePickfordailysumry.AllowDrop = true;
            this.DatePickfordailysumry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickfordailysumry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePickfordailysumry.Location = new System.Drawing.Point(127, 86);
            this.DatePickfordailysumry.Margin = new System.Windows.Forms.Padding(2);
            this.DatePickfordailysumry.MaxDate = new System.DateTime(9998, 1, 12, 0, 0, 0, 0);
            this.DatePickfordailysumry.Name = "DatePickfordailysumry";
            this.DatePickfordailysumry.Size = new System.Drawing.Size(318, 23);
            this.DatePickfordailysumry.TabIndex = 15;
            this.DatePickfordailysumry.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(59, 86);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 20);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date";
            // 
            // foodloglabel
            // 
            this.foodloglabel.AutoSize = true;
            this.foodloglabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodloglabel.Location = new System.Drawing.Point(40, 15);
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
            this.WoutoutLogLabel.Location = new System.Drawing.Point(302, 15);
            this.WoutoutLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WoutoutLogLabel.Name = "WoutoutLogLabel";
            this.WoutoutLogLabel.Size = new System.Drawing.Size(108, 20);
            this.WoutoutLogLabel.TabIndex = 21;
            this.WoutoutLogLabel.Text = "Workout Log";
            // 
            // FoodLogDataGridView
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FoodLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.FoodLogDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FoodLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodLogDataGridView.Location = new System.Drawing.Point(31, 47);
            this.FoodLogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FoodLogDataGridView.Name = "FoodLogDataGridView";
            this.FoodLogDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FoodLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.FoodLogDataGridView.RowTemplate.Height = 28;
            this.FoodLogDataGridView.Size = new System.Drawing.Size(245, 156);
            this.FoodLogDataGridView.TabIndex = 26;
            // 
            // WorkoutLogDataGridView
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.WorkoutLogDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkoutLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkoutLogDataGridView.Location = new System.Drawing.Point(307, 47);
            this.WorkoutLogDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.WorkoutLogDataGridView.Name = "WorkoutLogDataGridView";
            this.WorkoutLogDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.WorkoutLogDataGridView.RowTemplate.Height = 28;
            this.WorkoutLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WorkoutLogDataGridView.Size = new System.Drawing.Size(303, 156);
            this.WorkoutLogDataGridView.TabIndex = 30;
            // 
            // TotalCalBurned
            // 
            chartArea3.Name = "ChartArea1";
            this.TotalCalBurned.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.TotalCalBurned.Legends.Add(legend3);
            this.TotalCalBurned.Location = new System.Drawing.Point(721, 443);
            this.TotalCalBurned.Margin = new System.Windows.Forms.Padding(2);
            this.TotalCalBurned.Name = "TotalCalBurned";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "Protein";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.Name = "Fat";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series9.Legend = "Legend1";
            series9.Name = "Carbs";
            this.TotalCalBurned.Series.Add(series7);
            this.TotalCalBurned.Series.Add(series8);
            this.TotalCalBurned.Series.Add(series9);
            this.TotalCalBurned.Size = new System.Drawing.Size(419, 234);
            this.TotalCalBurned.TabIndex = 7;
            this.TotalCalBurned.Text = "Body Measurement History ";
            title3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Total Calories Burned";
            this.TotalCalBurned.Titles.Add(title3);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TotalCalConsumedcircularProgressBar);
            this.panel2.Controls.Add(this.TotalCalConsumedLabel);
            this.panel2.Controls.Add(this.NetCaloriesLabel);
            this.panel2.Controls.Add(this.NetCaloriesProgressBar);
            this.panel2.Location = new System.Drawing.Point(721, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 272);
            this.panel2.TabIndex = 32;
            // 
            // TotalCalConsumedcircularProgressBar
            // 
            this.TotalCalConsumedcircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.TotalCalConsumedcircularProgressBar.AnimationSpeed = 500;
            this.TotalCalConsumedcircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.TotalCalConsumedcircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCalConsumedcircularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalCalConsumedcircularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalCalConsumedcircularProgressBar.InnerMargin = 2;
            this.TotalCalConsumedcircularProgressBar.InnerWidth = -1;
            this.TotalCalConsumedcircularProgressBar.Location = new System.Drawing.Point(21, 84);
            this.TotalCalConsumedcircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.TotalCalConsumedcircularProgressBar.Name = "TotalCalConsumedcircularProgressBar";
            this.TotalCalConsumedcircularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.TotalCalConsumedcircularProgressBar.OuterMargin = -25;
            this.TotalCalConsumedcircularProgressBar.OuterWidth = 26;
            this.TotalCalConsumedcircularProgressBar.ProgressColor = System.Drawing.Color.Turquoise;
            this.TotalCalConsumedcircularProgressBar.ProgressWidth = 25;
            this.TotalCalConsumedcircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCalConsumedcircularProgressBar.Size = new System.Drawing.Size(155, 155);
            this.TotalCalConsumedcircularProgressBar.StartAngle = 270;
            this.TotalCalConsumedcircularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TotalCalConsumedcircularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TotalCalConsumedcircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TotalCalConsumedcircularProgressBar.SubscriptText = "";
            this.TotalCalConsumedcircularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TotalCalConsumedcircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TotalCalConsumedcircularProgressBar.SuperscriptText = "%";
            this.TotalCalConsumedcircularProgressBar.TabIndex = 35;
            this.TotalCalConsumedcircularProgressBar.Text = "0";
            this.TotalCalConsumedcircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.TotalCalConsumedcircularProgressBar.Value = 68;
            // 
            // TotalCalConsumedLabel
            // 
            this.TotalCalConsumedLabel.AutoSize = true;
            this.TotalCalConsumedLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCalConsumedLabel.Location = new System.Drawing.Point(17, 47);
            this.TotalCalConsumedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCalConsumedLabel.Name = "TotalCalConsumedLabel";
            this.TotalCalConsumedLabel.Size = new System.Drawing.Size(191, 20);
            this.TotalCalConsumedLabel.TabIndex = 34;
            this.TotalCalConsumedLabel.Text = "Total Calories Consumed";
            this.TotalCalConsumedLabel.Click += new System.EventHandler(this.TotalCalConsumedLabel_Click);
            // 
            // NetCaloriesLabel
            // 
            this.NetCaloriesLabel.AutoSize = true;
            this.NetCaloriesLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCaloriesLabel.Location = new System.Drawing.Point(269, 47);
            this.NetCaloriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NetCaloriesLabel.Name = "NetCaloriesLabel";
            this.NetCaloriesLabel.Size = new System.Drawing.Size(98, 20);
            this.NetCaloriesLabel.TabIndex = 33;
            this.NetCaloriesLabel.Text = "Net Calories";
            this.NetCaloriesLabel.Click += new System.EventHandler(this.NetCaloriesLabel_Click);
            // 
            // NetCaloriesProgressBar
            // 
            this.NetCaloriesProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.NetCaloriesProgressBar.AnimationSpeed = 500;
            this.NetCaloriesProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.NetCaloriesProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCaloriesProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NetCaloriesProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NetCaloriesProgressBar.InnerMargin = 2;
            this.NetCaloriesProgressBar.InnerWidth = -1;
            this.NetCaloriesProgressBar.Location = new System.Drawing.Point(246, 84);
            this.NetCaloriesProgressBar.MarqueeAnimationSpeed = 2000;
            this.NetCaloriesProgressBar.Name = "NetCaloriesProgressBar";
            this.NetCaloriesProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.NetCaloriesProgressBar.OuterMargin = -25;
            this.NetCaloriesProgressBar.OuterWidth = 26;
            this.NetCaloriesProgressBar.ProgressColor = System.Drawing.Color.Turquoise;
            this.NetCaloriesProgressBar.ProgressWidth = 25;
            this.NetCaloriesProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetCaloriesProgressBar.Size = new System.Drawing.Size(155, 155);
            this.NetCaloriesProgressBar.StartAngle = 270;
            this.NetCaloriesProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.NetCaloriesProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NetCaloriesProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.NetCaloriesProgressBar.SubscriptText = "";
            this.NetCaloriesProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.NetCaloriesProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.NetCaloriesProgressBar.SuperscriptText = "%";
            this.NetCaloriesProgressBar.TabIndex = 0;
            this.NetCaloriesProgressBar.Text = "0";
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
            this.panel3.Size = new System.Drawing.Size(645, 245);
            this.panel3.TabIndex = 33;
            // 
            // FoodExeContainer1
            // 
            this.FoodExeContainer1.Location = new System.Drawing.Point(29, 455);
            this.FoodExeContainer1.Name = "FoodExeContainer1";
            // 
            // FoodExeContainer1.Panel1
            // 
            this.FoodExeContainer1.Panel1.Controls.Add(this.ExelogLb);
            this.FoodExeContainer1.Panel1.Controls.Add(this.ExeDateTimePicker1);
            this.FoodExeContainer1.Panel1.Controls.Add(this.BtnLogExercise);
            this.FoodExeContainer1.Panel1.Controls.Add(this.CaloriesBrnTb);
            this.FoodExeContainer1.Panel1.Controls.Add(this.textBox1);
            this.FoodExeContainer1.Panel1.Controls.Add(this.Datelbl);
            this.FoodExeContainer1.Panel1.Controls.Add(this.CaloriesBrnLbl);
            this.FoodExeContainer1.Panel1.Controls.Add(this.ExeNameLbl);
            // 
            // FoodExeContainer1.Panel2
            // 
            this.FoodExeContainer1.Panel2.Controls.Add(this.FoodLogLb);
            this.FoodExeContainer1.Panel2.Controls.Add(this.FooddateTimePicker1);
            this.FoodExeContainer1.Panel2.Controls.Add(this.button1);
            this.FoodExeContainer1.Panel2.Controls.Add(this.CalConsumedtextBox2);
            this.FoodExeContainer1.Panel2.Controls.Add(this.FoodNameTb);
            this.FoodExeContainer1.Panel2.Controls.Add(this.FoodDate);
            this.FoodExeContainer1.Panel2.Controls.Add(this.CalConsumedLbl);
            this.FoodExeContainer1.Panel2.Controls.Add(this.label3);
            this.FoodExeContainer1.Size = new System.Drawing.Size(645, 242);
            this.FoodExeContainer1.SplitterDistance = 332;
            this.FoodExeContainer1.TabIndex = 34;
            // 
            // ExeNameLbl
            // 
            this.ExeNameLbl.AutoSize = true;
            this.ExeNameLbl.Location = new System.Drawing.Point(68, 84);
            this.ExeNameLbl.Name = "ExeNameLbl";
            this.ExeNameLbl.Size = new System.Drawing.Size(83, 15);
            this.ExeNameLbl.TabIndex = 0;
            this.ExeNameLbl.Text = "Exercise Name";
            // 
            // CaloriesBrnLbl
            // 
            this.CaloriesBrnLbl.AutoSize = true;
            this.CaloriesBrnLbl.Location = new System.Drawing.Point(68, 115);
            this.CaloriesBrnLbl.Name = "CaloriesBrnLbl";
            this.CaloriesBrnLbl.Size = new System.Drawing.Size(90, 15);
            this.CaloriesBrnLbl.TabIndex = 1;
            this.CaloriesBrnLbl.Text = "Calories Burned";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(71, 145);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(31, 15);
            this.Datelbl.TabIndex = 2;
            this.Datelbl.Text = "Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // CaloriesBrnTb
            // 
            this.CaloriesBrnTb.Location = new System.Drawing.Point(157, 115);
            this.CaloriesBrnTb.Name = "CaloriesBrnTb";
            this.CaloriesBrnTb.Size = new System.Drawing.Size(100, 23);
            this.CaloriesBrnTb.TabIndex = 4;
            // 
            // BtnLogExercise
            // 
            this.BtnLogExercise.Location = new System.Drawing.Point(117, 185);
            this.BtnLogExercise.Name = "BtnLogExercise";
            this.BtnLogExercise.Size = new System.Drawing.Size(91, 23);
            this.BtnLogExercise.TabIndex = 6;
            this.BtnLogExercise.Text = "Log Exercise";
            this.BtnLogExercise.UseVisualStyleBackColor = true;
            // 
            // ExeDateTimePicker1
            // 
            this.ExeDateTimePicker1.CustomFormat = "00/00/0000";
            this.ExeDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExeDateTimePicker1.Location = new System.Drawing.Point(157, 144);
            this.ExeDateTimePicker1.Name = "ExeDateTimePicker1";
            this.ExeDateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.ExeDateTimePicker1.TabIndex = 7;
            this.ExeDateTimePicker1.Value = new System.DateTime(2025, 5, 3, 0, 4, 34, 0);
            this.ExeDateTimePicker1.ValueChanged += new System.EventHandler(this.ExeDateTimePicker1_ValueChanged);
            // 
            // FooddateTimePicker1
            // 
            this.FooddateTimePicker1.CustomFormat = "00/00/0000";
            this.FooddateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FooddateTimePicker1.Location = new System.Drawing.Point(157, 145);
            this.FooddateTimePicker1.Name = "FooddateTimePicker1";
            this.FooddateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.FooddateTimePicker1.TabIndex = 14;
            this.FooddateTimePicker1.Value = new System.DateTime(2025, 5, 3, 0, 4, 34, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Log Food";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CalConsumedtextBox2
            // 
            this.CalConsumedtextBox2.Location = new System.Drawing.Point(157, 115);
            this.CalConsumedtextBox2.Name = "CalConsumedtextBox2";
            this.CalConsumedtextBox2.Size = new System.Drawing.Size(100, 23);
            this.CalConsumedtextBox2.TabIndex = 12;
            // 
            // FoodNameTb
            // 
            this.FoodNameTb.Location = new System.Drawing.Point(157, 76);
            this.FoodNameTb.Name = "FoodNameTb";
            this.FoodNameTb.Size = new System.Drawing.Size(100, 23);
            this.FoodNameTb.TabIndex = 11;
            // 
            // FoodDate
            // 
            this.FoodDate.AutoSize = true;
            this.FoodDate.Location = new System.Drawing.Point(50, 145);
            this.FoodDate.Name = "FoodDate";
            this.FoodDate.Size = new System.Drawing.Size(31, 15);
            this.FoodDate.TabIndex = 10;
            this.FoodDate.Text = "Date";
            // 
            // CalConsumedLbl
            // 
            this.CalConsumedLbl.AutoSize = true;
            this.CalConsumedLbl.Location = new System.Drawing.Point(47, 115);
            this.CalConsumedLbl.Name = "CalConsumedLbl";
            this.CalConsumedLbl.Size = new System.Drawing.Size(110, 15);
            this.CalConsumedLbl.TabIndex = 9;
            this.CalConsumedLbl.Text = "Calories Consumed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Food Name";
            // 
            // FoodLogLb
            // 
            this.FoodLogLb.AutoSize = true;
            this.FoodLogLb.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodLogLb.Location = new System.Drawing.Point(90, 19);
            this.FoodLogLb.Name = "FoodLogLb";
            this.FoodLogLb.Size = new System.Drawing.Size(120, 30);
            this.FoodLogLb.TabIndex = 8;
            this.FoodLogLb.Text = "FOOD LOG";
            // 
            // ExelogLb
            // 
            this.ExelogLb.AutoSize = true;
            this.ExelogLb.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExelogLb.Location = new System.Drawing.Point(83, 19);
            this.ExelogLb.Name = "ExelogLb";
            this.ExelogLb.Size = new System.Drawing.Size(158, 30);
            this.ExelogLb.TabIndex = 9;
            this.ExelogLb.Text = "EXERCISE LOG";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 749);
            this.Controls.Add(this.FoodExeContainer1);
            this.Controls.Add(this.TotalCalBurned);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.FoodExeContainer1.Panel1.ResumeLayout(false);
            this.FoodExeContainer1.Panel1.PerformLayout();
            this.FoodExeContainer1.Panel2.ResumeLayout(false);
            this.FoodExeContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodExeContainer1)).EndInit();
            this.FoodExeContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NetCaloriesLabel;
        private CircularProgressBar.CircularProgressBar NetCaloriesProgressBar;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar TotalCalConsumedcircularProgressBar;
        private System.Windows.Forms.Label TotalCalConsumedLabel;
        private System.Windows.Forms.SplitContainer FoodExeContainer1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label CaloriesBrnLbl;
        private System.Windows.Forms.Label ExeNameLbl;
        private System.Windows.Forms.Button BtnLogExercise;
        private System.Windows.Forms.TextBox CaloriesBrnTb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker ExeDateTimePicker1;
        private System.Windows.Forms.DateTimePicker FooddateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CalConsumedtextBox2;
        private System.Windows.Forms.TextBox FoodNameTb;
        private System.Windows.Forms.Label FoodDate;
        private System.Windows.Forms.Label CalConsumedLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FoodLogLb;
        private System.Windows.Forms.Label ExelogLb;
    }
}