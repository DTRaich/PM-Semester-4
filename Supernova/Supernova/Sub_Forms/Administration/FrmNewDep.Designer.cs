namespace Supernova.Sub_Forms.Administration
{
    partial class FrmNewDep
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDepName = new System.Windows.Forms.Label();
            this.lblBudget1 = new System.Windows.Forms.Label();
            this.lblBudget2 = new System.Windows.Forms.Label();
            this.lblBudget3 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.mtbBudget1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbBudget2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbBudget3 = new System.Windows.Forms.MaskedTextBox();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(190, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(309, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDepName
            // 
            this.lblDepName.AutoSize = true;
            this.lblDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepName.Location = new System.Drawing.Point(69, 74);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(109, 17);
            this.lblDepName.TabIndex = 2;
            this.lblDepName.Text = "Abteilungsname";
            // 
            // lblBudget1
            // 
            this.lblBudget1.AutoSize = true;
            this.lblBudget1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget1.Location = new System.Drawing.Point(69, 131);
            this.lblBudget1.Name = "lblBudget1";
            this.lblBudget1.Size = new System.Drawing.Size(175, 17);
            this.lblBudget1.TabIndex = 3;
            this.lblBudget1.Text = "Abteilungskapazität Jahr 1";
            // 
            // lblBudget2
            // 
            this.lblBudget2.AutoSize = true;
            this.lblBudget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget2.Location = new System.Drawing.Point(69, 175);
            this.lblBudget2.Name = "lblBudget2";
            this.lblBudget2.Size = new System.Drawing.Size(175, 17);
            this.lblBudget2.TabIndex = 4;
            this.lblBudget2.Text = "Abteilungskapazität Jahr 2";
            // 
            // lblBudget3
            // 
            this.lblBudget3.AutoSize = true;
            this.lblBudget3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget3.Location = new System.Drawing.Point(69, 220);
            this.lblBudget3.Name = "lblBudget3";
            this.lblBudget3.Size = new System.Drawing.Size(175, 17);
            this.lblBudget3.TabIndex = 5;
            this.lblBudget3.Text = "Abteilungskapazität Jahr 1";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(186, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(182, 20);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Neue Abteilung erstellen\r\n";
            // 
            // mtbBudget1
            // 
            this.mtbBudget1.Location = new System.Drawing.Point(309, 131);
            this.mtbBudget1.Mask = "00000000";
            this.mtbBudget1.Name = "mtbBudget1";
            this.mtbBudget1.Size = new System.Drawing.Size(55, 20);
            this.mtbBudget1.TabIndex = 7;
            // 
            // mtbBudget2
            // 
            this.mtbBudget2.Location = new System.Drawing.Point(309, 175);
            this.mtbBudget2.Mask = "00000000";
            this.mtbBudget2.Name = "mtbBudget2";
            this.mtbBudget2.Size = new System.Drawing.Size(55, 20);
            this.mtbBudget2.TabIndex = 8;
            // 
            // mtbBudget3
            // 
            this.mtbBudget3.Location = new System.Drawing.Point(309, 220);
            this.mtbBudget3.Mask = "00000000";
            this.mtbBudget3.Name = "mtbBudget3";
            this.mtbBudget3.Size = new System.Drawing.Size(55, 20);
            this.mtbBudget3.TabIndex = 9;
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(309, 74);
            this.txtDepName.MaxLength = 50;
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(153, 20);
            this.txtDepName.TabIndex = 10;
            // 
            // FrmNewDep
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(575, 309);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.mtbBudget3);
            this.Controls.Add(this.mtbBudget2);
            this.Controls.Add(this.mtbBudget1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblBudget3);
            this.Controls.Add(this.lblBudget2);
            this.Controls.Add(this.lblBudget1);
            this.Controls.Add(this.lblDepName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FrmNewDep";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neue Abteilung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDepName;
        private System.Windows.Forms.Label lblBudget1;
        private System.Windows.Forms.Label lblBudget2;
        private System.Windows.Forms.Label lblBudget3;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MaskedTextBox mtbBudget1;
        private System.Windows.Forms.MaskedTextBox mtbBudget2;
        private System.Windows.Forms.MaskedTextBox mtbBudget3;
        private System.Windows.Forms.TextBox txtDepName;
    }
}