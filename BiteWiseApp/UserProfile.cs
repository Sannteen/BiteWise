using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiteWiseApp.Classes;

namespace BiteWiseApp
{
    public partial class UserProfileForm : Form
    {
        private readonly BiteWiseDBEntities biteWiseDBEntities;
        private User currentUser;
        private Goal currentGoals;
        private byte[] imageBytes = null;

        public UserProfileForm()
        {
            InitializeComponent();
            biteWiseDBEntities = new BiteWiseDBEntities();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            int userId = Session.LoggedInUserId;
            currentUser = biteWiseDBEntities.Users.FirstOrDefault(u => u.user_id == userId);

            if (currentUser != null)
            {
                nametextBox.Text = currentUser.name;
                EmailtextBox.Text = currentUser.email;
                PasswordtextBox.Text = currentUser.password;
                AgenumericUpDown.Value = (decimal)currentUser.age;
                HeightnumericUpDown.Value = (decimal)currentUser.height;
                WeightnumericUpDown.Value = (decimal)currentUser.weight;

                var goals = biteWiseDBEntities.Goals.FirstOrDefault(g => g.user_id == userId);
                if (goals != null)
                {
                    currentGoals = goals;
                    TargetWeightnumericUpDown.Value = (decimal)goals.target_weight;
                    decimal? daily_caloric_target = goals.daily_caloric_target;
                    DailyCalTarnumericUpDown.Value = (decimal)daily_caloric_target;
                }

                var imageEntry = biteWiseDBEntities.User_Picture.FirstOrDefault(p => p.user_Id == userId);
                if (imageEntry != null && imageEntry.image != null)
                {
                    using (var ms = new MemoryStream(imageEntry.image))
                    {
                        ProfilePictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            nametextBox.ReadOnly = false;
            EmailtextBox.ReadOnly = false;
            PasswordtextBox.ReadOnly = false;
            AgenumericUpDown.Enabled = true;
            HeightnumericUpDown.Enabled = true;
            WeightnumericUpDown.Enabled = true;
            TargetWeightnumericUpDown.Enabled = true;
            DailyCalTarnumericUpDown.Enabled = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int userId = Session.LoggedInUserId;

            if (currentUser != null)
            {
                currentUser.name = nametextBox.Text;
                currentUser.email = EmailtextBox.Text;
                currentUser.password = PasswordtextBox.Text;
                currentUser.age = (int)AgenumericUpDown.Value;
                currentUser.height = (int)HeightnumericUpDown.Value;
                currentUser.weight = (int)WeightnumericUpDown.Value;
            }

            if (currentGoals != null)
            {
                currentGoals.target_weight = (int)TargetWeightnumericUpDown.Value;
                currentGoals.daily_caloric_target = (int)DailyCalTarnumericUpDown.Value;

            }
            else
            {
                currentGoals = new Goal
                {
                    user_id = userId,
                    target_weight = (int)TargetWeightnumericUpDown.Value,
                    daily_caloric_target = (int)DailyCalTarnumericUpDown.Value
                };
                biteWiseDBEntities.Goals.Add(currentGoals);
            }

            if (imageBytes != null)
            {
                var existing = biteWiseDBEntities.User_Picture.FirstOrDefault(x => x.user_Id == userId);
                if (existing != null)
                {
                    existing.image = imageBytes;
                }
                else
                {
                    biteWiseDBEntities.User_Picture.Add(new User_Picture
                    {
                        user_Id = userId,
                        image = imageBytes
                    });
                }
            }

            try {
                biteWiseDBEntities.SaveChanges();
                MessageBox.Show("Changes saved successfully.", "User Profile",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exp){

                MessageBox.Show(exp.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 

        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                imageBytes = File.ReadAllBytes(filePath);

                ProfilePictureBox.Image = Image.FromFile(filePath);
            }
        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordtextBox.PasswordChar = '*';
        }

        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordtextBox.PasswordChar = PasswordcheckBox.Checked ? '\0' : '*';
        }
    }
}
