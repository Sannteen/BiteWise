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


using System;
using System.Drawing;
using System.Windows.Forms;

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
            if (form == null)
            {
                MessageBox.Show("Error: Cannot load a null form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            panelMain.Controls.Add(form);

            // Center form in panel
            form.Location = new Point(
                (panelMain.Width - form.Width) / 2,
                (panelMain.Height - form.Height) / 2
            );

            form.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadFormInPanel(new Dashboard());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLbl.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
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
            LoadFormInPanel(new UserSettings(this));
        }

        //private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LoadFormInPanel(new SummaryForm());
        //}

        private void logFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Load a dedicated Food Logging form instead of SummaryForm
            LoadFormInPanel(new ExerciseAndFoodLog()); // Placeholder
        }

        private void logWorkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Load a dedicated Workout Logging form instead of SummaryForm
            LoadFormInPanel(new ExerciseAndFoodLog()); // Placeholder
        }

        private void logEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dailySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new SummaryForm());
        }
    }
}