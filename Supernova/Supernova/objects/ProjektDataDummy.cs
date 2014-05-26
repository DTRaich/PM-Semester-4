using Supernova.data;
using Supernova.Sub_Forms.General;
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
        public DataTable budgetCapa;


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
        public double costsyear1, costyear2, costyeae3;
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
        public int techleader;
        public int wachstum;
        public int mitarbeiter;
        public int Prozess;
        public int Kunde;
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
            budgetCapa = null;
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
            bool retval = true;
            
            DataLoad dl = new DataLoad();
            DataSet projektDataSet = dl.loadWholeProjectData(id);

            if (projektDataSet.Tables[1].Rows.Count > 0)
            {
                ProjectID = id;
                extractProjektData(projektDataSet);
               
            }else
            {
                retval = false;
            }


            return retval;
        }

        private void extractProjektData(DataSet projektDataSet)
        {
            extractbasis(projektDataSet.Tables[0]);
            extractRisks(projektDataSet.Tables[1]);
            extractStrategie(projektDataSet.Tables[2]);
            extractDivCrit(projektDataSet.Tables[3]);
            extractNeedDep(projektDataSet.Tables[4]);
            extractBudget(projektDataSet.Tables[5]);

        }

        private void extractBudget(DataTable budget)
        {
            foreach (DataRow dr in budget.Rows)
            {
               costsyear1 = Convert.ToDouble(dr[0]);
               costyear2 =  Convert.ToDouble(dr[1]);
               costyeae3 =  Convert.ToDouble(dr[2]);

            }
        }

        private void extractNeedDep(DataTable depcapa)
        {
            foreach (DataRow originRow in departmentCapa.Rows)
            {

                foreach (DataRow dr in depcapa.Rows)
                {
                    if(originRow[0].ToString().Equals(dr[0].ToString()))
                    {
                        originRow[2] = dr[1];
                        originRow[3] = dr[2];
                        originRow[4] = dr[3];

                    }
                }
            }
        }

        private void extractDivCrit(DataTable divcrit)
        {
            foreach (DataRow dr in divcrit.Rows)
            {
                if (dr[0].ToString().Contains("auer"))
                {
                    ProjectDuration = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
                if (dr[0].ToString().Contains("ategorie"))
                {
                    ProjectCategory  =  Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
                if (dr[0].ToString().Contains("mtkosten"))
                {
                    GesamtKosten  = Convert.ToDouble(dr["PTC_ORIGINALVALUE"]);
                }
                if (dr[0].ToString().Contains("NPV"))
                {
                   NPV =  Convert.ToDouble(dr["PTC_ORIGINALVALUE"]);

                }
                if (dr[0].ToString().Contains("arket"))
                {
                   TimeToMarket =  Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
            }
        }

        private void extractStrategie(DataTable strategie)
        {
            foreach (DataRow dr in strategie.Rows)
            {
                if (dr[0].ToString().Contains("echn"))
                {
                    techleader = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
                if (dr[0].ToString().Contains("undenz"))
                {
                    Kunde = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
                if (dr[0].ToString().Contains("achstum"))
                {
                    wachstum = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
                if (dr[0].ToString().Contains("rozess"))
                {
                    Prozess = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);

                }
                if (dr[0].ToString().Contains("arbeiter"))
                {
                    mitarbeiter = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
            }
        }

        private void extractRisks(DataTable risiko)
        {
            foreach (DataRow dr in risiko.Rows)
            {
                if (dr[0].ToString().Contains("echn"))
                {
                    technicalRisk = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]); 
                }
                if (dr[0].ToString().Contains("uali"))
                {
                    qualityRisk = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]); 
                }
                if (dr[0].ToString().Contains("cher"))
                {
                    securityRisk = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]); 
                }
                if (dr[0].ToString().Contains("anziel"))
                {
                    financialRisk = Convert.ToInt32(dr["PTC_ORIGINALVALUE"]);
                }
            }
        }

        private void extractbasis(DataTable basisdaten)
        {
            foreach (DataRow dr in basisdaten.Rows)
            {
                ProjectName = dr[1].ToString();
                ProjectDescription = dr[2].ToString();
                ProjectLeader = Convert.ToInt32(dr[3]);
                ProjectStartDate = Convert.ToDateTime(dr[4]);
                ProjectEndDate = Convert.ToDateTime(dr[5]);;
                ProjectCategory = Convert.ToInt32(dr[8]); 

            }
        }
        #endregion

        #region save
        public bool saveProjectDataToDb()
        {
            List<string> basisData = collectBasisData();
            List<double> budgetList = collectBudgetList();
           // Kriterien
            DataSet CriteriaDataset = collectCriteriaDataset();
            CriteriaDataset.AcceptChanges();
            // speichern
            bool ergebenis = ds.SaveorUpdateProject(basisData, CriteriaDataset, departmentCapa, budgetList);



           return ergebenis;      
        }
    
        #region collecting
        private List<double> collectBudgetList()
        {
            List<double> li = new List<double>();
            li.Add(costsyear1);
            li.Add(costyear2);
            li.Add(costyeae3);

            return li;
        }
        private DataSet collectCriteriaDataset()
        {
            DataSet ds = new DataSet();
            collectRiskSaving();
            collectStrategieSaving();
            collectDivCriteria();
            ds.Tables.Add(risks);
            ds.Tables.Add(strategie);
            ds.Tables.Add(divCriterias);
            ds.AcceptChanges();
            return ds;
            
        }

        private void collectDivCriteria()
        {
            foreach (DataRow dr in divCriterias.Rows)
            {
                if (dr[1].ToString().Contains("auer"))
                {
                    dr["Value"] = ProjectDuration;
                }
                if (dr[1].ToString().Contains("ategorie"))
                {
                    dr["Value"] = ProjectCategory;
                }
                if (dr[1].ToString().Contains("mtkosten"))
                {
                    dr["Value"] = GesamtKosten;
                }
                if (dr[1].ToString().Contains("NPV"))
                {
                    dr["Value"] = NPV;

                }
                if (dr[1].ToString().Contains("arket"))
                {
                    dr["Value"] = TimeToMarket;
                }
            }
            divCriterias.AcceptChanges();
        }

        private void collectStrategieSaving()
        {
            foreach (DataRow dr in strategie.Rows)
            {
                if (dr[1].ToString().Contains("echn"))
                {
                    dr["Value"] = techleader;
                }
                if (dr[1].ToString().Contains("undenz"))
                {
                    dr["Value"] = Kunde;
                }
                if (dr[1].ToString().Contains("achstum"))
                {
                    dr["Value"] = wachstum;
                }
                if (dr[1].ToString().Contains("rozess"))
                {
                    dr["Value"] = Prozess;

                }
                if (dr[1].ToString().Contains("arbeiter"))
                {
                    dr["Value"] = mitarbeiter;
                }
            }
            strategie.AcceptChanges();
        }

        private void collectRiskSaving()
        {
            foreach (DataRow dr in risks.Rows)
            {
                if(dr[1].ToString().Contains("echn"))
                {
                    dr["Value"] = technicalRisk;
                }
                if (dr[1].ToString().Contains("uali"))
                {
                    dr["Value"] = qualityRisk;
                }
                if (dr[1].ToString().Contains("cher"))
                {
                    dr["Value"] = securityRisk;
                }
                if (dr[1].ToString().Contains("anziel"))
                {
                    dr["Value"] = financialRisk;
                }
            }
            risks.AcceptChanges();
        }

        private List<string> collectBasisData()
        {
            List<string> basisData = new List<string>();
            //basisdaten
            basisData.Add(ProjectID.ToString());
            basisData.Add(ProjectName);
            basisData.Add(ProjectDescription);
            basisData.Add(ProjectLeader.ToString());
           string  startstring = ProjectStartDate.Year+"-"+ProjectStartDate.Month+"-"+ProjectStartDate.Day;
           string endstring = ProjectEndDate.Year + "-" + ProjectEndDate.Month + "-" + ProjectEndDate.Day;
            basisData.Add(startstring);
            basisData.Add(endstring);          
            basisData.Add(CreatedBY.ToString());
            basisData.Add(ProjectCategory.ToString());

            return basisData;
        }

        #endregion

        #endregion
    }
}
