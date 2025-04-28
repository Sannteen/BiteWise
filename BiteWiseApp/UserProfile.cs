using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity;
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

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select Profile Picture";
                dialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    ProfilePictureBox.ImageLocation = imageLocation;

                    //SaveImagePathToDatabase(imageLocation); 

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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
    }
    }
