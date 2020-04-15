using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFileApp
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCodeGenarator fcg = new frmCodeGenarator();
            fcg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBatches fb = new frmBatches();
            fb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firmSettings settings = new firmSettings();
            settings.Show();
        }
    }
}
