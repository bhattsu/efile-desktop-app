using EFileApp.DTOs;
using EFileApp.Helper;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFileApp
{
    public partial class frmCodeGenarator : MaterialForm
    {
        public bool SearchResultsReset { get; set; }
        public frmCodeGenarator()
        {
            InitializeComponent();
        }
        private firmSettings settings = null;


        public frmCodeGenarator(firmSettings settings)
        {
            this.settings = settings;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                AppConstants.PrimaryColor, AppConstants.DarkColor, AppConstants.LightPrimary, AppConstants.AccentColor, TextShade.BLACK);
            InitializeComponent();
        }

        private void jurisdiction_SelectedIndexChanged(object sender, EventArgs e)
        {
            casecategory.Items.Clear();
            casecategory.ResetText();
            filertype.Items.Clear();
            filertype.ResetText();
            casecategory_SelectedIndexChanged(sender, e);
        }

        private void casecategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            casetype.Items.Clear();
            casetype.ResetText();
            remedy.Items.Clear();
            remedy.ResetText();
            datamageamount.Items.Clear();
            datamageamount.ResetText();
            casetype_SelectedIndexChanged(sender, e);
        }

        private void casetype_SelectedIndexChanged(object sender, EventArgs e)
        {

            filingcode.Items.Clear();
            filingcode.ResetText();

            documenttype.Items.Clear();
            documenttype.ResetText();

            caseparties.Items.Clear();

            casepartytype.Items.Clear();
            casepartytype.ResetText();
            casepartytype_Click(sender, e);





            filingcode_SelectedIndexChanged(sender, e);
        }


        private void filingcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            documenttype.Items.Clear();
            documenttype.ResetText();

            optionalservices.Rows.Clear();
            optionalservices_Click(sender, e);
        }


        private void jurisdiction_Click(object sender, EventArgs e)
        {
            if (jurisdiction.Items.Count == 0)
            {
                dynamic codes = AppConstants.ApiCaller.loadCode("location_codes");
                var items = codes["items"];
                jurisdiction.DisplayMember = "name";
                jurisdiction.ValueMember = "code";
                List<Object> items1 = new List<Object>();
                foreach (var item in items)
                {
                    jurisdiction.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }
        }



        private void casecategory_Click(object sender, EventArgs e)
        {
            if (jurisdiction.SelectedItem != null && casecategory.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                dynamic codes = AppConstants.ApiCaller.loadCode("case_category_codes?location_code=" + locationcode);
                var items = codes["items"];
                casecategory.DisplayMember = "name";
                casecategory.ValueMember = "code";
                foreach (var item in items)
                {
                    casecategory.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }
        }


        private void casetype_Click(object sender, EventArgs e)
        {

            if (jurisdiction.SelectedItem != null && casecategory.SelectedItem != null && casetype.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string casecategorycode = (casecategory.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("case_type_codes?location_code=" + locationcode + "&case_category_code=" + casecategorycode + "&is_initial=true");
                var items = codes["items"];
                casetype.DisplayMember = "name";
                casetype.ValueMember = "code";
                foreach (var item in items)
                {
                    casetype.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }
        }

        private void filingcode_Click(object sender, EventArgs e)
        {
            if (jurisdiction.SelectedItem != null && casecategory.SelectedItem != null && casetype.SelectedItem != null && filingcode.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string casecategorycode = (casecategory.SelectedItem as dynamic).code;
                string casetypecode = (casetype.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("filing_codes?location_code=" + locationcode + "&case_category_code=" + casecategorycode + "&case_type_code=" + casetypecode + "&is_initial=true");
                var items = codes["items"];
                filingcode.DisplayMember = "name";
                filingcode.ValueMember = "code";
                foreach (var item in items)
                {
                    filingcode.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }

        }

        private void documenttype_Click(object sender, EventArgs e)
        {
            if (jurisdiction.SelectedItem != null && filingcode.SelectedItem != null && documenttype.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string filingcode1 = (filingcode.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("document_type_codes?location_code=" + locationcode + "&filing_code=" + filingcode1);
                var items = codes["items"];
                documenttype.DisplayMember = "name";
                documenttype.ValueMember = "code";
                foreach (var item in items)
                {
                    documenttype.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }
        }

        private void filertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filertype_Click(object sender, EventArgs e)
        {

            if (jurisdiction.SelectedItem != null && filertype.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("filer_type_codes?location_code=" + locationcode);
                var items = codes["items"];
                filertype.DisplayMember = "name";
                filertype.ValueMember = "code";
                foreach (var item in items)
                {
                    filertype.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }

        }

        private void optionalservices_Click(object sender, EventArgs e)
        {


            if (jurisdiction.SelectedItem != null && filingcode.SelectedItem != null)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string filingcode1 = (filingcode.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("optional_service_codes?location_code=" + locationcode + "&filing_code=" + filingcode1);
                var items = codes["items"];
                foreach (var item in items)
                {
                    string code = item["code"];
                    string name = item["name"];
                    int count = 0;
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(optionalservices);
                    dr.Cells[0].Value = name;
                    dr.Cells[1].Value = code;
                    dr.Cells[2].Value = count;
                    optionalservices.Rows.Add(dr);
                }
                optionalservices.Refresh();
            }


        }


        private void filingattorney_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void filingattorney_Click(object sender, EventArgs e)
        {
            if (filingattorney.Items.Count == 0)
            {
                dynamic codes = AppConstants.ApiCaller.getUsingAuthToken("/firm/attorneys");
                var items = codes["items"];
                filingattorney.DisplayMember = "name";
                filingattorney.ValueMember = "code";
                foreach (var item in items)
                {
                    filingattorney.Items.Add(new { name = item["display_name"], code = item["id"] });
                }
            }
        }

        private void paymentaccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void paymentaccount_Click(object sender, EventArgs e)
        {
            if (paymentaccount.Items.Count == 0)
            {

                dynamic codes = AppConstants.ApiCaller.getUsingAuthToken("/payment_accounts");
                var items = codes["items"];
                paymentaccount.DisplayMember = "name";
                paymentaccount.ValueMember = "code";
                foreach (var item in items)
                {
                    paymentaccount.Items.Add(new { name = item["account_name"], code = item["payment_account_id"] });
                }
            }

        }


        private void remedy_Click(object sender, EventArgs e)
        {
            if (jurisdiction.SelectedItem != null && casecategory.SelectedItem != null && remedy.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string casecategorycode = (casecategory.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("procedure_remedy_codes?location_code=" + locationcode + "&case_category_code=" + casecategorycode + "&is_initial=true");
                var items = codes["items"];
                remedy.DisplayMember = "name";
                remedy.ValueMember = "code";
                foreach (var item in items)
                {
                    remedy.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }

        }



        private void datamageamount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void datamageamount_Click(object sender, EventArgs e)
        {
            if (jurisdiction.SelectedItem != null && casecategory.SelectedItem != null && datamageamount.Items.Count == 0)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string casecategorycode = (casecategory.SelectedItem as dynamic).code;

                dynamic codes = AppConstants.ApiCaller.loadCode("damage_amount_codes?location_code=" + locationcode + "&case_category_code=" + casecategorycode + "&is_initial=true");
                var items = codes["items"];
                datamageamount.DisplayMember = "name";
                datamageamount.ValueMember = "code";
                foreach (var item in items)
                {
                    datamageamount.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }

        }


        private void casepartytype_Click(object sender, EventArgs e)
        {

            if (jurisdiction.SelectedItem != null && casetype.SelectedItem != null)
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                string casetypecode = (casetype.SelectedItem as dynamic).code;

                JsonObject codes = AppConstants.ApiCaller.loadCode("party_type_codes?is_required=true&location_code=" + locationcode + "&case_type_code=" + casetypecode);
                JsonObject codes1 = AppConstants.ApiCaller.loadCode("party_type_codes?is_required=false&location_code=" + locationcode + "&case_type_code=" + casetypecode);
                dynamic items = codes["items"];
                dynamic items1 = codes1["items"];

                casepartytype.DisplayMember = "name";
                casepartytype.ValueMember = "code";
                //bool isexisting = caseparties.Rows.Count > 0;
                foreach (var item in items)
                {
                    if (jurisdiction.Enabled)
                    {
                        populateCaseParties(item);
                    }
                    casepartytype.Items.Add(new { name = item["name"], code = item["code"] });
                }

                foreach (var item in items1)
                {
                    casepartytype.Items.Add(new { name = item["name"], code = item["code"] });
                }
            }

        }

        public void populateCaseParties(dynamic item)
        {


            string is_required = item["is_required"];
            string name = item["name"];
            string code = item["code"];
            string required = "";
            if (is_required == "True")
            {
                required = "Yes";
            }

            var rfc4122bytes = Convert.FromBase64String("aguidthatIgotonthewire==");
            Array.Reverse(rfc4122bytes, 0, 4);
            Array.Reverse(rfc4122bytes, 4, 2);
            Array.Reverse(rfc4122bytes, 6, 2);
            var guid = new Guid(rfc4122bytes);

            var row = new ListViewItem(new[] { name, "", required, code, "", "Party_" + guid });


            //dr.Cells[4].Value = count;
            caseparties.Items.Add(row);


        }

        private void generateTemplate_Click(object sender, EventArgs e)
        {

            string json = JsonConvert.SerializeObject(new
            {
                data = new
                {
                    batch_id = "${batch_id}",
                    reference_id = "${id}",
                    jurisdiction = getSelectedValue(jurisdiction, "jurisdiction"),
                    case_category = getSelectedValue(casecategory, "casecategory"),
                    case_type = getSelectedValue(casetype, "casetype"),
                    payment_account = getSelectedValue(paymentaccount, "paymentaccount"),
                    filing_attorney = getSelectedValue(filingattorney, "filingattorney"),
                    filer_type = getSelectedValue(filertype, "filertype"),
                    damage_amount = getSelectedValue(datamageamount, "datamageamount"),
                    procedure_remedy = createProcedureRemedy(),
                    filing = new[] { createFiling(1) },
                    case_party = createcaseParties()
                }

            }, Formatting.Indented); ;

            frmPayload frmPayload = new frmPayload(this.settings);
            frmPayload.Payload = json;
            frmPayload.ShowDialog();
        }

        public dynamic createProcedureRemedy()
        {
            ArrayList list = new ArrayList();
            string remedy1 = getSelectedValue(remedy, null);
            if (remedy1 != null)
            {
                list.Add(remedy1);
            }
            return list;
        }

        public dynamic createcaseParties()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < caseparties.Items.Count; i++)
            {
                var dr = caseparties.Items[i];
                string name = dr.SubItems[0].Text;
                dynamic filing_party = dr.SubItems[1].Text;
                dynamic code = dr.SubItems[2].Text;
                dynamic required = dr.SubItems[3].Text;
                //dynamic count = int.Parse(dr.Cells[4].Value.ToString());

                dynamic party = createCaseParty(name.ToLower(), code, i + 1, filing_party);
                list.Add(party);

            }
            return list.ToArray();

        }
        public dynamic createCaseParty(string name, string code, dynamic count, dynamic isfilingparty)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            name = rgx.Replace(name, "");
            name = name.Replace(" ", "");
            return new
            {
                counsel = "",
                lead_attorney = "",
                is_filing_party = isfilingparty == true ? "true" : "",
                type = code,
                business_name = "${" + name + count + "_business_name}",
                first_name = "${" + name + count + "_first_name}",
                last_name = "${" + name + count + "_last_name}",
                middle_name = "${" + name + count + "_middle_name}",
                address_one = "${" + name + count + "_address1}",
                address_two = "${" + name + count + "_address2}",
                address_city = "${" + name + count + "_city}",
                address_state = "${" + name + count + "_state}",
                address_zip = "${" + name + count + "_zip}"
            };

        }

        public dynamic createFiling(int count)
        {

            return new
            {
                filing_type = "EFile",
                lead_doc_code = "332",
                filing_description = getSelectedDisplay(filingcode),
                lead_doc_path = "${lead_doc" + count + "}",
                lead_doc_security = getSelectedValue(documenttype, "documenttype"),
                code = getSelectedValue(filingcode, "filingcode"),
                attachment = new[] {
                            new
                            {
                                path = "${lead_doc" + count + "_attachment1}",
                                security = getSelectedValue(documenttype, "documenttype")
                            }
                        },
                optional_service = createOptionalServices()
            };


        }


        public dynamic createOptionalServices()
        {

            ArrayList list = new ArrayList();
            for (int i = 0; i < optionalservices.Rows.Count; i++)
            {
                DataGridViewRow dr = optionalservices.Rows[i];
                string name = dr.Cells[0].Value.ToString();
                dynamic code1 = dr.Cells[1].Value;
                dynamic count = int.Parse(dr.Cells[2].Value.ToString());

                if (count > 0)
                {
                    list.Add(new
                    {
                        code = code1,
                        quantity = count.ToString()
                    }); ;
                }

            }
            return list.ToArray();


        }


        private string getSelectedValue(ComboBox obj, string defaultvalue)
        {
            string value = null;
            if (defaultvalue != null)
            {
                value = "${" + defaultvalue + "}";
            }
            if (obj.SelectedItem != null)
            {
                value = (obj.SelectedItem as dynamic).code;
            }
            return value;
        }

        private string getSelectedDisplay(ComboBox obj)
        {
            string value = "";
            if (obj.SelectedItem != null)
            {
                value = (obj.SelectedItem as dynamic).name;
            }
            return value;
        }

        private void searchcase_Click(object sender, EventArgs e)
        {
            if (SearchResultsReset)
            {
                jurisdiction.Enabled = true;
                casesearchbox.Enabled = true;
                casecategory.Enabled = true;
                casecategory.Items.Clear();

                casetype.Enabled = true;
                casetype.Items.Clear();

                datamageamount.Enabled = true;
                datamageamount.Items.Clear();
                remedy.Enabled = true;

                caseparties.Items.Clear();
                btnSearchCase.Text = "Search";

                SearchResultsReset = false;
            }
           else if (casesearchbox.Text == "")
            {
                MessageBox.Show("Case Number is required");
            }
            else if (jurisdiction.SelectedItem == null)
            {
                MessageBox.Show("Jurisdiction is required");
            }
            else
            {
                string locationcode = (jurisdiction.SelectedItem as dynamic).code;
                dynamic result = AppConstants.ApiCaller.get("/search_case?location_code=" + locationcode + "&case_number=" + casesearchbox.Text, true);
                dynamic items = result["items"];
                foreach (var item in items)
                {
                    jurisdiction.Enabled = false;
                    casesearchbox.Enabled = false;
                    string case_tracking_id = item["case_tracking_id"];
                    dynamic casedetails = AppConstants.ApiCaller.get("/case/" + case_tracking_id, true);
                    dynamic details = casedetails["item"];
                    //string jurisdiction1 = details["jurisdiction"];

                    casecategory.DisplayMember = "name";
                    casecategory.ValueMember = "code";
                    casecategory.Items.Add(new { name = details["case_category_display"], code = item["case_category"] });
                    casecategory.SelectedIndex = 0;
                    casecategory.Enabled = false;

                    casetype.DisplayMember = "name";
                    casetype.ValueMember = "code";
                    casetype.Items.Add(new { name = details["case_type_display"], code = item["case_type"] });
                    casetype.SelectedIndex = 0;
                    casetype.Enabled = false;

                    if (details.ContainsKey("damage_amount"))
                    {
                        datamageamount.Text = details["damage_amount"];
                    }
                    datamageamount.Enabled = false;
                    remedy.Enabled = false;

                    dynamic case_parties = details["case_parties"];


                    foreach (var cp in case_parties)
                    {

                        string name = cp["party_type_display"];
                        string code = cp["party_type"];
                        string first_name = cp["first_name"];
                        string identification_id = cp["identification_id"];

                        var row = new ListViewItem(new[] { name, "", code, "", first_name, identification_id });


                        //dr.Cells[4].Value = count;
                        caseparties.Items.Add(row);

                    }
                    if (!SearchResultsReset)
                    {
                        btnSearchCase.Text = "Reset";
                        SearchResultsReset = true;
                    }
                    /*
                    dynamic citems = casecategory.Items;
                    foreach (var citem in citems)
                    {

                        MessageBox.Show(citem["code"]); ;
                    }
                    */

                }

                //MessageBox.Show("Done");
            }
        }
        public void GetCaseDetailsById()
        {

        }

        private void addcaseparty_Click(object sender, EventArgs e)
        {

            string name = (casepartytype.SelectedItem as dynamic).name;
            string code = (casepartytype.SelectedItem as dynamic).code;

            Dictionary<string, string> map = new Dictionary<string, string>();
            map["name"] = name;
            map["code"] = code;
            map["is_required"] = "False";
            map["address"] = "Lorem ipsum dolor sit amet.";
            populateCaseParties(map);
            //MessageBox.Show(name + "=" + code);
        }

        private void casepartytype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filingcode1 = (filingcode.SelectedItem as dynamic).name;
            string documenttype1 = (documenttype.SelectedItem as dynamic).name;

            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(filings);
            dr.Cells[0].Value = filingcode1;
            dr.Cells[1].Value = documenttype1;
            dr.Cells[2].Value = 0;

            var rfc4122bytes = Convert.FromBase64String("aguidthatIgotonthewire==");
            Array.Reverse(rfc4122bytes, 0, 4);
            Array.Reverse(rfc4122bytes, 4, 2);
            Array.Reverse(rfc4122bytes, 6, 2);
            var guid = new Guid(rfc4122bytes);

            filings.Rows.Add(dr);


        }

        private void rbEFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEFile.Checked)
            {
                tabControl1.TabPages.Remove(tpServiceContacts);
            }
            else
            {
                tabControl1.TabPages.Insert(3, tpServiceContacts);
            }
        }

        private void frmCodeGenarator_Load(object sender, EventArgs e)
        {

        }

        private void caseparties_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = caseparties.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                MessageBox.Show("The selected Item Name is: " + item.Text);
                EditCasePartyDTO edit = new EditCasePartyDTO()
                {
                    RowIndex = item.Index,
                    FullName = item.SubItems[4].Text,
                    Address = item.SubItems[5].Text
                };
                frmEditCaseParty frmEditCase = new frmEditCaseParty(edit);
                frmEditCase.ShowDialog();
            }
            else
            {
                this.caseparties.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
        }
    }
}
