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

namespace BiteWiseApp
{
    public partial class UserSettings: Form
    {
        private readonly int _currentUserId;
        private readonly BiteWiseDBEntities biteWiseDBEntities;
        
        public UserSettings()
        {
            InitializeComponent();
            _currentUserId = Session.LoggedInUserId;
            biteWiseDBEntities = new BiteWiseDBEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteProfilebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Are you sure you want to delete your profile? This action cannot be undone.",
      "Confirm Deletion",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the user
                    var user = biteWiseDBEntities.Users.SingleOrDefault(u => u.user_id == _currentUserId);

                    if (user != null)
                    {
                        
                        var foodLogs = biteWiseDBEntities.FoodLogs.Where(f => f.User_Id == _currentUserId).ToList();
                        var workoutLogs = biteWiseDBEntities.WorkoutLogs.Where(w => w.user_id == _currentUserId).ToList();

                        biteWiseDBEntities.FoodLogs.RemoveRange(foodLogs);
                        biteWiseDBEntities.WorkoutLogs.RemoveRange(workoutLogs);

                        // Delete the user
                        biteWiseDBEntities.Users.Remove(user);

                        // Save changes to the database
                        biteWiseDBEntities.SaveChanges();

                        MessageBox.Show("Your profile and all related data have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Application.Restart(); 
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting your profile: " + ex.Message);
                }
            }
        }

        private void UpdatePasswordbutton_Click(object sender, EventArgs e)
        {
            var profileForm = new UserProfileForm();
            profileForm.Show();
            this.Hide();
        }
    }
}
