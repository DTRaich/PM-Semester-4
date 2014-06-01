namespace Supernova.Sub_Forms.Overview
{
    partial class FrmGeneralAnalysis
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
            this.tpCapacity = new System.Windows.Forms.TabPage();
            this.chartCapacity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadDep = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.tpBudget = new System.Windows.Forms.TabPage();
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExcelExportCapa = new System.Windows.Forms.Button();
            this.btnExcelExportBudget = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCapacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCapacity)).BeginInit();
            this.tpBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCapacity);
            this.tabControl1.Controls.Add(this.tpBudget);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCapacity
            // 
            this.tpCapacity.Controls.Add(this.btnExcelExportCapa);
            this.tpCapacity.Controls.Add(this.chartCapacity);
            this.tpCapacity.Controls.Add(this.btnLoadDep);
            this.tpCapacity.Controls.Add(this.cboDepartment);
            this.tpCapacity.Location = new System.Drawing.Point(4, 22);
            this.tpCapacity.Name = "tpCapacity";
            this.tpCapacity.Padding = new System.Windows.Forms.Padding(3);
            this.tpCapacity.Size = new System.Drawing.Size(666, 320);
            this.tpCapacity.TabIndex = 0;
            this.tpCapacity.Text = "Kapazität";
            this.tpCapacity.UseVisualStyleBackColor = true;
            // 
            // chartCapacity
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCapacity.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCapacity.Legends.Add(legend4);
            this.chartCapacity.Location = new System.Drawing.Point(8, 31);
            this.chartCapacity.Name = "chartCapacity";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCapacity.Series.Add(series4);
            this.chartCapacity.Size = new System.Drawing.Size(650, 281);
            this.chartCapacity.TabIndex = 2;
            this.chartCapacity.Text = "chart1";
            // 
            // btnLoadDep
            // 
            this.btnLoadDep.Location = new System.Drawing.Point(135, 6);
            this.btnLoadDep.Name = "btnLoadDep";
            this.btnLoadDep.Size = new System.Drawing.Size(101, 23);
            this.btnLoadDep.TabIndex = 1;
            this.btnLoadDep.Text = "Abteilung Laden";
            this.btnLoadDep.UseVisualStyleBackColor = true;
            this.btnLoadDep.Click += new System.EventHandler(this.btnLoadDep_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(8, 6);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 21);
            this.cboDepartment.TabIndex = 0;
            // 
            // tpBudget
            // 
            this.tpBudget.Controls.Add(this.btnExcelExportBudget);
            this.tpBudget.Controls.Add(this.chartBudget);
            this.tpBudget.Location = new System.Drawing.Point(4, 22);
            this.tpBudget.Name = "tpBudget";
            this.tpBudget.Padding = new System.Windows.Forms.Padding(3);
            this.tpBudget.Size = new System.Drawing.Size(666, 320);
            this.tpBudget.TabIndex = 1;
            this.tpBudget.Text = "Budget";
            this.tpBudget.UseVisualStyleBackColor = true;
            // 
            // chartBudget
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBudget.Legends.Add(legend3);
            this.chartBudget.Location = new System.Drawing.Point(8, 31);
            this.chartBudget.Name = "chartBudget";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartBudget.Series.Add(series3);
            this.chartBudget.Size = new System.Drawing.Size(650, 281);
            this.chartBudget.TabIndex = 3;
            this.chartBudget.Text = "chart2";
            // 
            // btnExcelExportCapa
            // 
            this.btnExcelExportCapa.Location = new System.Drawing.Point(561, 6);
            this.btnExcelExportCapa.Name = "btnExcelExportCapa";
            this.btnExcelExportCapa.Size = new System.Drawing.Size(97, 23);
            this.btnExcelExportCapa.TabIndex = 3;
            this.btnExcelExportCapa.Text = "Excel Export";
            this.btnExcelExportCapa.UseVisualStyleBackColor = true;
            this.btnExcelExportCapa.Click += new System.EventHandler(this.btnExcelExportCapa_Click);
            // 
            // btnExcelExportBudget
            // 
            this.btnExcelExportBudget.Location = new System.Drawing.Point(561, 6);
            this.btnExcelExportBudget.Name = "btnExcelExportBudget";
            this.btnExcelExportBudget.Size = new System.Drawing.Size(97, 23);
            this.btnExcelExportBudget.TabIndex = 4;
            this.btnExcelExportBudget.Text = "Excel Export";
            this.btnExcelExportBudget.UseVisualStyleBackColor = true;
            this.btnExcelExportBudget.Click += new System.EventHandler(this.btnExcelExportBudget_Click);
            // 
            // FrmGeneralAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 346);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGeneralAnalysis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Budget und Ressourcen ";
            this.tabControl1.ResumeLayout(false);
            this.tpCapacity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCapacity)).EndInit();
            this.tpBudget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCapacity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCapacity;
        private System.Windows.Forms.Button btnLoadDep;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.TabPage tpBudget;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.Button btnExcelExportCapa;
        private System.Windows.Forms.Button btnExcelExportBudget;
    }
}