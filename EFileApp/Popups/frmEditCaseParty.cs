using EFileApp.DTOs;
using EFileApp.Helper;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EFileApp
{
    public partial class frmEditCaseParty : Form
    {
        private readonly EditCasePartyDTO edit;
        private readonly frmCodeGenarator _parent;


        public frmEditCaseParty(EditCasePartyDTO edit, frmCodeGenarator parent)
        {
            InitializeComponent();
            this.edit = edit;
            _parent = parent;
            this.Text = "Currently Editing: " + edit.PartyType;
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
            txtFirstName.Text = edit.FirstName; 
            txtMiddleName.Text = edit.MiddleName;
            txtLastName.Text = edit.LastName;

            //txtAddress.Text = edit.Address;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //edit.Address = txtAddress.Text;
            edit.AssociatedAttorneys = "";
            edit.AssociatedAttorneysId = new List<string>();
            foreach (MaterialCheckbox item in cbAssociatedAttorney.Items)
            {
                if (item.Checked)
                {
                    edit.AssociatedAttorneys += item.Text + ",";
                    edit.AssociatedAttorneysId.Add(item.Tag.ToString());
                }
            }
            edit.FirstName = txtFirstName.Text;
            edit.MiddleName = txtMiddleName.Text;
            edit.LastName = txtLastName.Text;

            if (edit.AssociatedAttorneysId.Count > 0)
            {
                if (cbLeadAttorneys.SelectedItem == null)
                {
                    MessageBox.Show("You mush choose a Lead Attorney");
                }
                else
                {
                    edit.LeadAttorney = (cbLeadAttorneys.SelectedItem as dynamic).name;
                    edit.LeadAttorneyId = (cbLeadAttorneys.SelectedItem as dynamic).code;
                }
            }
            

            _parent.UpdatePartiesTable(edit);
            this.Close();
        }
    }
}
