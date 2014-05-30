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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartKostRisk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartKostRisk)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKostRisk
            // 
            legend1.Name = "Legend1";
            this.chartKostRisk.Legends.Add(legend1);
            this.chartKostRisk.Location = new System.Drawing.Point(26, 12);
            this.chartKostRisk.Name = "chartKostRisk";
            this.chartKostRisk.Size = new System.Drawing.Size(650, 400);
            this.chartKostRisk.TabIndex = 0;
            this.chartKostRisk.Text = "Projektanalyses";
            // 
            // FrmProjectAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 424);
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

    }
}