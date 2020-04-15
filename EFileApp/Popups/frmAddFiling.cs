using EFileApp.DTOs;
using EFileApp.Helper;
using MaterialSkin.Controls;
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

namespace EFileApp.Popups
{
    public partial class frmAddFiling : Form
    {
        private readonly CreateFilingDTO _create;
        List<OptionalServiceDTO> optionalServices;
        List<OptionalServiceDTO> selectedServices;
        frmCodeGenarator _frm;
        public frmAddFiling(CreateFilingDTO create, frmCodeGenarator frm)
        {
            InitializeComponent();
            _create = create;
            _frm = frm;
            optionalServices = new List<OptionalServiceDTO>();
            selectedServices = new List<OptionalServiceDTO>();

        }


        private void frmAddFiling_Load(object sender, EventArgs e)
        {
            dynamic codes = AppConstants.ApiCaller.get(
                "/code/filing_codes?location_code=" + _create.LocationCode
                + "&case_category_code=" + _create.CaseCategoryCode +
                "&case_type_code=" + _create.CaseTypeCode + "&is_initial=true");

            cbFilingCode.DisplayMember = "name";
            cbFilingCode.ValueMember = "code";
            foreach (var item in codes["items"])
            {
                cbFilingCode.Items.Add(new { name = item["name"], code = item["code"] });
            }

            //if (_create.IsEdit)
            //{
            //    cbFilingCode.SelectedIndex = cbFilingCode.Items.
            //}
            foreach (var item in _create.CaseParties)
            {
                MaterialCheckbox materialCheckbox = new MaterialCheckbox()
                {
                    Text = item.PartyType,
                    Tag = item.GUID
                };

                cbCaseParties.Items.Add(materialCheckbox);
            }

            cbSecurity.DisplayMember = "name";
            cbSecurity.ValueMember = "code";
        }

        private void cbSecurity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSecurity_Click(object sender, EventArgs e)
        {
            if (cbFilingCode.SelectedItem == null)
            {
                MessageBox.Show("Please select filing code first!");
                return;
            }
            string filingCode = (cbFilingCode.SelectedItem as dynamic).code;
            dynamic codes = AppConstants.ApiCaller.get("/code/document_type_codes?location_code=" + _create.LocationCode + "&filing_code=" + filingCode);
            cbSecurity.DisplayMember = "name";
            cbSecurity.ValueMember = "code";
            foreach (var item in codes["items"])
            {
                cbSecurity.Items.Add(new { name = item["name"], code = item["code"] });
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                RefreshOptionalServices();
            }
            else
            {
                lvOptionalServices.Items.Clear();
                foreach (var service in optionalServices.Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower())))
                {
                    var row = new ListViewItem(new[] {
                    service.Name,
                });
                    lvOptionalServices.Items.Add(row);
                }
            }

        }


        private void cbFilingCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            optionalServices = new List<OptionalServiceDTO>();
            dynamic codes = AppConstants.ApiCaller.get("/code/optional_service_codes?location_code="
                + _create.LocationCode + "&filing_code=" + (cbFilingCode.SelectedItem as dynamic).code);

            foreach (var item in codes["items"])
            {
                var service = new OptionalServiceDTO()
                {
                    Code = item["code"],
                    Name = item["name"]
                };
                optionalServices.Add(service);
            }
            RefreshOptionalServices();

            cbSecurity.Items.Clear();

            dynamic docTypes = AppConstants.ApiCaller.get("/code/document_type_codes?location_code=" + _create.LocationCode + "&filing_code=" + (cbFilingCode.SelectedItem as dynamic).code);

            foreach (var item in docTypes["items"])
            {
                cbSecurity.Items.Add(new { name = item["name"], code = item["code"] });
            }
        }



        private void mbAdd_Click(object sender, EventArgs e)
        {
            if (lvOptionalServices.SelectedItems.Count <= 0)
            {
                return;
            }
            frmAddOptionalService frm = new frmAddOptionalService(optionalServices[lvOptionalServices.SelectedItems[0].Index], this);
            frm.ShowDialog();
        }

        private void mbRemoveService_Click(object sender, EventArgs e)
        {
            if (lvOptionalServices.SelectedItems.Count <= 0)
            {
                return;
            }
            selectedServices.RemoveAt(lvSelectedServices.SelectedItems[0].Index);
            RefreshSelectedServices();
        }
        private void mbEditService_Click(object sender, EventArgs e)
        {
            if (lvOptionalServices.SelectedItems.Count <= 0)
            {
                return;
            }
            frmAddOptionalService frm = new frmAddOptionalService(optionalServices[lvOptionalServices.SelectedItems[0].Index], this);
            frm.ShowDialog();
        }
        public void UpdateService(OptionalServiceDTO service)
        {
            var existing = selectedServices.FirstOrDefault(x => x.Code == service.Code);
            if (existing != null)
            {
                existing.Quantity = service.Quantity;
            }
            RefreshSelectedServices();
        }
        public void AddService(OptionalServiceDTO optional)
        {
            selectedServices.Add(optional);
            RefreshSelectedServices();

        }
        public void RefreshSelectedServices()
        {
            lvSelectedServices.Items.Clear();
            foreach (var service in selectedServices)
            {
                var row = new ListViewItem(new[] {
                    service.Name,
                    service.Quantity.ToString()
                });
                lvSelectedServices.Items.Add(row);

            }
        }
        public void RefreshOptionalServices()
        {
            lvOptionalServices.Items.Clear();
            foreach (var service in optionalServices)
            {
                var row = new ListViewItem(new[] {
                    service.Name,
                });
                lvOptionalServices.Items.Add(row);
            }
        }

        private void btnAddFiling_Click(object sender, EventArgs e)
        {
            var security = (cbSecurity.SelectedItem as dynamic);
            if (security == null)
            {
                MessageBox.Show("You have to choose Security!");
                return;
            }
            var filing = (cbFilingCode.SelectedItem as dynamic); 
            if (filing == null)
            {
                MessageBox.Show("You have to choose Filing!");
                return;
            }
            _create.FilingName = filing.name;
            _create.FilingCode = filing.code;

            _create.SecurityName = security.name;
            _create.SecurtCode = security.code;

            _create.OptionalServices = selectedServices;
            foreach (var item in _create.CaseParties)
            {
                item.Checked = cbCaseParties.Items.FirstOrDefault(x => x.Tag.ToString() == item.GUID).Checked;
            }

                _frm.AddFiling(_create);

            this.Close();

        }

        private void btnLeadDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _create.LeadDocumentPath = openFileDialog1.FileName;
                lbLeadDocument.Text = Path.GetFileName(_create.LeadDocumentPath);
            }
        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            var security = (cbSecurity.SelectedItem as dynamic);
            if (security == null)
            {
                MessageBox.Show("You have to choose Security!");
                return;
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Multiselect = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _create.Attachments = new List<FilingAttachmentDTO>();
                foreach (var item in openFileDialog1.FileNames)
                {
                    _create.Attachments.Add(new FilingAttachmentDTO(
                        )
                    {
                        Path = item,
                        Security = (cbSecurity.SelectedItem as dynamic).code
                    });
                }
                lbAttachments.Text = string.Join(", ", _create.Attachments.Select(x => Path.GetFileName(x.Path)).ToArray());

            }
        }
    }
}
