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
        #region fields 
        public int ProjectID = 0;

        #region basisdaten
        public int lala;
        public string lalaknl;
        #endregion
        #region costTime

        #endregion
        #region Risk

        #endregion
        #region Strategie

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
            DataSet projektData = collectProjectData();
            bool savingWorked = false;

            if (ProjectID == 0)
            {
                savingWorked = ds.SaveNewProject(projektData);
            }
            else
            {
                savingWorked = ds.UpdateProject(ProjectID, projektData);
            }

            return savingWorked;      
        }
     
        #region extraxtAndCollect
        private DataSet collectProjectData()
        {
            return null;
        }
        private void extractProjektData(DataSet projektDataSet)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
