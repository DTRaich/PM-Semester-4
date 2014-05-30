using Supernova.helper;
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

            leader = Leader.getLeader(this.pnlMain);
            DBerror dberror = DBerror.getInstanze();
            dberror.setDbLabel(this.dbErrorLabel);
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
            adminToolStripMenuItem1.Visible = false;
            
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
            adminToolStripMenuItem1.Visible = true;
            kriterienPriorisierenToolStripMenuItem.Visible = false;
            budgetToolStripMenuItem.Visible = false;
            benutzerAnlegenToolStripMenuItem.Visible = false;
            rechteverwaltungToolStripMenuItem.Visible = false;
            schnittstellenverwaltungToolStripMenuItem.Visible = false;

        }

        private void initializePl()
        {
            adminToolStripMenuItem1.Visible = false;
        }

        private void initializeGl()
        {
            adminToolStripMenuItem1.Visible = true;
            benutzerAnlegenToolStripMenuItem.Visible = true;
            rechteverwaltungToolStripMenuItem.Visible = true;
            schnittstellenverwaltungToolStripMenuItem.Visible = true;

        }

        private void initializeAdmin()
        {
            adminToolStripMenuItem1.Visible = true;
            benutzerAnlegenToolStripMenuItem.Visible = true;
            rechteverwaltungToolStripMenuItem.Visible = true;
            schnittstellenverwaltungToolStripMenuItem.Visible = true;

        }

       

        #region ToolclickEvents

        private void rechteverwaltungToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            leader.LoadUserRights();
        }

        private void schnittstellenverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadWeiserRiese();
        }   

        private void ausloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.logout();
            resetRights();
            leader.LoadLogin();
            pnlMain.ControlRemoved += new ControlEventHandler(pnlMain_ControlRemoved);
        }

        private void projekteAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadProjektView();
        }

        private void projektErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadProjektCreate();
        }
              

        private void kriterienPriorisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadCriteriaWeight();
        }

        private void rechteverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadUserRights();
        }

        private void abteilungskapazitätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadDepartmentSpezification();
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadGeneralBudget();
        }

        private void benutzerAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadAddorUpdateUser();
        }

        private void benutzerinformationenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadUserInfo();
        }

        private void passwordÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.loadPasswordChange();  
        }

        private void hilfekatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leader.LoadUserHelp();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
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
            adminToolStripMenuItem1.Visible = false;

            kriterienPriorisierenToolStripMenuItem.Visible = true;
            budgetToolStripMenuItem.Visible = true;
            benutzerAnlegenToolStripMenuItem.Visible = true;
            rechteverwaltungToolStripMenuItem.Visible = true;
            schnittstellenverwaltungToolStripMenuItem.Visible = true;

        }
   

    }
}
