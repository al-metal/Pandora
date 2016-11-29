using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.percent = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.percent = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            int percent = Properties.Settings.Default.percent;
            numericUpDown1.Value = percent;
        }
    }
}
