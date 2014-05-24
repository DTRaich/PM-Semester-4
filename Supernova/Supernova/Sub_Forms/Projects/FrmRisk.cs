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

            if (projektdaten.ProjectID != 0)
            {
                fillAllBoxes();
            }
        }

        private void fillAllBoxes()
        {
            tbTechnicalRisk.Value = projektdaten.technicalRisk;
            tbFinancialRisk.Value = projektdaten.financialRisk;
            tbSecurityRisk.Value = projektdaten.securityRisk;
            tbQualityRisk.Value = projektdaten.qualityRisk;
        }

        public bool checkAndValidateForm()
        {
            collectData();
            return true;
        }

        private void collectData()
        {
            projektdaten.technicalRisk = tbTechnicalRisk.Value;
            projektdaten.financialRisk = tbFinancialRisk.Value;
            projektdaten.securityRisk = tbSecurityRisk.Value;
            projektdaten.qualityRisk = tbQualityRisk.Value;
        }

        private void tbTechnicalRisk_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = tbTechnicalRisk.Value.ToString();
        }

        private void tbFinancialRisk_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = tbFinancialRisk.Value.ToString();
        }

        private void tbSecurityRisk_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = tbSecurityRisk.Value.ToString();
        }

        private void tbQualityRisk_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = tbQualityRisk.Value.ToString();
        }
    }
}
