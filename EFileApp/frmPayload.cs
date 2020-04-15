using EFileApp.Helper;
using Newtonsoft.Json.Linq;
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
    public partial class frmPayload : Form
    {
        private JObject payload = null;

        public string Payload { get; set; }
        public frmPayload()
        {
            
            InitializeComponent();
            savepanel.Visible = false;
        }

        public frmPayload(JObject payload)
        {
            this.payload = payload;
            InitializeComponent();
        }

        private void frmPayload_Load(object sender, EventArgs e)
        {
            try
            {
                txtPayload.Text = payload.ToString();

            }
            catch (Exception ex)
            {
                  
                LogManager.LogError(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveastemplate_Click(object sender, EventArgs e)
        {
            if(filename.Text.Length == 0)
            {
                MessageBox.Show("Please enter template name");
            } else
            {

                string tempPath = Path.Combine(Properties.Settings.Default.DefaultTemplateLocation, AppConstants.LoginState);
                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                string fileName = Path.Combine(tempPath, filename.Text + ".json");
                if (File.Exists(fileName))
                {

                    if(MessageBox.Show("Template file name already exist. Overwrite", "Validate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No){
                        return;
                    }
                }

                FileStream fs = File.Create(fileName);
                byte[] info = new UTF8Encoding(true).GetBytes(txtPayload.Text);
                fs.Write(info, 0, info.Length);
                fs.Dispose();
                this.Close();
                //settings.LoadTeamplateFiles();
                MessageBox.Show("Successfully Saved");
            }
        }
    }
}
