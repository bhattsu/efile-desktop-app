namespace EFileApp
{
    partial class frmEditCaseParty
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
            this.cbLeadAttorneys = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.cbAssociatedAttorney = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMiddleName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLeadAttorneys
            // 
            this.cbLeadAttorneys.AutoResize = false;
            this.cbLeadAttorneys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLeadAttorneys.Depth = 0;
            this.cbLeadAttorneys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLeadAttorneys.DropDownHeight = 118;
            this.cbLeadAttorneys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeadAttorneys.DropDownWidth = 121;
            this.cbLeadAttorneys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLeadAttorneys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLeadAttorneys.FormattingEnabled = true;
            this.cbLeadAttorneys.Hint = "Lead Attorney";
            this.cbLeadAttorneys.IntegralHeight = false;
            this.cbLeadAttorneys.ItemHeight = 29;
            this.cbLeadAttorneys.Location = new System.Drawing.Point(8, 19);
            this.cbLeadAttorneys.MaxDropDownItems = 4;
            this.cbLeadAttorneys.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLeadAttorneys.Name = "cbLeadAttorneys";
            this.cbLeadAttorneys.Size = new System.Drawing.Size(546, 35);
            this.cbLeadAttorneys.TabIndex = 0;
            this.cbLeadAttorneys.UseTallSize = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFirstName.Hint = "First Name";
            this.txtFirstName.Location = new System.Drawing.Point(6, 19);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(546, 36);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "";
            this.txtFirstName.UseAccent = false;
            this.txtFirstName.UseTallSize = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = true;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(798, 344);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(986, 344);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = true;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAssociatedAttorney
            // 
            this.cbAssociatedAttorney.AutoScroll = true;
            this.cbAssociatedAttorney.BackColor = System.Drawing.SystemColors.Control;
            this.cbAssociatedAttorney.Depth = 0;
            this.cbAssociatedAttorney.Location = new System.Drawing.Point(9, 122);
            this.cbAssociatedAttorney.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbAssociatedAttorney.Name = "cbAssociatedAttorney";
            this.cbAssociatedAttorney.Size = new System.Drawing.Size(545, 187);
            this.cbAssociatedAttorney.Striped = false;
            this.cbAssociatedAttorney.StripeDarkColor = System.Drawing.Color.Empty;
            this.cbAssociatedAttorney.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(149, 18);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Associated Attorneys";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.Depth = 0;
            this.txtMiddleName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMiddleName.Hint = "Middle Name";
            this.txtMiddleName.Location = new System.Drawing.Point(6, 75);
            this.txtMiddleName.MaxLength = 50;
            this.txtMiddleName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMiddleName.Multiline = false;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(546, 36);
            this.txtMiddleName.TabIndex = 13;
            this.txtMiddleName.Text = "";
            this.txtMiddleName.UseAccent = false;
            this.txtMiddleName.UseTallSize = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLastName.Hint = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(6, 131);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(546, 36);
            this.txtLastName.TabIndex = 14;
            this.txtLastName.Text = "";
            this.txtLastName.UseAccent = false;
            this.txtLastName.UseTallSize = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 314);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLeadAttorneys);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.cbAssociatedAttorney);
            this.groupBox2.Location = new System.Drawing.Point(591, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 314);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attorney Information";
            // 
            // frmEditCaseParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditCaseParty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Case Party";
            this.Load += new System.EventHandler(this.frmEditCaseParty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbLeadAttorneys;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialCheckedListBox cbAssociatedAttorney;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtMiddleName;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}