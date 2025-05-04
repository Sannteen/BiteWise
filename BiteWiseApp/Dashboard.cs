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
using BiteWiseApp.Classes;
using System.Data.Entity;
using System.IO;


namespace BiteWiseApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            int userId = Session.LoggedInUserId;

            using (var db = new BiteWiseDBEntities())
            {
                // Fetch basic user info
                var user = db.Users.FirstOrDefault(u => u.user_id == userId);
                // Fetch image from User_Picture table
                var userImage = db.User_Picture.FirstOrDefault(p => p.user_Id == userId);
                // Fetch today's summary from DailySummary
                var today = DateTime.Today;
                var dailySummary = db.DailySummaries
                      .FirstOrDefault(s => s.user_id == userId && s.date == today);


                if (user != null)
                {
                    cbUserdb.Text = user.name;
                    tbCurrentWeightdb.Text = user.weight?.ToString() ?? "N/A";
                }

                if (dailySummary != null)
                {
                    tbTotalCalsConsumeddb.Text = dailySummary.total_calories_consumed?.ToString() ?? "0";
                    tbTotalCalsBurneddb.Text = dailySummary.total_calories_burned?.ToString() ?? "0";

                    int netCals = (int)((dailySummary.total_calories_consumed ?? 0) - (dailySummary.total_calories_burned ?? 0));
                    tbNetCalsdb.Text = netCals.ToString();
                }
                else
                {
                    tbTotalCalsConsumeddb.Text = "0";
                    tbTotalCalsBurneddb.Text = "0";
                    tbNetCalsdb.Text = "0";
                }

                if (userImage != null && userImage.image != null)
                {
                    using (MemoryStream ms = new MemoryStream(userImage.image))
                    {
                        ProfilePictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        

        // Navigation Buttons
        private void btnLogWorkoutdb_Click(object sender, EventArgs e)
        {
            ExerciseAndFoodLog logForm = new ExerciseAndFoodLog();
            ((MainMenu)this.ParentForm).LoadFormInPanel(logForm);
        }

        private void btnLogFooddb_Click(object sender, EventArgs e)
        {
            ExerciseAndFoodLog logForm = new ExerciseAndFoodLog();
            ((MainMenu)this.ParentForm).LoadFormInPanel(logForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm();
            ((MainMenu)this.ParentForm).LoadFormInPanel(profileForm);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
