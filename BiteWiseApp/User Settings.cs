using System;
using System.Linq;
using System.Windows.Forms;
using BiteWiseApp.Classes;

namespace BiteWiseApp
{
    public partial class UserSettings : Form
    {
        private readonly int _currentUserId;
        private readonly BiteWiseDBEntities biteWiseDBEntities;
        private readonly MainMenu _mainMenu;

        public UserSettings(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu ?? throw new ArgumentNullException(nameof(mainMenu));
            _currentUserId = Session.LoggedInUserId;
            biteWiseDBEntities = new BiteWiseDBEntities();
            Load += UserSettings_Load;
            Resize += (s, e) => CenterContentPanel();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        private void CenterContentPanel()
        {
            if (CenterPanel == null)
            {
                return;
            }

            CenterPanel.Left = (ClientSize.Width - CenterPanel.Width) / 2;
            CenterPanel.Top = (ClientSize.Height - CenterPanel.Height) / 2;
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
                    using (var db = new BiteWiseDBEntities())
                    {
                        var user = db.Users.SingleOrDefault(u => u.user_id == _currentUserId);
                        if (user == null)
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var foodLogs = db.FoodLogs.Where(f => f.User_Id == _currentUserId).ToList();
                        var workoutLogs = db.WorkoutLogs.Where(w => w.user_id == _currentUserId).ToList();

                        db.FoodLogs.RemoveRange(foodLogs);
                        db.WorkoutLogs.RemoveRange(workoutLogs);
                        db.Users.Remove(user);

                        db.SaveChanges();

                        MessageBox.Show("Your profile and all related data have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _mainMenu.Close();
                        new Login().Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting your profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdatePasswordbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdatePasswordbutton_Click_1(object sender, EventArgs e)
        {

            //if (_mainMenu == null)
            //{
            //    MessageBox.Show("Error: Main menu reference is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //_mainMenu.LoadFormInPanel(new UserProfileForm());

            using (var userProfileForm = new UserProfileForm())
            {
                userProfileForm.ShowDialog(); // Shows as a modal dialog
            }
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {

        }
    }
}