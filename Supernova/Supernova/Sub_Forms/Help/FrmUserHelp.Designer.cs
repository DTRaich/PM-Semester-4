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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Login");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Erste Schritte", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvUserHelp = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvUserHelp
            // 
            this.tvUserHelp.Location = new System.Drawing.Point(12, 12);
            this.tvUserHelp.Name = "tvUserHelp";
            treeNode1.Name = "Node0.0";
            treeNode1.Text = "Login";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Erste Schritte";
            this.tvUserHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvUserHelp.Size = new System.Drawing.Size(186, 353);
            this.tvUserHelp.TabIndex = 0;
            this.tvUserHelp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvUserHelp_NodeMouseDoubleClick);
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