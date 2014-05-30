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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Login/Logout");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Projekte anzeigen");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Projekte erstellen");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Projekte", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Kriterien priorisieren");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Abteilungskapazität");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Budget");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Benutzerverwaltung");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Rechteverwaltung");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Schnittstellenverwaltung");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Admin", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Benutzerinformationen");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Passwort ändern");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Account", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Hilfe", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode11,
            treeNode14});
            this.tvUserHelp = new System.Windows.Forms.TreeView();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvUserHelp
            // 
            this.tvUserHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvUserHelp.Location = new System.Drawing.Point(12, 12);
            this.tvUserHelp.Name = "tvUserHelp";
            treeNode1.Name = "login";
            treeNode1.Text = "Login/Logout";
            treeNode2.Name = "projekte_anzeigen";
            treeNode2.Text = "Projekte anzeigen";
            treeNode3.Name = "projekte_erstellen";
            treeNode3.Text = "Projekte erstellen";
            treeNode4.Name = "projekte";
            treeNode4.Text = "Projekte";
            treeNode5.Name = "kriterien_priorisieren";
            treeNode5.Text = "Kriterien priorisieren";
            treeNode6.Name = "abteilungskapazitaet";
            treeNode6.Text = "Abteilungskapazität";
            treeNode7.Name = "budget";
            treeNode7.Text = "Budget";
            treeNode8.Name = "benutzerverwaltung";
            treeNode8.Text = "Benutzerverwaltung";
            treeNode9.Name = "rechteverwaltung";
            treeNode9.Text = "Rechteverwaltung";
            treeNode10.Name = "schnittstellenverwaltung";
            treeNode10.Text = "Schnittstellenverwaltung";
            treeNode11.Name = "admin";
            treeNode11.Text = "Admin";
            treeNode12.Name = "benutzerinformationen";
            treeNode12.Text = "Benutzerinformationen";
            treeNode13.Name = "passwort_aendern";
            treeNode13.Text = "Passwort ändern";
            treeNode14.Name = "account";
            treeNode14.Text = "Account";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Hilfe";
            this.tvUserHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.tvUserHelp.Size = new System.Drawing.Size(186, 353);
            this.tvUserHelp.TabIndex = 0;
            this.tvUserHelp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvUserHelp_NodeMouseDoubleClick);
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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