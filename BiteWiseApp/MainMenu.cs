using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiteWiseApp.Properties;


namespace BiteWiseApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        public void LoadFormInPanel(Form form)
        {
            panelMain.Controls.Clear();              // Remove existing child controls
            form.TopLevel = false;                   // Important: embed form in panel
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            panelMain.Controls.Add(form);

            //center in panel
            form.Location = new Point(
               (panelMain.Width - form.Width) / 2,
               (panelMain.Height - form.Height) / 2
           );

            form.Show();
        }

        private void recipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void userPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
       {
          //  LoadFormInPanel(new ProgressTrackingForm());
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new SummaryForm());
        }

        private void getRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // LoadFormInPanel(new Recipes());
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new Dashboard());
            
        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TimerLbl_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            this.TimerLbl.Text = Time.ToString();

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Dashboard());
        }

        private void userProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new UserProfileForm());
        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new UserSettings());
        }

        private void logFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new SummaryForm());
        }

        private void logWorkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new SummaryForm());
        }

        
    }
}
