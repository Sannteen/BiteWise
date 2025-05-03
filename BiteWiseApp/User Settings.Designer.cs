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
            this.Helpbutton = new System.Windows.Forms.Button();
            this.UpdatePasswordbutton = new System.Windows.Forms.Button();
            this.DeleteProfilebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserSettigslabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.Transparent;
            this.Helpbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.Location = new System.Drawing.Point(42, 339);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(205, 53);
            this.Helpbutton.TabIndex = 0;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = false;
            // 
            // UpdatePasswordbutton
            // 
            this.UpdatePasswordbutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePasswordbutton.Location = new System.Drawing.Point(288, 339);
            this.UpdatePasswordbutton.Name = "UpdatePasswordbutton";
            this.UpdatePasswordbutton.Size = new System.Drawing.Size(205, 53);
            this.UpdatePasswordbutton.TabIndex = 1;
            this.UpdatePasswordbutton.Text = "Update Password ";
            this.UpdatePasswordbutton.UseVisualStyleBackColor = true;
            // 
            // DeleteProfilebutton
            // 
            this.DeleteProfilebutton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProfilebutton.Location = new System.Drawing.Point(525, 339);
            this.DeleteProfilebutton.Name = "DeleteProfilebutton";
            this.DeleteProfilebutton.Size = new System.Drawing.Size(205, 53);
            this.DeleteProfilebutton.TabIndex = 2;
            this.DeleteProfilebutton.Text = "Delete Profile";
            this.DeleteProfilebutton.UseVisualStyleBackColor = true;
            this.DeleteProfilebutton.Click += new System.EventHandler(this.DeleteProfilebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UserSettigslabel
            // 
            this.UserSettigslabel.AutoSize = true;
            this.UserSettigslabel.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettigslabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.UserSettigslabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserSettigslabel.Location = new System.Drawing.Point(229, 9);
            this.UserSettigslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserSettigslabel.Name = "UserSettigslabel";
            this.UserSettigslabel.Size = new System.Drawing.Size(358, 56);
            this.UserSettigslabel.TabIndex = 14;
            this.UserSettigslabel.Text = "User Settings";
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.Controls.Add(this.UserSettigslabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteProfilebutton);
            this.Controls.Add(this.UpdatePasswordbutton);
            this.Controls.Add(this.Helpbutton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserSettings";
            this.Text = "User Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button UpdatePasswordbutton;
        private System.Windows.Forms.Button DeleteProfilebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserSettigslabel;
    }
}