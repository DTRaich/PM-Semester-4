using Supernova.helper;
using Supernova.interfaces;
using Supernova.Sub_Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Projects
{
    public partial class FrmRessources : Form, ICriteriaChecking
    {
        private objects.ProjektDataDummy projektdaten;
        DataTable OriginalSource;
        DataTable CapaSource;
        ParameterHelper hl = new ParameterHelper();

        public FrmRessources()
        {
            InitializeComponent();
        }

        public FrmRessources(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            this.projektdaten = projektdaten;
            prepareGrid();
        }

        private void prepareGrid()
        {
           CapaSource = projektdaten.departmentCapa;
           OriginalSource = CapaSource.Copy();
           capaGrid.DataSource = CapaSource;
           capaGrid.Columns[0].Visible = false;
           capaGrid.Columns[1].ReadOnly = true;
           capaGrid.Columns[1].HeaderText = "Abteilung";

         
        }

        private void makeReadonly()
        {
            capaGrid.Columns[2].ReadOnly = true;
            capaGrid.Columns[3].ReadOnly = true;
            capaGrid.Columns[4].ReadOnly = true; 

            if (projektdaten.ProjectDuration <= 12)
            {
                capaGrid.Columns[2].ReadOnly = false;
            }
            else
            {
                if (projektdaten.ProjectDuration <= 24)
                {
                    capaGrid.Columns[2].ReadOnly = false;
                    capaGrid.Columns[3].ReadOnly = false; 
                }
                else
                {
                    capaGrid.Columns[2].ReadOnly = false;
                    capaGrid.Columns[3].ReadOnly = false; 
                    capaGrid.Columns[4].ReadOnly = false; 
                }
            }
        }

        public bool checkAndValidateForm()
        {
            bool retVal = true;
            retVal = CollecAndProofData();
            return retVal;
        }

        private bool CollecAndProofData()
        {
            bool retval = true;
            if (!AllNull())
            {
                DataTable differenze = hl.CompareTables(OriginalSource, CapaSource);

                if (differenze.Rows.Count > 0)
                {
                    projektdaten.departmentCapa = null;
                    projektdaten.departmentCapa = differenze;
                    projektdaten.departmentCapa.AcceptChanges();

                }
                
            }
            else
            {
                retval = false;
                FrmAfirmative frm = new FrmAfirmative("Bitte Ressourcen ausfüllen \n Es dürfen nicht alle Werte 0 sein",'e');
                frm.ShowDialog();
            }

            return retval;

        }

        private bool AllNull()
        {
            bool retval = true;
            int columnCount =  CapaSource.Columns.Count;
            foreach (DataRow dr in CapaSource.Rows)
            {
                
                    if (!dr[2].ToString().Equals("0"))
                    {
                        retval = false;
                    }
                if (!dr[3].ToString().Equals("0"))
                    {
                        retval = false;
                    }
                if (!dr[4].ToString().Equals("0"))
                    {
                        retval = false;
                    }
                 
            }
            return retval;
        }

        private void capaGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (capaGrid.CurrentCell.ColumnIndex != 1)
            {
                e.Control.KeyPress += Control_KeyPress;
                (e.Control as TextBox).MaxLength = 10;
            }
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void FrmRessources_VisibleChanged(object sender, EventArgs e)
        {
            makeReadonly();
        }

        private void FrmRessources_Shown(object sender, EventArgs e)
        {
            makeReadonly();
        }
    }
}
