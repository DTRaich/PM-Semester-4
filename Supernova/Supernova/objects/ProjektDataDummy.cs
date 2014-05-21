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
        ParameterLoad pl = new ParameterLoad();

        public DataTable risks;
        public DataTable strategie;
        public DataTable departmentCapa;
        public DataTable divCriterias;

        #region fields 

        #region basisdaten
        public int ProjectID = 0;
        public string ProjectName;
        public string ProjectDescription;
        public int ProjectLeader;
        public int ProjectCategory;
        public int CreatedBY;

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

        

        #endregion

        public ProjektDataDummy()
        {
            resetAllTabels();
            prepareTables();          
        }

       

        #region TabelPreparation
        private void resetAllTabels()
        {
            risks = null;
            strategie = null;
            departmentCapa = null;
            divCriterias = null;
        }
        private void prepareTables()
        {          
            prepareCapazitytable();
            prepareRiskTabel();
            prepareStrategieTabel();
            prepareDivCriterias();
        }

        private void prepareStrategieTabel()
        {
            DataTable dt = pl.loadStrategies();
            DataColumn dc = new DataColumn("Value");
            dt.Columns.Add(dc);
            foreach (DataRow dr in dt.Rows)
            {
                dr[2] = 0;
            }
            dt.AcceptChanges();
            strategie = dt;
            strategie.AcceptChanges();
        }

        private void prepareDivCriterias()
        {
            DataTable dt = pl.loadDivCriterias();
            DataColumn dc = new DataColumn("Value");
            dt.Columns.Add(dc);
            foreach (DataRow dr in dt.Rows)
            {
                dr[2] = 0;
            }
            dt.AcceptChanges();
            divCriterias = dt;
            divCriterias.AcceptChanges();
        }

        private void prepareRiskTabel()
        {
            DataTable dt = pl.loadRisks();
            DataColumn dc = new DataColumn("Value");            
            dt.Columns.Add(dc);           
            foreach (DataRow dr in dt.Rows)
            {
                dr[2] = 0;
                
            }
            dt.AcceptChanges();
            risks = dt;
            risks.AcceptChanges();
        }

        private void prepareCapazitytable()
        {
            DataTable dt = pl.loadDeparments();
            DataColumn dc  = new DataColumn("MT in Jahr 1");
            DataColumn dc2 = new DataColumn("MT in Jahr 2");
            DataColumn dc3 = new DataColumn("MT in Jahr 3");
            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);           
            foreach (DataRow dr in dt.Rows)
            {
                dr[2] = 0;
                dr[3] = 0;
                dr[4] = 0;
            }
            dt.AcceptChanges();
            departmentCapa = dt;
            departmentCapa.AcceptChanges();
        }
        #endregion

        #region load
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
        private void extractProjektData(DataSet projektDataSet)
        {

        }
        #endregion

        #region save
        public bool saveProjectDataToDb()
        {
            // user speichern
            List<string> basisData = collectBasisData();  //new List<string>();
            //basisdaten
            basisData.Add(ProjectID.ToString());
            basisData.Add(ProjectName);
            basisData.Add(ProjectDescription);
            basisData.Add(ProjectStartDate.ToShortDateString());
            basisData.Add(ProjectEndDate.ToShortDateString());
            basisData.Add(ProjectLeader.ToString());
            basisData.Add(CreatedBY.ToString());
            basisData.Add(ProjectCategory.ToString()); 
           // Kriterien
            DataSet CriteriaDataset = collectCriteriaDataset();
           

            // speichern
            bool ergebenis = ds.SaveorUpdateProject(basisData, CriteriaDataset,departmentCapa);



           return ergebenis;      
        }

        private DataSet collectCriteriaDataset()
        {
            throw new NotImplementedException();
        }

        private List<string> collectBasisData()
        {
            throw new NotImplementedException();
        }


           
        #endregion
    }
}
