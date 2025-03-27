using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BiteWiseApp.Classes
{
    class User_Registration
    {


        public void Registration(string name, string email, string Password, int Age, string Gender, decimal Height, decimal Weight,
            string ActivityLvl, string Goal, int LockStatus, DateTime CreationDate, int Login_Attempts)
        {

            string strconn = ("Data Source=23.95.235.16,1433;Network Library=DBMSSOCN;Initial Catalog=BiteWiseDB;User ID=vtdi_student;Password=P@ssword1;");

            using (SqlConnection Dbconn = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand("SignUp",Dbconn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name.ToString();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email.ToString();
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password.ToString();
                    cmd.Parameters.Add("@Age", SqlDbType.Int).Value = int.Parse(Age.ToString());
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender.ToString();
                    cmd.Parameters.Add("@Height", SqlDbType.Decimal).Value = Decimal.Parse(Height.ToString());
                    cmd.Parameters.Add("@Weight", SqlDbType.Decimal).Value = Decimal.Parse(Weight.ToString());
                    cmd.Parameters.Add("@ActivityLvl", SqlDbType.VarChar).Value = ActivityLvl.ToString();
                    cmd.Parameters.Add("@Goal", SqlDbType.VarChar).Value = Goal.ToString();
                    cmd.Parameters.Add("@LockStatus", SqlDbType.SmallInt).Value = int.Parse(LockStatus.ToString());
                    cmd.Parameters.Add("@Creation_Date", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@Login_Attempts", SqlDbType.Int).Value = Login_Attempts;

                    try
                    {
                        Dbconn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration completed Successfully", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {

                        Dbconn.Close();

                    }

                }

            }
        }
    }
}
