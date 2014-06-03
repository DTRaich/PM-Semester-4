namespace Supernova.Sub_Forms.Overview
{
    partial class FrmProjectDetails
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
            this.detailsGrid = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExcelExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsGrid
            // 
            this.detailsGrid.AllowUserToAddRows = false;
            this.detailsGrid.AllowUserToDeleteRows = false;
            this.detailsGrid.AllowUserToResizeColumns = false;
            this.detailsGrid.AllowUserToResizeRows = false;
            this.detailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGrid.Location = new System.Drawing.Point(67, 151);
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.ReadOnly = true;
            this.detailsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailsGrid.Size = new System.Drawing.Size(506, 150);
            this.detailsGrid.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(64, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Projektname";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(64, 113);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(121, 17);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Priorisierungswert";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(219, 75);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(219, 112);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(138, 20);
            this.txtPoints.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(273, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(104, 20);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Projektdetails";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(476, 110);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(97, 23);
            this.btnExcelExport.TabIndex = 6;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // FrmProjectDetails
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 332);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.detailsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProjectDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projekt Details";
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView detailsGrid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnExcelExport;
    }
}