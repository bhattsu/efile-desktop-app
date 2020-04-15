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
    public partial class frmDownloadBatch : Form
    {
        public string BatchId;
        private BackgroundWorker BGDownloader;
        public frmDownloadBatch()
        {
            InitializeComponent();
            // Instantiate BackgroundWorker and attach handlers to its
            // DoWork and RunWorkerCompleted events.
            BGDownloader = new BackgroundWorker();
            BGDownloader.DoWork += new  DoWorkEventHandler(this.BGDownloader_DoWork);
            BGDownloader.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BGDownloader_RunWorkerCompleted);
            BGDownloader.WorkerSupportsCancellation = true;
         }

        private void frmDownloadBatch_Load(object sender, EventArgs e)
        {
            try
            {
                this.BGDownloader.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }

        private void frmDownloadBatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (BGDownloader.IsBusy)
                    BGDownloader.CancelAsync();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void BGDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // progressBar1.Visible = true;
                LogManager.Trace(String.Format("Downloading batch {0} started ", BatchId));
                Bal.BatchBL.DownloadBatch(BatchId, Properties.Settings.Default.DefaultOutpuLocation);

                dynamic batchdetails = AppConstants.ApiCaller.GetBatchDetails(BatchId);
                var item = batchdetails["item"];
                var envelopes = item["envelopes"];
                string exportfolder = Properties.Settings.Default.DefaultOutpuLocation + "/BATCH_" + BatchId;
                if (!Directory.Exists(exportfolder))
                    Directory.CreateDirectory(exportfolder);
                foreach (var envelope in envelopes)
                {
                    if (BGDownloader.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    var envelope_id = envelope["envelope_id"];
                    Bal.EnvelopeBL.DownloadEnvelope(envelope_id, exportfolder);
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void BGDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    LogManager.Trace(String.Format("Downloading batch {0} cancelled by user.", BatchId));
                    return;
                }
                if (e.Error == null)
                {
                    this.progressBar1.Visible = false;
                    this.Hide();
                    LogManager.Trace(String.Format("Downloading batch {0} completed ", BatchId));
                    MessageBox.Show("Batch download completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progressBar1.Visible = false;
                    LogManager.Trace(String.Format("Downloading batch {0} failed. ", BatchId));
                    MessageBox.Show("Failed to download file", "Download failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

    }
}
