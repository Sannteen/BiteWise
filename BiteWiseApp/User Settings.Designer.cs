namespace BiteWiseApp
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.UserSettigslabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteProfilebutton = new System.Windows.Forms.Button();
            this.UpdatePasswordbutton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CenterPanel.BackColor = System.Drawing.Color.White;
            this.CenterPanel.Controls.Add(this.UserSettigslabel);
            this.CenterPanel.Controls.Add(this.pictureBox1);
            this.CenterPanel.Controls.Add(this.DeleteProfilebutton);
            this.CenterPanel.Controls.Add(this.UpdatePasswordbutton);
            this.CenterPanel.Controls.Add(this.Helpbutton);
            this.CenterPanel.Location = new System.Drawing.Point(12, 12);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(733, 425);
            this.CenterPanel.TabIndex = 0;
            // 
            // UserSettigslabel
            // 
            this.UserSettigslabel.AutoSize = true;
            this.UserSettigslabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettigslabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.UserSettigslabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserSettigslabel.Location = new System.Drawing.Point(245, 15);
            this.UserSettigslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserSettigslabel.Name = "UserSettigslabel";
            this.UserSettigslabel.Size = new System.Drawing.Size(243, 38);
            this.UserSettigslabel.TabIndex = 19;
            this.UserSettigslabel.Text = "User Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteProfilebutton
            // 
            this.DeleteProfilebutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProfilebutton.Location = new System.Drawing.Point(505, 345);
            this.DeleteProfilebutton.Name = "DeleteProfilebutton";
            this.DeleteProfilebutton.Size = new System.Drawing.Size(205, 53);
            this.DeleteProfilebutton.TabIndex = 17;
            this.DeleteProfilebutton.Text = "Delete Profile";
            this.DeleteProfilebutton.UseVisualStyleBackColor = true;
            // 
            // UpdatePasswordbutton
            // 
            this.UpdatePasswordbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePasswordbutton.Location = new System.Drawing.Point(264, 345);
            this.UpdatePasswordbutton.Name = "UpdatePasswordbutton";
            this.UpdatePasswordbutton.Size = new System.Drawing.Size(205, 53);
            this.UpdatePasswordbutton.TabIndex = 16;
            this.UpdatePasswordbutton.Text = "Update Password ";
            this.UpdatePasswordbutton.UseVisualStyleBackColor = true;
            this.UpdatePasswordbutton.Click += new System.EventHandler(this.UpdatePasswordbutton_Click_1);
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.Transparent;
            this.Helpbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.Location = new System.Drawing.Point(23, 345);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(205, 53);
            this.Helpbutton.TabIndex = 15;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = false;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.Controls.Add(this.CenterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserSettings";
            this.Text = "User Settings";
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label UserSettigslabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteProfilebutton;
        private System.Windows.Forms.Button UpdatePasswordbutton;
        private System.Windows.Forms.Button Helpbutton;
    }
}