namespace BiteWiseApp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsernameTxt = new System.Windows.Forms.Label();
            this.TimerLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.progressTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.logEntriesToolStripMenuItem,
            this.goalsToolStripMenuItem,
            this.userPreferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // logEntriesToolStripMenuItem
            // 
            this.logEntriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logFoodToolStripMenuItem,
            this.logWorkoutToolStripMenuItem});
            this.logEntriesToolStripMenuItem.Name = "logEntriesToolStripMenuItem";
            this.logEntriesToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.logEntriesToolStripMenuItem.Text = "Log Entries";
            // 
            // logFoodToolStripMenuItem
            // 
            this.logFoodToolStripMenuItem.Name = "logFoodToolStripMenuItem";
            this.logFoodToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.logFoodToolStripMenuItem.Text = "Log Food";
            this.logFoodToolStripMenuItem.Click += new System.EventHandler(this.logFoodToolStripMenuItem_Click);
            // 
            // logWorkoutToolStripMenuItem
            // 
            this.logWorkoutToolStripMenuItem.Name = "logWorkoutToolStripMenuItem";
            this.logWorkoutToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.logWorkoutToolStripMenuItem.Text = "Log Workout";
            this.logWorkoutToolStripMenuItem.Click += new System.EventHandler(this.logWorkoutToolStripMenuItem_Click);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressTrackingToolStripMenuItem,
            this.dailySummaryToolStripMenuItem});
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.goalsToolStripMenuItem.Text = "Progress";
            this.goalsToolStripMenuItem.Click += new System.EventHandler(this.goalsToolStripMenuItem_Click);
            // 
            // userPreferencesToolStripMenuItem
            // 
            this.userPreferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userProfileToolStripMenuItem,
            this.userSettingsToolStripMenuItem});
            this.userPreferencesToolStripMenuItem.Name = "userPreferencesToolStripMenuItem";
            this.userPreferencesToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.userPreferencesToolStripMenuItem.Text = "Profile";
            this.userPreferencesToolStripMenuItem.Click += new System.EventHandler(this.userPreferencesToolStripMenuItem_Click);
            // 
            // userProfileToolStripMenuItem
            // 
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            this.userProfileToolStripMenuItem.Click += new System.EventHandler(this.userProfileToolStripMenuItem_Click_1);
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.userSettingsToolStripMenuItem.Text = "User Settings";
            this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.userSettingsToolStripMenuItem_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.UsernameTxt.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxt.Location = new System.Drawing.Point(784, 4);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(16, 24);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.Text = "*";
            // 
            // TimerLbl
            // 
            this.TimerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimerLbl.AutoSize = true;
            this.TimerLbl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLbl.ForeColor = System.Drawing.Color.Black;
            this.TimerLbl.Location = new System.Drawing.Point(999, 5);
            this.TimerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(16, 24);
            this.TimerLbl.TabIndex = 3;
            this.TimerLbl.Text = "*";
            this.TimerLbl.Click += new System.EventHandler(this.TimerLbl_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1133, 539);
            this.panelMain.TabIndex = 5;
            
            // 
            // progressTrackingToolStripMenuItem
            // 
            this.progressTrackingToolStripMenuItem.Name = "progressTrackingToolStripMenuItem";
            this.progressTrackingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressTrackingToolStripMenuItem.Text = "Progress Tracking";
            // 
            // dailySummaryToolStripMenuItem
            // 
            this.dailySummaryToolStripMenuItem.Name = "dailySummaryToolStripMenuItem";
            this.dailySummaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dailySummaryToolStripMenuItem.Text = "Daily Summary";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 570);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.TimerLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goalsToolStripMenuItem;
        public System.Windows.Forms.Label UsernameTxt;
        public System.Windows.Forms.Label TimerLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logWorkoutToolStripMenuItem;
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem progressTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySummaryToolStripMenuItem;
    }
}