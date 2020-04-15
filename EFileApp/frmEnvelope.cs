using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFileApp.Helper;
using EFileApp.Bal;
using EFileApp.Models;
using System.IO;
using System.Net;

namespace EFileApp
{
    public partial class frmEnvelope : Form
    {
        public string BatchId { get; set; }
        public string CreatedDate { get; set; }
        public frmEnvelope()
        {
            InitializeComponent();
        }

        private void frmEnvelope_Load(object sender, EventArgs e)
        {
            try
            {


                lblBatchId.Text = BatchId;
              
                LogManager.Trace(String.Format("Envelope Details : Listing Envelopes for batch {0} started.", BatchId));

                dynamic envelopedetails = EnvelopeBL.GetEnvelopes(BatchId);

                dynamic item = envelopedetails["item"];

                lblBatchName.Text = item["batch_name"];
                string created_date = item["created_date"];
                DateTime convertedDate = DateTime.Parse(created_date);
                lblCreatedDate.Text = TimeZone.CurrentTimeZone.ToLocalTime(convertedDate).ToString();

                dynamic envelopes = item["envelopes"];

                if (envelopes != null && AppConstants.LoginState == "MD")
                {
                    courtInfoGrp.Visible = true;
                }


                if (item.ContainsKey("court_hearing_scheduled_start_date"))
                {
                    string court_hearing_scheduled_start_date = item["court_hearing_scheduled_start_date"];
                    convertedDate = DateTime.Parse(court_hearing_scheduled_start_date);
                    lblCourtHearingStart.Text = TimeZone.CurrentTimeZone.ToLocalTime(convertedDate).ToString();
                    
                    string court_hearing_scheduled_end_date = item["court_hearing_scheduled_end_date"];
                    convertedDate = DateTime.Parse(court_hearing_scheduled_end_date);
                    lblCourtHearingEnd.Text = TimeZone.CurrentTimeZone.ToLocalTime(convertedDate).ToString(); 
                    
                    lblCourtRoom.Text = item["court_room"];
                    lblCourtAddress.Text = item["court_city_state_zip"];
                }


                dgEnvelope.Visible = false;
                dgEnvelope.Rows.Clear();
                foreach (dynamic envelope in envelopes)
                {

                    DataGridViewRow dr = new DataGridViewRow();
                    dr.Height = 30;
                    dr.CreateCells(dgEnvelope);

                    dr.Cells[1].Value = envelope["reference_id"];
                    dr.Cells[2].Value = envelope["envelope_id"];
                    if (envelope.ContainsKey("case_number"))
                    {
                        dr.Cells[3].Value = envelope["case_number"];
                    }
                    if (envelope.ContainsKey("envelope_status"))
                    {
                        dr.Cells[4].Value = envelope["envelope_status"];
                    }
                    if (envelope.ContainsKey("total_fees"))
                    {
                        dr.Cells[5].Value = envelope["total_fees"];
                    }

                    dgEnvelope.Rows.Add(dr);
                }
                dgEnvelope.Refresh();
                if (dgEnvelope.Rows.Count >= 1)
                {
                    dgEnvelope.Visible = true; dgEnvelope.Rows[0].Selected = true;
                } else
                {
                    refreshEnvelope.Enabled = false;
                }
                LogManager.Trace(String.Format("Envelope Details: Listing envelopes for batch {0} completed ", BatchId));

            }
            catch (Exception ex)
            { LogManager.LogError(ex); }
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

        private void dgEnvelope_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                int selectedIndex = dgEnvelope.CurrentCell.RowIndex;
                int colIndex = dgEnvelope.CurrentCell.ColumnIndex;
                //Get envelop id to download
                if (selectedIndex > -1 && selectedIndex < dgEnvelope.Rows.Count && colIndex == 0)
                {
                    //     Get envelope Id
                    string envelopeId = Convert.ToString(dgEnvelope.Rows[selectedIndex].Cells[2].Value);

                    if (String.IsNullOrEmpty(Properties.Settings.Default.DefaultOutpuLocation) ||
                      !Directory.Exists(Properties.Settings.Default.DefaultOutpuLocation))
                    {
                        MessageBox.Show("Default download/ouput location is empty or not valid in settings.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    LogManager.Trace(String.Format("Envelope Details : Download envelope for id {0} started.", envelopeId));

                    if (EnvelopeBL.DownloadEnvelope(envelopeId, Properties.Settings.Default.DefaultOutpuLocation))
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Envelope download completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LogManager.Trace(String.Format("Envelope Details : Download envelope for id {0} completed.", envelopeId));

                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }

        private void dgEnvelope_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgEnvelope.SelectedCells[0].RowIndex;

                //Get envelop detail of filing
                if (selectedIndex > -1 && selectedIndex < dgEnvelope.Rows.Count)
                {
                    //     Get envelope Id
                    string envelopeId = Convert.ToString(dgEnvelope.Rows[selectedIndex].Cells[2].Value);
                    string caseNumber = Convert.ToString(dgEnvelope.Rows[selectedIndex].Cells[3].Value);
                    lblEnvelopeId.Text = envelopeId;
                    lblCaseNumber.Text = caseNumber;
                    LoadFilings(envelopeId);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }

        private void dgEnvelope_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                    dgEnvelope.Rows[e.RowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void dgEnvelope_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex != -1)
                {
                    dgEnvelope.Cursor = Cursors.Hand;
                }
                else
                    dgEnvelope.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void dgFilings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                int selectedIndex = dgFilings.CurrentCell.RowIndex;
                int colIndex = dgFilings.CurrentCell.ColumnIndex;

                if (selectedIndex > -1 && selectedIndex < dgEnvelope.Rows.Count && colIndex == 0)
                {
                    // Get filing Id to cancel
                    string filingId = Convert.ToString(dgFilings.Rows[selectedIndex].Cells[4].Value);

                    if (MessageBox.Show("Are you sure to cancel filings.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        LogManager.Trace(String.Format("Envelope Details : Canceling of filing Id- {0} started.", filingId));

                        if (AppConstants.ApiCaller.CancelFiling(filingId.Trim()))
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("Filing cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadFilings(this.lblEnvelopeId.Text.Trim());
                        }
                        LogManager.Trace(String.Format("Envelope Details : Cannceling of filing Id -{0} completed.", filingId));

                    }
                }
                if (selectedIndex > -1 && selectedIndex < dgEnvelope.Rows.Count && colIndex == -1)
                {
                    // Get filing Id to download
                    string filingId = Convert.ToString(dgFilings.Rows[selectedIndex].Cells[4].Value);
                    //Download filing

                    string url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf ";

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    saveFileDialog1.Title = "Save Filing File";
                    saveFileDialog1.CheckFileExists = false;
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "pdf";
                    saveFileDialog1.FileName = "filing.pdf";
                    saveFileDialog1.Filter = "Filing PDF files (*.pdf)|*.pdf";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string localFileName = saveFileDialog1.FileName;
                        // Download the pdf file and save it local system folder.
                        LogManager.Trace(String.Format("Envelope Details : Downloading filing for Id - {0} started.", filingId));
                        using (WebClient webClient = new WebClient())
                        {
                            webClient.UseDefaultCredentials = true;
                            webClient.Headers.Add("user-agent", " Mozilla/5.0 (Windows NT 6.1; WOW64; rv:25.0) Gecko/20100101 Firefox/25.0");
                            webClient.DownloadFile(new Uri(url), localFileName);
                            MessageBox.Show("Filing downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LogManager.Trace(String.Format("Envelope Details : Downloading filing for Id - {0} completed.", FilingId));
                    }
                }

                if (selectedIndex > -1 && selectedIndex < dgEnvelope.Rows.Count && colIndex == 1)
                {
                    // Get filing Id to cancel
                    string filingId = Convert.ToString(dgFilings.Rows[selectedIndex].Cells[4].Value);
        
                    string url = "https://" + AppConstants.ApiCaller.getEnv() + ".uslegalpro.com/efile/filingdetail/" + filingId;
                   
                    System.Diagnostics.Process.Start(url);
                }


            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }

        private void dgFilings_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex == 0 || e.ColumnIndex == 1) && e.RowIndex != -1)
                {
                    dgFilings.Cursor = Cursors.Hand;
                }
                else
                    dgFilings.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        /// <summary>
        /// Load filings details for givin envelope id
        /// </summary>
        /// <param name="envelopeId"></param>
        private void LoadFilings(string envelopeId)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                LogManager.Trace(String.Format("Envelope Details : Listing filings for Envelope {0} started.", envelopeId));

                dynamic lstFilings = EnvelopeBL.GetEnvelopeDetails(envelopeId);
                lblFiling.Visible = dgFilings.Visible = pnlEnvDetails.Visible = false;
                dgFilings.Rows.Clear();
                foreach (var filing in lstFilings)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.Height = 30;
                    dr.CreateCells(dgFilings);

                    dr.Cells[2].Value = filing["filing_description"].ToString();
                    dr.Cells[3].Value = filing["status"].ToString();
                    dr.Cells[4].Value = filing["id"].ToString();
                    dgFilings.Rows.Add(dr);
                    lblFiling.Visible = pnlEnvDetails.Visible = dgFilings.Visible = true;
                }
                dgFilings.Refresh();
                LogManager.Trace(String.Format("Envelope Details : Listing fillings for envelope {0} completed ", envelopeId));

                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void refreshEnvelope_Click(object sender, EventArgs e)
        {

                refreshEnvelope.Enabled = false;
                BatchBL.refreshBatch(BatchId);
                refreshEnvelope.Enabled = true;
            
        }
    }
}
