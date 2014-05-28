using Supernova.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmHaveToErrorPopUp : Form
    {
        private DataTable val;

        public FrmHaveToErrorPopUp()
        {
            InitializeComponent();
        }

        public FrmHaveToErrorPopUp(DataTable val)
        {
           this.val = val;
           PrepareGrid();
           Leader l = Leader.getLeaderInst();        
        }

        private void PrepareGrid()
        {
            val.Columns.Add("Muss-Projekt", System.Type.GetType("System.Boolean"));

            foreach (DataRow dataRow in val.Rows)
            {
                if (dataRow["P_HaveTo"].ToString().Equals("1"))
                {
                    dataRow["Muss-Projekt"] = true;
                }
                else
                {
                    dataRow["Muss-Projekt"] = false;
                }
            }
            val.AcceptChanges();

            errorGrid.DataSource = val;
            errorGrid.Columns["P_HaveTo"].Visible = false;

            foreach (DataGridViewColumn col in errorGrid.Columns)
            {
                if (col.HeaderText == "Muss-Projekt")
                {
                    col.ReadOnly = false;
                }
                else
                {
                    col.ReadOnly = true;
                }

            }
        }

        private void errorGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ValidationData vl = new ValidationData();

            try
            {
                int currentId = Convert.ToInt32(errorGrid[0,e.RowIndex].Value);
                DataTable dt = vl.SaveAndValidateHaveTo(currentId,0);
                if (dt.Rows.Count > 0)
                {
                    val = null;
                    val = new DataTable();
                    val = dt.Copy();
                    PrepareGrid();
                }
                else
                {
                    Leader lead = Leader.getLeaderInst();
                    lead.LoadProjektView();

                }
            }
            catch (Exception ex)
            {

            }
                
        }
   
    
    }
}
