using Supernova.data;
using Supernova.helper;
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
        DataTable activationSource = new DataTable();
        DataTable originActivation;
        #endregion
        public FrmCriteriaWeight()
        {
            
            InitializeComponent();
            StartPrepares();
            
            //activationGrid.DataSource = dl.loadtest();
            //DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            //List<int> li = new List<int>();
            //li.Add(1);
            //li.Add(2);
            //li.Add(3);
            //comboBoxColumn.DataSource = li;

            //comboBoxColumn.ValueType = typeof(int);
            //activationGrid.Columns.Add(comboBoxColumn);
          
        }

        private void StartPrepares()
        {
            criteriaWeightDataSet = loader.LoadCriteriaWeightDataSet();
            prepareWeightMatrix();
            prepareActivation();
        }

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

                originActivation = activationSource.Copy();
               
            }
            catch (Exception ex)
            {
            }

        }

        private void prepareWeightMatrix()
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            DataTable differenz  = parahelp.CompareTables(originActivation,activationSource);

            if (differenz.Rows.Count > 0)
            {
                saver.saveCriteriaActivation(differenz);
            }
            

            StartPrepares();
	    }
        
     
    }
}
