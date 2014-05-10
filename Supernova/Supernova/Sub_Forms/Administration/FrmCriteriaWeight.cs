using Supernova.data;
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
        DataLoad loader = new DataLoad();
        DataSet criteriaWeightDataSet;
        DataTable activationSource = new DataTable();        

        public FrmCriteriaWeight()
        {
            
            InitializeComponent();
            criteriaWeightDataSet = loader.LoadCriteriaWeightDataSet();
            prepareWeightMatrix();
            prepareActivation();
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

        private void prepareActivation()
        {
            try
            {
                activationSource = criteriaWeightDataSet.Tables["Criterias"];
                activationGrid.DataSource = activationSource;
                DataGridViewCheckBoxColumn activator = new DataGridViewCheckBoxColumn();
                activator.TrueValue = true;
                activator.FalseValue = false;

                activationGrid.Columns.Add(activator);
                activationGrid.Columns[0].Visible = false;
                activationGrid.Columns[2].Visible = false;
                activationGrid.Columns[1].HeaderText = "Kriterium";
                activationGrid.Columns[3].HeaderText = "Aktiv";

                activationGrid.ReadOnly = false;

                foreach (DataGridViewRow row in activationGrid.Rows)
                {
                    row.Cells[3].Value = true;
                    row.Cells[3].GetType();
                    object value = row.Cells[3].Value;
                }

                   
                    //     row.Cells[3].Value = true;                         
                    //}
                    //else
                    //{
                    //    row.Cells[3].Value = false;

                    //}

                
                activationGrid.EndEdit();
                
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
            foreach (DataGridViewRow dr in activationGrid.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    object dsd = dc.Value;
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow dr in activationGrid.Rows)
        //    {
        //        foreach (DataGridViewCell dc in dr.Cells)
        //        {
        //            object dsd = dc.Value;
        //        }
        //    }
        //}
    }
}
