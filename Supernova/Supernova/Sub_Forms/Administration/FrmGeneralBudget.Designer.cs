namespace Supernova.Sub_Forms.Administration
{
    partial class FrmGeneralBudget
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
            this.lblheader = new System.Windows.Forms.Label();
            this.lblBudget1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbBudget1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbBudget2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbBudget3 = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMoney1 = new System.Windows.Forms.Label();
            this.lblMoney2 = new System.Windows.Forms.Label();
            this.lblMoney3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(364, 44);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(177, 20);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "Jahresbudget festlegen";
            // 
            // lblBudget1
            // 
            this.lblBudget1.AutoSize = true;
            this.lblBudget1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget1.Location = new System.Drawing.Point(281, 127);
            this.lblBudget1.Name = "lblBudget1";
            this.lblBudget1.Size = new System.Drawing.Size(145, 17);
            this.lblBudget1.TabIndex = 1;
            this.lblBudget1.Text = "Gesamtbudget Jahr 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gesamtbudget Jahr 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gesamtbudget Jahr 3";
            // 
            // mtbBudget1
            // 
            this.mtbBudget1.Location = new System.Drawing.Point(486, 126);
            this.mtbBudget1.Mask = "0000000000.00";
            this.mtbBudget1.Name = "mtbBudget1";
            this.mtbBudget1.Size = new System.Drawing.Size(82, 20);
            this.mtbBudget1.TabIndex = 4;
            this.mtbBudget1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbBudget2
            // 
            this.mtbBudget2.Location = new System.Drawing.Point(486, 196);
            this.mtbBudget2.Mask = "0000000000.00";
            this.mtbBudget2.Name = "mtbBudget2";
            this.mtbBudget2.Size = new System.Drawing.Size(82, 20);
            this.mtbBudget2.TabIndex = 5;
            this.mtbBudget2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbBudget3
            // 
            this.mtbBudget3.Location = new System.Drawing.Point(486, 276);
            this.mtbBudget3.Mask = "0000000000.00";
            this.mtbBudget3.Name = "mtbBudget3";
            this.mtbBudget3.Size = new System.Drawing.Size(82, 20);
            this.mtbBudget3.TabIndex = 6;
            this.mtbBudget3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(806, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(694, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 28);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Verwerfen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMoney1
            // 
            this.lblMoney1.AutoSize = true;
            this.lblMoney1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney1.Location = new System.Drawing.Point(578, 127);
            this.lblMoney1.Name = "lblMoney1";
            this.lblMoney1.Size = new System.Drawing.Size(53, 17);
            this.lblMoney1.TabIndex = 9;
            this.lblMoney1.Text = "in Euro";
            // 
            // lblMoney2
            // 
            this.lblMoney2.AutoSize = true;
            this.lblMoney2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney2.Location = new System.Drawing.Point(578, 197);
            this.lblMoney2.Name = "lblMoney2";
            this.lblMoney2.Size = new System.Drawing.Size(53, 17);
            this.lblMoney2.TabIndex = 10;
            this.lblMoney2.Text = "in Euro";
            // 
            // lblMoney3
            // 
            this.lblMoney3.AutoSize = true;
            this.lblMoney3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney3.Location = new System.Drawing.Point(578, 277);
            this.lblMoney3.Name = "lblMoney3";
            this.lblMoney3.Size = new System.Drawing.Size(53, 17);
            this.lblMoney3.TabIndex = 11;
            this.lblMoney3.Text = "in Euro";
            // 
            // FrmGeneralBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 339);
            this.Controls.Add(this.lblMoney3);
            this.Controls.Add(this.lblMoney2);
            this.Controls.Add(this.lblMoney1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtbBudget3);
            this.Controls.Add(this.mtbBudget2);
            this.Controls.Add(this.mtbBudget1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBudget1);
            this.Controls.Add(this.lblheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGeneralBudget";
            this.Text = "FrmGeneralBudget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblBudget1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbBudget1;
        private System.Windows.Forms.MaskedTextBox mtbBudget2;
        private System.Windows.Forms.MaskedTextBox mtbBudget3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMoney1;
        private System.Windows.Forms.Label lblMoney2;
        private System.Windows.Forms.Label lblMoney3;
    }
}