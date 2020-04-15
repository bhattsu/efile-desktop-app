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
using EFileApp.Helper;

namespace EFileApp
{
    public partial class frmBatches : Form
    {
        public int LastFoundLine = 0;
        public int FirstBatchNo = 1;
        public int LastBatchNo = 20;
        public int pageCount = 10;
        public frmBatches()
        {
            InitializeComponent();
        }

        private void frmBatches_Load(object sender, EventArgs e)
        {
            try
            {
                AdjustControls();

                lblStatus.Text = "Connected";
                lblState.Text = AppConstants.LoginState;
                lblUser.Text = AppConstants.LoginEmail;
                lblEnviornment.Text = AppConstants.LoginEnviornment;

                LoadBatches(FirstBatchNo, pageCount);

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void frmBatches_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                //frmSettngs setting = new frmSettngs();
                //setting.Show();
            }
            catch (Exception ex)
            {

                LogManager.LogError(ex);
            }
        }

        private void btnCreateBatch_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateBatch createBatch = new frmCreateBatch();
                createBatch.ShowDialog();
                if (createBatch.IsSuccess)
                {
                    FirstBatchNo = 1;

                    LoadBatches(FirstBatchNo, pageCount);
                }
            }
            catch (Exception ex)
            {

                LogManager.LogError(ex);
            }
        }

        private void btnShowNext_Click(object sender, EventArgs e)
        {
            try
            {
                FirstBatchNo += pageCount;
                LastBatchNo += pageCount;
                LoadBatches(FirstBatchNo, pageCount);
                this.btnShowPrevious.Enabled = true;
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnShowPrevious_Click(object sender, EventArgs e)
        {
            try
            {

                FirstBatchNo -= pageCount;
                LoadBatches(FirstBatchNo, pageCount);
                //if (FirstBatchNo == 0)
                //    btnShowPrevious.Enabled = false;

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    txtSearch.Text = "Search...";
                    txtSearch.ForeColor = Color.Silver;
                }

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Equals("Search..."))
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Silver;
                FirstBatchNo = 1;
                LoadBatches(FirstBatchNo, pageCount);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadBatches(FirstBatchNo, pageCount);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    FirstBatchNo = 1;
                    LoadBatches(FirstBatchNo, 10);

                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void dgBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;
                int selectedIndex = dgBatch.CurrentCell.RowIndex;
                int selectedCol = dgBatch.CurrentCell.ColumnIndex;
                //Add Batch
                if (selectedIndex > -1 && selectedIndex < dgBatch.Rows.Count && selectedCol == 0)
                {
                    //     Get Batch Id
                    string batchId = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[4].Value);
                    AddToBatch(batchId);
                }
                //Delete batch
                if (selectedIndex > -1 && selectedIndex < dgBatch.Rows.Count && selectedCol == 1)
                {
                    string batchId = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[4].Value);
                    DeleteBatch(batchId);
                }
                //Download batch
                if (selectedIndex > -1 && selectedIndex < dgBatch.Rows.Count && selectedCol == 3)
                {
                    string batchId = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[4].Value);
                    DownloadBatch(batchId);
                }
                //Show Batch details
                if (selectedIndex > -1 && selectedIndex < dgBatch.Rows.Count && selectedCol == 2)
                {
                    //     Get Batch Id
                    string batchId = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[4].Value);
                    string createdDate = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[6].Value);
                    ShowBatch(batchId, createdDate);
                }

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }

        }

        private void dgBatch_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgBatch.CurrentCell.RowIndex;
                //Show Batch details
                if (selectedIndex > -1 && selectedIndex < dgBatch.Rows.Count)
                {
                    //     Get Batch Id
                    string batchId = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[4].Value);
                    string createdDate = Convert.ToString(dgBatch.Rows[selectedIndex].Cells[6].Value);

                    ShowBatch(batchId, createdDate);
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void dgBatch_MouseHover(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgBatch_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3) && e.RowIndex != -1)
                {
                    dgBatch.Cursor = Cursors.Hand;
                }
                else
                    dgBatch.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void dgBatch_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgBatch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && e.RowIndex != -1)
                {

                    mnuBatches.Show(Cursor.Position.X, Cursor.Position.Y);
                    dgBatch.Rows[e.RowIndex].Selected = true;

                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        #region Shortcut or context menu
        private void mnuAddToBatch_Click(object sender, EventArgs e)
        {
            try
            {
                string batchId = dgBatch.SelectedRows[0].Cells[4].Value.ToString();
                AddToBatch(batchId);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void mnuDeleteBatch_Click(object sender, EventArgs e)
        {
            try
            {
                string batchId = dgBatch.SelectedRows[0].Cells[4].Value.ToString();
                DeleteBatch(batchId);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void mnuBatchDetails_Click(object sender, EventArgs e)
        {
            try
            {
                string batchId = dgBatch.SelectedRows[0].Cells[4].Value.ToString();
                string createdDate = dgBatch.SelectedRows[0].Cells[6].Value.ToString();
                ShowBatch(batchId, createdDate);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void mnuDownloadBatch_Click(object sender, EventArgs e)
        {
            try
            {
                string batchId = dgBatch.SelectedRows[0].Cells[4].Value.ToString();
                DownloadBatch(batchId);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }
        #endregion Shortcut or context menu

        private void AdjustControls()
        {
            try
            {
                int winWidth = this.Width;
                int colWidth = 280;
                dgBatch.Width = winWidth - 100;

                dgBatch.Columns[4].Width = (winWidth - colWidth) / 3;
                dgBatch.Columns[5].Width = (winWidth - colWidth) / 3;
                dgBatch.Columns[6].Width = (winWidth - colWidth) / 3;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadBatches(int firstBatch, int limit)
        {
            try
            {
                LogManager.Trace("Batch Details : Listing batches started.");
                string searchText = this.txtSearch.Text.StartsWith("Search...") ? string.Empty : this.txtSearch.Text;
                dynamic batchesjson = AppConstants.ApiCaller.Listbatches(firstBatch, limit, searchText);
                var batches = batchesjson["items"];
                var batchCount = batchesjson["count"];
                dgBatch.Rows.Clear();

                foreach (var batch in batches)
                {
                    string batch_id = batch["batch_id"];
                    string batch_name = batch["batch_name"];
                    string created_date = batch["created_date"];
                    string status = batch["status"];
                    string size = object.Equals(batch["current_size"], null) ? 0 : batch["current_size"];
                    string batchsize = object.Equals(batch["batch_size"], null) ? 0 : batch["batch_size"];

                    DateTime convertedDate = DateTime.Parse(created_date);
                    convertedDate = TimeZone.CurrentTimeZone.ToLocalTime(convertedDate);
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.Height = 30;
                    dr.CreateCells(dgBatch);
                    dr.Cells[4].Value = batch_id;
                    dr.Cells[5].Value = status;
                    dr.Cells[6].Value = Convert.ToInt16(size);
                    dr.Cells[7].Value = Convert.ToInt16(batchsize);
                    dr.Cells[8].Value = convertedDate;
                    dgBatch.Rows.Add(dr);
                    //Console.WriteLine((count++).ToString().PadLeft(2, '0') + ".  [Batch Id: " + batch_id + " ] [ Created On: " + convertedDate + " ]");
                }
                dgBatch.Refresh();
                lblpage.Text = String.Format("Showing {0} to {1}", firstBatch, firstBatch + dgBatch.Rows.Count - 1);
                btnShowPrevious.Enabled = (firstBatch + 1 > pageCount);
                btnShowNext.Enabled = (firstBatch + dgBatch.Rows.Count <= batchCount);
                //btnShowNext.Enabled = true;
                LogManager.Trace("Batch Details : Listing batches completed.");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddToBatch(string batchId)
        {
            try
            {
                frmAddBatch addBatch = new frmAddBatch();
                addBatch.BatchId = batchId;
                addBatch.Text = "Add to Batch - " + batchId;
                addBatch.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DownloadBatch(string batchId)
        {
            try
            {
                if (String.IsNullOrEmpty(Properties.Settings.Default.DefaultOutpuLocation) ||
                          !Directory.Exists(Properties.Settings.Default.DefaultOutpuLocation))
                {
                    MessageBox.Show("Default download/ouput location is empty or not valid in settings.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmDownloadBatch download = new frmDownloadBatch();
                download.Text = string.Format("Downloading Batch Id -{0}", batchId);
                download.BatchId = batchId;
                download.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DeleteBatch(string batchId)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this batch.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LogManager.Trace(String.Format("Batch Details : Deleting batch for id {0} started.", batchId));

                    if (AppConstants.ApiCaller.DeleteBatch(batchId))
                    {
                        MessageBox.Show("Batch deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBatches(FirstBatchNo, pageCount);
                    }
                    LogManager.Trace(String.Format("Batch Details : Deleting batch for id {0} completed.", batchId));

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ShowBatch(string batchId, string createdDate)
        {
            try
            {
                frmEnvelope envelope = new frmEnvelope();
                envelope.BatchId = batchId;
                envelope.Text = String.Format("Batch Details for Id - {0}", batchId);
                envelope.CreatedDate = createdDate;
                envelope.ShowDialog();
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }
    }
}
