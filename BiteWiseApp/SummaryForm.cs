using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiteWiseApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiteWiseApp
{
    public partial class SummaryForm: Form
    {
        private readonly int _currentUserId;
        private readonly BiteWiseDBEntities biteWiseDBEntities;
        public SummaryForm()
        {
            InitializeComponent();
            _currentUserId = Session.LoggedInUserId;
            biteWiseDBEntities = new BiteWiseDBEntities();
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


            var workoutSummary = (from wl in biteWiseDBEntities.WorkoutLogs
                                  join ex in biteWiseDBEntities.Exercises
                                  on wl.exercise_id equals ex.exercise_id
                                  group new { wl, ex } by ex.name into g
                                  select new
                                  {
                                      Exercise = g.Key,
                                      TotalDuration = g.Sum(x => x.wl.duration),
                                      CaloriesBurned = g.Sum(x => x.wl.duration * x.ex.calories_burned_per_min)
                                  })
                     .ToList();

            WorkoutLogDataGridView.DataSource = workoutSummary;
        }

        private void DailySumarylabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalCalConsumedLabel_Click(object sender, EventArgs e)
        {

        }

        private void NetCaloriesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExeDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DailySumarylabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
