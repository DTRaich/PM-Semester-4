using Supernova.helper;
using Supernova.interfaces;
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
           CapaSource = projektdaten.AbteilungsKapazitaet;
           OriginalSource = CapaSource.Copy();
           capaGrid.DataSource = CapaSource;
           capaGrid.Columns[0].Visible = false;
           capaGrid.Columns[1].ReadOnly = true;



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
                    projektdaten.AbteilungsKapazitaet = null;
                    projektdaten.AbteilungsKapazitaet = differenze;

                }
                
            }
            else
            {
                //
            }

            return retval;

        }

        private bool AllNull()
        {
            bool retval = true;

            foreach (DataRow dr in CapaSource.Rows)
            {
                if (dr.ToString().Equals("0"))
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
            }
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
