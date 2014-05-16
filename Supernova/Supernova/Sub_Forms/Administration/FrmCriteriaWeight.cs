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
        private void resetTables()
        {
            criteriaWeightDataSet = null;
            criteriaWeightDataSet = new DataSet();
            activationSource = null;
            activationSource = new DataTable();
            originWeight = null;
            originWeight = new DataTable();
            originActivation = null;
            originActivation = new DataTable();
            weightSource = null;
            weightSource = new DataTable();

            weightGrid.DataSource = null;
            activationGrid.DataSource = null;

            
        }
        private void StartPrepares()
        {
            resetTables();
            
            criteriaWeightDataSet = loader.LoadCriteriaWeightDataSet();
            if (criteriaWeightDataSet.Tables[0].Rows.Count > 0)
            {
                prepareWeightMatrix();
                prepareActivation();
                DisallowSortingBothGrids();
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

        private void FrmCriteriaWeight_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void weightGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (weightGrid.CurrentCell.ColumnIndex > 1)
            {
                e.Control.KeyPress += new KeyPressEventHandler(weightGrid_KeyPress);
            }

        }

        private void weightGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ('0' == e.KeyChar || '1' == e.KeyChar || '2' == e.KeyChar || '3' == e.KeyChar || '4' == e.KeyChar)
                {

                }
                else
                {
                    e.Handled = true;
                }
           
        }

        private void btnDiscardActive_Click(object sender, EventArgs e)
        {
            activationSource = originActivation.Copy();
            activationGrid.DataSource = activationSource;

        }

        private void btnSaveWeight_Click(object sender, EventArgs e)
        {
            DataTable differenz = parahelp.CompareTables(originWeight, weightSource);

            if (differenz.Rows.Count > 0)
            {
                DataTable toSave = generateTable(differenz);

                if (saver.saveCriteriaWeight(toSave))
                {
                    FrmAfirmative SaveNewUser = new FrmAfirmative("Die Änderungen wurden gespeichert. \n ", 'i');
                    SaveNewUser.StartPosition = FormStartPosition.CenterParent;
                    SaveNewUser.ShowDialog();
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

        
        private void btnDiscardWeight_Click(object sender, EventArgs e)
        {
            weightSource = originWeight.Copy();
            weightGrid.DataSource = weightSource;
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

        private DataTable generateTable(DataTable toSave)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("From"));
            dt.Columns.Add(new DataColumn("To"));
            dt.Columns.Add(new DataColumn("Points"));
            DataRow newRow;

            int columCount = toSave.Columns.Count;
            foreach (DataRow dr in toSave.Rows)
            {
                for (int i = 2; i < columCount; i++)
                {
                    newRow = dt.NewRow();
                    newRow[0] = dr[0].ToString();
                    newRow[1] = getToID(i);
                    newRow[2] = dr[i].ToString();
                    dt.Rows.Add(newRow);
                }
                
            }

            return dt;
        }

        private object getToID(int i)
        {
            object id = criteriaWeightDataSet.Tables["ActiveCriterias"].Rows[i-2][0].ToString();         
            

            return id;
        }



        private void prepareWeightMatrix()
        {
            weightSource = defineTemplate();
            fillWeightSource();
            originWeight = weightSource.Copy();
            weightGrid.DataSource = weightSource;
            weightGrid.Columns[0].Visible = false;
            weightGrid.Columns[1].ReadOnly = true;
        }

        private void fillWeightSource()
        {
            try
            {
                int columnCount = weightSource.Columns.Count;
                int row = 0;
                foreach (DataRow dr in weightSource.Rows)
                {
                    
                    for (int i = 2; i < columnCount; i++)
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

        #region both

        private void DisallowSortingBothGrids()
        {
            for (int i = 0; i < weightGrid.Columns.Count; i++)
            {
                weightGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;        
            }

            for (int i = 0; i < activationGrid.Columns.Count; i++)
            {
                activationGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion





    }
}
