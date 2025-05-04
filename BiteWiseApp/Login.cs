using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiteWiseApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

//using System;
//using System.Data;
//using System.Linq;
//using System.Windows.Forms;
//using BiteWiseApp.Classes;

namespace BiteWiseApp
{
    public partial class Login : Form
    {
        UserLogin Ul = new UserLogin();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Any initialization logic if needed
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Check if the username is empty
            if (UsernameTB.Text == "")
            {
                MessageBox.Show("Please enter your username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameTB.Focus();
                return;
            }

            // Check if the password is empty
            if (PasswordTB.Text == "")
            {
                MessageBox.Show("Please enter your Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTB.Focus();
                return;
            }

            try
            {
                string email = UsernameTB.Text.Trim();
                string password = PasswordTB.Text.Trim();

                // Validate user credentials
                string accountStatus = Ul.ValidateUser(email, password);

                // If the user is validated and active
                if (accountStatus == "0")
                {
                    // Retrieve user info to set the logged-in user session
                    using (var db = new BiteWiseDBEntities())
                    {
                        var user = db.Users.FirstOrDefault(u => u.email == email && u.password == password);
                        if (user != null)
                        {
                            // Set the logged-in user ID in session
                            Session.LoggedInUserId = user.user_id;
                        }
                    }

                    // Proceed to MainMenu Form
                    MainMenu MM = new MainMenu();
                    this.Hide();
                    MM.Show();
                    MM.UsernameTxt.Text = "Current User: " + email;

                    // Show successful login message
                    MessageBox.Show("Login successful! Welcome " + email, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (accountStatus == "1")
                {
                    // Account locked
                    MessageBox.Show("Your account is locked. Please contact support.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid credentials. Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any error that occurs during login
                MessageBox.Show("Error: " + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the sign-up form
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change (if needed)
        }
    }
}
