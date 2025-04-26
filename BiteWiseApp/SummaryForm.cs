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
           var foodSummary = biteWiseDBEntities.Foods
                .GroupBy(f => f.category)
                .Select(g => new
            {
               Category = g.Key,
               TotalCalories = g.Sum(f => f.calories)
            })
                .ToList();

                FoodLogDataGridView.DataSource = foodSummary;


            var workoutSummary = biteWiseDBEntities.Exercises
                .GroupBy(ex => ex.name)
                .Select(g => new
                {
                    Exercise = g.Key,
                    CaloriesBurned = g.Sum(ex => ex.calories_burned_per_min)
                })
                .ToList();

            WorkoutLogDataGridView.DataSource = workoutSummary;
        }

      
    }
}
