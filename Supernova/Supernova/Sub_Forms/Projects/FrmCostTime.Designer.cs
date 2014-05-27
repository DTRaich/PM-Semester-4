namespace Supernova.Sub_Forms.Projects
{
    partial class FrmCostTime
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
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbNPV = new System.Windows.Forms.MaskedTextBox();
            this.nupTimeToMarket = new System.Windows.Forms.NumericUpDown();
            this.cbStartMonth = new System.Windows.Forms.ComboBox();
            this.cbStartYear = new System.Windows.Forms.ComboBox();
            this.cbEndYear = new System.Windows.Forms.ComboBox();
            this.cbEndMonth = new System.Windows.Forms.ComboBox();
            this.errMsgStartEndDate = new System.Windows.Forms.Label();
            this.tbCostAll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeToMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gesamtkosten";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(695, 337);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(0, 0);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Endtermin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Starttermin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Time To Market";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "NPV";
            // 
            // mtbNPV
            // 
            this.mtbNPV.Location = new System.Drawing.Point(394, 254);
            this.mtbNPV.Mask = "00.000";
            this.mtbNPV.Name = "mtbNPV";
            this.mtbNPV.Size = new System.Drawing.Size(136, 20);
            this.mtbNPV.TabIndex = 25;
            this.mtbNPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupTimeToMarket
            // 
            this.nupTimeToMarket.Location = new System.Drawing.Point(394, 289);
            this.nupTimeToMarket.Name = "nupTimeToMarket";
            this.nupTimeToMarket.Size = new System.Drawing.Size(136, 20);
            this.nupTimeToMarket.TabIndex = 26;
            // 
            // cbStartMonth
            // 
            this.cbStartMonth.FormattingEnabled = true;
            this.cbStartMonth.Location = new System.Drawing.Point(394, 21);
            this.cbStartMonth.Name = "cbStartMonth";
            this.cbStartMonth.Size = new System.Drawing.Size(65, 21);
            this.cbStartMonth.TabIndex = 27;
            this.cbStartMonth.SelectedValueChanged += new System.EventHandler(this.cbStartMonth_SelectedValueChanged);
            // 
            // cbStartYear
            // 
            this.cbStartYear.FormattingEnabled = true;
            this.cbStartYear.Location = new System.Drawing.Point(465, 21);
            this.cbStartYear.Name = "cbStartYear";
            this.cbStartYear.Size = new System.Drawing.Size(65, 21);
            this.cbStartYear.TabIndex = 28;
            this.cbStartYear.SelectedValueChanged += new System.EventHandler(this.cbStartYear_SelectedValueChanged);
            // 
            // cbEndYear
            // 
            this.cbEndYear.FormattingEnabled = true;
            this.cbEndYear.Location = new System.Drawing.Point(465, 65);
            this.cbEndYear.Name = "cbEndYear";
            this.cbEndYear.Size = new System.Drawing.Size(65, 21);
            this.cbEndYear.TabIndex = 30;
            this.cbEndYear.SelectedValueChanged += new System.EventHandler(this.cbEndYear_SelectedValueChanged);
            // 
            // cbEndMonth
            // 
            this.cbEndMonth.FormattingEnabled = true;
            this.cbEndMonth.Location = new System.Drawing.Point(394, 65);
            this.cbEndMonth.Name = "cbEndMonth";
            this.cbEndMonth.Size = new System.Drawing.Size(65, 21);
            this.cbEndMonth.TabIndex = 29;
            this.cbEndMonth.SelectedValueChanged += new System.EventHandler(this.cbEndMonth_SelectedValueChanged_1);
            // 
            // errMsgStartEndDate
            // 
            this.errMsgStartEndDate.AutoSize = true;
            this.errMsgStartEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgStartEndDate.ForeColor = System.Drawing.Color.DarkRed;
            this.errMsgStartEndDate.Location = new System.Drawing.Point(536, 66);
            this.errMsgStartEndDate.Name = "errMsgStartEndDate";
            this.errMsgStartEndDate.Size = new System.Drawing.Size(303, 17);
            this.errMsgStartEndDate.TabIndex = 31;
            this.errMsgStartEndDate.Text = "Das Startdatum muss vor dem Endatum liegen!";
            this.errMsgStartEndDate.Visible = false;
            // 
            // tbCostAll
            // 
            this.tbCostAll.Location = new System.Drawing.Point(394, 218);
            this.tbCostAll.Name = "tbCostAll";
            this.tbCostAll.ReadOnly = true;
            this.tbCostAll.Size = new System.Drawing.Size(136, 20);
            this.tbCostAll.TabIndex = 32;
            this.tbCostAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "in Euro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "in Monaten";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Kosten in Jahr 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Kosten in Jahr 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Kosten in Jahr 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "in Euro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(546, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "in Euro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(546, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "in Euro";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(398, 108);
            this.maskedTextBox1.Mask = "000000000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox1.TabIndex = 44;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox1.Validated += new System.EventHandler(this.maskedTextBox1_Validated);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(398, 144);
            this.maskedTextBox2.Mask = "000000000.00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox2.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox2.TabIndex = 45;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox2.Validated += new System.EventHandler(this.maskedTextBox2_Validated);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(398, 177);
            this.maskedTextBox3.Mask = "000000000.00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox3.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox3.TabIndex = 46;
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox3.Validated += new System.EventHandler(this.maskedTextBox3_Validated);
            // 
            // FrmCostTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 325);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCostAll);
            this.Controls.Add(this.errMsgStartEndDate);
            this.Controls.Add(this.cbEndYear);
            this.Controls.Add(this.cbEndMonth);
            this.Controls.Add(this.cbStartYear);
            this.Controls.Add(this.cbStartMonth);
            this.Controls.Add(this.nupTimeToMarket);
            this.Controls.Add(this.mtbNPV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCostTime";
            this.Text = "FrmCostTime";
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeToMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbNPV;
        private System.Windows.Forms.NumericUpDown nupTimeToMarket;
        private System.Windows.Forms.ComboBox cbStartMonth;
        private System.Windows.Forms.ComboBox cbStartYear;
        private System.Windows.Forms.ComboBox cbEndYear;
        private System.Windows.Forms.ComboBox cbEndMonth;
        private System.Windows.Forms.Label errMsgStartEndDate;
        private System.Windows.Forms.TextBox tbCostAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}