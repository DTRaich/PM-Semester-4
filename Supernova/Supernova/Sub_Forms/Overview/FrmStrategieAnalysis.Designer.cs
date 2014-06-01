namespace Supernova.Sub_Forms.Overview
{
    partial class FrmStrategieAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStrategy = new System.Windows.Forms.TabPage();
            this.chartStrategy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnExcelExportCat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStrategy)).BeginInit();
            this.tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStrategy);
            this.tabControl1.Controls.Add(this.tpCategory);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStrategy
            // 
            this.tpStrategy.Controls.Add(this.btnExcelExport);
            this.tpStrategy.Controls.Add(this.chartStrategy);
            this.tpStrategy.Location = new System.Drawing.Point(4, 22);
            this.tpStrategy.Name = "tpStrategy";
            this.tpStrategy.Padding = new System.Windows.Forms.Padding(3);
            this.tpStrategy.Size = new System.Drawing.Size(770, 308);
            this.tpStrategy.TabIndex = 0;
            this.tpStrategy.Text = "Strategie";
            this.tpStrategy.UseVisualStyleBackColor = true;
            // 
            // chartStrategy
            // 
            chartArea4.Name = "ChartArea1";
            this.chartStrategy.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartStrategy.Legends.Add(legend4);
            this.chartStrategy.Location = new System.Drawing.Point(3, 35);
            this.chartStrategy.Name = "chartStrategy";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartStrategy.Series.Add(series4);
            this.chartStrategy.Size = new System.Drawing.Size(764, 270);
            this.chartStrategy.TabIndex = 1;
            this.chartStrategy.Text = "chart1";
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.btnExcelExportCat);
            this.tpCategory.Controls.Add(this.chartCategory);
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(770, 308);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Kategorie";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // chartCategory
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCategory.Legends.Add(legend3);
            this.chartCategory.Location = new System.Drawing.Point(3, 35);
            this.chartCategory.Name = "chartCategory";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCategory.Series.Add(series3);
            this.chartCategory.Size = new System.Drawing.Size(764, 270);
            this.chartCategory.TabIndex = 0;
            this.chartCategory.Text = "chart1";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(665, 6);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(97, 23);
            this.btnExcelExport.TabIndex = 2;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnExcelExportCat
            // 
            this.btnExcelExportCat.Location = new System.Drawing.Point(667, 6);
            this.btnExcelExportCat.Name = "btnExcelExportCat";
            this.btnExcelExportCat.Size = new System.Drawing.Size(97, 23);
            this.btnExcelExportCat.TabIndex = 3;
            this.btnExcelExportCat.Text = "Excel Export";
            this.btnExcelExportCat.UseVisualStyleBackColor = true;
            this.btnExcelExportCat.Click += new System.EventHandler(this.btnExcelExportCat_Click);
            // 
            // FrmStrategieAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStrategieAnalysis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Strategie Auswertung";
            this.tabControl1.ResumeLayout(false);
            this.tpStrategy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStrategy)).EndInit();
            this.tpCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStrategy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStrategy;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnExcelExportCat;

    }
}