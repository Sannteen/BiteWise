namespace BiteWiseApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.tbNetCalsdb = new System.Windows.Forms.TextBox();
            this.tbTotalCalsBurneddb = new System.Windows.Forms.TextBox();
            this.tbTotalCalsConsumeddb = new System.Windows.Forms.TextBox();
            this.tbCurrentWeightdb = new System.Windows.Forms.TextBox();
            this.cbUserdb = new System.Windows.Forms.ComboBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfileBT = new System.Windows.Forms.Button();
            this.chWeightProgressdb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLogFooddb = new System.Windows.Forms.Button();
            this.btnViewProgressbd = new System.Windows.Forms.Button();
            this.btnLogWorkoutdb = new System.Windows.Forms.Button();
            this.dashboardLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWeightProgressdb)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(60, 102);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.splitContainer1.Panel1.Controls.Add(this.ProfilePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.tbNetCalsdb);
            this.splitContainer1.Panel1.Controls.Add(this.tbTotalCalsBurneddb);
            this.splitContainer1.Panel1.Controls.Add(this.tbTotalCalsConsumeddb);
            this.splitContainer1.Panel1.Controls.Add(this.tbCurrentWeightdb);
            this.splitContainer1.Panel1.Controls.Add(this.cbUserdb);
            this.splitContainer1.Panel1.Controls.Add(this.labeluser);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.ProfileBT);
            this.splitContainer1.Panel2.Controls.Add(this.chWeightProgressdb);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogFooddb);
            this.splitContainer1.Panel2.Controls.Add(this.btnViewProgressbd);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogWorkoutdb);
            this.splitContainer1.Size = new System.Drawing.Size(857, 474);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 71;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePictureBox.ErrorImage = null;
            this.ProfilePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ProfilePictureBox.InitialImage")));
            this.ProfilePictureBox.Location = new System.Drawing.Point(92, 37);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(201, 201);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureBox.TabIndex = 79;
            this.ProfilePictureBox.TabStop = false;
            // 
            // tbNetCalsdb
            // 
            this.tbNetCalsdb.Location = new System.Drawing.Point(194, 420);
            this.tbNetCalsdb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNetCalsdb.Name = "tbNetCalsdb";
            this.tbNetCalsdb.Size = new System.Drawing.Size(118, 23);
            this.tbNetCalsdb.TabIndex = 78;
            // 
            // tbTotalCalsBurneddb
            // 
            this.tbTotalCalsBurneddb.Location = new System.Drawing.Point(244, 383);
            this.tbTotalCalsBurneddb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTotalCalsBurneddb.Name = "tbTotalCalsBurneddb";
            this.tbTotalCalsBurneddb.Size = new System.Drawing.Size(68, 23);
            this.tbTotalCalsBurneddb.TabIndex = 77;
            // 
            // tbTotalCalsConsumeddb
            // 
            this.tbTotalCalsConsumeddb.Location = new System.Drawing.Point(269, 346);
            this.tbTotalCalsConsumeddb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTotalCalsConsumeddb.Name = "tbTotalCalsConsumeddb";
            this.tbTotalCalsConsumeddb.Size = new System.Drawing.Size(43, 23);
            this.tbTotalCalsConsumeddb.TabIndex = 76;
            // 
            // tbCurrentWeightdb
            // 
            this.tbCurrentWeightdb.Location = new System.Drawing.Point(194, 309);
            this.tbCurrentWeightdb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCurrentWeightdb.Name = "tbCurrentWeightdb";
            this.tbCurrentWeightdb.Size = new System.Drawing.Size(118, 23);
            this.tbCurrentWeightdb.TabIndex = 75;
            // 
            // cbUserdb
            // 
            this.cbUserdb.FormattingEnabled = true;
            this.cbUserdb.Location = new System.Drawing.Point(122, 272);
            this.cbUserdb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUserdb.Name = "cbUserdb";
            this.cbUserdb.Size = new System.Drawing.Size(190, 23);
            this.cbUserdb.TabIndex = 74;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(78, 279);
            this.labeluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(40, 16);
            this.labeluser.TabIndex = 73;
            this.labeluser.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Net Calories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Total Calories Burned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Total Calories Consumed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Current Weight";
            // 
            // ProfileBT
            // 
            this.ProfileBT.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBT.Location = new System.Drawing.Point(362, 78);
            this.ProfileBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProfileBT.Name = "ProfileBT";
            this.ProfileBT.Size = new System.Drawing.Size(96, 27);
            this.ProfileBT.TabIndex = 75;
            this.ProfileBT.Text = "View Profile";
            this.ProfileBT.UseVisualStyleBackColor = true;
            this.ProfileBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // chWeightProgressdb
            // 
            chartArea1.Name = "ChartArea1";
            this.chWeightProgressdb.ChartAreas.Add(chartArea1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Weekly Progress";
            legend1.Title = "Weight Progress";
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWeightProgressdb.Legends.Add(legend1);
            this.chWeightProgressdb.Location = new System.Drawing.Point(28, 149);
            this.chWeightProgressdb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chWeightProgressdb.Name = "chWeightProgressdb";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Weekly Progress";
            series1.Name = "Days";
            this.chWeightProgressdb.Series.Add(series1);
            this.chWeightProgressdb.Size = new System.Drawing.Size(428, 275);
            this.chWeightProgressdb.TabIndex = 74;
            this.chWeightProgressdb.Text = "Weight Progress";
            this.chWeightProgressdb.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // btnLogFooddb
            // 
            this.btnLogFooddb.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogFooddb.Location = new System.Drawing.Point(17, 78);
            this.btnLogFooddb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogFooddb.Name = "btnLogFooddb";
            this.btnLogFooddb.Size = new System.Drawing.Size(96, 27);
            this.btnLogFooddb.TabIndex = 73;
            this.btnLogFooddb.Text = "Log Food";
            this.btnLogFooddb.UseVisualStyleBackColor = true;
            this.btnLogFooddb.Click += new System.EventHandler(this.btnLogFooddb_Click);
            // 
            // btnViewProgressbd
            // 
            this.btnViewProgressbd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProgressbd.Location = new System.Drawing.Point(247, 78);
            this.btnViewProgressbd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewProgressbd.Name = "btnViewProgressbd";
            this.btnViewProgressbd.Size = new System.Drawing.Size(96, 27);
            this.btnViewProgressbd.TabIndex = 72;
            this.btnViewProgressbd.Text = "View Progress";
            this.btnViewProgressbd.UseVisualStyleBackColor = true;
            // 
            // btnLogWorkoutdb
            // 
            this.btnLogWorkoutdb.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogWorkoutdb.Location = new System.Drawing.Point(132, 78);
            this.btnLogWorkoutdb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogWorkoutdb.Name = "btnLogWorkoutdb";
            this.btnLogWorkoutdb.Size = new System.Drawing.Size(96, 27);
            this.btnLogWorkoutdb.TabIndex = 71;
            this.btnLogWorkoutdb.Text = "Log Workout";
            this.btnLogWorkoutdb.UseVisualStyleBackColor = true;
            this.btnLogWorkoutdb.Click += new System.EventHandler(this.btnLogWorkoutdb_Click);
            // 
            // dashboardLB
            // 
            this.dashboardLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dashboardLB.AutoSize = true;
            this.dashboardLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardLB.ForeColor = System.Drawing.Color.DarkCyan;
            this.dashboardLB.Location = new System.Drawing.Point(281, 34);
            this.dashboardLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboardLB.Name = "dashboardLB";
            this.dashboardLB.Size = new System.Drawing.Size(572, 42);
            this.dashboardLB.TabIndex = 69;
            this.dashboardLB.Text = "Welcome to BitWise Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 706);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dashboardLB);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWeightProgressdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label dashboardLB;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.TextBox tbNetCalsdb;
        private System.Windows.Forms.TextBox tbTotalCalsBurneddb;
        private System.Windows.Forms.TextBox tbTotalCalsConsumeddb;
        private System.Windows.Forms.TextBox tbCurrentWeightdb;
        private System.Windows.Forms.ComboBox cbUserdb;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProfileBT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chWeightProgressdb;
        private System.Windows.Forms.Button btnLogFooddb;
        private System.Windows.Forms.Button btnViewProgressbd;
        private System.Windows.Forms.Button btnLogWorkoutdb;
    }
}