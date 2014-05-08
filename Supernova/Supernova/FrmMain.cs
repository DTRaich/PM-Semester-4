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
            pnlMain.ControlRemoved += pnlMain_ControlRemoved;
        }

        void pnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            int right = leader.initialRightsForMain();
            initialRightsMain(right);
            pnlMain.ControlRemoved -= pnlMain_ControlRemoved;
        }

        private void initialRightsMain(int right)
        {
            throw new NotImplementedException();
        }

        

        

        #region ToolclickEvents

        private void projektErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadProjektCreate();
        }

        private void projekteAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadProjektView();
        }

        private void kriterienPriorisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadCriteriaWeight();
        }

        private void rechteverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadUserRights();
        }

        private void abteilungskapazitätenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadDepartmentSpezification();
        }

        private void benutzerinformationenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void passwordÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hilfekatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadUserHelp();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadInfo();
        }

        private void ausloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.logout();
            leader.LoadLogin();
        }


        #endregion 

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            leader.logout();            
        }

    }
}
