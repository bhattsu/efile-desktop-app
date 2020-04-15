using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFileApp
{
    public partial class frmAddCaseparty : Form
    {
        firmSettings settings;

        public frmAddCaseparty()
        {
            InitializeComponent();
        }

        public frmAddCaseparty(firmSettings settings)
        {
            this.settings = settings;
            InitializeComponent();
        }
    }
}
