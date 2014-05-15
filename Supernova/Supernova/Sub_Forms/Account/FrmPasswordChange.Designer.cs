namespace Supernova.Sub_Forms.Account
{
    partial class FrmPasswordChange
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
            this.btnChangePw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbOldPW = new System.Windows.Forms.MaskedTextBox();
            this.mtbNewPW1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbNewPW2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnChangePw
            // 
            this.btnChangePw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePw.Location = new System.Drawing.Point(391, 255);
            this.btnChangePw.Name = "btnChangePw";
            this.btnChangePw.Size = new System.Drawing.Size(132, 38);
            this.btnChangePw.TabIndex = 0;
            this.btnChangePw.Text = "Passwort ändern";
            this.btnChangePw.UseVisualStyleBackColor = true;
            this.btnChangePw.Click += new System.EventHandler(this.btnChangePw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "altes Passwort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "neues Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "neues Passwort wiederholen";
            // 
            // mtbOldPW
            // 
            this.mtbOldPW.Location = new System.Drawing.Point(483, 115);
            this.mtbOldPW.Mask = "00000";
            this.mtbOldPW.Name = "mtbOldPW";
            this.mtbOldPW.PasswordChar = '*';
            this.mtbOldPW.Size = new System.Drawing.Size(40, 20);
            this.mtbOldPW.TabIndex = 10;
            // 
            // mtbNewPW1
            // 
            this.mtbNewPW1.Location = new System.Drawing.Point(483, 154);
            this.mtbNewPW1.Mask = "00000";
            this.mtbNewPW1.Name = "mtbNewPW1";
            this.mtbNewPW1.PasswordChar = '*';
            this.mtbNewPW1.Size = new System.Drawing.Size(40, 20);
            this.mtbNewPW1.TabIndex = 11;
            // 
            // mtbNewPW2
            // 
            this.mtbNewPW2.Location = new System.Drawing.Point(483, 194);
            this.mtbNewPW2.Mask = "00000";
            this.mtbNewPW2.Name = "mtbNewPW2";
            this.mtbNewPW2.PasswordChar = '*';
            this.mtbNewPW2.Size = new System.Drawing.Size(40, 20);
            this.mtbNewPW2.TabIndex = 12;
            // 
            // FrmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.mtbNewPW2);
            this.Controls.Add(this.mtbNewPW1);
            this.Controls.Add(this.mtbOldPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasswordChange";
            this.Text = "FrmPasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbOldPW;
        private System.Windows.Forms.MaskedTextBox mtbNewPW1;
        private System.Windows.Forms.MaskedTextBox mtbNewPW2;
    }
}