using System.Windows;

namespace EFileApp
{
    partial class firmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firmSettings));
            this.btnExit = new System.Windows.Forms.Button();
            this.codeGenerator = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDefaultTSVFileLocation = new System.Windows.Forms.TextBox();
            this.txtJsonTemplateLocation = new System.Windows.Forms.TextBox();
            this.btnSelectTemplates = new System.Windows.Forms.Button();
            this.btnDefaultOutput = new System.Windows.Forms.Button();
            this.btnSelectTsvLocation = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDefaultOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCodeGenerator = new MaterialSkin.Controls.MaterialButton();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.RichTextBox();
            this.lstTeamplates = new System.Windows.Forms.ListBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.codeGenerator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1090, 605);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 38);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // codeGenerator
            // 
            this.codeGenerator.Controls.Add(this.tabPage2);
            this.codeGenerator.Controls.Add(this.tabPage1);
            this.codeGenerator.Location = new System.Drawing.Point(12, 12);
            this.codeGenerator.Name = "codeGenerator";
            this.codeGenerator.SelectedIndex = 0;
            this.codeGenerator.Size = new System.Drawing.Size(1208, 587);
            this.codeGenerator.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtDefaultTSVFileLocation);
            this.tabPage2.Controls.Add(this.txtJsonTemplateLocation);
            this.tabPage2.Controls.Add(this.btnSelectTemplates);
            this.tabPage2.Controls.Add(this.btnDefaultOutput);
            this.tabPage2.Controls.Add(this.btnSelectTsvLocation);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDefaultOutput);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Default TSV File";
            // 
            // txtDefaultTSVFileLocation
            // 
            this.txtDefaultTSVFileLocation.Location = new System.Drawing.Point(227, 12);
            this.txtDefaultTSVFileLocation.Name = "txtDefaultTSVFileLocation";
            this.txtDefaultTSVFileLocation.Size = new System.Drawing.Size(563, 22);
            this.txtDefaultTSVFileLocation.TabIndex = 7;
            // 
            // txtJsonTemplateLocation
            // 
            this.txtJsonTemplateLocation.Location = new System.Drawing.Point(227, 90);
            this.txtJsonTemplateLocation.Name = "txtJsonTemplateLocation";
            this.txtJsonTemplateLocation.Size = new System.Drawing.Size(563, 22);
            this.txtJsonTemplateLocation.TabIndex = 5;
            // 
            // btnSelectTemplates
            // 
            this.btnSelectTemplates.Location = new System.Drawing.Point(796, 84);
            this.btnSelectTemplates.Name = "btnSelectTemplates";
            this.btnSelectTemplates.Size = new System.Drawing.Size(126, 33);
            this.btnSelectTemplates.TabIndex = 6;
            this.btnSelectTemplates.Text = "Select Folder";
            this.btnSelectTemplates.UseVisualStyleBackColor = true;
            this.btnSelectTemplates.Click += new System.EventHandler(this.btnSelectTemplates_Click);
            // 
            // btnDefaultOutput
            // 
            this.btnDefaultOutput.Location = new System.Drawing.Point(796, 45);
            this.btnDefaultOutput.Name = "btnDefaultOutput";
            this.btnDefaultOutput.Size = new System.Drawing.Size(126, 33);
            this.btnDefaultOutput.TabIndex = 17;
            this.btnDefaultOutput.Text = "Select Folder";
            this.btnDefaultOutput.UseVisualStyleBackColor = true;
            this.btnDefaultOutput.Click += new System.EventHandler(this.btnDefaultOutput_Click);
            // 
            // btnSelectTsvLocation
            // 
            this.btnSelectTsvLocation.Location = new System.Drawing.Point(796, 6);
            this.btnSelectTsvLocation.Name = "btnSelectTsvLocation";
            this.btnSelectTsvLocation.Size = new System.Drawing.Size(126, 33);
            this.btnSelectTsvLocation.TabIndex = 8;
            this.btnSelectTsvLocation.Text = "Select File";
            this.btnSelectTsvLocation.UseVisualStyleBackColor = true;
            this.btnSelectTsvLocation.Click += new System.EventHandler(this.btnSelectTsvLocation_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Default JSON Template Location";
            // 
            // txtDefaultOutput
            // 
            this.txtDefaultOutput.Location = new System.Drawing.Point(227, 48);
            this.txtDefaultOutput.Name = "txtDefaultOutput";
            this.txtDefaultOutput.Size = new System.Drawing.Size(563, 22);
            this.txtDefaultOutput.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Default Output Location";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Template Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnCodeGenerator);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.txtTemplate);
            this.groupBox1.Controls.Add(this.lstTeamplates);
            this.groupBox1.Controls.Add(this.btnSaveTemplate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 548);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btnCodeGenerator
            // 
            this.btnCodeGenerator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCodeGenerator.Depth = 0;
            this.btnCodeGenerator.DrawShadows = true;
            this.btnCodeGenerator.HighEmphasis = true;
            this.btnCodeGenerator.Icon = null;
            this.btnCodeGenerator.Location = new System.Drawing.Point(305, 21);
            this.btnCodeGenerator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCodeGenerator.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCodeGenerator.Name = "btnCodeGenerator";
            this.btnCodeGenerator.Size = new System.Drawing.Size(195, 36);
            this.btnCodeGenerator.TabIndex = 24;
            this.btnCodeGenerator.Text = "Template Generator";
            this.btnCodeGenerator.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCodeGenerator.UseAccentColor = false;
            this.btnCodeGenerator.UseVisualStyleBackColor = true;
            this.btnCodeGenerator.Click += new System.EventHandler(this.btnCodeGenerator_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(198, 21);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(101, 34);
            this.btnImport.TabIndex = 23;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(305, 61);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(883, 480);
            this.txtTemplate.TabIndex = 22;
            this.txtTemplate.Text = "";
            this.txtTemplate.WordWrap = false;
            this.txtTemplate.TextChanged += new System.EventHandler(this.txtTemplate_TextChanged);
            this.txtTemplate.Leave += new System.EventHandler(this.txtTemplate_Leave);
            // 
            // lstTeamplates
            // 
            this.lstTeamplates.FormattingEnabled = true;
            this.lstTeamplates.ItemHeight = 14;
            this.lstTeamplates.Location = new System.Drawing.Point(7, 61);
            this.lstTeamplates.Name = "lstTeamplates";
            this.lstTeamplates.Size = new System.Drawing.Size(292, 480);
            this.lstTeamplates.TabIndex = 21;
            this.lstTeamplates.SelectedIndexChanged += new System.EventHandler(this.lstTeamplates_SelectedIndexChanged);
            this.lstTeamplates.SelectedValueChanged += new System.EventHandler(this.lstTeamplates_SelectedValueChanged);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(1041, 23);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(141, 34);
            this.btnSaveTemplate.TabIndex = 2;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // firmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1219, 660);
            this.Controls.Add(this.codeGenerator);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "firmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.frmSettngs_Load);
            this.codeGenerator.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl codeGenerator;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDefaultTSVFileLocation;
        private System.Windows.Forms.TextBox txtJsonTemplateLocation;
        private System.Windows.Forms.Button btnSelectTemplates;
        private System.Windows.Forms.Button btnDefaultOutput;
        private System.Windows.Forms.Button btnSelectTsvLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDefaultOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnCodeGenerator;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RichTextBox txtTemplate;
        private System.Windows.Forms.ListBox lstTeamplates;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}