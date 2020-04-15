namespace EFileApp
{
    partial class frmBatches
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBatches));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgBatch = new System.Windows.Forms.DataGridView();
            this.btnCreateBatch = new System.Windows.Forms.Button();
            this.lblpage = new System.Windows.Forms.Label();
            this.btnShowPrevious = new System.Windows.Forms.Button();
            this.btnShowNext = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEnviornment = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mnuBatches = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddToBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBatchDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDownloadBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imgAddTo = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgDeleteBatch = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.BatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBatch)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mnuBatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBatch
            // 
            this.dgBatch.AllowUserToAddRows = false;
            this.dgBatch.AllowUserToResizeRows = false;
            this.dgBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgBatch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgAddTo,
            this.imgDeleteBatch,
            this.imgDetails,
            this.imgDownload,
            this.BatchId,
            this.Status,
            this.Size,
            this.BatchSize,
            this.CreatedDate,
            this.Filler});
            this.dgBatch.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgBatch.Location = new System.Drawing.Point(33, 137);
            this.dgBatch.MultiSelect = false;
            this.dgBatch.Name = "dgBatch";
            this.dgBatch.RowHeadersVisible = false;
            this.dgBatch.RowHeadersWidth = 50;
            this.dgBatch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgBatch.RowTemplate.Height = 30;
            this.dgBatch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBatch.Size = new System.Drawing.Size(1194, 424);
            this.dgBatch.TabIndex = 5;
            this.dgBatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBatch_CellContentClick);
            this.dgBatch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBatch_CellMouseClick);
            this.dgBatch.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBatch_CellMouseMove);
            this.dgBatch.DoubleClick += new System.EventHandler(this.dgBatch_DoubleClick);
            this.dgBatch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgBatch_MouseClick);
            this.dgBatch.MouseHover += new System.EventHandler(this.dgBatch_MouseHover);
            // 
            // btnCreateBatch
            // 
            this.btnCreateBatch.Location = new System.Drawing.Point(33, 82);
            this.btnCreateBatch.Name = "btnCreateBatch";
            this.btnCreateBatch.Size = new System.Drawing.Size(152, 29);
            this.btnCreateBatch.TabIndex = 1;
            this.btnCreateBatch.Text = "Create Batch";
            this.btnCreateBatch.UseVisualStyleBackColor = true;
            this.btnCreateBatch.Click += new System.EventHandler(this.btnCreateBatch_Click);
            // 
            // lblpage
            // 
            this.lblpage.AutoSize = true;
            this.lblpage.Location = new System.Drawing.Point(34, 583);
            this.lblpage.Name = "lblpage";
            this.lblpage.Size = new System.Drawing.Size(110, 14);
            this.lblpage.TabIndex = 4;
            this.lblpage.Text = "Showing 1 to 20";
            // 
            // btnShowPrevious
            // 
            this.btnShowPrevious.Enabled = false;
            this.btnShowPrevious.Location = new System.Drawing.Point(33, 617);
            this.btnShowPrevious.Name = "btnShowPrevious";
            this.btnShowPrevious.Size = new System.Drawing.Size(147, 31);
            this.btnShowPrevious.TabIndex = 6;
            this.btnShowPrevious.Text = "Show Previous";
            this.btnShowPrevious.UseVisualStyleBackColor = true;
            this.btnShowPrevious.Click += new System.EventHandler(this.btnShowPrevious_Click);
            // 
            // btnShowNext
            // 
            this.btnShowNext.Location = new System.Drawing.Point(206, 618);
            this.btnShowNext.Name = "btnShowNext";
            this.btnShowNext.Size = new System.Drawing.Size(137, 30);
            this.btnShowNext.TabIndex = 7;
            this.btnShowNext.Text = "Show Next";
            this.btnShowNext.UseVisualStyleBackColor = true;
            this.btnShowNext.Click += new System.EventHandler(this.btnShowNext_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.btnSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1239, 50);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExit
            // 
            this.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbExit.AutoSize = false;
            this.tsbExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsbExit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExit.Image = global::EFileApp.Properties.Resources.exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Margin = new System.Windows.Forms.Padding(0, 2, 5, 5);
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(100, 45);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.AutoSize = false;
            this.btnSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::EFileApp.Properties.Resources.setting;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 2, 5, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 45);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lblStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblState,
            this.toolStripStatusLabel5,
            this.lblEnviornment,
            this.toolStripStatusLabel1,
            this.lblUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 728);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1239, 40);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 35);
            this.toolStripStatusLabel.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Info;
            this.lblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 35);
            this.lblStatus.Text = "Not Connected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 35);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(57, 35);
            this.toolStripStatusLabel3.Text = "State :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = false;
            this.lblState.BackColor = System.Drawing.SystemColors.Info;
            this.lblState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblState.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(120, 35);
            this.lblState.Text = "N/A";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(103, 35);
            this.toolStripStatusLabel5.Text = "Enviornment:";
            // 
            // lblEnviornment
            // 
            this.lblEnviornment.AutoSize = false;
            this.lblEnviornment.BackColor = System.Drawing.SystemColors.Info;
            this.lblEnviornment.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblEnviornment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviornment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEnviornment.Name = "lblEnviornment";
            this.lblEnviornment.Size = new System.Drawing.Size(120, 35);
            this.lblEnviornment.Text = "N/A";
            this.lblEnviornment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 35);
            this.toolStripStatusLabel1.Text = "User :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = false;
            this.lblUser.BackColor = System.Drawing.SystemColors.Info;
            this.lblUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(300, 35);
            this.lblUser.Text = "N/A";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(193, 82);
            this.txtSearch.MaximumSize = new System.Drawing.Size(300, 35);
            this.txtSearch.MaxLength = 300;
            this.txtSearch.MinimumSize = new System.Drawing.Size(300, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // mnuBatches
            // 
            this.mnuBatches.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBatches.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddToBatch,
            this.mnuDeleteBatch,
            this.mnuBatchDetails,
            this.mnuDownloadBatch});
            this.mnuBatches.Name = "mnuBatches";
            this.mnuBatches.Size = new System.Drawing.Size(171, 92);
            // 
            // mnuAddToBatch
            // 
            this.mnuAddToBatch.Name = "mnuAddToBatch";
            this.mnuAddToBatch.Size = new System.Drawing.Size(170, 22);
            this.mnuAddToBatch.Text = "Add To Batch";
            this.mnuAddToBatch.Click += new System.EventHandler(this.mnuAddToBatch_Click);
            // 
            // mnuDeleteBatch
            // 
            this.mnuDeleteBatch.Name = "mnuDeleteBatch";
            this.mnuDeleteBatch.Size = new System.Drawing.Size(170, 22);
            this.mnuDeleteBatch.Text = "Delete Batch";
            this.mnuDeleteBatch.Click += new System.EventHandler(this.mnuDeleteBatch_Click);
            // 
            // mnuBatchDetails
            // 
            this.mnuBatchDetails.Name = "mnuBatchDetails";
            this.mnuBatchDetails.Size = new System.Drawing.Size(170, 22);
            this.mnuBatchDetails.Text = "View Batch Details";
            this.mnuBatchDetails.Click += new System.EventHandler(this.mnuBatchDetails_Click);
            // 
            // mnuDownloadBatch
            // 
            this.mnuDownloadBatch.Name = "mnuDownloadBatch";
            this.mnuDownloadBatch.Size = new System.Drawing.Size(170, 22);
            this.mnuDownloadBatch.Text = "Download Batch";
            this.mnuDownloadBatch.Click += new System.EventHandler(this.mnuDownloadBatch_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.NullValue = null;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewImageColumn1.HeaderText = "AddTo";
            this.dataGridViewImageColumn1.Image = global::EFileApp.Properties.Resources.Add;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Add To Batch";
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.NullValue = null;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::EFileApp.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Delete Batch";
            this.dataGridViewImageColumn2.Width = 80;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.NullValue = null;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewImageColumn3.HeaderText = "Details";
            this.dataGridViewImageColumn3.Image = global::EFileApp.Properties.Resources.list;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ToolTipText = "Batch Details";
            this.dataGridViewImageColumn3.Width = 80;
            // 
            // dataGridViewImageColumn4
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.NullValue = null;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn4.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewImageColumn4.HeaderText = "Download";
            this.dataGridViewImageColumn4.Image = global::EFileApp.Properties.Resources.download;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ToolTipText = "Download Batch";
            this.dataGridViewImageColumn4.Width = 90;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(499, 82);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 29);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(627, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 29);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imgAddTo
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.imgAddTo.DefaultCellStyle = dataGridViewCellStyle15;
            this.imgAddTo.HeaderText = "";
            this.imgAddTo.Image = ((System.Drawing.Image)(resources.GetObject("imgAddTo.Image")));
            this.imgAddTo.MinimumWidth = 50;
            this.imgAddTo.Name = "imgAddTo";
            this.imgAddTo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imgAddTo.ToolTipText = "Add To Batch";
            this.imgAddTo.Width = 50;
            // 
            // imgDeleteBatch
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.imgDeleteBatch.DefaultCellStyle = dataGridViewCellStyle16;
            this.imgDeleteBatch.HeaderText = "";
            this.imgDeleteBatch.Image = ((System.Drawing.Image)(resources.GetObject("imgDeleteBatch.Image")));
            this.imgDeleteBatch.MinimumWidth = 50;
            this.imgDeleteBatch.Name = "imgDeleteBatch";
            this.imgDeleteBatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imgDeleteBatch.ToolTipText = "Delete Batch";
            this.imgDeleteBatch.Width = 50;
            // 
            // imgDetails
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.imgDetails.DefaultCellStyle = dataGridViewCellStyle17;
            this.imgDetails.HeaderText = "";
            this.imgDetails.Image = global::EFileApp.Properties.Resources.list2;
            this.imgDetails.MinimumWidth = 50;
            this.imgDetails.Name = "imgDetails";
            this.imgDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imgDetails.ToolTipText = "Batch Details";
            this.imgDetails.Width = 50;
            // 
            // imgDownload
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.imgDownload.DefaultCellStyle = dataGridViewCellStyle18;
            this.imgDownload.HeaderText = "";
            this.imgDownload.Image = global::EFileApp.Properties.Resources.download2;
            this.imgDownload.MinimumWidth = 50;
            this.imgDownload.Name = "imgDownload";
            this.imgDownload.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imgDownload.ToolTipText = "Download Batch";
            this.imgDownload.Width = 50;
            // 
            // BatchId
            // 
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.BatchId.DefaultCellStyle = dataGridViewCellStyle19;
            this.BatchId.HeaderText = "Batch Id";
            this.BatchId.MinimumWidth = 350;
            this.BatchId.Name = "BatchId";
            this.BatchId.ReadOnly = true;
            this.BatchId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BatchId.Width = 350;
            // 
            // Status
            // 
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle20;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 120;
            this.Status.Name = "Status";
            this.Status.Width = 120;
            // 
            // Size
            // 
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.Size.DefaultCellStyle = dataGridViewCellStyle21;
            this.Size.HeaderText = "Current Size";
            this.Size.MinimumWidth = 110;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 110;
            // 
            // BatchSize
            // 
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.BatchSize.DefaultCellStyle = dataGridViewCellStyle22;
            this.BatchSize.HeaderText = "Batch Size";
            this.BatchSize.MinimumWidth = 110;
            this.BatchSize.Name = "BatchSize";
            this.BatchSize.ReadOnly = true;
            this.BatchSize.Width = 110;
            // 
            // CreatedDate
            // 
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.CreatedDate.DefaultCellStyle = dataGridViewCellStyle23;
            this.CreatedDate.HeaderText = "Created Date ";
            this.CreatedDate.MinimumWidth = 200;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 200;
            // 
            // Filler
            // 
            this.Filler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.Filler.DefaultCellStyle = dataGridViewCellStyle24;
            this.Filler.HeaderText = "";
            this.Filler.MinimumWidth = 2;
            this.Filler.Name = "Filler";
            // 
            // frmBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 768);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnShowNext);
            this.Controls.Add(this.btnShowPrevious);
            this.Controls.Add(this.lblpage);
            this.Controls.Add(this.btnCreateBatch);
            this.Controls.Add(this.dgBatch);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBatches";
            this.Text = "eFiling System For Courts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBatches_FormClosing);
            this.Load += new System.EventHandler(this.frmBatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBatch)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mnuBatches.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBatch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Button btnCreateBatch;
        private System.Windows.Forms.Label lblpage;
        private System.Windows.Forms.Button btnShowPrevious;
        private System.Windows.Forms.Button btnShowNext;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblEnviornment;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip mnuBatches;
        private System.Windows.Forms.ToolStripMenuItem mnuAddToBatch;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteBatch;
        private System.Windows.Forms.ToolStripMenuItem mnuBatchDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuDownloadBatch;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn imgAddTo;
        private System.Windows.Forms.DataGridViewImageColumn imgDeleteBatch;
        private System.Windows.Forms.DataGridViewImageColumn imgDetails;
        private System.Windows.Forms.DataGridViewImageColumn imgDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filler;
    }
}