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
            Recipes R1 = new Recipes();
            R1.Show();

        }
        private void userPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPreferences U1 = new UserPreferences();
            U1.Show();

        }

    }
}
