using EFileApp.Helper;
using EFileApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EFileApp
{
    public partial class frmLogin : Form
    {
        public bool IsCancelled { get; set; }
        public ApiSettingsList LstApiSettings;
        public ApiSettings ApiSettings { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                LstApiSettings = HelperMethods.GetApiSettings();

                LoadStates();
                string lastLogin = Properties.Settings.Default.LastLoginStateEnv;
                if (!string.IsNullOrEmpty(lastLogin))
                {
                    var appSetting = HelperMethods.GetStateApiSettings(lastLogin);
                    if (appSetting != null)
                    {
                        cmbState.SelectedValue = appSetting.State;
                        txtEmail.Text = appSetting.UserName;
                        txtClientToken.Text = appSetting.Token;
                    }
                }

            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VaildateInputs())
                    return;

                string state = string.Empty;
                string env = string.Empty;

                var stateEnvs = cmbState.SelectedValue.ToString().Split('-');
                state = stateEnvs[0].Trim();
                env = stateEnvs[1].Trim();

                this.Cursor = Cursors.WaitCursor;
                APICall apiCaller = new APICall(env, state, this.txtClientToken.Text.Trim());

                string token = await apiCaller.AuthenticateAsync(this.txtClientToken.Text.Trim(), this.txtEmail.Text.Trim(), this.txtPassword.Text);
                LogManager.Trace(String.Format("User {0} logged in to {1} success. ", txtEmail.Text, cmbState.SelectedValue.ToString()));
                AppConstants.LoginState = state;
                AppConstants.ApiCaller = apiCaller;

                //Store the appsetting to xml
                ApiSettings apiSetting = new ApiSettings();
                apiSetting.UserName = txtEmail.Text;
                apiSetting.Token = txtClientToken.Text;
                apiSetting.State = cmbState.SelectedValue.ToString();
                HelperMethods.CreateUpdateXmlFile(apiSetting);
                Properties.Settings.Default.LastLoginStateEnv = cmbState.SelectedValue.ToString();
                Properties.Settings.Default.Save();
                LogManager.Trace(String.Format("Last logged in {0} for user {1} updated. ", cmbState.SelectedValue.ToString(), txtEmail.Text));
                //Update login detail to main window
                stateEnvs = cmbState.Text.ToString().Split('-');
                AppConstants.LoginEmail = this.txtEmail.Text;
                AppConstants.LoginStateName = stateEnvs[0].Trim();
                AppConstants.LoginEnviornment = stateEnvs[1].Trim();

                frmDashboard frmd = new frmDashboard();
                frmd.Show();
                
                this.Hide();

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
                LogManager.LogError(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.IsCancelled = true;

            this.Close();
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtClientToken.Text = string.Empty;
                if (cmbState.SelectedIndex != -1)
                {
                    int index = LstApiSettings.apiSettingList.FindIndex(m => m.State == cmbState.SelectedValue.ToString());
                    if (index != -1)
                    {
                        txtEmail.Text = LstApiSettings.apiSettingList[index].UserName;
                        txtClientToken.Text = LstApiSettings.apiSettingList[index].Token;
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex);
            }
        }

        private bool VaildateInputs()
        {
            try
            {
                if (cmbState.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select valid State.", "Login Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email.", "Login Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter a valid password.", "Login Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (string.IsNullOrEmpty(txtClientToken.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid client token.", "Login Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadStates()
        {
            try
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                List<string> states = new List<string>();
                comboSource.Add("TX-PROD", "Texas-Production");
                comboSource.Add("TX-STAGE", "Texas-Staging");
                comboSource.Add("IL-PROD", "Illinois-Production");
                comboSource.Add("IL-STAGE", "Illinois-Staging");
                comboSource.Add("IN-PROD", "Indiana-Production");
                comboSource.Add("IN-STAGE", "Indiana-Staging");
                comboSource.Add("CA-PROD", "California-Production");
                comboSource.Add("CA-STAGE", "California-Staging");
                comboSource.Add("MD-PROD", "Maryland-Production");
                comboSource.Add("MD-STAGE", "Maryland-Staging");

                cmbState.DataSource = new BindingSource(comboSource, null);
                cmbState.DisplayMember = "Value";
                cmbState.ValueMember = "Key";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
