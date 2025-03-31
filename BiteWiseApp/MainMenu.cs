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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void recipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void userPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm upf = new UserProfileForm();
            upf.MdiParent = this;
            upf.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
       {
          ProgressTrackingForm ptf = new ProgressTrackingForm();
          ptf.MdiParent = this;
          ptf.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryForm sf = new SummaryForm();
            sf.MdiParent = this;
            sf.Show();
        }

        private void getRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Recipes R1 = new Recipes();
            R1.MdiParent = this;
            R1.Show();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
