namespace EFileApp
{
    partial class frmCodeGenarator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbEFile = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbEService = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbBoth = new MaterialSkin.Controls.MaterialRadioButton();
            this.textBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.preliminarycopies = new MaterialSkin.Controls.MaterialTextBox();
            this.courtesycopy = new MaterialSkin.Controls.MaterialTextBox();
            this.paymentaccount = new MaterialSkin.Controls.MaterialComboBox();
            this.filertype = new MaterialSkin.Controls.MaterialComboBox();
            this.filingattorney = new MaterialSkin.Controls.MaterialComboBox();
            this.datamageamount = new MaterialSkin.Controls.MaterialComboBox();
            this.remedy = new MaterialSkin.Controls.MaterialComboBox();
            this.casetype = new MaterialSkin.Controls.MaterialComboBox();
            this.casecategory = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSearchCase = new MaterialSkin.Controls.MaterialButton();
            this.casesearchbox = new MaterialSkin.Controls.MaterialTextBox();
            this.jurisdiction = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.caseparties = new MaterialSkin.Controls.MaterialListView();
            this.partyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isFillingParty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.required = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.filings = new System.Windows.Forms.DataGridView();
            this.filingname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filingsecurity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedparties = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filingoptionalservice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.optionalservices = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.documenttype = new System.Windows.Forms.ComboBox();
            this.filingcode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpServiceContacts = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.generateTemplate = new MaterialSkin.Controls.MaterialButton();
            this.casepartytype = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddNewParty = new MaterialSkin.Controls.MaterialButton();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filings)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionalservices)).BeginInit();
            this.tpServiceContacts.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tpServiceContacts);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 593);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.rbEFile);
            this.tabPage3.Controls.Add(this.rbEService);
            this.tabPage3.Controls.Add(this.rbBoth);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.preliminarycopies);
            this.tabPage3.Controls.Add(this.courtesycopy);
            this.tabPage3.Controls.Add(this.paymentaccount);
            this.tabPage3.Controls.Add(this.filertype);
            this.tabPage3.Controls.Add(this.filingattorney);
            this.tabPage3.Controls.Add(this.datamageamount);
            this.tabPage3.Controls.Add(this.remedy);
            this.tabPage3.Controls.Add(this.casetype);
            this.tabPage3.Controls.Add(this.casecategory);
            this.tabPage3.Controls.Add(this.btnSearchCase);
            this.tabPage3.Controls.Add(this.casesearchbox);
            this.tabPage3.Controls.Add(this.jurisdiction);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1024, 567);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Remedy";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(41, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 53;
            this.materialLabel1.Text = "Filing Type";
            // 
            // rbEFile
            // 
            this.rbEFile.AutoSize = true;
            this.rbEFile.Depth = 0;
            this.rbEFile.Location = new System.Drawing.Point(200, 45);
            this.rbEFile.Margin = new System.Windows.Forms.Padding(0);
            this.rbEFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEFile.Name = "rbEFile";
            this.rbEFile.Ripple = true;
            this.rbEFile.Size = new System.Drawing.Size(69, 37);
            this.rbEFile.TabIndex = 52;
            this.rbEFile.TabStop = true;
            this.rbEFile.Text = "EFile";
            this.rbEFile.UseVisualStyleBackColor = true;
            this.rbEFile.CheckedChanged += new System.EventHandler(this.rbEFile_CheckedChanged);
            // 
            // rbEService
            // 
            this.rbEService.AutoSize = true;
            this.rbEService.Depth = 0;
            this.rbEService.Location = new System.Drawing.Point(269, 45);
            this.rbEService.Margin = new System.Windows.Forms.Padding(0);
            this.rbEService.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEService.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEService.Name = "rbEService";
            this.rbEService.Ripple = true;
            this.rbEService.Size = new System.Drawing.Size(95, 37);
            this.rbEService.TabIndex = 51;
            this.rbEService.TabStop = true;
            this.rbEService.Text = "EService";
            this.rbEService.UseVisualStyleBackColor = true;
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Checked = true;
            this.rbBoth.Depth = 0;
            this.rbBoth.Location = new System.Drawing.Point(44, 45);
            this.rbBoth.Margin = new System.Windows.Forms.Padding(0);
            this.rbBoth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBoth.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Ripple = true;
            this.rbBoth.Size = new System.Drawing.Size(156, 37);
            this.rbBoth.TabIndex = 50;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "EFile and  EServe";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Depth = 0;
            this.textBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox2.Hint = "Note to Clerk";
            this.textBox2.Location = new System.Drawing.Point(434, 368);
            this.textBox2.MaxLength = 50;
            this.textBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 50);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "";
            // 
            // preliminarycopies
            // 
            this.preliminarycopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preliminarycopies.Depth = 0;
            this.preliminarycopies.Font = new System.Drawing.Font("Roboto", 12F);
            this.preliminarycopies.Hint = "Preliminary Copies";
            this.preliminarycopies.Location = new System.Drawing.Point(434, 254);
            this.preliminarycopies.MaxLength = 50;
            this.preliminarycopies.MouseState = MaterialSkin.MouseState.OUT;
            this.preliminarycopies.Multiline = false;
            this.preliminarycopies.Name = "preliminarycopies";
            this.preliminarycopies.Size = new System.Drawing.Size(348, 50);
            this.preliminarycopies.TabIndex = 48;
            this.preliminarycopies.Text = "";
            // 
            // courtesycopy
            // 
            this.courtesycopy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courtesycopy.Depth = 0;
            this.courtesycopy.Font = new System.Drawing.Font("Roboto", 12F);
            this.courtesycopy.Hint = "Courtesy Copy";
            this.courtesycopy.Location = new System.Drawing.Point(434, 312);
            this.courtesycopy.MaxLength = 50;
            this.courtesycopy.MouseState = MaterialSkin.MouseState.OUT;
            this.courtesycopy.Multiline = false;
            this.courtesycopy.Name = "courtesycopy";
            this.courtesycopy.Size = new System.Drawing.Size(348, 50);
            this.courtesycopy.TabIndex = 47;
            this.courtesycopy.Text = "";
            // 
            // paymentaccount
            // 
            this.paymentaccount.AutoResize = false;
            this.paymentaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paymentaccount.Depth = 0;
            this.paymentaccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.paymentaccount.DropDownHeight = 174;
            this.paymentaccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentaccount.DropDownWidth = 121;
            this.paymentaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.paymentaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paymentaccount.FormattingEnabled = true;
            this.paymentaccount.Hint = "Payment Account";
            this.paymentaccount.IntegralHeight = false;
            this.paymentaccount.ItemHeight = 43;
            this.paymentaccount.Location = new System.Drawing.Point(434, 199);
            this.paymentaccount.MaxDropDownItems = 4;
            this.paymentaccount.MouseState = MaterialSkin.MouseState.OUT;
            this.paymentaccount.Name = "paymentaccount";
            this.paymentaccount.Size = new System.Drawing.Size(345, 49);
            this.paymentaccount.TabIndex = 45;
            this.paymentaccount.SelectedIndexChanged += new System.EventHandler(this.paymentaccount_SelectedIndexChanged);
            this.paymentaccount.Click += new System.EventHandler(this.paymentaccount_Click);
            // 
            // filertype
            // 
            this.filertype.AutoResize = false;
            this.filertype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filertype.Depth = 0;
            this.filertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filertype.DropDownHeight = 174;
            this.filertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filertype.DropDownWidth = 121;
            this.filertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.filertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filertype.FormattingEnabled = true;
            this.filertype.Hint = "Filer Type";
            this.filertype.IntegralHeight = false;
            this.filertype.ItemHeight = 43;
            this.filertype.Location = new System.Drawing.Point(434, 144);
            this.filertype.MaxDropDownItems = 4;
            this.filertype.MouseState = MaterialSkin.MouseState.OUT;
            this.filertype.Name = "filertype";
            this.filertype.Size = new System.Drawing.Size(345, 49);
            this.filertype.TabIndex = 44;
            this.filertype.SelectedIndexChanged += new System.EventHandler(this.filertype_SelectedIndexChanged);
            this.filertype.Click += new System.EventHandler(this.filertype_Click);
            // 
            // filingattorney
            // 
            this.filingattorney.AutoResize = false;
            this.filingattorney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filingattorney.Depth = 0;
            this.filingattorney.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filingattorney.DropDownHeight = 174;
            this.filingattorney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filingattorney.DropDownWidth = 121;
            this.filingattorney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.filingattorney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filingattorney.FormattingEnabled = true;
            this.filingattorney.Hint = "Filing Attorney";
            this.filingattorney.IntegralHeight = false;
            this.filingattorney.ItemHeight = 43;
            this.filingattorney.Location = new System.Drawing.Point(434, 90);
            this.filingattorney.MaxDropDownItems = 4;
            this.filingattorney.MouseState = MaterialSkin.MouseState.OUT;
            this.filingattorney.Name = "filingattorney";
            this.filingattorney.Size = new System.Drawing.Size(345, 49);
            this.filingattorney.TabIndex = 41;
            this.filingattorney.SelectedIndexChanged += new System.EventHandler(this.filingattorney_SelectedIndexChanged);
            this.filingattorney.Click += new System.EventHandler(this.filingattorney_Click);
            // 
            // datamageamount
            // 
            this.datamageamount.AutoResize = false;
            this.datamageamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datamageamount.Depth = 0;
            this.datamageamount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.datamageamount.DropDownHeight = 174;
            this.datamageamount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datamageamount.DropDownWidth = 121;
            this.datamageamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.datamageamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datamageamount.FormattingEnabled = true;
            this.datamageamount.Hint = "Damage Amount";
            this.datamageamount.IntegralHeight = false;
            this.datamageamount.ItemHeight = 43;
            this.datamageamount.Location = new System.Drawing.Point(44, 367);
            this.datamageamount.MaxDropDownItems = 4;
            this.datamageamount.MouseState = MaterialSkin.MouseState.OUT;
            this.datamageamount.Name = "datamageamount";
            this.datamageamount.Size = new System.Drawing.Size(345, 49);
            this.datamageamount.TabIndex = 40;
            this.datamageamount.SelectedIndexChanged += new System.EventHandler(this.datamageamount_SelectedIndexChanged);
            this.datamageamount.Click += new System.EventHandler(this.datamageamount_Click);
            // 
            // remedy
            // 
            this.remedy.AutoResize = false;
            this.remedy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.remedy.Depth = 0;
            this.remedy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.remedy.DropDownHeight = 174;
            this.remedy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remedy.DropDownWidth = 121;
            this.remedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.remedy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remedy.FormattingEnabled = true;
            this.remedy.Hint = "Remedy";
            this.remedy.IntegralHeight = false;
            this.remedy.ItemHeight = 43;
            this.remedy.Location = new System.Drawing.Point(44, 312);
            this.remedy.MaxDropDownItems = 4;
            this.remedy.MouseState = MaterialSkin.MouseState.OUT;
            this.remedy.Name = "remedy";
            this.remedy.Size = new System.Drawing.Size(345, 49);
            this.remedy.TabIndex = 39;
            this.remedy.Click += new System.EventHandler(this.remedy_Click);
            // 
            // casetype
            // 
            this.casetype.AutoResize = false;
            this.casetype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casetype.Depth = 0;
            this.casetype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.casetype.DropDownHeight = 174;
            this.casetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.casetype.DropDownWidth = 121;
            this.casetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.casetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.casetype.FormattingEnabled = true;
            this.casetype.Hint = "Case Type";
            this.casetype.IntegralHeight = false;
            this.casetype.ItemHeight = 43;
            this.casetype.Location = new System.Drawing.Point(44, 257);
            this.casetype.MaxDropDownItems = 4;
            this.casetype.MouseState = MaterialSkin.MouseState.OUT;
            this.casetype.Name = "casetype";
            this.casetype.Size = new System.Drawing.Size(345, 49);
            this.casetype.TabIndex = 38;
            this.casetype.SelectedIndexChanged += new System.EventHandler(this.casetype_SelectedIndexChanged);
            this.casetype.Click += new System.EventHandler(this.casetype_Click);
            // 
            // casecategory
            // 
            this.casecategory.AutoResize = false;
            this.casecategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casecategory.Depth = 0;
            this.casecategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.casecategory.DropDownHeight = 174;
            this.casecategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.casecategory.DropDownWidth = 121;
            this.casecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.casecategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.casecategory.FormattingEnabled = true;
            this.casecategory.Hint = "Case Category";
            this.casecategory.IntegralHeight = false;
            this.casecategory.ItemHeight = 43;
            this.casecategory.Location = new System.Drawing.Point(44, 202);
            this.casecategory.MaxDropDownItems = 4;
            this.casecategory.MouseState = MaterialSkin.MouseState.OUT;
            this.casecategory.Name = "casecategory";
            this.casecategory.Size = new System.Drawing.Size(345, 49);
            this.casecategory.TabIndex = 37;
            this.casecategory.SelectedIndexChanged += new System.EventHandler(this.casecategory_SelectedIndexChanged);
            this.casecategory.Click += new System.EventHandler(this.casecategory_Click);
            // 
            // btnSearchCase
            // 
            this.btnSearchCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchCase.Depth = 0;
            this.btnSearchCase.DrawShadows = true;
            this.btnSearchCase.HighEmphasis = true;
            this.btnSearchCase.Icon = null;
            this.btnSearchCase.Location = new System.Drawing.Point(311, 152);
            this.btnSearchCase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchCase.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchCase.Name = "btnSearchCase";
            this.btnSearchCase.Size = new System.Drawing.Size(78, 36);
            this.btnSearchCase.TabIndex = 36;
            this.btnSearchCase.Text = "Search";
            this.btnSearchCase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchCase.UseAccentColor = false;
            this.btnSearchCase.UseVisualStyleBackColor = true;
            this.btnSearchCase.Click += new System.EventHandler(this.searchcase_Click);
            // 
            // casesearchbox
            // 
            this.casesearchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.casesearchbox.Depth = 0;
            this.casesearchbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.casesearchbox.Hint = "Case Number";
            this.casesearchbox.Location = new System.Drawing.Point(44, 146);
            this.casesearchbox.MaxLength = 50;
            this.casesearchbox.MouseState = MaterialSkin.MouseState.OUT;
            this.casesearchbox.Multiline = false;
            this.casesearchbox.Name = "casesearchbox";
            this.casesearchbox.Size = new System.Drawing.Size(255, 50);
            this.casesearchbox.TabIndex = 35;
            this.casesearchbox.Text = "";
            // 
            // jurisdiction
            // 
            this.jurisdiction.AutoResize = false;
            this.jurisdiction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.jurisdiction.Depth = 0;
            this.jurisdiction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.jurisdiction.DropDownHeight = 647;
            this.jurisdiction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jurisdiction.DropDownWidth = 121;
            this.jurisdiction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.jurisdiction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.jurisdiction.FormattingEnabled = true;
            this.jurisdiction.Hint = "Jurisdiction";
            this.jurisdiction.IntegralHeight = false;
            this.jurisdiction.ItemHeight = 43;
            this.jurisdiction.Location = new System.Drawing.Point(44, 91);
            this.jurisdiction.MaxDropDownItems = 15;
            this.jurisdiction.MouseState = MaterialSkin.MouseState.OUT;
            this.jurisdiction.Name = "jurisdiction";
            this.jurisdiction.Size = new System.Drawing.Size(345, 49);
            this.jurisdiction.TabIndex = 25;
            this.jurisdiction.SelectedIndexChanged += new System.EventHandler(this.jurisdiction_SelectedIndexChanged);
            this.jurisdiction.Click += new System.EventHandler(this.jurisdiction_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnAddNewParty);
            this.tabPage4.Controls.Add(this.casepartytype);
            this.tabPage4.Controls.Add(this.caseparties);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1024, 567);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Case Parties";
            // 
            // caseparties
            // 
            this.caseparties.AutoSizeTable = false;
            this.caseparties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.caseparties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caseparties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partyType,
            this.isFillingParty,
            this.code,
            this.required,
            this.fullName,
            this.address,
            this.id});
            this.caseparties.Depth = 0;
            this.caseparties.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.caseparties.FullRowSelect = true;
            this.caseparties.HideSelection = false;
            this.caseparties.Location = new System.Drawing.Point(20, 76);
            this.caseparties.MinimumSize = new System.Drawing.Size(200, 100);
            this.caseparties.MouseLocation = new System.Drawing.Point(-1, -1);
            this.caseparties.MouseState = MaterialSkin.MouseState.OUT;
            this.caseparties.Name = "caseparties";
            this.caseparties.OwnerDraw = true;
            this.caseparties.Size = new System.Drawing.Size(982, 491);
            this.caseparties.TabIndex = 21;
            this.caseparties.UseCompatibleStateImageBehavior = false;
            this.caseparties.View = System.Windows.Forms.View.Details;
            this.caseparties.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.caseparties_MouseDoubleClick);
            // 
            // partyType
            // 
            this.partyType.Name = "partyType";
            this.partyType.Text = "Party Type";
            this.partyType.Width = 129;
            // 
            // isFillingParty
            // 
            this.isFillingParty.Name = "isFillingParty";
            this.isFillingParty.Text = "Is Filling Party";
            this.isFillingParty.Width = 150;
            // 
            // code
            // 
            this.code.Text = "Code";
            this.code.Width = 0;
            // 
            // required
            // 
            this.required.Text = "Required";
            this.required.Width = 100;
            // 
            // fullName
            // 
            this.fullName.Name = "fullName";
            this.fullName.Text = "Full Name";
            this.fullName.Width = 200;
            // 
            // address
            // 
            this.address.DisplayIndex = 6;
            this.address.Name = "address";
            this.address.Text = "Address";
            this.address.Width = 200;
            // 
            // id
            // 
            this.id.DisplayIndex = 5;
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.filings);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1024, 567);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Filings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Added Filings:";
            // 
            // filings
            // 
            this.filings.AllowUserToAddRows = false;
            this.filings.AllowUserToDeleteRows = false;
            this.filings.BackgroundColor = System.Drawing.SystemColors.Window;
            this.filings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filingname,
            this.filingsecurity,
            this.attachmentsize,
            this.associatedparties,
            this.filingoptionalservice,
            this.fill});
            this.filings.Location = new System.Drawing.Point(139, 258);
            this.filings.Name = "filings";
            this.filings.Size = new System.Drawing.Size(827, 126);
            this.filings.TabIndex = 20;
            // 
            // filingname
            // 
            this.filingname.HeaderText = "filingname";
            this.filingname.MinimumWidth = 200;
            this.filingname.Name = "filingname";
            this.filingname.ReadOnly = true;
            this.filingname.Width = 200;
            // 
            // filingsecurity
            // 
            this.filingsecurity.HeaderText = "Security";
            this.filingsecurity.MinimumWidth = 100;
            this.filingsecurity.Name = "filingsecurity";
            this.filingsecurity.ReadOnly = true;
            // 
            // attachmentsize
            // 
            this.attachmentsize.HeaderText = "Attachment Size";
            this.attachmentsize.MinimumWidth = 150;
            this.attachmentsize.Name = "attachmentsize";
            this.attachmentsize.Width = 150;
            // 
            // associatedparties
            // 
            this.associatedparties.HeaderText = "Associated Parties";
            this.associatedparties.MinimumWidth = 150;
            this.associatedparties.Name = "associatedparties";
            this.associatedparties.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.associatedparties.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.associatedparties.Width = 150;
            // 
            // filingoptionalservice
            // 
            this.filingoptionalservice.HeaderText = "Optional Service";
            this.filingoptionalservice.MinimumWidth = 150;
            this.filingoptionalservice.Name = "filingoptionalservice";
            this.filingoptionalservice.Width = 150;
            // 
            // fill
            // 
            this.fill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fill.HeaderText = "";
            this.fill.MinimumWidth = 2;
            this.fill.Name = "fill";
            this.fill.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.optionalservices);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.documenttype);
            this.groupBox2.Controls.Add(this.filingcode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 233);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filing 1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(615, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(345, 19);
            this.checkedListBox1.TabIndex = 23;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(546, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 22;
            this.label25.Text = "Counsel:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(508, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Lead Attorney:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(615, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add New Filing";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // optionalservices
            // 
            this.optionalservices.AllowUserToAddRows = false;
            this.optionalservices.AllowUserToDeleteRows = false;
            this.optionalservices.BackgroundColor = System.Drawing.SystemColors.Window;
            this.optionalservices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionalservices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionalservices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.code1,
            this.quantity,
            this.filler});
            this.optionalservices.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.optionalservices.Location = new System.Drawing.Point(133, 97);
            this.optionalservices.Name = "optionalservices";
            this.optionalservices.Size = new System.Drawing.Size(827, 92);
            this.optionalservices.TabIndex = 15;
            // 
            // Name1
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Name1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Name1.HeaderText = "Name";
            this.Name1.MinimumWidth = 300;
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Width = 300;
            // 
            // code1
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.code1.DefaultCellStyle = dataGridViewCellStyle5;
            this.code1.HeaderText = "Code";
            this.code1.MinimumWidth = 100;
            this.code1.Name = "code1";
            // 
            // quantity
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 100;
            this.quantity.Name = "quantity";
            // 
            // filler
            // 
            this.filler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filler.HeaderText = "";
            this.filler.MinimumWidth = 2;
            this.filler.Name = "filler";
            this.filler.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Optional Services:";
            // 
            // documenttype
            // 
            this.documenttype.FormattingEnabled = true;
            this.documenttype.Location = new System.Drawing.Point(133, 51);
            this.documenttype.Name = "documenttype";
            this.documenttype.Size = new System.Drawing.Size(345, 21);
            this.documenttype.TabIndex = 9;
            // 
            // filingcode
            // 
            this.filingcode.FormattingEnabled = true;
            this.filingcode.Location = new System.Drawing.Point(133, 23);
            this.filingcode.Name = "filingcode";
            this.filingcode.Size = new System.Drawing.Size(345, 21);
            this.filingcode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Security:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filing Code:";
            // 
            // tpServiceContacts
            // 
            this.tpServiceContacts.Controls.Add(this.listBox2);
            this.tpServiceContacts.Location = new System.Drawing.Point(4, 22);
            this.tpServiceContacts.Name = "tpServiceContacts";
            this.tpServiceContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tpServiceContacts.Size = new System.Drawing.Size(1024, 567);
            this.tpServiceContacts.TabIndex = 3;
            this.tpServiceContacts.Text = "Service Contacts";
            this.tpServiceContacts.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(16, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(952, 121);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Controls.Add(this.textBox3);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1024, 567);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Misc";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(23, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cross Reference";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(190, 120);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(291, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(190, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(291, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Cross Reference Number";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(291, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(37, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Cross Reference Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(190, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(291, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(291, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Amount in Controversy";
            // 
            // generateTemplate
            // 
            this.generateTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateTemplate.Depth = 0;
            this.generateTemplate.DrawShadows = true;
            this.generateTemplate.HighEmphasis = true;
            this.generateTemplate.Icon = null;
            this.generateTemplate.Location = new System.Drawing.Point(615, 741);
            this.generateTemplate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generateTemplate.MouseState = MaterialSkin.MouseState.HOVER;
            this.generateTemplate.Name = "generateTemplate";
            this.generateTemplate.Size = new System.Drawing.Size(173, 36);
            this.generateTemplate.TabIndex = 54;
            this.generateTemplate.Text = "Generate Template";
            this.generateTemplate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generateTemplate.UseAccentColor = false;
            this.generateTemplate.UseVisualStyleBackColor = true;
            this.generateTemplate.Click += new System.EventHandler(this.button2_Click);
            // 
            // casepartytype
            // 
            this.casepartytype.AutoResize = false;
            this.casepartytype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.casepartytype.Depth = 0;
            this.casepartytype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.casepartytype.DropDownHeight = 174;
            this.casepartytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.casepartytype.DropDownWidth = 121;
            this.casepartytype.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.casepartytype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.casepartytype.FormattingEnabled = true;
            this.casepartytype.IntegralHeight = false;
            this.casepartytype.ItemHeight = 43;
            this.casepartytype.Location = new System.Drawing.Point(20, 21);
            this.casepartytype.MaxDropDownItems = 4;
            this.casepartytype.MouseState = MaterialSkin.MouseState.OUT;
            this.casepartytype.Name = "casepartytype";
            this.casepartytype.Size = new System.Drawing.Size(317, 49);
            this.casepartytype.TabIndex = 22;
            this.casepartytype.SelectedIndexChanged += new System.EventHandler(this.casepartytype_SelectedIndexChanged);
            // 
            // btnAddNewParty
            // 
            this.btnAddNewParty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewParty.Depth = 0;
            this.btnAddNewParty.DrawShadows = true;
            this.btnAddNewParty.HighEmphasis = true;
            this.btnAddNewParty.Icon = null;
            this.btnAddNewParty.Location = new System.Drawing.Point(344, 31);
            this.btnAddNewParty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewParty.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewParty.Name = "btnAddNewParty";
            this.btnAddNewParty.Size = new System.Drawing.Size(136, 36);
            this.btnAddNewParty.TabIndex = 23;
            this.btnAddNewParty.Text = "Add New Party";
            this.btnAddNewParty.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewParty.UseAccentColor = false;
            this.btnAddNewParty.UseVisualStyleBackColor = true;
            this.btnAddNewParty.Click += new System.EventHandler(this.addcaseparty_Click);
            // 
            // frmCodeGenarator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 963);
            this.Controls.Add(this.generateTemplate);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "frmCodeGenarator";
            this.Text = "Template Generator";
            this.Load += new System.EventHandler(this.frmCodeGenarator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filings)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionalservices)).EndInit();
            this.tpServiceContacts.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView filings;
        private System.Windows.Forms.DataGridViewTextBoxColumn filingname;
        private System.Windows.Forms.DataGridViewTextBoxColumn filingsecurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachmentsize;
        private System.Windows.Forms.DataGridViewButtonColumn associatedparties;
        private System.Windows.Forms.DataGridViewButtonColumn filingoptionalservice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView optionalservices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn filler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox documenttype;
        private System.Windows.Forms.ComboBox filingcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpServiceContacts;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label21;
        private MaterialSkin.Controls.MaterialComboBox jurisdiction;
        private MaterialSkin.Controls.MaterialTextBox casesearchbox;
        private MaterialSkin.Controls.MaterialComboBox casecategory;
        private MaterialSkin.Controls.MaterialButton btnSearchCase;
        private MaterialSkin.Controls.MaterialComboBox casetype;
        private MaterialSkin.Controls.MaterialComboBox remedy;
        private MaterialSkin.Controls.MaterialComboBox datamageamount;
        private MaterialSkin.Controls.MaterialTextBox preliminarycopies;
        private MaterialSkin.Controls.MaterialTextBox courtesycopy;
        private MaterialSkin.Controls.MaterialComboBox filertype;
        private MaterialSkin.Controls.MaterialComboBox filingattorney;
        private MaterialSkin.Controls.MaterialTextBox textBox2;
        private MaterialSkin.Controls.MaterialComboBox paymentaccount;
        private MaterialSkin.Controls.MaterialRadioButton rbEFile;
        private MaterialSkin.Controls.MaterialRadioButton rbEService;
        private MaterialSkin.Controls.MaterialRadioButton rbBoth;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton generateTemplate;
        private MaterialSkin.Controls.MaterialListView caseparties;
        private System.Windows.Forms.ColumnHeader partyType3;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader required;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader isFillingParty;
        private System.Windows.Forms.ColumnHeader partyType;
        private MaterialSkin.Controls.MaterialComboBox casepartytype;
        private MaterialSkin.Controls.MaterialButton btnAddNewParty;
    }
}