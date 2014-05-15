﻿using Supernova.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.objects
{
    public class ProjektDataDummy
    {
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
        #endregion

        #region Risk
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
            DataSave ds = new DataSave();
            bool savingWorked = false;                       
            savingWorked = ds.SaveorUpdateProject(this);
            

            return savingWorked;      
        }
     
        #region extraxtAndCollect
        
        private void extractProjektData(DataSet projektDataSet)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
