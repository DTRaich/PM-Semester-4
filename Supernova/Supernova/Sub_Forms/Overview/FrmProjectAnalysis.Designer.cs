namespace Supernova.Sub_Forms.Overview
{
    partial class FrmProjectAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartKostRisk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExcelExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartKostRisk)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKostRisk
            // 
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Risiko";
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Kosten";
            chartArea1.Name = "ChartArea1";
            this.chartKostRisk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartKostRisk.Legends.Add(legend1);
            this.chartKostRisk.Location = new System.Drawing.Point(0, 35);
            this.chartKostRisk.Name = "chartKostRisk";
            this.chartKostRisk.Size = new System.Drawing.Size(762, 338);
            this.chartKostRisk.TabIndex = 0;
            this.chartKostRisk.Text = "chart1";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(653, 6);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(97, 23);
            this.btnExcelExport.TabIndex = 3;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // FrmProjectAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 373);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.chartKostRisk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectAnalysis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projekt Analyse";
            ((System.ComponentModel.ISupportInitialize)(this.chartKostRisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKostRisk;
        private System.Windows.Forms.Button btnExcelExport;


    }
}