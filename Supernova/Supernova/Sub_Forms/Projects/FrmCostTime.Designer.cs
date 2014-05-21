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
            this.mtbTotalCost = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbNPV = new System.Windows.Forms.MaskedTextBox();
            this.nupTimeToMarket = new System.Windows.Forms.NumericUpDown();
            this.cbStartMonth = new System.Windows.Forms.ComboBox();
            this.cbStartYear = new System.Windows.Forms.ComboBox();
            this.cbEndYear = new System.Windows.Forms.ComboBox();
            this.cbEndMonth = new System.Windows.Forms.ComboBox();
            this.errMsgStartEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeToMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 150);
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
            this.label2.Location = new System.Drawing.Point(316, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Endtermin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Starttermin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Time To Market";
            // 
            // mtbTotalCost
            // 
            this.mtbTotalCost.Location = new System.Drawing.Point(394, 149);
            this.mtbTotalCost.Mask = "0000000000,00";
            this.mtbTotalCost.Name = "mtbTotalCost";
            this.mtbTotalCost.Size = new System.Drawing.Size(83, 20);
            this.mtbTotalCost.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "NPV";
            // 
            // mtbNPV
            // 
            this.mtbNPV.Location = new System.Drawing.Point(394, 201);
            this.mtbNPV.Mask = "00,000";
            this.mtbNPV.Name = "mtbNPV";
            this.mtbNPV.Size = new System.Drawing.Size(43, 20);
            this.mtbNPV.TabIndex = 25;
            // 
            // nupTimeToMarket
            // 
            this.nupTimeToMarket.Location = new System.Drawing.Point(394, 251);
            this.nupTimeToMarket.Name = "nupTimeToMarket";
            this.nupTimeToMarket.Size = new System.Drawing.Size(120, 20);
            this.nupTimeToMarket.TabIndex = 26;
            // 
            // cbStartMonth
            // 
            this.cbStartMonth.FormattingEnabled = true;
            this.cbStartMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbStartMonth.Location = new System.Drawing.Point(394, 54);
            this.cbStartMonth.Name = "cbStartMonth";
            this.cbStartMonth.Size = new System.Drawing.Size(65, 21);
            this.cbStartMonth.TabIndex = 27;
            // 
            // cbStartYear
            // 
            this.cbStartYear.FormattingEnabled = true;
            this.cbStartYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbStartYear.Location = new System.Drawing.Point(465, 54);
            this.cbStartYear.Name = "cbStartYear";
            this.cbStartYear.Size = new System.Drawing.Size(65, 21);
            this.cbStartYear.TabIndex = 28;
            // 
            // cbEndYear
            // 
            this.cbEndYear.FormattingEnabled = true;
            this.cbEndYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbEndYear.Location = new System.Drawing.Point(465, 98);
            this.cbEndYear.Name = "cbEndYear";
            this.cbEndYear.Size = new System.Drawing.Size(65, 21);
            this.cbEndYear.TabIndex = 30;
            // 
            // cbEndMonth
            // 
            this.cbEndMonth.FormattingEnabled = true;
            this.cbEndMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbEndMonth.Location = new System.Drawing.Point(394, 98);
            this.cbEndMonth.Name = "cbEndMonth";
            this.cbEndMonth.Size = new System.Drawing.Size(65, 21);
            this.cbEndMonth.TabIndex = 29;
            // 
            // errMsgStartEndDate
            // 
            this.errMsgStartEndDate.AutoSize = true;
            this.errMsgStartEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgStartEndDate.ForeColor = System.Drawing.Color.DarkRed;
            this.errMsgStartEndDate.Location = new System.Drawing.Point(536, 99);
            this.errMsgStartEndDate.Name = "errMsgStartEndDate";
            this.errMsgStartEndDate.Size = new System.Drawing.Size(303, 17);
            this.errMsgStartEndDate.TabIndex = 31;
            this.errMsgStartEndDate.Text = "Das Startdatum muss vor dem Endatum liegen!";
            this.errMsgStartEndDate.Visible = false;
            // 
            // FrmCostTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 325);
            this.Controls.Add(this.errMsgStartEndDate);
            this.Controls.Add(this.cbEndYear);
            this.Controls.Add(this.cbEndMonth);
            this.Controls.Add(this.cbStartYear);
            this.Controls.Add(this.cbStartMonth);
            this.Controls.Add(this.nupTimeToMarket);
            this.Controls.Add(this.mtbNPV);
            this.Controls.Add(this.mtbTotalCost);
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
        private System.Windows.Forms.MaskedTextBox mtbTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbNPV;
        private System.Windows.Forms.NumericUpDown nupTimeToMarket;
        private System.Windows.Forms.ComboBox cbStartMonth;
        private System.Windows.Forms.ComboBox cbStartYear;
        private System.Windows.Forms.ComboBox cbEndYear;
        private System.Windows.Forms.ComboBox cbEndMonth;
        private System.Windows.Forms.Label errMsgStartEndDate;
    }
}