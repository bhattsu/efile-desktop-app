using EFileApp.Helper;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFileApp.DTOs
{
    public partial class frmEditCaseParty : MaterialForm
    {
        private readonly EditCasePartyDTO edit;

        public frmEditCaseParty(EditCasePartyDTO edit)
        {
            InitializeComponent();
            this.edit = edit;
        }

        private void frmEditCaseParty_Load(object sender, EventArgs e)
        {
            dynamic codes = AppConstants.ApiCaller.getUsingAuthToken("/firm/attorneys");
            var items = codes["items"];
            cbLeadAttorneys.DisplayMember = "name";
            cbLeadAttorneys.ValueMember = "code";
            foreach (var item in items)
            {
                cbLeadAttorneys.Items.Add(new { name = item["display_name"], code = item["id"] });
                MaterialCheckbox materialCheckbox = new MaterialCheckbox()
                {
                    Text = item["display_name"],
                    Tag = item["id"]
                };
                cbAssociatedAttorney.Items.Add(materialCheckbox);

            }
    //        MessageBox.Show(edit.RowIndex.ToString());
            txtFullName.Text = edit.FullName;
            txtAddress.Text = edit.Address;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
