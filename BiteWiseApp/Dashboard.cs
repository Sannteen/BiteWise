using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiteWiseApp
{
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void LoadData() {



            //database code 
            string strconn = (ConfigurationManager.ConnectionStrings["BiteWiseDB_Connect"].ConnectionString);
            using (SqlConnection conn = new SqlConnection(strconn))
            {


                using (SqlCommand cmd = new SqlCommand("SELECT image FROM user where", conn))
               


                    try
                    {

                        conn.Open();
                        cmd.CommandType = CommandType.Text;

                      
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        conn.Close();
                    }


            






            }

        }







        private void tbUserMeassurementsdb_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationLB_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfileForm logForm = new UserProfileForm(); // Create instance of ExerciseAndFoodLog
            ((MainMenu)this.ParentForm).LoadFormInPanel(logForm); // Load it into the Main Menu panel
        }

        private void btnLogFooddb_Click(object sender, EventArgs e)
        {
            ExerciseAndFoodLog logForm = new ExerciseAndFoodLog(); 
            ((MainMenu)this.ParentForm).LoadFormInPanel(logForm); 
        }

        private void btnLogWorkoutdb_Click(object sender, EventArgs e)
        {
            ExerciseAndFoodLog logForm = new ExerciseAndFoodLog(); 
            ((MainMenu)this.ParentForm).LoadFormInPanel(logForm); 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
