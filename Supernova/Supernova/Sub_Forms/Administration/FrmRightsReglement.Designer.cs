namespace Supernova.Sub_Forms.Administration
{
    partial class FrmRightsReglement
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
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.gpLoad = new System.Windows.Forms.GroupBox();
            this.btnLoadGroups = new System.Windows.Forms.Button();
            this.cbUserGroups = new System.Windows.Forms.ComboBox();
            this.gpContent = new System.Windows.Forms.GroupBox();
            this.rightsGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlPanel.SuspendLayout();
            this.gpLoad.SuspendLayout();
            this.gpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.Controls.Add(this.gpLoad);
            this.pnlPanel.Controls.Add(this.gpContent);
            this.pnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(945, 381);
            this.pnlPanel.TabIndex = 0;
            // 
            // gpLoad
            // 
            this.gpLoad.Controls.Add(this.btnLoadGroups);
            this.gpLoad.Controls.Add(this.cbUserGroups);
            this.gpLoad.Location = new System.Drawing.Point(12, 12);
            this.gpLoad.Name = "gpLoad";
            this.gpLoad.Size = new System.Drawing.Size(921, 71);
            this.gpLoad.TabIndex = 0;
            this.gpLoad.TabStop = false;
            // 
            // btnLoadGroups
            // 
            this.btnLoadGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGroups.Location = new System.Drawing.Point(465, 19);
            this.btnLoadGroups.Name = "btnLoadGroups";
            this.btnLoadGroups.Size = new System.Drawing.Size(143, 38);
            this.btnLoadGroups.TabIndex = 1;
            this.btnLoadGroups.Text = "Rechte laden";
            this.btnLoadGroups.UseVisualStyleBackColor = true;
            this.btnLoadGroups.Click += new System.EventHandler(this.btnLoadGroups_Click);
            // 
            // cbUserGroups
            // 
            this.cbUserGroups.FormattingEnabled = true;
            this.cbUserGroups.Location = new System.Drawing.Point(286, 29);
            this.cbUserGroups.Name = "cbUserGroups";
            this.cbUserGroups.Size = new System.Drawing.Size(151, 21);
            this.cbUserGroups.TabIndex = 0;
            // 
            // gpContent
            // 
            this.gpContent.Controls.Add(this.btnSave);
            this.gpContent.Controls.Add(this.rightsGrid);
            this.gpContent.Location = new System.Drawing.Point(12, 89);
            this.gpContent.Name = "gpContent";
            this.gpContent.Size = new System.Drawing.Size(921, 280);
            this.gpContent.TabIndex = 1;
            this.gpContent.TabStop = false;
            // 
            // rightsGrid
            // 
            this.rightsGrid.AllowUserToAddRows = false;
            this.rightsGrid.AllowUserToDeleteRows = false;
            this.rightsGrid.AllowUserToOrderColumns = true;
            this.rightsGrid.AllowUserToResizeColumns = false;
            this.rightsGrid.AllowUserToResizeRows = false;
            this.rightsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rightsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightsGrid.Location = new System.Drawing.Point(189, 20);
            this.rightsGrid.Name = "rightsGrid";
            this.rightsGrid.Size = new System.Drawing.Size(522, 242);
            this.rightsGrid.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(819, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRightsReglement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 381);
            this.Controls.Add(this.pnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRightsReglement";
            this.Text = "FrmCreateUser";
            this.pnlPanel.ResumeLayout(false);
            this.gpLoad.ResumeLayout(false);
            this.gpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.GroupBox gpLoad;
        private System.Windows.Forms.Button btnLoadGroups;
        private System.Windows.Forms.ComboBox cbUserGroups;
        private System.Windows.Forms.GroupBox gpContent;
        private System.Windows.Forms.DataGridView rightsGrid;
        private System.Windows.Forms.Button btnSave;
    }
}