namespace Supernova.Sub_Forms.Projects
{
    partial class FrmRisk
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
            this.tbTechRisk = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFinancialRisk = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecurityRisk = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQualityRisk = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbTechRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinancialRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSecurityRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQualityRisk)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTechRisk
            // 
            this.tbTechRisk.Location = new System.Drawing.Point(475, 12);
            this.tbTechRisk.Minimum = 1;
            this.tbTechRisk.Name = "tbTechRisk";
            this.tbTechRisk.Size = new System.Drawing.Size(104, 45);
            this.tbTechRisk.TabIndex = 0;
            this.tbTechRisk.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Technisches Risiko";
            // 
            // tbFinancialRisk
            // 
            this.tbFinancialRisk.Location = new System.Drawing.Point(475, 63);
            this.tbFinancialRisk.Minimum = 1;
            this.tbFinancialRisk.Name = "tbFinancialRisk";
            this.tbFinancialRisk.Size = new System.Drawing.Size(104, 45);
            this.tbFinancialRisk.TabIndex = 2;
            this.tbFinancialRisk.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Finanzielles Risiko";
            // 
            // tbSecurityRisk
            // 
            this.tbSecurityRisk.Location = new System.Drawing.Point(475, 114);
            this.tbSecurityRisk.Minimum = 1;
            this.tbSecurityRisk.Name = "tbSecurityRisk";
            this.tbSecurityRisk.Size = new System.Drawing.Size(104, 45);
            this.tbSecurityRisk.TabIndex = 4;
            this.tbSecurityRisk.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sicherheitsrelevantes Risiko";
            // 
            // tbQualityRisk
            // 
            this.tbQualityRisk.Location = new System.Drawing.Point(475, 165);
            this.tbQualityRisk.Minimum = 1;
            this.tbQualityRisk.Name = "tbQualityRisk";
            this.tbQualityRisk.Size = new System.Drawing.Size(104, 45);
            this.tbQualityRisk.TabIndex = 6;
            this.tbQualityRisk.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qualitatives Risiko";
            // 
            // FrmRisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQualityRisk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSecurityRisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFinancialRisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTechRisk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRisk";
            this.Text = "FrmRisk";
            ((System.ComponentModel.ISupportInitialize)(this.tbTechRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinancialRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSecurityRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQualityRisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTechRisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbFinancialRisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbSecurityRisk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbQualityRisk;
        private System.Windows.Forms.Label label4;
    }
}