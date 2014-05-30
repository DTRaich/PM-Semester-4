using Supernova.data;
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
    public partial class FrmGeneralAnalysis : Form
    {
        ParameterLoad pl = new ParameterLoad();
        DataTable depComboTab;
        DataTable depDataTab;
        DataLoad loader = new DataLoad();
        int currentid = 0;

        public FrmGeneralAnalysis()
        {
            InitializeComponent();
            
            fillcboDepartment();
        }

        private void fillcboDepartment()
        {
            depComboTab = pl.loadDeparments();

            cboDepartment.DataSource = depComboTab;
            cboDepartment.ValueMember = "DEPARTMENTS_ID";
            cboDepartment.DisplayMember = "D_NAME";
        }

        private void btnLoadDep_Click(object sender, EventArgs e)
        {
            LoadDepartmentStatistic();
        }

        private void LoadDepartmentStatistic()
        {
            currentid = Convert.ToInt32(cboDepartment.SelectedValue);
            depDataTab = loader.LoadDepartmenntCapacity(currentid);


        }

    }
}
