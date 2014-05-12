namespace Supernova
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.projekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projekteÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kriterienPriorisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechteverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abteilungskapazitätToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerinformationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfekatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sStateStrip = new System.Windows.Forms.StatusStrip();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekteToolStripMenuItem,
            this.adminToolStripMenuItem1,
            this.accountToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(945, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            // 
            // projekteToolStripMenuItem
            // 
            this.projekteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projekteAnzeigenToolStripMenuItem,
            this.projektErstellenToolStripMenuItem,
            this.projekteÄndernToolStripMenuItem});
            this.projekteToolStripMenuItem.Enabled = false;
            this.projekteToolStripMenuItem.Name = "projekteToolStripMenuItem";
            this.projekteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.projekteToolStripMenuItem.Text = "Projekte";
            // 
            // projekteAnzeigenToolStripMenuItem
            // 
            this.projekteAnzeigenToolStripMenuItem.Name = "projekteAnzeigenToolStripMenuItem";
            this.projekteAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projekteAnzeigenToolStripMenuItem.Text = "Projekte anzeigen";
            this.projekteAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.projekteAnzeigenToolStripMenuItem_Click);
            // 
            // projektErstellenToolStripMenuItem
            // 
            this.projektErstellenToolStripMenuItem.Name = "projektErstellenToolStripMenuItem";
            this.projektErstellenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projektErstellenToolStripMenuItem.Text = "Projekt erstellen";
            this.projektErstellenToolStripMenuItem.Click += new System.EventHandler(this.projektErstellenToolStripMenuItem_Click);
            // 
            // projekteÄndernToolStripMenuItem
            // 
            this.projekteÄndernToolStripMenuItem.Name = "projekteÄndernToolStripMenuItem";
            this.projekteÄndernToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projekteÄndernToolStripMenuItem.Text = "Projekte ändern";
            // 
            // adminToolStripMenuItem1
            // 
            this.adminToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kriterienPriorisierenToolStripMenuItem,
            this.rechteverwaltungToolStripMenuItem,
            this.abteilungskapazitätToolStripMenuItem,
            this.budgetToolStripMenuItem,
            this.benutzerAnlegenToolStripMenuItem});
            this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            this.adminToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem1.Text = "Admin";
            this.adminToolStripMenuItem1.Visible = false;
            // 
            // kriterienPriorisierenToolStripMenuItem
            // 
            this.kriterienPriorisierenToolStripMenuItem.Name = "kriterienPriorisierenToolStripMenuItem";
            this.kriterienPriorisierenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.kriterienPriorisierenToolStripMenuItem.Text = "Kriterien priorisieren";
            // 
            // rechteverwaltungToolStripMenuItem
            // 
            this.rechteverwaltungToolStripMenuItem.Name = "rechteverwaltungToolStripMenuItem";
            this.rechteverwaltungToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.rechteverwaltungToolStripMenuItem.Text = "Rechteverwaltung";
            // 
            // abteilungskapazitätToolStripMenuItem
            // 
            this.abteilungskapazitätToolStripMenuItem.Name = "abteilungskapazitätToolStripMenuItem";
            this.abteilungskapazitätToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.abteilungskapazitätToolStripMenuItem.Text = "Abteilungskapazität";
            // 
            // budgetToolStripMenuItem
            // 
            this.budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            this.budgetToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.budgetToolStripMenuItem.Text = "Budget";
            // 
            // benutzerAnlegenToolStripMenuItem
            // 
            this.benutzerAnlegenToolStripMenuItem.Name = "benutzerAnlegenToolStripMenuItem";
            this.benutzerAnlegenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.benutzerAnlegenToolStripMenuItem.Text = "Benutzer anlegen";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerinformationenToolStripMenuItem,
            this.passwordÄndernToolStripMenuItem,
            this.ausloggenToolStripMenuItem});
            this.accountToolStripMenuItem.Enabled = false;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // benutzerinformationenToolStripMenuItem
            // 
            this.benutzerinformationenToolStripMenuItem.Name = "benutzerinformationenToolStripMenuItem";
            this.benutzerinformationenToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.benutzerinformationenToolStripMenuItem.Text = "Benutzerinformationen";
            this.benutzerinformationenToolStripMenuItem.Click += new System.EventHandler(this.benutzerinformationenToolStripMenuItem_Click);
            // 
            // passwordÄndernToolStripMenuItem
            // 
            this.passwordÄndernToolStripMenuItem.Name = "passwordÄndernToolStripMenuItem";
            this.passwordÄndernToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.passwordÄndernToolStripMenuItem.Text = "Password ändern";
            this.passwordÄndernToolStripMenuItem.Click += new System.EventHandler(this.passwordÄndernToolStripMenuItem_Click);
            // 
            // ausloggenToolStripMenuItem
            // 
            this.ausloggenToolStripMenuItem.Name = "ausloggenToolStripMenuItem";
            this.ausloggenToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ausloggenToolStripMenuItem.Text = "Ausloggen";
            this.ausloggenToolStripMenuItem.Click += new System.EventHandler(this.ausloggenToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfekatalogToolStripMenuItem,
            this.überToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.adminToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfekatalogToolStripMenuItem
            // 
            this.hilfekatalogToolStripMenuItem.Name = "hilfekatalogToolStripMenuItem";
            this.hilfekatalogToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.hilfekatalogToolStripMenuItem.Text = "Hilfekatalog";
            this.hilfekatalogToolStripMenuItem.Click += new System.EventHandler(this.hilfekatalogToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // sStateStrip
            // 
            this.sStateStrip.Location = new System.Drawing.Point(0, 405);
            this.sStateStrip.Name = "sStateStrip";
            this.sStateStrip.Size = new System.Drawing.Size(945, 22);
            this.sStateStrip.TabIndex = 1;
            this.sStateStrip.Text = "statusStrip1";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(945, 381);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 427);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.sStateStrip);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmMain";
            this.Text = "Supernova Version 1.0.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.StatusStrip sStateStrip;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem projekteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekteAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerinformationenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfekatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projekteÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kriterienPriorisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechteverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abteilungskapazitätToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerAnlegenToolStripMenuItem;
    }
}

