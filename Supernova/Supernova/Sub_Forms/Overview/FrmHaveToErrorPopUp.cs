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

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmHaveToErrorPopUp : Form
    {
        private DataTable val;
        private DataTable valOrigin;

        int clickedProjektS;
        public FrmHaveToErrorPopUp()
        {
            InitializeComponent();
        }

        public FrmHaveToErrorPopUp(DataTable val, int clickedProjekt)
        {
           InitializeComponent();
           this.val = val;
           PrepareGrid();
           clickedProjektS = clickedProjekt;
        }

        private void PrepareGrid()
        {
            val.Columns.Add("Muss-Projekt", System.Type.GetType("System.Boolean"));

            foreach (DataRow dataRow in val.Rows)
            {
                if (dataRow["Muss_Projekt"].ToString().Equals("1"))
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
            valOrigin =  val.Copy();
            errorGrid.Columns[0].Visible = false;
            errorGrid.Columns["Muss_Projekt"].Visible = false;


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

      

        private void button1_Click(object sender, EventArgs e)
        {
            revertDesision(clickedProjektS);
            this.Close();

        }

        private void revertDesision(int id)
        {
            ValidationData vl = new ValidationData();

            try
            {
                
                DataTable dt = vl.SaveAndValidateHaveTo(id, 0);
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

        private void FrmHaveToErrorPopUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            revertDesision(clickedProjektS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParameterHelper pm = new ParameterHelper();
            DataTable Differenz = pm.CompareTables(valOrigin, val);

            if (Differenz.Rows.Count < 1)
            {
                FrmAfirmative frm = new FrmAfirmative("Fehler\nKeine Ändrungen erkannt",'e');
                frm.ShowDialog();
            }
            else
            {
            }

            revertDesision(1);
        }
   
    
    }
}
