using EFileApp.Helper;
using EFileApp.Models;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EFileApp
{
    public partial class firmSettings : Form
    {
        public Dictionary<string, string> LstTeamplatesFiles { get; set; }
        private bool isEdit { get; set; }
        private int lastSelected { get; set; }
        public firmSettings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettngs_Load(object sender, EventArgs e)
        {
            try
            {
                if (AppConstants.LoginState == "FL")
                {
                    //MessageBox.Show(codeGenerator.TabPages.Count.ToString());
                    codeGenerator.TabPages.RemoveAt(1);
                }
                isEdit = false;
                LogManager.Trace("Settings : Loading settings started.");
                LoadSettings();
                LogManager.Trace("Settings : Loading settings completed.");


            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }


        private void LoadSettings()
        {
            try
            {
                // this.txtProdApiEndPoint.Text = Properties.Settings.Default.ProdApiEndPoint;
                //this.txtStageApiEndpoint.Text = Properties.Settings.Default.StageApiEndPoint;
                this.txtJsonTemplateLocation.Text = Properties.Settings.Default.DefaultTemplateLocation;
                this.txtDefaultTSVFileLocation.Text = Properties.Settings.Default.DefaultTsvFile;
                this.txtDefaultOutput.Text = Properties.Settings.Default.DefaultOutpuLocation;
                if (Directory.Exists(this.txtJsonTemplateLocation.Text))
                {
                    LoadTeamplateFiles();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                LogManager.Trace("Settings : Save settings started.");
                //Properties.Settings.Default.ProdApiEndPoint = this.txtProdApiEndPoint.Text.Trim();
                //Properties.Settings.Default.StageApiEndPoint = this.txtStageApiEndpoint.Text.Trim();
                Properties.Settings.Default.DefaultTsvFile = this.txtDefaultTSVFileLocation.Text;
                Properties.Settings.Default.DefaultTemplateLocation = this.txtJsonTemplateLocation.Text;
                Properties.Settings.Default.DefaultOutpuLocation = this.txtDefaultOutput.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Application settings updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogManager.Trace("Settings : Save settings completed.");
                this.Close();

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }


        private bool ValidateInput()
        {
            try
            {

                if (!Directory.Exists(txtJsonTemplateLocation.Text))
                {
                    MessageBox.Show("Invalid JSON template folder location.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (!File.Exists(txtDefaultTSVFileLocation.Text))
                {
                    MessageBox.Show("TSV file doesn't exist or invalid path.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (String.IsNullOrEmpty(txtDefaultOutput.Text) || !Directory.Exists(txtDefaultOutput.Text))
                {
                    MessageBox.Show("Invalid default output location.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void LoadTeamplateFiles()
        {
            try
            {
                string templatePath = Path.Combine(this.txtJsonTemplateLocation.Text, AppConstants.LoginState);

                LstTeamplatesFiles = Bal.BatchBL.InitiTemplates(templatePath);
                lstTeamplates.DataSource = LstTeamplatesFiles.Keys.ToList();
                if (LstTeamplatesFiles.Count >= 1)
                {
                    lstTeamplates.SelectedIndex = 0;
                    txtTemplate.Text = LstTeamplatesFiles[LstTeamplatesFiles.Keys.ElementAt(0)];
                    lastSelected = 0;
                }
                else
                {
                    lstTeamplates.DataSource = null;
                    txtTemplate.Text = string.Empty;
                    lastSelected = -1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSelectTemplates_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtJsonTemplateLocation.Text = folderDlg.SelectedPath;
                    LoadTeamplateFiles();
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnSelectTsvLocation_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Title = "Browse TSV Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "tsv",
                    Filter = "tsv files (*.tsv)|*.tsv",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtDefaultTSVFileLocation.Text = openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }

        private void btnDefaultOutput_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDefaultOutput.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }


        private void lstTeamplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstTeamplates.SelectedIndex == -1)
                    return;

                if (txtTemplate.Modified &&
                  MessageBox.Show("Do you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstTeamplates.SelectedIndexChanged -= new EventHandler(lstTeamplates_SelectedIndexChanged);
                    SaveTemplate();
                    LoadTeamplateFiles();
                    lstTeamplates.SelectedIndexChanged += new EventHandler(lstTeamplates_SelectedIndexChanged);

                }

                lastSelected = lstTeamplates.SelectedIndex;
                txtTemplate.Text = LstTeamplatesFiles[lstTeamplates.SelectedItem.ToString()];
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddTemplate frmAddTemplate = new frmAddTemplate();
                frmAddTemplate.ShowDialog();
                if (frmAddTemplate.IsSuccess)
                {
                    LoadTeamplateFiles();
                    lstTeamplates.SelectedIndex = lstTeamplates.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTeamplates.SelectedIndex == -1)
                    return;

                if (MessageBox.Show("Are sure you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    string tempPath = Path.Combine(this.txtJsonTemplateLocation.Text, AppConstants.LoginState);
                    string selectedFile = lstTeamplates.SelectedItem.ToString() + ".json";
                    File.Delete(Path.Combine(tempPath, selectedFile));
                    lstTeamplates.SelectedIndexChanged -= new EventHandler(lstTeamplates_SelectedIndexChanged);

                    LoadTeamplateFiles();
                    lstTeamplates.SelectedIndexChanged += new EventHandler(lstTeamplates_SelectedIndexChanged);
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstTeamplates.SelectedIndex == -1)
                    return;
                string selectedBeforeSave = lstTeamplates.SelectedItem.ToString();

                lstTeamplates.SelectedIndexChanged -= new EventHandler(lstTeamplates_SelectedIndexChanged);
                SaveTemplate();
                LoadTeamplateFiles();
                lstTeamplates.SelectedIndexChanged += new EventHandler(lstTeamplates_SelectedIndexChanged);

                lstTeamplates.SelectedItem = selectedBeforeSave;
                MessageBox.Show("Template file updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void SaveTemplate()
        {
            try
            {

                string tempPath = Path.Combine(this.txtJsonTemplateLocation.Text, AppConstants.LoginState);
                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                string selectedFile = Path.Combine(tempPath, lstTeamplates.Items[lastSelected].ToString() + ".json");
                File.Delete(selectedFile);
                File.WriteAllText(selectedFile, this.txtTemplate.Text);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstTeamplates.SelectedIndex == -1)
                    return;

                // if (!txtTemplate.Text.Equals(LstTeamplatesFiles[lstTeamplates.SelectedItem.ToString()]))
                if (txtTemplate.Modified)

                    isEdit = true;
                else
                    isEdit = false;

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void txtTemplate_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (isEdit &&
                //  MessageBox.Show("Do you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    SaveTemplate();
                //}

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void lstTeamplates_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var i = lstTeamplates.SelectedIndex;
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtTemplate.Modified &&
                  MessageBox.Show("Do you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveTemplate();
                }

                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Title = "Browse json File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "json",
                    Filter = "json files (*.json)|*.json",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string tempPath = Path.Combine(this.txtJsonTemplateLocation.Text, AppConstants.LoginState);
                    if (!Directory.Exists(tempPath))
                        Directory.CreateDirectory(tempPath);
                    string destPath = Path.Combine(tempPath, Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, destPath);
                    lstTeamplates.SelectedIndexChanged -= new EventHandler(lstTeamplates_SelectedIndexChanged);

                    LoadTeamplateFiles();
                    lstTeamplates.SelectedIndexChanged += new EventHandler(lstTeamplates_SelectedIndexChanged);

                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }

        private void btnCodeGenerator_Click(object sender, EventArgs e)
        {
            frmCodeGenarator frmPayload = new frmCodeGenarator();
            frmPayload.ShowDialog();
        }
    }
}
