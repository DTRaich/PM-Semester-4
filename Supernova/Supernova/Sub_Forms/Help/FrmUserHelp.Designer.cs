﻿namespace Supernova.Sub_Forms.Help
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Abteilungskapazität");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Benutzerinformationen");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Benutzerverwaltung");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Passwort ändern");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hilfe", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.tvUserHelp = new System.Windows.Forms.TreeView();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvUserHelp
            // 
            this.tvUserHelp.Location = new System.Drawing.Point(12, 12);
            this.tvUserHelp.Name = "tvUserHelp";
            treeNode1.Name = "login";
            treeNode1.Text = "Login";
            treeNode2.Name = "abteilungskapazitaet";
            treeNode2.Text = "Abteilungskapazität";
            treeNode3.Name = "benutzerinformationen";
            treeNode3.Text = "Benutzerinformationen";
            treeNode4.Name = "benutzerverwaltung";
            treeNode4.Text = "Benutzerverwaltung";
            treeNode5.Name = "passwort_aendern";
            treeNode5.Text = "Passwort ändern";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Hilfe";
            this.tvUserHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvUserHelp.Size = new System.Drawing.Size(186, 353);
            this.tvUserHelp.TabIndex = 0;
            this.tvUserHelp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvUserHelp_NodeMouseDoubleClick);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(204, 12);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(711, 353);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // FrmUserHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tvUserHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserHelp";
            this.Text = "FrmUserHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvUserHelp;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}