using Supernova.data;
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
        private DataTable kategorie;
        private DataTable projektleiter;

        public FrmBasisData()
        {
            InitializeComponent();
        }

        public FrmBasisData(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            this.projektdaten = projektdaten;
            loadBoxes();

            if (projektdaten.ProjectID != 0)
            {
                fillAllBoxes();
            }
        }

        private void fillAllBoxes()
        {
            tbProjectName.Text = projektdaten.ProjectName;
            tbShortDescription.Text = projektdaten.ProjectDescription;
            cbProjectLeader.SelectedValue = projektdaten.ProjectLeader;
            cbProjectCategory.SelectedValue = projektdaten.ProjectCategory;
        }

        private void loadBoxes()
        {
            ParameterLoad pl = new ParameterLoad();
            kategorie = pl.loadProjectKategorie();
            projektleiter = pl.loadProjectLeader();
            cbProjectCategory.DataSource = kategorie;
            cbProjectLeader.DataSource = projektleiter;
            cbProjectCategory.ValueMember = "PC_ID";
            cbProjectCategory.DisplayMember = "PC_NAME";
            cbProjectLeader.ValueMember = "USER_ID";
            cbProjectLeader.DisplayMember = "U_NAME";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
