namespace Supernova.Sub_Forms.Help
{
    partial class FrmUserHelp
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
            this.tvUserHelp = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvUserHelp
            // 
            this.tvUserHelp.Location = new System.Drawing.Point(12, 12);
            this.tvUserHelp.Name = "tvUserHelp";
            this.tvUserHelp.Size = new System.Drawing.Size(186, 353);
            this.tvUserHelp.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(204, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(711, 353);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // FrmUserHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tvUserHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserHelp";
            this.Text = "FrmUserHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvUserHelp;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}