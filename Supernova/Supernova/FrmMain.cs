using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova
{
    public partial class FrmMain : Form
    {
        private Leader leader;
        public FrmMain()
        {
            InitializeComponent();

            leader = new Leader(this.pnlMain);
        }

        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            leader.LoadLogin();
        }


        #region ToolclickEvents

        private void projektErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projekteAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kriterienPriorisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rechteverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abteilungskapazitätenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void benutzerinformationenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passwordÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hilfekatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion 

    }
}
