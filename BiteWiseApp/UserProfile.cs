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
    public partial class UserProfileForm: Form

    {
        private readonly BiteWiseDBEntities biteWiseDBEntities;
        public UserProfileForm()
        {
            InitializeComponent();
            biteWiseDBEntities = new BiteWiseDBEntities();
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


    }
}
