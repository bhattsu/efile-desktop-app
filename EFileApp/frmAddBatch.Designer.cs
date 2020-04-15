namespace EFileApp
{
    partial class frmAddBatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBatch));
            this.btnSelectTsvLocation = new System.Windows.Forms.Button();
            this.btnSelectTemplates = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTSVFileLocation = new System.Windows.Forms.TextBox();
            this.txtJsonTemplateLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgCases = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Template = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jurisdiction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviewPayload = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectTsvLocation
            // 
            this.btnSelectTsvLocation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectTsvLocation.Location = new System.Drawing.Point(813, 24);
            this.btnSelectTsvLocation.Name = "btnSelectTsvLocation";
            this.btnSelectTsvLocation.Size = new System.Drawing.Size(126, 33);
            this.btnSelectTsvLocation.TabIndex = 1;
            this.btnSelectTsvLocation.Text = "Select File";
            this.btnSelectTsvLocation.UseVisualStyleBackColor = true;
            this.btnSelectTsvLocation.Click += new System.EventHandler(this.btnSelectTsvLocation_Click);
            // 
            // btnSelectTemplates
            // 
            this.btnSelectTemplates.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectTemplates.Location = new System.Drawing.Point(813, 66);
            this.btnSelectTemplates.Name = "btnSelectTemplates";
            this.btnSelectTemplates.Size = new System.Drawing.Size(126, 33);
            this.btnSelectTemplates.TabIndex = 3;
            this.btnSelectTemplates.Text = "Select Folder";
            this.btnSelectTemplates.UseVisualStyleBackColor = true;
            this.btnSelectTemplates.Click += new System.EventHandler(this.btnSelectTemplates_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "TSV File Location";
            // 
            // txtTSVFileLocation
            // 
            this.txtTSVFileLocation.Location = new System.Drawing.Point(218, 24);
            this.txtTSVFileLocation.Name = "txtTSVFileLocation";
            this.txtTSVFileLocation.Size = new System.Drawing.Size(572, 22);
            this.txtTSVFileLocation.TabIndex = 0;
            // 
            // txtJsonTemplateLocation
            // 
            this.txtJsonTemplateLocation.Location = new System.Drawing.Point(218, 66);
            this.txtJsonTemplateLocation.Name = "txtJsonTemplateLocation";
            this.txtJsonTemplateLocation.Size = new System.Drawing.Size(572, 22);
            this.txtJsonTemplateLocation.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "JSON Template Location";
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Location = new System.Drawing.Point(664, 555);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnCreateBatch_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(819, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 487);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(922, 22);
            this.progressBar1.TabIndex = 25;
            this.progressBar1.Visible = false;
            // 
            // dgCases
            // 
            this.dgCases.AllowUserToAddRows = false;
            this.dgCases.AllowUserToResizeRows = false;
            this.dgCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCases.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgCases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Template,
            this.CaseNumber,
            this.Jurisdiction,
            this.Status,
            this.Message,
            this.PreviewPayload});
            this.dgCases.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgCases.Location = new System.Drawing.Point(23, 136);
            this.dgCases.MultiSelect = false;
            this.dgCases.Name = "dgCases";
            this.dgCases.RowHeadersVisible = false;
            this.dgCases.RowTemplate.Height = 24;
            this.dgCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCases.Size = new System.Drawing.Size(922, 308);
            this.dgCases.TabIndex = 26;
            this.dgCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCases_CellContentClick);
            // 
            // Id
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Template
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Template.DefaultCellStyle = dataGridViewCellStyle2;
            this.Template.HeaderText = "Template";
            this.Template.MinimumWidth = 100;
            this.Template.Name = "Template";
            this.Template.ReadOnly = true;
            // 
            // CaseNumber
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.CaseNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.CaseNumber.HeaderText = "Case Number";
            this.CaseNumber.Name = "CaseNumber";
            this.CaseNumber.ReadOnly = true;
            // 
            // Jurisdiction
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Jurisdiction.DefaultCellStyle = dataGridViewCellStyle4;
            this.Jurisdiction.HeaderText = "Jurisdiction";
            this.Jurisdiction.Name = "Jurisdiction";
            this.Jurisdiction.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle5;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Message
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Message.DefaultCellStyle = dataGridViewCellStyle6;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // PreviewPayload
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Blue;
            this.PreviewPayload.DefaultCellStyle = dataGridViewCellStyle7;
            this.PreviewPayload.HeaderText = "Preview";
            this.PreviewPayload.Name = "PreviewPayload";
            // 
            // frmAddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(978, 627);
            this.Controls.Add(this.dgCases);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectTsvLocation);
            this.Controls.Add(this.btnSelectTemplates);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTSVFileLocation);
            this.Controls.Add(this.txtJsonTemplateLocation);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add To Batch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddBatch_FormClosing);
            this.Load += new System.EventHandler(this.frmAddBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectTsvLocation;
        private System.Windows.Forms.Button btnSelectTemplates;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTSVFileLocation;
        private System.Windows.Forms.TextBox txtJsonTemplateLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Template;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jurisdiction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewLinkColumn PreviewPayload;
    }
}