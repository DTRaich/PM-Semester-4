using Supernova.data;
using Supernova.helper;
using Supernova.Sub_Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmCriteriaWeight : Form
    {
        #region fields
        DataLoad loader = new DataLoad();
        ParameterHelper parahelp = new ParameterHelper();
        DataSave saver = new DataSave();

        DataSet criteriaWeightDataSet;

        DataTable activationSource;
        DataTable originActivation;

        DataTable weightSource;
        DataTable originWeight;

        #endregion

        public FrmCriteriaWeight()
        {
            
            InitializeComponent();
            StartPrepares(); 
        }

        private void StartPrepares()
        {
            criteriaWeightDataSet = loader.LoadCriteriaWeightDataSet();
            if (criteriaWeightDataSet.Tables[0].Rows.Count > 0)
            {
                prepareWeightMatrix();
                prepareActivation();
            }
            else
            {
                FrmAfirmative dberror = new FrmAfirmative("Keine Daten gefunden \n Bitte wenden Sie sich an den Administrator", 'e');
                dberror.ShowDialog();
            }
           
        }
       
        #region events

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable differenz = parahelp.CompareTables(originActivation, activationSource);

            if (differenz.Rows.Count > 0)
            {
                if (saver.saveCriteriaActivation(differenz))
                {
                    FrmAfirmative SaveNewUser = new FrmAfirmative("Die Änderungen wurden gespeichert. \n ", 'i');
                    SaveNewUser.StartPosition = FormStartPosition.CenterParent;
                    SaveNewUser.ShowDialog();

                    StartPrepares();
                }
                else
                {
                    FrmAfirmative SaveNewUser = new FrmAfirmative("Speichern fehlgeschlagen. \n Bitte wenden sie sich an den Administrator", 'e');
                    SaveNewUser.StartPosition = FormStartPosition.CenterParent;
                    SaveNewUser.ShowDialog();
                }

            }
            else
            {
                FrmAfirmative noChanges = new FrmAfirmative("Keine Änderungen erkannt. \n ", 'i');
                noChanges.StartPosition = FormStartPosition.CenterParent;
                noChanges.ShowDialog();
            }



        }
        #endregion

        #region activation
        private void prepareActivation()
        {
            try
            {
                activationSource = criteriaWeightDataSet.Tables["Criterias"];
                activationSource.Columns.Add("Aktiv", System.Type.GetType("System.Boolean"));

                foreach (DataRow dataRow in activationSource.Rows)
                {
                    if (dataRow["C_ISACTIVE"].ToString().Equals("1"))
                    {
                        dataRow["Aktiv"] = true;
                    }
                    else
                    {
                        dataRow["Aktiv"] = false;
                    }
                }

                activationSource.AcceptChanges();
                activationGrid.DataSource = activationSource;
                activationGrid.Columns[0].Visible = false;
                activationGrid.Columns[2].Visible = false;
                activationGrid.Columns[1].HeaderText = "Kriterium";
                activationGrid.Columns[1].ReadOnly = true;
                activationGrid.ScrollBars = ScrollBars.Vertical;
                originActivation = activationSource.Copy();

            }
            catch (Exception ex)
            {
            }

        }

        #endregion

        #region Weight

        private void prepareWeightMatrix()
        {
            weightSource = defineTemplate();
            fillWeightSource();
            originWeight = weightSource.Copy();
            weightGrid.DataSource = weightSource;
            weightGrid.Columns[0].Visible = false;
            weightGrid.Columns[1].ReadOnly = true;
           // weightGrid.Columns[2].ValueType = System.Type.GetType("System.Int32");

        }

        private void fillWeightSource()
        {
            try
            {
                string currentCritID = "0";
                int columnCount = weightSource.Columns.Count;
                int row = 0;
                
                foreach (DataRow dr in weightSource.Rows)
                {
                    currentCritID = dr[0].ToString();
                    for(int i = 2; i < columnCount;i++)
                    {
                        dr[i] = criteriaWeightDataSet.Tables["ActiveCriteriasWeight"].Rows[row][2].ToString();
                        row = row + 1;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private DataTable defineTemplate()
        {
            DataTable dt = new DataTable();
            DataColumn dcID = new DataColumn("FromID");
            DataColumn dcKat = new DataColumn("Kategorie");

            // columns adden
            dt.Columns.Add(dcID);
            dt.Columns.Add(dcKat);

            DataColumn dc;
            foreach (DataRow dr in criteriaWeightDataSet.Tables["ActiveCriterias"].Rows)
            {
                dc = new DataColumn(dr[1].ToString());
                dc.DataType = System.Type.GetType("System.Int32");
                dt.Columns.Add(dc);
            }
           
            dt.AcceptChanges();

            // rows adden
            DataRow row;

            foreach (DataRow dr in criteriaWeightDataSet.Tables["ActiveCriterias"].Rows)
            {
                row = dt.NewRow();
                row[0] = dr[0].ToString();
                row[1] = dr[1].ToString();
                dt.Rows.Add(row);
            }
            dt.AcceptChanges();

            return dt;
        }
        #endregion

       

        
        
     
    }
}
