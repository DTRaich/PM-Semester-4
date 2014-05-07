using Supernova.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.Sub_Forms;
using Supernova.Sub_Forms.Administration;
using Supernova.Sub_Forms.General;
using Supernova.Sub_Forms.Help;
using Supernova.Sub_Forms.Overview;
using Supernova.Sub_Forms.Projects;


namespace Supernova
{
    public class Leader
    {
        #region fields
        private Panel mainPanel;
        private int UserID;

        #endregion

        public Leader(Panel pnl)
        {
            this.mainPanel = pnl;
        }

        #region publicMethods

        public void setUserID(int uID)
        {
            UserID = uID;
        }
        public int getUserID()
        {
            return UserID;
        }


        public void LoadLogin()
        {
            mainPanel.Controls.Clear();            
            FrmLogin login = new FrmLogin(this);
            mainPanel.Controls.Add(prepareForm(login));
            login.Show();
            
        }
        //List mit Forms übergeben für FrmOrderControlling
        public void LoadProjektCreate()
        {
            mainPanel.Controls.Clear();
            FrmOrderControlling frm = new FrmOrderControlling();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadProjektView()
        {
            mainPanel.Controls.Clear();
            FrmProjectOverview frm = new FrmProjectOverview();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadCriteriaWeight()
        {
            mainPanel.Controls.Clear();
            FrmCriteriaWeight frm = new FrmCriteriaWeight();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadUserRights()
        {
            mainPanel.Controls.Clear();
            FrmUserRights frm = new FrmUserRights();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadGeneralBudget()
        {
            mainPanel.Controls.Clear();
            FrmGeneralBudget frm = new FrmGeneralBudget();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadDepartmentSpezification()
        {
            mainPanel.Controls.Clear();
            FrmDepartmentSpecifikation frm = new FrmDepartmentSpecifikation();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadInfo()
        {
            mainPanel.Controls.Clear();
            FrmInfo frm = new FrmInfo();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadUserHelp()
        {
            mainPanel.Controls.Clear();
            FrmUserHelp frm = new FrmUserHelp();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        #endregion

        #region privateMethods

        /// <summary>
        /// Diese Methode aufrufen, um die Form für PanelControl bereit zumachen.
        /// </summary>
        /// <param name="frm">Form</param>
        /// <returns>Form</returns>
        private Form prepareForm(Form frm)
        {
            frm.AutoScroll = true;
            frm.AutoSize = true;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;

            return frm;
        }
        #endregion


    }
}
