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
    public partial class FrmBasisData : Form,ICriteriaChecking
    {
        private objects.ProjektDataDummy projektdaten;

        public FrmBasisData()
        {
            InitializeComponent();
        }

        public FrmBasisData(ref objects.ProjektDataDummy projektdaten)
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
            if (tbProjectName.Text == "" || tbShortDescription.Text == "")
            {
                return false;
            }

            return true;
        }

        private void collectData()
        {
            projektdaten.ProjectName = tbProjectName.Text;
            projektdaten.ProjectDescription = tbShortDescription.Text;
            projektdaten.ProjectLeader = (int) cbProjectLeader.SelectedValue;
            projektdaten.ProjectCategory = (int) cbProjectCategory.SelectedValue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // dummy method to test if github works as expected
        private void testIfGithubWorksAsExpected()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
