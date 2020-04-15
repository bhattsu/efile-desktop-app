﻿using EFileApp.DTOs;
using EFileApp.Helper;
using log4net.Repository;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace EFileApp
{
    public partial class frmCodeGenarator : Form
    {
        public bool SearchResultsReset { get; set; }
        private List<EditCasePartyDTO> casePartiesList = new List<EditCasePartyDTO>();
        private List<CreateFilingDTO> filingList = new List<CreateFilingDTO>();
        JObject payload = null;
        Dictionary<string, object> configs = null;

        //----------------------------------------------------------------------------------------------------
        public void initializePayload()
        {
            payload = new JObject();
            JObject data = new JObject();
            data.Add(new JProperty("batch_id", "${batch_id}"));
            data.Add(new JProperty("reference_id", "${reference_id}"));
            data.Add(new JProperty("case_parties", new JArray()));
            data.Add(new JProperty("filings", new JArray()));
            payload.Add(new JProperty("data", data));

            configs = new Dictionary<string, object>();

            configs.Add("jurisdiction", createExpandoObject("jurisdiction", "jurisdiction_display", "name", "code", jurisdiction1, new string[2] { "case_category", "filer_type" }));
            configs.Add("case_category", createExpandoObject("case_category", "case_category_display", "name", "code", casecategory1, new string[3] { "case_type", "procedure_remedy", "damage_amount" }));
            configs.Add("filer_type", createExpandoObject("filer_type", "filer_type_display", "name", "code", filertype1, null));
            configs.Add("case_type", createExpandoObject("case_type", "case_type_display", "name", "code", casetype1, new string[2] { "caseparty_type", "filing_code" }));
            configs.Add("procedure_remedy", createExpandoObject("procedure_remedy", "procedure_remedy_display", "name", "code", remedy1, null));
            configs.Add("damage_amount", createExpandoObject("damage_amount", "damage_amount_display", "name", "code", damageamount1, null));
            configs.Add("filing_attorney", createExpandoObject("filing_attorney", "filing_attorney_display", "display_name", "id", filingattorney1, null));
            configs.Add("payment_account", createExpandoObject("payment_account", "payment_account_display", "account_name", "payment_account_id", paymentaccount1, null));
            configs.Add("filing_code", createExpandoObject("filing_code", "filing_code_display", "name", "code", filingcode1, new string[1] { "document_type"}));
            configs.Add("document_type", createExpandoObject("document_type", "document_type_display", "name", "code", filingsecurity1, null));
            configs.Add("caseparty_type", createExpandoObject("caseparty_type", "caseparty_type_display", "name", "code", casepartytype1, null));
            configs.Add("service_contact", createExpandoObject("service_contact", "service_contact_display", "email", "service_contact_id", contact1, null));

        }
        public dynamic createExpandoObject(string code, string display,  string combodisplay, string combovalue, ComboBox component, string[] dependents)
        {
            dynamic expando = new ExpandoObject();
            expando.code = code;
            expando.display = display;
            expando.component = component;
            expando.isloaded = false;
            expando.combodisplay = combodisplay;
            expando.combovalue = combovalue;
            expando.dependents = dependents;
            return expando;
        }
        //----------------------------------------------------------------------------------------------------
        public string getDataValue(string key)
        {
            JObject data = (JObject)payload.GetValue("data");
            return (string)data.GetValue(key);
        }

        public void setDataValue(string key, string value)
        {
            JObject data = (JObject)payload.GetValue("data");
            data.Remove(key);
            data.Add(new JProperty(key, value));
        }

        public string generateUID()
        {
            var rfc4122bytes = Convert.FromBase64String("aguidthatIgotonthewire==");
            Array.Reverse(rfc4122bytes, 0, 4);
            Array.Reverse(rfc4122bytes, 4, 2);
            Array.Reverse(rfc4122bytes, 6, 2);
            var guid = new Guid(rfc4122bytes);
            return guid.ToString();
        }
        //----------------------------------------------------------------------------------------------------
        // Templates
        //----------------------------------------------------------------------------------------------------

        private void template1_Click(object sender, EventArgs e)
        {
            if (template1.Items.Count < 1)
            {
                string templatePath = Path.Combine(Properties.Settings.Default.DefaultTemplateLocation, AppConstants.LoginState);
                template1.DisplayMember = "name";
                template1.ValueMember = "code";
                string[] filePaths = Directory.GetFileSystemEntries(templatePath, "*.json", SearchOption.AllDirectories);
                template1.Items.Add(new { name = "", code = "" });
                for (int i = 0; i < filePaths.Length; i++)
                {
                    string filePath = filePaths[i];
                    string fileName = Path.GetFileName(filePath);
                    if (fileName.EndsWith(AppConstants.JSON_PATTERN))
                    {
                        template1.Items.Add(new { name = fileName.Replace(AppConstants.JSON_PATTERN, ""), code = filePath });
                    }
                }
            }

        }
        //----------------------------------------------------------------------------------------------------
        private void template1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = (template1.SelectedItem as dynamic).code;
            string readText = File.ReadAllText(path);
            payload = JObject.Parse(readText);

            JObject data = (JObject)payload.GetValue("data");
            JArray case_parties = (JArray)data.GetValue("case_parties");
            JArray filings = (JArray)data.GetValue("filings");

            if (case_parties == null)
            {
                data.Add(new JProperty("case_parties", new JArray()));
            }
            if (filings == null)
            {
                data.Add(new JProperty("filings", new JArray()));
            }
            loadData("jurisdiction", true);
            loadData("case_category", true);
            loadData("case_type", true);
            loadData("procedure_remedy", true);
            loadData("payment_account", true);
            loadData("filing_attorney", true);
            loadData("filer_type", true);
            
            reloadFilingsTable();
        }

        //----------------------------------------------------------------------------------------------------

        public void loadComboData(dynamic config, string api)
        {
            ComboBox combobox = config.component;
            combobox.DisplayMember = "name";
            combobox.ValueMember = "code";


            dynamic eitem = new { name = config.display, code = config.code };
            if (api == null)
            {
                /*
                if (existingcode != null && existingcode.Length != 0)
                {
                    combobox.Items.Add(eitem);
                    combobox.SelectedItem = eitem;
                }
                */
            }
            else
            {
                combobox.Items.Clear();
                combobox.ResetText();
                dynamic codes = AppConstants.ApiCaller.get(api);
                foreach (var item in codes["items"])
                {
                    combobox.Items.Add(new { name = item[config.combodisplay], code = item[config.combovalue] });
                }   
                selectComboItem(jurisdiction1, eitem);
            }
        }

        //----------------------------------------------------------------------------------------------------
        public void selectComboItem(ComboBox combobox, dynamic eitem)
        {
            foreach (dynamic item in combobox.Items)
            {
                if (eitem.code == item.code)
                {
                    combobox.SelectedItem = item;
                    break;
                }
            }
        }

        //----------------------------------------------------------------------------------------------------

        public void indexChange(string type) // If api is null, load as new
        {
            dynamic config = configs[type];
            string code = "";
            string display = "";
            dynamic item = config.component.SelectedItem;
            if (item != null)
            {
                code = item.code;
                display = item.name;
            }
            setDataValue(config.code, code);
            setDataValue(config.display, display);
            string[] dependents = config.dependents;
            if (dependents != null)
            {
                foreach (string dependent in dependents)
                {
                    dynamic dconfig = configs[dependent];
                    ComboBox dcombo = dconfig.component;
                    dcombo.SelectedItem = null;
                    dconfig.isloaded = false;
                }
            }
        }

        public void loadData(string type, bool isinitial) // If api is null, load as new
        {
            dynamic config = configs[type];
            if (!config.isloaded)
            {
                string api = null;
                if(type == "jurisdiction")
                {
                    api = "/code/location_codes";
                } else if (type == "case_category")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    if (jurisdiction != null)
                    {
                        api = "/code/case_category_codes?location_code=" + jurisdiction;
                    }

                } else if(type == "case_type")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    string case_category = getDataValue("case_category");
                    if (jurisdiction != null && case_category != null)
                    {
                        api = "/code/case_type_codes?location_code=" + jurisdiction + "&case_category_code=" + case_category + "&is_initial=true";
                    }
                } else if (type == "procedure_remedy")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    string case_category = getDataValue("case_category");
                    if (jurisdiction != null && case_category != null)
                    {
                        api = "/code/procedure_remedy_codes?location_code=" + jurisdiction + "&case_category_code=" + case_category + "&is_initial=true";
                    }
                } else if (type == "damage_amount")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    string case_category = getDataValue("case_category");
                    if (jurisdiction != null && case_category != null)
                    {
                        api = "/code/damage_amount_codes?location_code=" + jurisdiction + "&case_category_code=" + case_category + "&is_initial=true";
                    }
                } else if (type == "filer_type")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    if (jurisdiction != null)
                    {
                        api = "/code/filer_type_codes?location_code=" + jurisdiction;
                    }
                } else if (type == "filing_attorney")
                {
                   api = "/firm/attorneys";

                } else if (type == "payment_account")
                {
                    api = "/payment_accounts";

                } else if (type == "caseparty_type")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    string case_type = getDataValue("case_type");
                    if (jurisdiction != null && case_type != null)
                    {
                        api = "/code/party_type_codes?is_required=false&location_code=" + jurisdiction + "&case_type_code=" + case_type;
                    }
                }
                else if (type == "filing_code")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    string case_category = getDataValue("case_category");
                    string case_type = getDataValue("case_type");
                    if (jurisdiction != null && case_category != null && case_type != null)
                    {
                        api = "/code/filing_codes?location_code=" + jurisdiction + "&case_category_code=" + case_category + "&case_type_code=" + case_type + "&is_initial=true";
                    }
                }
                else if (type == "document_type")
                {
                    string jurisdiction = getDataValue("jurisdiction");
                    string filing_code = getDataValue("filing_code");
                    if (jurisdiction != null && filing_code != null)
                    {
                        api = "/code/document_type_codes?location_code=" + jurisdiction + "&filing_code=" + filing_code;
                    }
                } else if (type == "service_contact")
                {
                    api = "/service_contacts";
                }
                loadComboData(config, api);
                config.isloaded = true;
            }
        }
        //----------------------------------------------------------------------------------------------------
        //Jurisdiction Related code
        //----------------------------------------------------------------------------------------------------
        private void jurisdiction1_Click(object sender, EventArgs e)
        {
            loadData("jurisdiction", false);
        }
        private void jurisdiction1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("jurisdiction");
        }
        //----------------------------------------------------------------------------------------------------
        //Case Category
        //----------------------------------------------------------------------------------------------------

        private void casecategory1_Click(object sender, EventArgs e)
        {
            loadData("case_category", false);
        }

        private void casecategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("case_category");
        }

        //----------------------------------------------------------------------------------------------------
        //Case Type
        //----------------------------------------------------------------------------------------------------

        private void casetype1_Click(object sender, EventArgs e)
        {
            loadData("case_type", false);
        }

        private void casetype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("case_type");
        }


        //----------------------------------------------------------------------------------------------------
        //Procedure Remedy
        //----------------------------------------------------------------------------------------------------
 

        private void remedy1_Click(object sender, EventArgs e)
        {
            loadData("procedure_remedy", false);
        }

        private void remedy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("procedure_remedy");
        }

        //----------------------------------------------------------------------------------------------------
        //Damage Amount
        //----------------------------------------------------------------------------------------------------

        private void damageamount1_Click(object sender, EventArgs e)
        {
            loadData("damage_amount", false);
        }

        private void damageamount1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("damage_amount");
        }

        //----------------------------------------------------------------------------------------------------
        //Filer Type
        //----------------------------------------------------------------------------------------------------

        private void filertype1_Click(object sender, EventArgs e)
        {
            loadData("filer_type", false);
        }

        private void filertype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("filer_type");
        }

        //----------------------------------------------------------------------------------------------------
        //Filing Attorney
        //----------------------------------------------------------------------------------------------------

        private void filingattorney1_Click(object sender, EventArgs e)
        {
            loadData("filing_attorney", false);
        }

        private void filingattorney1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("filing_attorney");
        }

        //----------------------------------------------------------------------------------------------------
        //Payment Account
        //----------------------------------------------------------------------------------------------------

        private void paymentaccount1_Click(object sender, EventArgs e)
        {
            loadData("payment_account", false);
        }

        private void paymentaccount1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("payment_account");
        }


        //----------------------------------------------------------------------------------------------------
        //Filing Code
        //----------------------------------------------------------------------------------------------------

        private void filingcode1_Click(object sender, EventArgs e)
        {
            loadData("filing_code", false);
        }

        private void filingcode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange("filing_code");
        }

        //----------------------------------------------------------------------------------------------------
        //Filing Security
        //----------------------------------------------------------------------------------------------------


        private void filingsecurity1_Click(object sender, EventArgs e)
        {
            loadData("document_type", false);
        }

        //----------------------------------------------------------------------------------------------------
        //Case Party Type
        //----------------------------------------------------------------------------------------------------

        private void casepartytype1_Click(object sender, EventArgs e)
        {
            loadData("caseparty_type", false);
        }

        //----------------------------------------------------------------------------------------------------
        //Service Contacts
        //----------------------------------------------------------------------------------------------------

        private void contact1_Click(object sender, EventArgs e)
        {
            loadData("service_contact", false);
        }
        //----------------------------------------------------------------------------------------------------
        //Case Parties
        //----------------------------------------------------------------------------------------------------

        private void loadcasepartytypeandparties()
        {
            string jurisdiction = getDataValue("jurisdiction");
            string casetype = getDataValue("case_type");

            JObject data = (JObject)payload.GetValue("data");
            JArray case_parties = (JArray)data.GetValue("case_parties");
            case_parties.Clear();

            if (jurisdiction != null && casetype != null)
            {

                JsonObject codes = AppConstants.ApiCaller.get("/code/party_type_codes?is_required=true&location_code=" + jurisdiction + "&case_type_code=" + casetype);
                JsonObject codes1 = AppConstants.ApiCaller.get("/code/party_type_codes?is_required=false&location_code=" + jurisdiction + "&case_type_code=" + casetype);
                dynamic items = codes["items"];
                dynamic items1 = codes1["items"];

                casepartytype1.DisplayMember = "name";
                casepartytype1.ValueMember = "code";
                foreach (var item in items)
                {
                    if (jurisdiction1.Enabled)
                    {
                        addCasePartyToPayload(item);
                    }
                    casepartytype1.Items.Add(new { name = item["name"], code = item["code"] });
                }

                foreach (var item in items1)
                {
                    casepartytype1.Items.Add(new { name = item["name"], code = item["code"] });
                }

            }

            reloadCasePartyTable();
        }

        public void addCasePartyToPayload(dynamic item)
        {
            string name = item["name"];
            string code = item["code"];

            JObject caseparty = new JObject();
            caseparty.Add(new JProperty("type", code));
            caseparty.Add(new JProperty("type_display", name));
            caseparty.Add(new JProperty("identifcation_object", "Party_"+ generateUID()));
            
            JObject data = (JObject)payload.GetValue("data");
            JArray case_parties = (JArray)data.GetValue("case_parties");
            case_parties.Add(caseparty);
        }


        public void reloadCasePartyTable()
        {
            caseparties1.Rows.Clear();
            JObject data = (JObject)payload.GetValue("data");
            JArray case_parties = (JArray)data.GetValue("case_parties");
            foreach(JObject case_party in case_parties)
            {
                caseparties1.Rows.Add(new[] { 
                    case_party.GetValue("type_display") 
                });
            }
        }

        private void addcaseparty1_Click(object sender, EventArgs e)
        {
            dynamic item = casepartytype1.SelectedItem;
            if (item != null)
            {
                JObject obj = new JObject();
                obj.Add(new JProperty("name", item.name));
                obj.Add(new JProperty("code", item.code));

                addCasePartyToPayload(obj);
                reloadCasePartyTable();
                //MessageBox.Show(payload.ToString());
            }
        }


        //----------------------------------------------------------------------------------------------------
        //Filing code
        //----------------------------------------------------------------------------------------------------
        
        private void loadfilingcodes()
        {
            string jurisdiction = getDataValue("jurisdiction");
            string case_category = getDataValue("case_category");
            string case_type = getDataValue("case_type");
            if (jurisdiction != null && case_category != null && case_type != null)
            {
                string api = "filing_codes?location_code=" + jurisdiction + "&case_category_code=" + case_category + "&case_type_code=" + case_type + "&is_initial=true";
                //loadComboData(filingcode1, null, null, api);
            }
        }


        private void loadfilingsecurity()
        {
            string jurisdiction = getDataValue("jurisdiction");
            if (jurisdiction != null && filingcode1.SelectedItem != null)
            {
                string filingcode = (filingcode1.SelectedItem as dynamic).code;
                if (jurisdiction != null && filingcode != null)
                {
                    dynamic api = "document_type_codes?location_code=" + jurisdiction + "&filing_code=" + filingcode;
                    //loadComboData(filingsecurity1, null, null, api);
                }
            }
        }


        private void addfiling1_Click(object sender, EventArgs e)
        {
            if (filingcode1.SelectedItem != null && filingsecurity1.SelectedItem != null) {

                string filingcode = (filingcode1.SelectedItem as dynamic).code;
                string filingcodedisplay = (filingcode1.SelectedItem as dynamic).name;

                string filingsecurity = (filingsecurity1.SelectedItem as dynamic).code;
                string filingsecuritydisplay = (filingsecurity1.SelectedItem as dynamic).name;

                JObject filing = new JObject();
                filing.Add(new JProperty("code", filingcode));
                filing.Add(new JProperty("code_display", filingcodedisplay));
                filing.Add(new JProperty("lead_doc_security", filingsecurity));
                filing.Add(new JProperty("lead_doc_security_display", filingsecuritydisplay));

                JObject data = (JObject)payload.GetValue("data");
                JArray filings = (JArray)data.GetValue("filings");
                filings.Add(filing);
                reloadFilingsTable();
                //MessageBox.Show(payload.ToString());
             }
            
        }


        public void reloadFilingsTable()
        {
            filings1.Rows.Clear();
            JObject data = (JObject)payload.GetValue("data");
            JArray filings = (JArray)data.GetValue("filings");
            foreach (JObject filing in filings)
            {
                filings1.Rows.Add(new[] {
                    filing.GetValue("code_display"),
                    filing.GetValue("lead_doc_security_display")
                });
            }
        }



        private void previewtemplate1_Click(object sender, EventArgs e)
        {
            frmPayload pa = new frmPayload(payload);
            pa.Show();
        }


        //----------------------------------------------------------------------------------------------------
        // Below this is old code - just use as a reference
        //----------------------------------------------------------------------------------------------------




















        public frmCodeGenarator()
        {
            InitializeComponent();
            initializePayload();
            

            //this.settings = settings;

        }


        private void casecategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            casetype_SelectedIndexChanged(sender, e);
        }

        private void casetype_SelectedIndexChanged(object sender, EventArgs e)
        {


            caseparties.Items.Clear();

            casepartytype.Items.Clear();
            casepartytype.ResetText();
            casepartytype_Click(sender, e);
        }




        private void casepartytype_Click(object sender, EventArgs e)
        {


        }

        public void populateCaseParties(dynamic item)
        {


            string is_required = item["is_required"];
            string name = item["name"];
            string code = item["code"];


            var rfc4122bytes = Convert.FromBase64String("aguidthatIgotonthewire==");
            Array.Reverse(rfc4122bytes, 0, 4);
            Array.Reverse(rfc4122bytes, 4, 2);
            Array.Reverse(rfc4122bytes, 6, 2);
            var guid = new Guid(rfc4122bytes);

            //   var row = new ListViewItem(new[] { name, "", required, code, "", "Party_" + guid });
            EditCasePartyDTO caseParty = new EditCasePartyDTO()
            {
                Address = "",
                PartyType = name,
                Code = code,
                IsRequired = (is_required == "True"),
                GUID = "Party_" + guid
            };
            casePartiesList.Add(caseParty);
            RefreshPartiesTable();

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
            //TODO : Edit here

            return new
            {
                filing_type = "EFile",
                lead_doc_code = "332",
                //filing_description = getSelectedDisplay(filingcode),
                lead_doc_path = "${lead_doc" + count + "}",
                //  lead_doc_security = getSelectedValue(documenttype, "documenttype"),
                //       code = getSelectedValue(filingcode, "filingcode"),
                attachment = new[] {
                            new
                            {
                                path = "${lead_doc" + count + "_attachment1}",
                        //        security = getSelectedValue(documenttype, "documenttype")
                            }
                        },
                // optional_service = createOptionalServices()
            };


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

        private async void searchcase_Click(object sender, EventArgs e)
        {
            
        }
        public async Task GetCaseDetailsByIdAsync(CaseSearchResultDTO item)
        {
           
        }

        private void addcaseparty_Click(object sender, EventArgs e)
        {

            if (casepartytype.SelectedItem != null)
            {

                string name = (casepartytype.SelectedItem as dynamic).name;
                string code = (casepartytype.SelectedItem as dynamic).code;


                EditCasePartyDTO caseParty = new EditCasePartyDTO()
                {
                    Address = "",
                    PartyType = name,
                    Code = code,
                    IsRequired = false
                };
                var rfc4122bytes = Convert.FromBase64String("aguidthatIgotonthewire==");
                Array.Reverse(rfc4122bytes, 0, 4);
                Array.Reverse(rfc4122bytes, 4, 2);
                Array.Reverse(rfc4122bytes, 6, 2);
                var guid = Guid.NewGuid();

                caseParty.GUID = "Party_" + guid;
                casePartiesList.Add(caseParty);
                RefreshPartiesTable();
            }
        }



        private void frmCodeGenarator_Load(object sender, EventArgs e)
        {
            if (AppConstants.LoginState != "IL-PROD" && AppConstants.LoginState != "IL-PROD")
            {
                gbAmount.Hide();
                //TODO: IF COOK COUNTY IMPLEMENTATION
                if (true)
                {
                    gbCrossReference.Show();
                }
            }
            var services = AppConstants.ApiCaller.getUsingAuthToken("/service_contacts");
            lbServiceContacts.DisplayMember = "name";
            lbServiceContacts.ValueMember = "code";
            foreach (var item in services["items"])
            {
                lbServiceContacts.Items.Add(new { name = item["email"], code = item["service_contact_id"] });
            }

        }

        /*
        private void caseparties_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = caseparties.HitTest(e.X, e.Y).Item;

            if (item != null)
            {
                frmEditCaseParty frmEditCase = new frmEditCaseParty(casePartiesList[item.Index], this);
                frmEditCase.ShowDialog();
            }
            else
            {
                caseparties.SelectedItems.Clear();
            }
        }*/

        public void RefreshPartiesTable()
        {
            caseparties.Items.Clear();
            foreach (var caseParty in casePartiesList)
            {
                var row = new ListViewItem(new[] { caseParty.PartyType,
                    caseParty.IsFiling.ToString(),
                    caseParty.IsRequired.ToString(),
                    caseParty.FirstName,
                    caseParty.Address,
                    caseParty.GUID,
                    caseParty.LeadAttorney,
                    caseParty.AssociatedAttorneys
                });
                caseparties.Items.Add(row);

            }
        }
        public void UpdatePartiesTable(EditCasePartyDTO caseParty)
        {
            casePartiesList = casePartiesList.Select(x => x.GUID == caseParty.GUID ? caseParty : x).ToList();
            RefreshPartiesTable();
        }

        private void btnEditParty_Click(object sender, EventArgs e)
        {
            if (caseparties.SelectedItems[0] != null)
            {
                var selected = casePartiesList[caseparties.SelectedItems[0].Index];
                frmEditCaseParty frmEditCase = new frmEditCaseParty(selected, this);
                frmEditCase.ShowDialog();

            }

        }
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            var selected = casePartiesList[caseparties.SelectedItems[0].Index];
            casePartiesList.Remove(selected);
            RefreshPartiesTable();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
  
        }

        private void btnGenerateTemplate_Click(object sender, EventArgs e)
        {

        }
        private void btnAddNewFiling_Click(object sender, EventArgs e)
        {


        }
        private void btnEditFiling_Click(object sender, EventArgs e)
        {
            if (lvFilings.SelectedItems.Count <= 0)
            {
                return;
            }
            filingList.RemoveAt(lvFilings.SelectedItems[0].Index);
            UpdateFilingListView();

        }

        public void AddFiling(CreateFilingDTO create)
        {
            filingList.Add(create);
            UpdateFilingListView();
        }




        public void UpdateFilingListView()
        {

            lvFilings.Items.Clear();
            foreach (var filing in filingList)
            {
                var row = new ListViewItem(new[] {
                    filing.FilingName,
                    filing.SecurityName,
                    (filing.OptionalServices != null && filing.OptionalServices.Count > 0) ?
                    string.Join(", ",filing.OptionalServices.Select(x=>x.Name).ToArray()) :"",
                    (filing.LeadDocumentPath != null && filing.LeadDocumentPath.Length> 0) ?   Path.GetFileName(filing.LeadDocumentPath) : "",
                    (filing.Attachments != null && filing.Attachments.Count > 0) ?
                    string.Join(", ", filing.Attachments.Select(x => Path.GetFileName(x.Path)).ToArray()) : "",
                }); ;
                lvFilings.Items.Add(row);
            }
        }


    }
}
