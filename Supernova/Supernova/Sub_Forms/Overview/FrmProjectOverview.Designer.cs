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
            this.cmsGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mainpnl = new System.Windows.Forms.Panel();
            this.gbAnalysis = new System.Windows.Forms.GroupBox();
            this.clbBox = new System.Windows.Forms.CheckedListBox();
            this.btnRiskCostAnalysis = new System.Windows.Forms.Button();
            this.btnStrategieAnalysis = new System.Windows.Forms.Button();
            this.btnDepBudAnalysis = new System.Windows.Forms.Button();
            this.gbFilterSort = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbMust = new System.Windows.Forms.CheckBox();
            this.cbMy = new System.Windows.Forms.CheckBox();
            this.cbStrategy = new System.Windows.Forms.ComboBox();
            this.lblStrategy = new System.Windows.Forms.Label();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.cmsGridMenu.SuspendLayout();
            this.mainpnl.SuspendLayout();
            this.gbAnalysis.SuspendLayout();
            this.gbFilterSort.SuspendLayout();
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
            this.mainGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainGrid_MouseDown);
            // 
            // cmsGridMenu
            // 
            this.cmsGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDetail,
            this.tsmChange,
            this.tsmHaveTo});
            this.cmsGridMenu.Name = "cmsGridMenu";
            this.cmsGridMenu.Size = new System.Drawing.Size(201, 70);
            this.cmsGridMenu.Text = "Menu";
            this.cmsGridMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsGridMenu_Opening);
            // 
            // tsmDetail
            // 
            this.tsmDetail.Name = "tsmDetail";
            this.tsmDetail.Size = new System.Drawing.Size(200, 22);
            this.tsmDetail.Text = "Details";
            this.tsmDetail.Click += new System.EventHandler(this.tsmDetail_Click);
            // 
            // tsmChange
            // 
            this.tsmChange.Name = "tsmChange";
            this.tsmChange.Size = new System.Drawing.Size(200, 22);
            this.tsmChange.Text = "Projekt ändern";
            this.tsmChange.Click += new System.EventHandler(this.tsmChange_Click);
            // 
            // tsmHaveTo
            // 
            this.tsmHaveTo.Name = "tsmHaveTo";
            this.tsmHaveTo.Size = new System.Drawing.Size(200, 22);
            this.tsmHaveTo.Text = "\"Muss\" Projekt(Ja/Nein)";
            this.tsmHaveTo.Click += new System.EventHandler(this.tsmHaveTo_Click);
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
            // gbAnalysis
            // 
            this.gbAnalysis.Controls.Add(this.btnExcelExport);
            this.gbAnalysis.Controls.Add(this.clbBox);
            this.gbAnalysis.Controls.Add(this.btnRiskCostAnalysis);
            this.gbAnalysis.Controls.Add(this.btnStrategieAnalysis);
            this.gbAnalysis.Controls.Add(this.btnDepBudAnalysis);
            this.gbAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnalysis.Location = new System.Drawing.Point(458, 9);
            this.gbAnalysis.Name = "gbAnalysis";
            this.gbAnalysis.Size = new System.Drawing.Size(477, 132);
            this.gbAnalysis.TabIndex = 0;
            this.gbAnalysis.TabStop = false;
            this.gbAnalysis.Text = "Auswertungen";
            // 
            // clbBox
            // 
            this.clbBox.AllowDrop = true;
            this.clbBox.CheckOnClick = true;
            this.clbBox.FormattingEnabled = true;
            this.clbBox.Location = new System.Drawing.Point(210, 51);
            this.clbBox.Name = "clbBox";
            this.clbBox.Size = new System.Drawing.Size(261, 76);
            this.clbBox.TabIndex = 4;
            this.clbBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.clbBox_DragDrop);
            this.clbBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.clbBox_DragEnter);
            // 
            // btnRiskCostAnalysis
            // 
            this.btnRiskCostAnalysis.Location = new System.Drawing.Point(210, 14);
            this.btnRiskCostAnalysis.Name = "btnRiskCostAnalysis";
            this.btnRiskCostAnalysis.Size = new System.Drawing.Size(168, 31);
            this.btnRiskCostAnalysis.TabIndex = 2;
            this.btnRiskCostAnalysis.Text = "Projekt-Analyse";
            this.btnRiskCostAnalysis.UseVisualStyleBackColor = true;
            this.btnRiskCostAnalysis.Click += new System.EventHandler(this.btnRiskCostAnalysis_Click);
            // 
            // btnStrategieAnalysis
            // 
            this.btnStrategieAnalysis.Location = new System.Drawing.Point(6, 58);
            this.btnStrategieAnalysis.Name = "btnStrategieAnalysis";
            this.btnStrategieAnalysis.Size = new System.Drawing.Size(168, 34);
            this.btnStrategieAnalysis.TabIndex = 1;
            this.btnStrategieAnalysis.Text = "Strategie Auswertung";
            this.btnStrategieAnalysis.UseVisualStyleBackColor = true;
            this.btnStrategieAnalysis.Click += new System.EventHandler(this.btnStrategieAnalysis_Click);
            // 
            // btnDepBudAnalysis
            // 
            this.btnDepBudAnalysis.Location = new System.Drawing.Point(6, 18);
            this.btnDepBudAnalysis.Name = "btnDepBudAnalysis";
            this.btnDepBudAnalysis.Size = new System.Drawing.Size(168, 34);
            this.btnDepBudAnalysis.TabIndex = 0;
            this.btnDepBudAnalysis.Text = "Ressourcen-Auslastung";
            this.btnDepBudAnalysis.UseVisualStyleBackColor = true;
            this.btnDepBudAnalysis.Click += new System.EventHandler(this.btnDepBudAnalysis_Click);
            // 
            // gbFilterSort
            // 
            this.gbFilterSort.Controls.Add(this.btnFilter);
            this.gbFilterSort.Controls.Add(this.cbCategory);
            this.gbFilterSort.Controls.Add(this.lblCategory);
            this.gbFilterSort.Controls.Add(this.cbMust);
            this.gbFilterSort.Controls.Add(this.cbMy);
            this.gbFilterSort.Controls.Add(this.cbStrategy);
            this.gbFilterSort.Controls.Add(this.lblStrategy);
            this.gbFilterSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilterSort.Location = new System.Drawing.Point(9, 9);
            this.gbFilterSort.Name = "gbFilterSort";
            this.gbFilterSort.Size = new System.Drawing.Size(443, 132);
            this.gbFilterSort.TabIndex = 0;
            this.gbFilterSort.TabStop = false;
            this.gbFilterSort.Text = "Filtern";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(362, 103);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 24);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filtern";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(96, 72);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(164, 24);
            this.cbCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Kategorie";
            // 
            // cbMust
            // 
            this.cbMust.AutoSize = true;
            this.cbMust.Location = new System.Drawing.Point(297, 31);
            this.cbMust.Name = "cbMust";
            this.cbMust.Size = new System.Drawing.Size(126, 21);
            this.cbMust.TabIndex = 5;
            this.cbMust.Text = "\"Muss\" Projekte";
            this.cbMust.UseVisualStyleBackColor = true;
            // 
            // cbMy
            // 
            this.cbMy.AutoSize = true;
            this.cbMy.Location = new System.Drawing.Point(297, 74);
            this.cbMy.Name = "cbMy";
            this.cbMy.Size = new System.Drawing.Size(121, 21);
            this.cbMy.TabIndex = 3;
            this.cbMy.Text = "Meine Projekte";
            this.cbMy.UseVisualStyleBackColor = true;
            // 
            // cbStrategy
            // 
            this.cbStrategy.FormattingEnabled = true;
            this.cbStrategy.Location = new System.Drawing.Point(96, 28);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(164, 24);
            this.cbStrategy.TabIndex = 1;
            // 
            // lblStrategy
            // 
            this.lblStrategy.AutoSize = true;
            this.lblStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrategy.Location = new System.Drawing.Point(10, 28);
            this.lblStrategy.Name = "lblStrategy";
            this.lblStrategy.Size = new System.Drawing.Size(65, 17);
            this.lblStrategy.TabIndex = 0;
            this.lblStrategy.Text = "Strategie";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(6, 98);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(168, 34);
            this.btnExcelExport.TabIndex = 5;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
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
            this.cmsGridMenu.ResumeLayout(false);
            this.mainpnl.ResumeLayout(false);
            this.gbAnalysis.ResumeLayout(false);
            this.gbFilterSort.ResumeLayout(false);
            this.gbFilterSort.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.CheckBox cbMust;
        private System.Windows.Forms.CheckBox cbMy;
        private System.Windows.Forms.ComboBox cbStrategy;
        private System.Windows.Forms.Label lblStrategy;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDepBudAnalysis;
        private System.Windows.Forms.Button btnRiskCostAnalysis;
        private System.Windows.Forms.Button btnStrategieAnalysis;
        private System.Windows.Forms.CheckedListBox clbBox;
        private System.Windows.Forms.Button btnExcelExport;
    }
}