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
    public partial class Login : Form
    {
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

                    MainMenu MM = new MainMenu();
                    MM.Show();
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
