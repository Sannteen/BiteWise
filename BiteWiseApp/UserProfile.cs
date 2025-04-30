using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.IO;

namespace BiteWiseApp
{
    public partial class UserProfileForm: Form

    {
        private readonly BiteWiseDBEntities1 biteWiseDBEntities;
        public UserProfileForm()
        {
            InitializeComponent();
            biteWiseDBEntities = new BiteWiseDBEntities1();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes save successfully");
        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordtextBox.PasswordChar = '*';
        }

        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordcheckBox.Checked)
            {
                PasswordtextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordtextBox.PasswordChar = '*';
            }
        }

        byte[] imageBytes = null;
        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.Title = "Select an Image";
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    imageBytes = File.ReadAllBytes(filePath);

                    // Display image in PictureBox
                    ProfilePictureBox.Image = Image.FromFile(filePath);
                }

                if (imageBytes != null)
                {
                    int userId = Session.LoggedInUserId;

                    using (var db = new BiteWiseDBEntities1())
                    {
                        var existing = db.User_Picture.FirstOrDefault(x => x.user_Id == userId);

                        if (existing != null)
                        {
                            existing.image = imageBytes;
                        }
                        else
                        {
                            db.User_Picture.Add(new User_Picture
                            {
                                user_Id = userId,
                                image = imageBytes
                            });
                        }

                        db.SaveChanges();
                        MessageBox.Show("Image uploaded successfully.", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an image before uploading.", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public static class Session
        {
            public static int LoggedInUserId { get; set; }
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

            int currentUserId = Session.LoggedInUserId; 

            var currentUser = biteWiseDBEntities.Users.FirstOrDefault(u => u.user_id == currentUserId);

            if (currentUser != null)
            {
                nametextBox.Text = currentUser.name;
                EmailtextBox.Text = currentUser.email;
                PasswordtextBox.Text = currentUser.password;
                AgenumericUpDown.Value = (decimal) currentUser.age;
                HeightnumericUpDown.Value = (decimal) currentUser.height;
                WeightnumericUpDown.Value = (decimal) currentUser.weight;
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
