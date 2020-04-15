using EFileApp.Helper;
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
    public partial class frmCreateBatch : Form
    {
        public bool IsSuccess { get; set; }
        public frmCreateBatch()
        {
            InitializeComponent();
        }

        private void frmCreateBatch_Load(object sender, EventArgs e)
        {
            try
            {
                IsSuccess = false;
                if (AppConstants.LoginState == "MD")
                {
                    lblCount.Visible = txtCount.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
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
                if (String.IsNullOrEmpty(this.txtBatchId.Text))
                {
                    MessageBox.Show("Please enter the bacth id.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int test = 0;
                int.TryParse(txtCount.Text, out test);
                if (AppConstants.LoginState.Equals("IL") && test <= 0)
                {
                    MessageBox.Show("Please enter valid count value.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LogManager.Trace("New batch creation started.");
                AppConstants.ApiCaller.CreateBatch(this.txtBatchId.Text.Trim(), this.txtBatchId.Text.Trim(), test);
                LogManager.Trace("New batch creation completed. Batch id :-" + txtBatchId.Text);
                IsSuccess = true;
                MessageBox.Show("Batch creation done: " + this.txtBatchId.Text.Trim(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                this.txtBatchId.Text = string.Empty;
                this.txtCount.Text = string.Empty;
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
