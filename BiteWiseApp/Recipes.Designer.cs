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
            this.RecipeSearchBox = new System.Windows.Forms.TextBox();
            this.SearchJamRecipesLabel = new System.Windows.Forms.Label();
            this.RecipeDisplayBox = new System.Windows.Forms.TextBox();
            this.RecipeoftheDayLabel = new System.Windows.Forms.Label();
            this.RecipePgLogo = new System.Windows.Forms.Label();
            this.RandomRecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipeSearchBox
            // 
            this.RecipeSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeSearchBox.Location = new System.Drawing.Point(62, 61);
            this.RecipeSearchBox.Name = "RecipeSearchBox";
            this.RecipeSearchBox.Size = new System.Drawing.Size(672, 26);
            this.RecipeSearchBox.TabIndex = 0;
            // 
            // SearchJamRecipesLabel
            // 
            this.SearchJamRecipesLabel.AutoSize = true;
            this.SearchJamRecipesLabel.Location = new System.Drawing.Point(63, 32);
            this.SearchJamRecipesLabel.Name = "SearchJamRecipesLabel";
            this.SearchJamRecipesLabel.Size = new System.Drawing.Size(194, 20);
            this.SearchJamRecipesLabel.TabIndex = 1;
            this.SearchJamRecipesLabel.Text = "Search Jamaican Recipes";
            // 
            // RecipeDisplayBox
            // 
            this.RecipeDisplayBox.Location = new System.Drawing.Point(62, 165);
            this.RecipeDisplayBox.Multiline = true;
            this.RecipeDisplayBox.Name = "RecipeDisplayBox";
            this.RecipeDisplayBox.Size = new System.Drawing.Size(671, 149);
            this.RecipeDisplayBox.TabIndex = 2;
            // 
            // RecipeoftheDayLabel
            // 
            this.RecipeoftheDayLabel.AutoSize = true;
            this.RecipeoftheDayLabel.Location = new System.Drawing.Point(63, 125);
            this.RecipeoftheDayLabel.Name = "RecipeoftheDayLabel";
            this.RecipeoftheDayLabel.Size = new System.Drawing.Size(178, 20);
            this.RecipeoftheDayLabel.TabIndex = 3;
            this.RecipeoftheDayLabel.Text = "Your Recipe of the Day!";
            // 
            // RecipePgLogo
            // 
            this.RecipePgLogo.AutoSize = true;
            this.RecipePgLogo.Font = new System.Drawing.Font("Juice ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipePgLogo.ForeColor = System.Drawing.Color.Red;
            this.RecipePgLogo.Location = new System.Drawing.Point(455, 332);
            this.RecipePgLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecipePgLogo.Name = "RecipePgLogo";
            this.RecipePgLogo.Size = new System.Drawing.Size(279, 109);
            this.RecipePgLogo.TabIndex = 8;
            this.RecipePgLogo.Text = "BiteWise";
            // 
            // RandomRecipeButton
            // 
            this.RandomRecipeButton.Location = new System.Drawing.Point(67, 359);
            this.RandomRecipeButton.Name = "RandomRecipeButton";
            this.RandomRecipeButton.Size = new System.Drawing.Size(251, 67);
            this.RandomRecipeButton.TabIndex = 9;
            this.RandomRecipeButton.Text = "Get New Recipe";
            this.RandomRecipeButton.UseVisualStyleBackColor = true;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomRecipeButton);
            this.Controls.Add(this.RecipePgLogo);
            this.Controls.Add(this.RecipeoftheDayLabel);
            this.Controls.Add(this.RecipeDisplayBox);
            this.Controls.Add(this.SearchJamRecipesLabel);
            this.Controls.Add(this.RecipeSearchBox);
            this.Name = "Recipes";
            this.Text = "Recipes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecipeSearchBox;
        private System.Windows.Forms.Label SearchJamRecipesLabel;
        private System.Windows.Forms.TextBox RecipeDisplayBox;
        private System.Windows.Forms.Label RecipeoftheDayLabel;
        private System.Windows.Forms.Label RecipePgLogo;
        private System.Windows.Forms.Button RandomRecipeButton;
    }
}