using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiteWiseApp
{
    public partial class SummaryForm: Form
    {
        private readonly BiteWiseDBEntities1 biteWiseDBEntities;
        public SummaryForm()
        {
            InitializeComponent();
            biteWiseDBEntities = new BiteWiseDBEntities1();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            var FoodLog = biteWiseDBEntities.Foods.ToList(); 
            FoodLogDataGridView.DataSource = FoodLog;
        }

        private void WorkoutLogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FoodLogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
