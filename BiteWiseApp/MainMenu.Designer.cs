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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivityStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsernameTxt = new System.Windows.Forms.Label();
            this.TimerLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.recipesToolStripMenuItem,
            this.userPreferencesToolStripMenuItem,
            this.goalsToolStripMenuItem,
            this.ActivityStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // recipesToolStripMenuItem
            // 
            this.recipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getRecipesToolStripMenuItem});
            this.recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            this.recipesToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.recipesToolStripMenuItem.Text = "Recipes";
            this.recipesToolStripMenuItem.Click += new System.EventHandler(this.recipesToolStripMenuItem_Click);
            // 
            // getRecipesToolStripMenuItem
            // 
            this.getRecipesToolStripMenuItem.Name = "getRecipesToolStripMenuItem";
            this.getRecipesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.getRecipesToolStripMenuItem.Text = "Get Recipes";
            this.getRecipesToolStripMenuItem.Click += new System.EventHandler(this.getRecipesToolStripMenuItem_Click);
            // 
            // userPreferencesToolStripMenuItem
            // 
            this.userPreferencesToolStripMenuItem.Name = "userPreferencesToolStripMenuItem";
            this.userPreferencesToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.userPreferencesToolStripMenuItem.Text = "Profile";
            this.userPreferencesToolStripMenuItem.Click += new System.EventHandler(this.userPreferencesToolStripMenuItem_Click);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.summaryToolStripMenuItem});
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.goalsToolStripMenuItem.Text = "Goals";
            this.goalsToolStripMenuItem.Click += new System.EventHandler(this.goalsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem1.Text = "Progress Tracking";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // ActivityStripMenuItem
            // 
            this.ActivityStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciseToolStripMenuItem,
            this.serachToolStripMenuItem});
            this.ActivityStripMenuItem.Name = "ActivityStripMenuItem";
            this.ActivityStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.ActivityStripMenuItem.Text = "Activity Log";
            this.ActivityStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // exerciseToolStripMenuItem
            // 
            this.exerciseToolStripMenuItem.Name = "exerciseToolStripMenuItem";
            this.exerciseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exerciseToolStripMenuItem.Text = "Exercise";
            // 
            // serachToolStripMenuItem
            // 
            this.serachToolStripMenuItem.Name = "serachToolStripMenuItem";
            this.serachToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.serachToolStripMenuItem.Text = "Serach";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxt.Location = new System.Drawing.Point(701, 0);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(17, 24);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.Text = "*";
            // 
            // TimerLbl
            // 
            this.TimerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimerLbl.AutoSize = true;
            this.TimerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLbl.ForeColor = System.Drawing.Color.Black;
            this.TimerLbl.Location = new System.Drawing.Point(848, 0);
            this.TimerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(17, 24);
            this.TimerLbl.TabIndex = 3;
            this.TimerLbl.Text = "*";
            this.TimerLbl.Click += new System.EventHandler(this.TimerLbl_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 570);
            this.Controls.Add(this.TimerLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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
        private System.Windows.Forms.ToolStripMenuItem ActivityStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serachToolStripMenuItem;
        public System.Windows.Forms.Label UsernameTxt;
        public System.Windows.Forms.Label TimerLbl;
        private System.Windows.Forms.Timer timer1;
    }
}