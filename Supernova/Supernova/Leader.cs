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
using Supernova.objects;
using Supernova.Sub_Forms.Account;
using Supernova.Sub_Forms.Administration.Schnitstellen;


namespace Supernova
{
    public class Leader
    {
        #region fields
        private Panel mainPanel;
        private int UserID = 0;
        public ProjektDataDummy projektdaten;

        #endregion
        private static Leader lead;
        private Leader() { }
        private Leader(Panel pnl)
        {
            this.mainPanel = pnl;
        }
        public static Leader getLeader(Panel pnl)
        {
            if (lead == null)
            {
                lead = new Leader(pnl);
            }

            return lead;
        }

        public static Leader getLeaderInst()
        {
            return lead;
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

        public int initialRightsForMain()
        {
            string formname = "FrmMain";
            DataLoad dl = new DataLoad();

            return dl.UserRight(UserID, formname);
 
        }

        #region FormLoader
        public void LoadLogin()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();            
            FrmLogin login = new FrmLogin(this);
            mainPanel.Controls.Add(prepareForm(login));
            login.Show();
            
        }
        //List mit Forms übergeben für FrmOrderControlling
        public void LoadProjektCreate()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            projektdaten = new ProjektDataDummy();
            projektdaten.CreatedBY = UserID;
            List<Form> li = getFormsListNewProject();
            FrmOrderControlling frm = new FrmOrderControlling(li, ref projektdaten);
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadEditProjects(int proID)
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            //
            //--------------------> Platz zum abhandeln der ProjectLadenForm
            projektdaten = new ProjektDataDummy();
            projektdaten.loadProjectdataintoDummy(proID);
            //

            List<Form> li = getFormsListNewProject();
            FrmOrderControlling frm = new FrmOrderControlling(li, ref projektdaten);
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }


        public void LoadProjektView()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmProjectOverview frm = new FrmProjectOverview();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadCriteriaWeight()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmCriteriaWeight frm = new FrmCriteriaWeight();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadUserRights()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmRightsReglement frm = new FrmRightsReglement();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadGeneralBudget()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmGeneralBudget frm = new FrmGeneralBudget();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadDepartmentSpezification()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmDepartmentSpecifikation frm = new FrmDepartmentSpecifikation(UserID);    
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }



        public void loadPasswordChange()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmPasswordChange frm = new FrmPasswordChange(UserID);
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadWeiserRiese()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmWeiserRieseMain frm = new FrmWeiserRieseMain();
            frm.ShowDialog();
            //mainPanel.Controls.Add(prepareForm(frm));
            //frm.Show();
        }
      

        public void LoadUserInfo()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmUserInformation frm = new FrmUserInformation(UserID);
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadUserHelp()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmUserHelp frm = new FrmUserHelp();
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }

        public void LoadAddorUpdateUser()
        {
            ClearUpMainPanel();
            mainPanel.Controls.Clear();
            FrmUser frm = new FrmUser(UserID);
            mainPanel.Controls.Add(prepareForm(frm));
            frm.Show();
        }
        #endregion

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


        private List<Form> getFormsListNewProject()
        {
            // Forms
            FrmBasisData bdata = new FrmBasisData(ref projektdaten);
            FrmCostTime cform = new FrmCostTime(ref projektdaten);
            FrmRessources frmRes = new FrmRessources(ref projektdaten);
            FrmRisk frmR = new FrmRisk(ref projektdaten);
            FrmStrategie frmS = new FrmStrategie(ref projektdaten);

            //adden

            List<Form> list = new List<Form>();
            list.Add(prepareForm(bdata));
            list.Add(prepareForm(cform));
            list.Add(prepareForm(frmRes));
            list.Add(prepareForm(frmR));
            list.Add(prepareForm(frmS));

            return list;
        }

        public  void ClearUpMainPanel()
        {
            foreach (Form forms in mainPanel.Controls)
            {
                forms.Close();
            }
        }
        #endregion

        #region internal

        internal void logout()
        {
            DataLoad dl = new DataLoad();
            dl.Logout(UserID);
            UserID = 0;
        }

        internal void RemoveLogin()
        {
            mainPanel.Controls.Clear();

        }

        void mainPanel_ControlRemoved(object sender, ControlEventArgs e)
        {

            mainPanel.ControlRemoved -= mainPanel_ControlRemoved;
        }

        

        #endregion




    }
}
