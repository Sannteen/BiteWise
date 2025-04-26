namespace BiteWiseApp
{
    partial class Recipes
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
            this.JamRecipeSearchTxtBx = new System.Windows.Forms.TextBox();
            this.JamRecipeSearchLabel = new System.Windows.Forms.Label();
            this.RecipeDisplayTxtBx = new System.Windows.Forms.TextBox();
            this.RecipeOfDayLabel = new System.Windows.Forms.Label();
            this.BitwiseLogoRecipes = new System.Windows.Forms.Label();
            this.GetRecipeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JamRecipeSearchTxtBx
            // 
            this.JamRecipeSearchTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JamRecipeSearchTxtBx.Location = new System.Drawing.Point(48, 46);
            this.JamRecipeSearchTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JamRecipeSearchTxtBx.Name = "JamRecipeSearchTxtBx";
            this.JamRecipeSearchTxtBx.Size = new System.Drawing.Size(523, 23);
            this.JamRecipeSearchTxtBx.TabIndex = 0;
            // 
            // JamRecipeSearchLabel
            // 
            this.JamRecipeSearchLabel.AutoSize = true;
            this.JamRecipeSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JamRecipeSearchLabel.Location = new System.Drawing.Point(49, 24);
            this.JamRecipeSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JamRecipeSearchLabel.Name = "JamRecipeSearchLabel";
            this.JamRecipeSearchLabel.Size = new System.Drawing.Size(217, 20);
            this.JamRecipeSearchLabel.TabIndex = 1;
            this.JamRecipeSearchLabel.Text = "Search Jamaican Recipes";
            // 
            // RecipeDisplayTxtBx
            // 
            this.RecipeDisplayTxtBx.Location = new System.Drawing.Point(48, 123);
            this.RecipeDisplayTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecipeDisplayTxtBx.Multiline = true;
            this.RecipeDisplayTxtBx.Name = "RecipeDisplayTxtBx";
            this.RecipeDisplayTxtBx.Size = new System.Drawing.Size(523, 112);
            this.RecipeDisplayTxtBx.TabIndex = 2;
            this.RecipeDisplayTxtBx.TextChanged += new System.EventHandler(this.RecipeDisplayTxtBx_TextChanged);
            // 
            // RecipeOfDayLabel
            // 
            this.RecipeOfDayLabel.AutoSize = true;
            this.RecipeOfDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeOfDayLabel.Location = new System.Drawing.Point(49, 93);
            this.RecipeOfDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecipeOfDayLabel.Name = "RecipeOfDayLabel";
            this.RecipeOfDayLabel.Size = new System.Drawing.Size(201, 20);
            this.RecipeOfDayLabel.TabIndex = 3;
            this.RecipeOfDayLabel.Text = "Your Recipe of the Day!";
            // 
            // BitwiseLogoRecipes
            // 
            this.BitwiseLogoRecipes.AutoSize = true;
            this.BitwiseLogoRecipes.Font = new System.Drawing.Font("Juice ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitwiseLogoRecipes.ForeColor = System.Drawing.Color.Red;
            this.BitwiseLogoRecipes.Location = new System.Drawing.Point(354, 249);
            this.BitwiseLogoRecipes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BitwiseLogoRecipes.Name = "BitwiseLogoRecipes";
            this.BitwiseLogoRecipes.Size = new System.Drawing.Size(187, 72);
            this.BitwiseLogoRecipes.TabIndex = 8;
            this.BitwiseLogoRecipes.Text = "BiteWise";
            // 
            // GetRecipeBtn
            // 
            this.GetRecipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRecipeBtn.Location = new System.Drawing.Point(52, 269);
            this.GetRecipeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetRecipeBtn.Name = "GetRecipeBtn";
            this.GetRecipeBtn.Size = new System.Drawing.Size(195, 51);
            this.GetRecipeBtn.TabIndex = 9;
            this.GetRecipeBtn.Text = "Get New Recipe";
            this.GetRecipeBtn.UseVisualStyleBackColor = true;
            this.GetRecipeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 337);
            this.Controls.Add(this.GetRecipeBtn);
            this.Controls.Add(this.BitwiseLogoRecipes);
            this.Controls.Add(this.RecipeOfDayLabel);
            this.Controls.Add(this.RecipeDisplayTxtBx);
            this.Controls.Add(this.JamRecipeSearchLabel);
            this.Controls.Add(this.JamRecipeSearchTxtBx);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Recipes";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.Recipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JamRecipeSearchTxtBx;
        private System.Windows.Forms.Label JamRecipeSearchLabel;
        private System.Windows.Forms.TextBox RecipeDisplayTxtBx;
        private System.Windows.Forms.Label RecipeOfDayLabel;
        private System.Windows.Forms.Label BitwiseLogoRecipes;
        private System.Windows.Forms.Button GetRecipeBtn;
    }
}