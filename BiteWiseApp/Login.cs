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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {


            if (UsernameTB.Text == "")
            {
                MessageBox.Show("Please enter your username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameTB.Focus();
            }

            else

           if (PasswordTB.Text == "")
            {
                MessageBox.Show("Please enter your Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTB.Focus();
            }
            else
            {
                try
                {

                    String email = UsernameTB.Text.Trim();
                    String Password = PasswordTB.Text.Trim();

                    string accountStatus = Ul.ValidateUser(email, Password);

                    if (accountStatus == "0")
                    {

                        MainMenu MM = new MainMenu();
                        this.Hide();
                        MM.Show();
                        MM.UsernameTxt.Text = email.ToString();



                        MessageBox.Show("Login successful! Welcome "+UsernameTB.Text.Trim(),"Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
                    }
                    else if (accountStatus == "1" )
                    {
                        MessageBox.Show("Your account is locked. Please contact support.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }


                }


                catch (Exception es)
                {

                    MessageBox.Show(es.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
       
        }

        private void Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            this.Hide();
            SignUp su = new SignUp();
            su.Show();


        }

           
    }
}
