using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiteWiseApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiteWiseApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            /* Email Validation Variable delcaration */
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";



            if (NameTB.Text == "")
            {
                MessageBox.Show("Please enter your Name", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTB.Focus();
            }

            else

            if(EmailTB.Text == "")
            {
                MessageBox.Show("Please enter your email", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTB.Focus();
            }
            
            else
 
            if (!Regex.IsMatch(EmailTB.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address enter your email", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTB.Focus();
            }

            else

            if (AgeTB.Text == "")
            {
                MessageBox.Show("Please enter your Age", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AgeTB.Focus();
            }

            else

            if (!int.TryParse(AgeTB.Text, out _))
            {
                MessageBox.Show("Please enter a valid Age.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AgeTB.Clear();
                AgeTB.Focus();
            }

            else

            if (GenderCB.Text == "")
            {
                MessageBox.Show("Please select your Gender", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GenderCB.Focus();
            }

            else

            if (WeightTB.Text == "")
            {
                MessageBox.Show("Please enter your weight", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WeightTB.Focus();
            }


            else

            if (HeightTB.Text == "")
            {
                MessageBox.Show("Please enter your height", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HeightTB.Focus();
            }

            else

            if (GoalTB.Text == "")
            {
                MessageBox.Show("Please enter your Goal", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GoalTB.Focus();
            }

            else

            if (ActivityLvlTB.Text == "")
            {
                MessageBox.Show("Please select your activity level", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActivityLvlTB.Focus();
            }

            else
            {


                string Name = NameTB.Text.Trim();
                string Email = EmailTB.Text.Trim();
                string Password = PasswordTB.Text.Trim();
                int Age = int.Parse(AgeTB.Text.Trim());
                string Gender = GenderCB.Text.Trim();
                decimal Height = Decimal.Parse(HeightTB.Text.Trim());
                decimal Weight = Decimal.Parse(HeightTB.Text.Trim());
                String ActivityLvl = ActivityLvlTB.Text.Trim();
                string Goal = GoalTB.Text.Trim();
                int LockStatus = 0;
                DateTime CreationDate = DateTime.Now;
                int Login_Attempts = 0;


                try

                {

                    User_Registration UR = new User_Registration();
                    UR.Registration(Name, Email, Password, Age, Gender, Height, Weight, ActivityLvl, Goal, LockStatus, CreationDate, Login_Attempts);
                    
                    this.Hide();
                    Login Log = new Login();
                    Log.Show();

                }

                catch (Exception es)
                {

                    MessageBox.Show(es.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
