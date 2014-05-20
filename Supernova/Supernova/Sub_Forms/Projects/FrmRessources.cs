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

        }

        public bool checkAndValidateForm()
        {
            bool retVal = true;

            return retVal;
        }
    }
}
