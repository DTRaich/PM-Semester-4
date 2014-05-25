namespace Supernova.Sub_Forms.Overview
{
    partial class FrmProjectOverview
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
            this.btnUseFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.mainpnl = new System.Windows.Forms.Panel();
            this.gbFilterSort = new System.Windows.Forms.GroupBox();
            this.gbAnalysis = new System.Windows.Forms.GroupBox();
            this.cmsGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.mainpnl.SuspendLayout();
            this.cmsGridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUseFilter
            // 
            this.btnUseFilter.Location = new System.Drawing.Point(851, 12);
            this.btnUseFilter.Name = "btnUseFilter";
            this.btnUseFilter.Size = new System.Drawing.Size(75, 23);
            this.btnUseFilter.TabIndex = 0;
            this.btnUseFilter.Text = "Filtern";
            this.btnUseFilter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainpnl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 377);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AllowUserToResizeColumns = false;
            this.mainGrid.AllowUserToResizeRows = false;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.ContextMenuStrip = this.cmsGridMenu;
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(3, 153);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGrid.Size = new System.Drawing.Size(944, 221);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainGrid_MouseClick);
            // 
            // mainpnl
            // 
            this.mainpnl.Controls.Add(this.gbAnalysis);
            this.mainpnl.Controls.Add(this.gbFilterSort);
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.Location = new System.Drawing.Point(3, 3);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(944, 144);
            this.mainpnl.TabIndex = 1;
            // 
            // gbFilterSort
            // 
            this.gbFilterSort.Location = new System.Drawing.Point(9, 9);
            this.gbFilterSort.Name = "gbFilterSort";
            this.gbFilterSort.Size = new System.Drawing.Size(443, 123);
            this.gbFilterSort.TabIndex = 0;
            this.gbFilterSort.TabStop = false;
            this.gbFilterSort.Text = "Filtern und Sortieren";
            // 
            // gbAnalysis
            // 
            this.gbAnalysis.Location = new System.Drawing.Point(492, 18);
            this.gbAnalysis.Name = "gbAnalysis";
            this.gbAnalysis.Size = new System.Drawing.Size(311, 100);
            this.gbAnalysis.TabIndex = 0;
            this.gbAnalysis.TabStop = false;
            this.gbAnalysis.Text = "Auswertungen";
            // 
            // cmsGridMenu
            // 
            this.cmsGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDetail,
            this.tsmChange,
            this.tsmHaveTo});
            this.cmsGridMenu.Name = "cmsGridMenu";
            this.cmsGridMenu.Size = new System.Drawing.Size(156, 70);
            this.cmsGridMenu.Text = "Menu";
            // 
            // tsmDetail
            // 
            this.tsmDetail.Name = "tsmDetail";
            this.tsmDetail.Size = new System.Drawing.Size(155, 22);
            this.tsmDetail.Text = "Details";
            this.tsmDetail.Click += new System.EventHandler(this.tsmDetail_Click);
            // 
            // tsmChange
            // 
            this.tsmChange.Name = "tsmChange";
            this.tsmChange.Size = new System.Drawing.Size(155, 22);
            this.tsmChange.Text = "Projekt ändern";
            this.tsmChange.Click += new System.EventHandler(this.tsmChange_Click);
            // 
            // tsmHaveTo
            // 
            this.tsmHaveTo.Name = "tsmHaveTo";
            this.tsmHaveTo.Size = new System.Drawing.Size(155, 22);
            this.tsmHaveTo.Text = "\"Muss\" Projekt ";
            // 
            // FrmProjectOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnUseFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProjectOverview";
            this.Text = "FrmProjectOverview";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.mainpnl.ResumeLayout(false);
            this.cmsGridMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUseFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.Panel mainpnl;
        private System.Windows.Forms.GroupBox gbAnalysis;
        private System.Windows.Forms.GroupBox gbFilterSort;
        private System.Windows.Forms.ContextMenuStrip cmsGridMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmChange;
        private System.Windows.Forms.ToolStripMenuItem tsmHaveTo;
    }
}