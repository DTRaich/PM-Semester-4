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
    public partial class FrmCostTime : Form, ICriteriaChecking
    {
        private objects.ProjektDataDummy projektdaten;

        public FrmCostTime()
        {
            InitializeComponent();
        }

        public FrmCostTime(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            this.projektdaten = projektdaten;
        }

        public bool checkAndValidateForm()
        {
            collectData();
            return validateData();
        }

        private bool validateData()
        {
            if (dtStartDate.Value >= dtEndDate.Value)
            {
                return false;
            }

            return true;
        }

        private void collectData()
        {
            projektdaten.ProjectStartDate = dtStartDate.Value;
            projektdaten.ProjectEndDate = dtEndDate.Value;
            projektdaten.GesamtKosten = Convert.ToDouble(mtbTotalCost.Text);
            projektdaten.NPV = Convert.ToDouble(mtbTotalCost.Text);
            projektdaten.TimeToMarket = (int) nupTimeToMarket.Value;
        }
    }
}
