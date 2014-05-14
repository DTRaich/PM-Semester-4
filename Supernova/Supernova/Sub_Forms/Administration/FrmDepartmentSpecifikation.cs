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
        DataTable depComboTab;
        DataTable depDataTab;
        
        ParameterLoad pl = new ParameterLoad();
        DataLoad loader = new DataLoad();
        DataSave saver = new DataSave();

        public FrmDepartmentSpecifikation(int userid)
        {
            InitializeComponent();
            prepareBoxes();
            prepareFields();
        }

        private void prepareFields()
        {
            depDataTab = loader.LoadDepartmenntCapacity(Convert.ToInt32(cbDepartments.SelectedValue));
            foreach(DataRow rw in depDataTab.Rows)
            {
                try
                {
                    txtDepartmentChef.Text = rw["LEADER"].ToString();
                }
                catch (Exception ex)
                {
                    txtDepartmentChef.Text = string.Empty;
                }

                mtbBudget1.Text = rw["D_MANNTAGEBUDGET_YEAR1"].ToString();
                mtbBudget2.Text = rw["D_MANNTAGEBUDGET_YEAR2"].ToString();
                mtbBudget3.Text = rw["D_MANNTAGEBUDGET_YEAR3"].ToString();

      
            }
        }

        private void prepareBoxes()
        {

            depComboTab = pl.loadDeparments();

            cbDepartments.DataSource = depComboTab;
            cbDepartments.ValueMember = "DEPARTMENTS_ID";
            cbDepartments.DisplayMember = "D_NAME";

            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mtbBudget1.Text = string.Empty;
            mtbBudget2.Text = string.Empty;
            mtbBudget3.Text = string.Empty;
        }

        private void btnloadDepartment_Click(object sender, EventArgs e)
        {
            prepareFields();
        }



    }
}
