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
        public UserProfileForm()
        {
            InitializeComponent();
        }

        string ImageLocation;





        private void profilepictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void profilepicture_Click(object sender, EventArgs e)
        {

        }

        private void savechangesbutn_Click(object sender, EventArgs e)
        {

        }

        private void AgetxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeighttxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DCaloricTgetLabel_Click(object sender, EventArgs e)
        {

        }

        private void PicUploadbutton_Click(object sender, EventArgs e)
        {
             try
            {
                //Select & filter Image by file Extension.
                OpenFileDialog Ofd = new OpenFileDialog();
                Ofd.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*gif |PNG Files (*.png)|*png |All Files (*.*)|*.*";
                Ofd.Title = "Profile Picture";


                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageLocation = Ofd.FileName.ToString();
                    profilepicture.ImageLocation = ImageLocation;
                }

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Profile Picture" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
