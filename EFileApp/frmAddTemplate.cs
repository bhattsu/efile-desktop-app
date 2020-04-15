using EFileApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace EFileApp
{
    public partial class frmAddTemplate : Form
    {
        public bool IsSuccess { get; set; }
        public frmAddTemplate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.Combine(Properties.Settings.Default.DefaultTemplateLocation, AppConstants.LoginState);
                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                string fileName = Path.Combine(tempPath, txtTemplate.Text+ ".json");
                if(File.Exists(fileName))
                {
                    MessageBox.Show("Template file name already exist.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                File.Create(fileName).Dispose();

                IsSuccess = true;
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
