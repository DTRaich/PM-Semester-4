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
            projekteToolStripMenuItem.Enabled = true;
            accountToolStripMenuItem.Enabled = true;
            
            switch (right)
            {
                case 16: initializeAdmin();
                    break;
                case 17: initializeGl();
                    break;
                case 18: initializePl();
                    break;
                case 19: initializeAl();
                    break;

            }
        }

        private void initializeAl()
        {
            kriterienPriorisierenToolStripMenuItem.Visible = false;
            rechteverwaltungToolStripMenuItem.Visible = false;
            budgetToolStripMenuItem.Visible = false;
        }

        private void initializePl()
        {
            adminToolStripMenuItem1.Visible = false;
        }

        private void initializeGl()
        {
           
        }

        private void initializeAdmin()
        {

        }

       

        #region ToolclickEvents

        private void benutzerAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadAddorUpdateUser();
        }

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
            resetRights();
            leader.LoadLogin();
            pnlMain.ControlRemoved +=new ControlEventHandler(pnlMain_ControlRemoved);
        }


        #endregion 

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (leader.getUserID() != 0)
            {
                leader.logout();         

            }
          
        }

        private void resetRights()
        {
            projekteToolStripMenuItem.Enabled = false;
            accountToolStripMenuItem.Enabled = false;

            kriterienPriorisierenToolStripMenuItem.Visible = true;
            rechteverwaltungToolStripMenuItem.Visible = true;
            budgetToolStripMenuItem.Visible = true;
            adminToolStripMenuItem1.Visible = true;
        }

       

    }
}
