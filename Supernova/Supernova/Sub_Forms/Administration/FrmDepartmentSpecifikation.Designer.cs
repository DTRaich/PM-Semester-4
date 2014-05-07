namespace Supernova.Sub_Forms.Administration
{
    partial class FrmDepartmentSpecifikation
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
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Location = new System.Drawing.Point(12, 48);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(926, 326);
            this.pnlDepartment.TabIndex = 0;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(140, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Auswählen";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(13, 13);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 21);
            this.cboDepartment.TabIndex = 2;
            // 
            // FrmDepartmentSpecifikation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pnlDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartmentSpecifikation";
            this.Text = "FrmDepartmentSpecifikation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepartment;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ComboBox cboDepartment;
    }
}