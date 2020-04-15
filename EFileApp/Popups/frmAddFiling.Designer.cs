namespace EFileApp.Popups
{
    partial class frmAddFiling
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lvOptionalServices = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbCaseParties = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.btnAddFiling = new MaterialSkin.Controls.MaterialButton();
            this.cbSecurity = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFilingCode = new MaterialSkin.Controls.MaterialComboBox();
            this.lvSelectedServices = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mbAdd = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.mbRemoveService = new MaterialSkin.Controls.MaterialButton();
            this.mbEditService = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLeadDocument = new MaterialSkin.Controls.MaterialButton();
            this.btnAttachments = new MaterialSkin.Controls.MaterialButton();
            this.lbLeadDocument = new MaterialSkin.Controls.MaterialLabel();
            this.lbAttachments = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 18);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Optional Services";
            // 
            // lvOptionalServices
            // 
            this.lvOptionalServices.AutoSizeTable = false;
            this.lvOptionalServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvOptionalServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOptionalServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvOptionalServices.Depth = 0;
            this.lvOptionalServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lvOptionalServices.FullRowSelect = true;
            this.lvOptionalServices.HideSelection = false;
            this.lvOptionalServices.Location = new System.Drawing.Point(16, 56);
            this.lvOptionalServices.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvOptionalServices.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvOptionalServices.MouseState = MaterialSkin.MouseState.OUT;
            this.lvOptionalServices.MultiSelect = false;
            this.lvOptionalServices.Name = "lvOptionalServices";
            this.lvOptionalServices.OwnerDraw = true;
            this.lvOptionalServices.Size = new System.Drawing.Size(437, 349);
            this.lvOptionalServices.TabIndex = 5;
            this.lvOptionalServices.UseCompatibleStateImageBehavior = false;
            this.lvOptionalServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(477, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 18);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Select Case Parties";
            // 
            // cbCaseParties
            // 
            this.cbCaseParties.AutoScroll = true;
            this.cbCaseParties.BackColor = System.Drawing.SystemColors.Control;
            this.cbCaseParties.Depth = 0;
            this.cbCaseParties.Location = new System.Drawing.Point(480, 31);
            this.cbCaseParties.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbCaseParties.Name = "cbCaseParties";
            this.cbCaseParties.Size = new System.Drawing.Size(482, 163);
            this.cbCaseParties.Striped = false;
            this.cbCaseParties.StripeDarkColor = System.Drawing.Color.Empty;
            this.cbCaseParties.TabIndex = 17;
            // 
            // btnAddFiling
            // 
            this.btnAddFiling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFiling.Depth = 0;
            this.btnAddFiling.DrawShadows = true;
            this.btnAddFiling.HighEmphasis = true;
            this.btnAddFiling.Icon = null;
            this.btnAddFiling.Location = new System.Drawing.Point(798, 695);
            this.btnAddFiling.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddFiling.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddFiling.Name = "btnAddFiling";
            this.btnAddFiling.Size = new System.Drawing.Size(141, 36);
            this.btnAddFiling.TabIndex = 16;
            this.btnAddFiling.Text = "Add New Filing";
            this.btnAddFiling.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddFiling.UseAccentColor = true;
            this.btnAddFiling.UseVisualStyleBackColor = true;
            this.btnAddFiling.Click += new System.EventHandler(this.btnAddFiling_Click);
            // 
            // cbSecurity
            // 
            this.cbSecurity.AutoResize = false;
            this.cbSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSecurity.Depth = 0;
            this.cbSecurity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSecurity.DropDownHeight = 118;
            this.cbSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecurity.DropDownWidth = 121;
            this.cbSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSecurity.FormattingEnabled = true;
            this.cbSecurity.Hint = "Security";
            this.cbSecurity.IntegralHeight = false;
            this.cbSecurity.ItemHeight = 29;
            this.cbSecurity.Location = new System.Drawing.Point(28, 72);
            this.cbSecurity.MaxDropDownItems = 4;
            this.cbSecurity.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSecurity.Name = "cbSecurity";
            this.cbSecurity.Size = new System.Drawing.Size(437, 35);
            this.cbSecurity.TabIndex = 15;
            this.cbSecurity.UseTallSize = false;
            // 
            // cbFilingCode
            // 
            this.cbFilingCode.AutoResize = false;
            this.cbFilingCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFilingCode.Depth = 0;
            this.cbFilingCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilingCode.DropDownHeight = 118;
            this.cbFilingCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilingCode.DropDownWidth = 121;
            this.cbFilingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFilingCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilingCode.FormattingEnabled = true;
            this.cbFilingCode.Hint = "Filing Code";
            this.cbFilingCode.IntegralHeight = false;
            this.cbFilingCode.ItemHeight = 29;
            this.cbFilingCode.Location = new System.Drawing.Point(28, 31);
            this.cbFilingCode.MaxDropDownItems = 4;
            this.cbFilingCode.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFilingCode.Name = "cbFilingCode";
            this.cbFilingCode.Size = new System.Drawing.Size(437, 35);
            this.cbFilingCode.TabIndex = 14;
            this.cbFilingCode.UseTallSize = false;
            this.cbFilingCode.SelectedIndexChanged += new System.EventHandler(this.cbFilingCode_SelectedIndexChanged);
            // 
            // lvSelectedServices
            // 
            this.lvSelectedServices.AutoSizeTable = false;
            this.lvSelectedServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvSelectedServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSelectedServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvSelectedServices.Depth = 0;
            this.lvSelectedServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lvSelectedServices.FullRowSelect = true;
            this.lvSelectedServices.HideSelection = false;
            this.lvSelectedServices.Location = new System.Drawing.Point(468, 56);
            this.lvSelectedServices.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvSelectedServices.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvSelectedServices.MouseState = MaterialSkin.MouseState.OUT;
            this.lvSelectedServices.MultiSelect = false;
            this.lvSelectedServices.Name = "lvSelectedServices";
            this.lvSelectedServices.OwnerDraw = true;
            this.lvSelectedServices.Size = new System.Drawing.Size(459, 349);
            this.lvSelectedServices.TabIndex = 19;
            this.lvSelectedServices.UseCompatibleStateImageBehavior = false;
            this.lvSelectedServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 100;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(465, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 18);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Selected Services";
            // 
            // mbAdd
            // 
            this.mbAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbAdd.Depth = 0;
            this.mbAdd.DrawShadows = true;
            this.mbAdd.HighEmphasis = true;
            this.mbAdd.Icon = null;
            this.mbAdd.Location = new System.Drawing.Point(16, 414);
            this.mbAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbAdd.Name = "mbAdd";
            this.mbAdd.Size = new System.Drawing.Size(198, 36);
            this.mbAdd.TabIndex = 21;
            this.mbAdd.Text = "Add Optional Service";
            this.mbAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbAdd.UseAccentColor = false;
            this.mbAdd.UseVisualStyleBackColor = true;
            this.mbAdd.Click += new System.EventHandler(this.mbAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.mbRemoveService);
            this.groupBox1.Controls.Add(this.mbEditService);
            this.groupBox1.Controls.Add(this.lvOptionalServices);
            this.groupBox1.Controls.Add(this.mbAdd);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.lvSelectedServices);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 466);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optional Services";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.Hint = "Search";
            this.txtSearch.Location = new System.Drawing.Point(222, 19);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 36);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.Text = "";
            this.txtSearch.UseTallSize = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // mbRemoveService
            // 
            this.mbRemoveService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbRemoveService.Depth = 0;
            this.mbRemoveService.DrawShadows = true;
            this.mbRemoveService.HighEmphasis = true;
            this.mbRemoveService.Icon = null;
            this.mbRemoveService.Location = new System.Drawing.Point(598, 414);
            this.mbRemoveService.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbRemoveService.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbRemoveService.Name = "mbRemoveService";
            this.mbRemoveService.Size = new System.Drawing.Size(165, 36);
            this.mbRemoveService.TabIndex = 23;
            this.mbRemoveService.Text = "Remove Selected";
            this.mbRemoveService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbRemoveService.UseAccentColor = false;
            this.mbRemoveService.UseVisualStyleBackColor = true;
            this.mbRemoveService.Click += new System.EventHandler(this.mbRemoveService_Click);
            // 
            // mbEditService
            // 
            this.mbEditService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbEditService.Depth = 0;
            this.mbEditService.DrawShadows = true;
            this.mbEditService.HighEmphasis = true;
            this.mbEditService.Icon = null;
            this.mbEditService.Location = new System.Drawing.Point(792, 414);
            this.mbEditService.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbEditService.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbEditService.Name = "mbEditService";
            this.mbEditService.Size = new System.Drawing.Size(135, 36);
            this.mbEditService.TabIndex = 22;
            this.mbEditService.Text = "Edit Selected";
            this.mbEditService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbEditService.UseAccentColor = false;
            this.mbEditService.UseVisualStyleBackColor = true;
            this.mbEditService.Click += new System.EventHandler(this.mbEditService_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLeadDocument
            // 
            this.btnLeadDocument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeadDocument.Depth = 0;
            this.btnLeadDocument.DrawShadows = true;
            this.btnLeadDocument.HighEmphasis = true;
            this.btnLeadDocument.Icon = null;
            this.btnLeadDocument.Location = new System.Drawing.Point(28, 116);
            this.btnLeadDocument.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLeadDocument.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLeadDocument.Name = "btnLeadDocument";
            this.btnLeadDocument.Size = new System.Drawing.Size(209, 36);
            this.btnLeadDocument.TabIndex = 25;
            this.btnLeadDocument.Text = "Select Lead Document";
            this.btnLeadDocument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLeadDocument.UseAccentColor = false;
            this.btnLeadDocument.UseVisualStyleBackColor = true;
            this.btnLeadDocument.Click += new System.EventHandler(this.btnLeadDocument_Click);
            // 
            // btnAttachments
            // 
            this.btnAttachments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttachments.Depth = 0;
            this.btnAttachments.DrawShadows = true;
            this.btnAttachments.HighEmphasis = true;
            this.btnAttachments.Icon = null;
            this.btnAttachments.Location = new System.Drawing.Point(273, 116);
            this.btnAttachments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttachments.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttachments.Name = "btnAttachments";
            this.btnAttachments.Size = new System.Drawing.Size(192, 36);
            this.btnAttachments.TabIndex = 26;
            this.btnAttachments.Text = "Select Attachments";
            this.btnAttachments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttachments.UseAccentColor = false;
            this.btnAttachments.UseVisualStyleBackColor = true;
            this.btnAttachments.Click += new System.EventHandler(this.btnAttachments_Click);
            // 
            // lbLeadDocument
            // 
            this.lbLeadDocument.AutoSize = true;
            this.lbLeadDocument.Depth = 0;
            this.lbLeadDocument.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbLeadDocument.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbLeadDocument.Location = new System.Drawing.Point(25, 155);
            this.lbLeadDocument.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbLeadDocument.Name = "lbLeadDocument";
            this.lbLeadDocument.Size = new System.Drawing.Size(1, 0);
            this.lbLeadDocument.TabIndex = 27;
            // 
            // lbAttachments
            // 
            this.lbAttachments.AutoSize = true;
            this.lbAttachments.Depth = 0;
            this.lbAttachments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbAttachments.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbAttachments.Location = new System.Drawing.Point(270, 155);
            this.lbAttachments.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(1, 0);
            this.lbAttachments.TabIndex = 28;
            // 
            // frmAddFiling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 746);
            this.Controls.Add(this.lbAttachments);
            this.Controls.Add(this.lbLeadDocument);
            this.Controls.Add(this.btnAttachments);
            this.Controls.Add(this.btnLeadDocument);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbCaseParties);
            this.Controls.Add(this.btnAddFiling);
            this.Controls.Add(this.cbSecurity);
            this.Controls.Add(this.cbFilingCode);
            this.Name = "frmAddFiling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Filing";
            this.Load += new System.EventHandler(this.frmAddFiling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView lvOptionalServices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckedListBox cbCaseParties;
        private MaterialSkin.Controls.MaterialButton btnAddFiling;
        private MaterialSkin.Controls.MaterialComboBox cbSecurity;
        private MaterialSkin.Controls.MaterialComboBox cbFilingCode;
        private MaterialSkin.Controls.MaterialListView lvSelectedServices;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton mbAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton mbRemoveService;
        private MaterialSkin.Controls.MaterialButton mbEditService;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialButton btnLeadDocument;
        private MaterialSkin.Controls.MaterialButton btnAttachments;
        private MaterialSkin.Controls.MaterialLabel lbLeadDocument;
        private MaterialSkin.Controls.MaterialLabel lbAttachments;
    }
}