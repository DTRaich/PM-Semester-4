using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmDepartmentSpecifikation : Form
    {
        DataTable departments;

        public FrmDepartmentSpecifikation(int userid)
        {
            InitializeComponent();
            prepareBoxes();
        }

        private void prepareBoxes()
        {
            ParameterLoad pl = new ParameterLoad();
            departments = pl.loadDeparments();
           
            cbDepartments.DataSource = departments;
            cbDepartments.ValueMember = "DEPARTMENTS_ID";
            cbDepartments.DisplayMember = "D_NAME";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }



    }
}
