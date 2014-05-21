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
    public partial class FrmRisk : Form,ICriteriaChecking
    {
        private objects.ProjektDataDummy projektdaten;

        public FrmRisk()
        {
            InitializeComponent();
        }

        public FrmRisk(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            this.projektdaten = projektdaten;
        }

        public bool checkAndValidateForm()
        {
            collectData();
            return true;
        }

        private void collectData()
        {
            projektdaten.technicalRisk = tbTechRisk.Value;
            projektdaten.financialRisk = tbFinancialRisk.Value;
            projektdaten.securityRisk = tbSecurityRisk.Value;
            projektdaten.qualityRisk = tbQualityRisk.Value;
        }
    }
}
