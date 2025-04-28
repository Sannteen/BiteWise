using System;
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
    public partial class ExerciseAndFoodLog: Form
    {
        public ExerciseAndFoodLog()
        {
            InitializeComponent();
            
        }


        private void SearchNtn_Click(object sender, EventArgs e)
        {

            try 
            {

              
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Work Log Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExerciseSearchLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biteWiseDBDataSet1.User_Work_log' table. You can move, or remove it, as needed.
            this.user_Work_logTableAdapter1.Fill(this.biteWiseDBDataSet1.User_Work_log);

            try
            {

            }

            catch (Exception ex) 
            {


                MessageBox.Show(ex.Message,"Exercise Logs",MessageBoxButtons.OK,MessageBoxIcon.Error);
                GC.Collect();
            
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
