namespace EFileApp
{
    partial class frmPayload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayload));
            this.txtPayload = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.saveastemplate = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.savepanel = new System.Windows.Forms.Panel();
            this.savepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPayload
            // 
            this.txtPayload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPayload.Location = new System.Drawing.Point(0, -1);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ReadOnly = true;
            this.txtPayload.Size = new System.Drawing.Size(689, 635);
            this.txtPayload.TabIndex = 0;
            this.txtPayload.Text = "";
            this.txtPayload.WordWrap = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(566, 640);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // saveastemplate
            // 
            this.saveastemplate.Location = new System.Drawing.Point(272, 3);
            this.saveastemplate.Name = "saveastemplate";
            this.saveastemplate.Size = new System.Drawing.Size(153, 29);
            this.saveastemplate.TabIndex = 2;
            this.saveastemplate.Text = "Save As Template";
            this.saveastemplate.UseVisualStyleBackColor = true;
            this.saveastemplate.Click += new System.EventHandler(this.saveastemplate_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(13, 7);
            this.filename.MaxLength = 50;
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(253, 22);
            this.filename.TabIndex = 3;
            // 
            // savepanel
            // 
            this.savepanel.Controls.Add(this.filename);
            this.savepanel.Controls.Add(this.saveastemplate);
            this.savepanel.Location = new System.Drawing.Point(30, 640);
            this.savepanel.Name = "savepanel";
            this.savepanel.Size = new System.Drawing.Size(428, 35);
            this.savepanel.TabIndex = 4;
            // 
            // frmPayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(687, 682);
            this.Controls.Add(this.savepanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPayload);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payload";
            this.Load += new System.EventHandler(this.frmPayload_Load);
            this.savepanel.ResumeLayout(false);
            this.savepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPayload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button saveastemplate;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Panel savepanel;
    }
}