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
            tbTechnicalRisk.Value = 10-projektdaten.technicalRisk;
            tbFinancialRisk.Value = 10 - projektdaten.financialRisk;
            tbSecurityRisk.Value = 10- projektdaten.securityRisk;
            tbQualityRisk.Value = 10- projektdaten.qualityRisk;
            textBox1.Text = Convert.ToString(10 - projektdaten.technicalRisk);
            textBox2.Text = Convert.ToString(10 - projektdaten.financialRisk);
            textBox3.Text = Convert.ToString(10 - projektdaten.securityRisk);
            textBox4.Text = Convert.ToString(10 - projektdaten.qualityRisk);
        }

        public bool checkAndValidateForm()
        {
            collectData();
            return true;
        }

        private void collectData()
        {
            projektdaten.technicalRisk = 10 - tbTechnicalRisk.Value;
            projektdaten.financialRisk = 10 - tbFinancialRisk.Value;
            projektdaten.securityRisk = 10- tbSecurityRisk.Value;
            projektdaten.qualityRisk = 10- tbQualityRisk.Value;
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
