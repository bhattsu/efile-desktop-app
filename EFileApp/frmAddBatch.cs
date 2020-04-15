using EFileApp.Bal;
using EFileApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EFileApp
{
    public partial class frmAddBatch : Form
    {
        BackgroundWorker BGBatchProcess;
        private bool issimulation = false;
        public string BatchId { get; set; }

        public frmAddBatch()
        {
            InitializeComponent();
            //Background Worker for  process
            BGBatchProcess = new BackgroundWorker();
            BGBatchProcess.DoWork += BGBatchProcess_DoWork;
            BGBatchProcess.ProgressChanged += BGBatchProcess_ProgressChanged;
            BGBatchProcess.RunWorkerCompleted += BGBatchProcess_RunWorkerCompleted;
            BGBatchProcess.WorkerReportsProgress = true;
            BGBatchProcess.WorkerSupportsCancellation = true;
        }

        private void frmAddBatch_Load(object sender, EventArgs e)
        {
            try
            {
                // txtBatchId.Text = "BULK_" + DateTime.Now.ToString("MMddyyyy_HHmmss");
                txtJsonTemplateLocation.Text = Properties.Settings.Default.DefaultTemplateLocation;
                txtTSVFileLocation.Text = Properties.Settings.Default.DefaultTsvFile;
                LoadCases();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void frmAddBatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (BGBatchProcess.IsBusy)
                {
                    if (MessageBox.Show("This will abort current eFile process,Are you sure to exit?", "Inquire",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BGBatchProcess.CancelAsync();
                        // e.Cancel = true;
                    }
                    else
                        e.Cancel = true;

                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void btnCreateBatch_Click(object sender, EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                if (!BGBatchProcess.IsBusy && btnStart.Text.Equals("&Start"))
                {
                    progressBar1.Visible = true;
                    BGBatchProcess.RunWorkerAsync();
                }
                else if (BGBatchProcess.IsBusy && btnStart.Text.Equals("&Stop"))
                {
                    if (MessageBox.Show("Are you sure to stop the eFile process?", "Inquire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BGBatchProcess.CancelAsync();
                    }

                }

                if (btnStart.Text.Equals("&Start"))
                {
                    btnStart.Text = "&Stop";
                    EnableDisableControls(false);
                }
                else
                {
                    btnStart.Text = "&Start";
                    EnableDisableControls(true);
                }
            }

            catch (Exception ex)
            {
                progressBar1.Visible = false;
                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    txtTSVFileLocation.Text = openFileDialog1.FileName;
                    LoadCases();
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }

        #region Batch Process Background worker
        private void BGBatchProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string templatepath = Path.Combine(txtJsonTemplateLocation.Text, AppConstants.LoginState);

                List<Dictionary<string, string>> parsedTable = BatchBL.ParseXSVFile(txtTSVFileLocation.Text);

                Dictionary<string, string> templates = BatchBL.InitiTemplates(templatepath);
                var results = new List<dynamic>();
                int counter = 0;
                int TotalRecord = parsedTable.Count;
                LogManager.Trace(String.Format("Add to batch process started  for batch {0}.", BatchId));
                foreach (var tableRow in parsedTable)
                {
                    if (BGBatchProcess.CancellationPending)
                    {
                        LogManager.Trace(String.Format("Add to batch process stopped by user for batch {0}.", BatchId));
                        e.Cancel = true;
                        break;
                    }
                    //Read each row of data	
                    tableRow.Add("batch_id", BatchId);

                    var line = string.Join(AppConstants.XSV_SEPERATOR, tableRow.Values);

                    String payload = null;
                    string template = null;
                    if (tableRow.ContainsKey("template"))
                    {
                        template = tableRow["template"];
                    }
                    if (template != null && template.Trim().Length > 0)
                    {
                        if (templates.ContainsKey(template))
                        {
                            payload = templates[template];
                        }
                    }
                    else
                    {
                        if (tableRow["case_number"].ToString().Trim().Length == 0)
                        {
                            template = "NEW";
                        }
                        else
                        {
                            template = "EXISTING";

                        }

                        if (templates.ContainsKey(template))
                        {
                            payload = templates[template];
                        }
                    }

                    //--------------------------------------------------------------------------------
                    var filepaths = new List<string>();

                    if (payload != null)
                    {
                        foreach (KeyValuePair<string, string> entry in tableRow)
                        {
                            var value = entry.Value;
                            if (entry.Value.EndsWith(AppConstants.PDF_PATTERN))
                            {
                                filepaths.Add(value);
                                value = Path.GetFileName(value);
                            }
                            payload = payload.Replace("${" + entry.Key + "}", value);
                        }
                    }

                    var id = tableRow["id"];
                    int progress = (counter * 100) / TotalRecord;
                    BGBatchProcess.ReportProgress(progress, id + "-Started-" + "efile process started.");
                    try
                    {
                        if(payload == null)
                        {
                            throw new Exception("Template not found: " + template);
                        }
                        LogManager.Trace(String.Format("eFile for batch- {0} and  id {1} started ", BatchId, id));
                        dynamic response = AppConstants.ApiCaller.Efile(id, payload, filepaths); //It is important that you update your database immidiately here with response before doing other things
                        results.Add(response);
                        LogManager.Trace(String.Format("eFile for batch- {0} and id {1} completed ", BatchId, id));

                        BGBatchProcess.ReportProgress(progress, id + "-Completed-" + "eFile process completed");
                    }
                    catch (Exception ex)
                    {
                        BGBatchProcess.ReportProgress(progress, id + "-Failed-" + ex.Message);
                    }

                    counter++;


                }
                e.Result = results;
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void BGBatchProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                string progress = (string)e.UserState;
                if (progress.Length > 0 && !String.IsNullOrEmpty(progress))
                {
                    var status = progress.Split('-');
                    if (status.Length >= 3)
                        UpdateStatus(status[0], status[1], status[2]);

                }
                progressBar1.Value = e.ProgressPercentage;

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }

        private void BGBatchProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                this.Cursor = Cursors.Default;
                if (e.Cancelled)
                    return;

                List<dynamic> processResult = (List<dynamic>)e.Result;
                this.Cursor = Cursors.Default;
                progressBar1.Visible = false;
                if (processResult == null)
                    return;

                LogManager.Trace(String.Format("Add to Batch process completed for batch- {0} ", BatchId));

                MessageBox.Show("Batch creation process completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //EnableDisableControls(true);
                //btnStart.Text = "&Start";
                btnStart.Visible = false;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }
        #endregion  Batch Process Background worker

        private void EnableDisableControls(bool IsEnabled)
        {
            try
            {
                txtJsonTemplateLocation.Enabled = IsEnabled;
                txtTSVFileLocation.Enabled = IsEnabled;
                btnSelectTemplates.Enabled = IsEnabled;
                btnSelectTsvLocation.Enabled = IsEnabled;
                progressBar1.Visible = !IsEnabled;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadCases()
        {
            try
            {
                if (File.Exists(txtTSVFileLocation.Text.Trim()))
                {
                    List<Dictionary<string, string>> parsedTable = BatchBL.ParseXSVFile(txtTSVFileLocation.Text);
                    dgCases.Rows.Clear();
                    foreach (var tableRow in parsedTable)
                    { //Read each row of data	
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.Height = 30;
                        dr.CreateCells(dgCases);
                        dr.Cells[0].Value = tableRow["id"].ToString();
                        if (tableRow.ContainsKey("template")){
                            dr.Cells[1].Value = tableRow["template"].ToString();
                        }
                        if (tableRow.ContainsKey("case_number"))
                        {
                            dr.Cells[2].Value = tableRow["case_number"].ToString();
                        }
                        if (tableRow.ContainsKey("jurisdiction"))
                        {
                            dr.Cells[3].Value = tableRow["jurisdiction"].ToString();
                        }
                        dr.Cells[6].Value = "Preview";
                        dgCases.Rows.Add(dr);
                    }
                    dgCases.Refresh();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateStatus(string id, string currentStatus, string message)
        {
            try
            {
                for (int i = 0; i < dgCases.Rows.Count; i++)
                {
                    if (dgCases.Rows[i].Cells[0].Value.ToString() == id)
                    {
                        dgCases.Rows[i].Cells[3].Value = currentStatus;
                        dgCases.Rows[i].Cells[4].Value = message;
                        dgCases.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex == -1)
                    return;
                int selectedIndex = dgCases.CurrentCell.RowIndex;
                int selectedCol = dgCases.CurrentCell.ColumnIndex;

                var id = dgCases.Rows[selectedIndex].Cells[0].Value;


                string templatepath = Path.Combine(txtJsonTemplateLocation.Text, AppConstants.LoginState);

                List<Dictionary<string, string>> parsedTable = BatchBL.ParseXSVFile(txtTSVFileLocation.Text);

                Dictionary<string, string> templates = BatchBL.InitiTemplates(templatepath);

                foreach (var tableRow in parsedTable)
                {
                    //Read each row of data	
                    if (id.Equals(tableRow["id"]))
                    {

                        tableRow.Add("batch_id", BatchId);

                        var line = string.Join(AppConstants.XSV_SEPERATOR, tableRow.Values);

                        String payload = null;
                        string template = null;

                        if (tableRow.ContainsKey("template"))
                        {
                            template = tableRow["template"];
                        }

                        if (template != null && template.Trim().Length > 0)
                        {
                            if (templates.ContainsKey(template))
                            {
                                payload = templates[template];
                            }
                        }
                        else
                        {
                            if (!tableRow.ContainsKey("case_number") || tableRow["case_number"].ToString().Trim().Length == 0)
                            {
                                template = "NEW";
                            }
                            else
                            {
                                template = "EXISTING";

                            }

                            if (templates.ContainsKey(template))
                            {
                                payload = templates[template];
                            }
                        }

                        if (payload == null)
                        {
                            MessageBox.Show("Template: " + template + " Not Found" );
                        }
                        else
                        {

                            foreach (KeyValuePair<string, string> entry in tableRow)
                            {
                                var value = entry.Value;
                                if (entry.Value.EndsWith(AppConstants.PDF_PATTERN))
                                {
                                    value = Path.GetFileName(value);
                                }
                                payload = payload.Replace("${" + entry.Key + "}", value);
                            }

                            frmPayload frmPayload = new frmPayload();
                            frmPayload.Payload = payload;
                            frmPayload.ShowDialog();
                        }
                    }


                }


            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }
    }
}
