using Supernova.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.objects
{
    public class ProjektDataDummy
    {
        DataSave ds = new DataSave();
        DataLoad load = new DataLoad();
        DataSet projektDataSet;
         
        #region fields 

        #region basisdaten
        public int ProjectID = 0;
        public string ProjectName;
        public string ProjectDescription;
        public int ProjectLeader;
        public int ProjectCategory;
        public bool HaveTo;
        #endregion

        #region costTime
        public int ProjectDuration;
        public DateTime ProjectStartDate;
        public DateTime ProjectEndDate;
        public double GesamtKosten;
        public double NPV;
        public int TimeToMarket;
        #endregion

        #region Risk
        public int technicalRisk;
        public int financialRisk;
        public int securityRisk;
        public int qualityRisk;
        #endregion

        #region Strategie
        public int frage1;
        public int frage2;
        public int frage3;
        public int frage4;
        public int frage5;
        #endregion

        #region Ressourcen
        public DataTable AbteilungsKapazitaet;
        #endregion

        #endregion

        public ProjektDataDummy()
        {            
        }

        public bool loadProjectdataintoDummy(int id)
        {
            bool saveworked = false;
            ProjectID = id;
            DataLoad dl = new DataLoad();
            DataSet projektDataSet = dl.loadWholeProjectData(ProjectID);

            if (projektDataSet.Tables[1].Rows.Count > 0)
            {
                extractProjektData(projektDataSet);
                saveworked = true;
            }
            

            return saveworked;
        }

       


        public bool saveProjectDataToDb()
        {
            // user speichern
            
            bool savingWorked = false;                       
            savingWorked = ds.SaveorUpdateProject(this);
            

            return savingWorked;      
        }
     
        #region extraxtAndCollect
        
        private void extractProjektData(DataSet projektDataSet)
        {
            
        }
        #endregion
    }
}
