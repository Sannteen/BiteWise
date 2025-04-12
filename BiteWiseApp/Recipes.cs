using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiteWiseApp
{
    public partial class Recipes: Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the connection string from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["BiteWiseDB_Connect"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to fetch a random recipe from the JamaicanRecipes table
                    string query = @"
                        SELECT TOP 1 
                            recipename, 
                            description, 
                            calories_Per_Serving, 
                            ingredients, 
                            instructions 
                        FROM JamaicanRecipes 
                        ORDER BY NEWID()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Format and display the recipe details in the RecipeDisplayTxtBx
                                RecipeDisplayTxtBx.Text =
                                    $"Recipe Name: {reader["recipename"]}\r\n\r\n" +
                                    $"Description: {reader["description"]}\r\n\r\n" +
                                    $"Calories Per Serving: {reader["calories_per_serving"]}\r\n\r\n" +
                                    $"Ingredients:\r\n{reader["ingredients"]}\r\n\r\n" +
                                    $"Instructions:\r\n{reader["instructions"]}";
                            }
                            else
                            {
                                MessageBox.Show("No Jamaican recipes found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Recipes_Load(object sender, EventArgs e)
        {

        }
    }
}
