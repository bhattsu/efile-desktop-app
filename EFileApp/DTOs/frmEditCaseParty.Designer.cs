namespace EFileApp.DTOs
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
            this.txtFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.cbAssociatedAttorney = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cbLeadAttorneys
            // 
            this.cbLeadAttorneys.AutoResize = false;
            this.cbLeadAttorneys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLeadAttorneys.Depth = 0;
            this.cbLeadAttorneys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLeadAttorneys.DropDownHeight = 174;
            this.cbLeadAttorneys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeadAttorneys.DropDownWidth = 121;
            this.cbLeadAttorneys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLeadAttorneys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLeadAttorneys.FormattingEnabled = true;
            this.cbLeadAttorneys.Hint = "Lead Attorney";
            this.cbLeadAttorneys.IntegralHeight = false;
            this.cbLeadAttorneys.ItemHeight = 43;
            this.cbLeadAttorneys.Location = new System.Drawing.Point(12, 83);
            this.cbLeadAttorneys.MaxDropDownItems = 4;
            this.cbLeadAttorneys.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLeadAttorneys.Name = "cbLeadAttorneys";
            this.cbLeadAttorneys.Size = new System.Drawing.Size(546, 49);
            this.cbLeadAttorneys.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFullName.Hint = "Full name";
            this.txtFullName.Location = new System.Drawing.Point(12, 352);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(546, 50);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "";
            this.txtFullName.UseAccent = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAddress.Hint = "Address";
            this.txtAddress.Location = new System.Drawing.Point(12, 408);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(546, 50);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "";
            this.txtAddress.UseAccent = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = true;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(13, 467);
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
            this.btnExit.Location = new System.Drawing.Point(390, 467);
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
            this.cbAssociatedAttorney.Location = new System.Drawing.Point(13, 157);
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
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 135);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(197, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Select Associated Attorneys";
            // 
            // frmEditCaseParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 519);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbAssociatedAttorney);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.cbLeadAttorneys);
            this.Name = "frmEditCaseParty";
            this.Text = "Edit Case Party";
            this.Load += new System.EventHandler(this.frmEditCaseParty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbLeadAttorneys;
        private MaterialSkin.Controls.MaterialTextBox txtFullName;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialCheckedListBox cbAssociatedAttorney;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}