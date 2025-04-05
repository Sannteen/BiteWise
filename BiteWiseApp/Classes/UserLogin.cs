using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BiteWiseApp.Classes
{
    class UserLogin
    {



        public string ValidateUser(string email, string Password)
        {
            string accountStatus = "Invalid"; // Default to invalid credentials

            // Update this connection string as per your database configuration
            string connectionString =  (ConfigurationManager.ConnectionStrings["BiteWiseDB_Connect"].ConnectionString);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("User_Login_test", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add input parameters
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@Password", Password);

                        // Add output parameter
                        SqlParameter outParam = new SqlParameter
                        {
                            ParameterName = "@IsAccountUnlocked",
                            SqlDbType = SqlDbType.SmallInt,
                            Size = 50,
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outParam);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        // Get the output parameter value
                        accountStatus = outParam.Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return accountStatus;
        }

    }

}
