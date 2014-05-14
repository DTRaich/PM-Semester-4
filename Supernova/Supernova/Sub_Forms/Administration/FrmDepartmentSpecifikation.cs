using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;
using Supernova.Sub_Forms.General;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmDepartmentSpecifikation : Form
    {
        DataTable depComboTab;
        DataTable depDataTab;
        int currentid = 0;
        
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
            currentid = Convert.ToInt32(cbDepartments.SelectedValue);
            depDataTab = loader.LoadDepartmenntCapacity(currentid);
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
            mtbBudget1.Text = string.Empty;
            mtbBudget2.Text = string.Empty;
            mtbBudget3.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int budget1 = Convert.ToInt32(mtbBudget1.Text);
                int budget2 = Convert.ToInt32(mtbBudget2.Text);
                int budget3 = Convert.ToInt32(mtbBudget3.Text);
                if (saver.SaveDepCapa(currentid, budget1, budget2, budget3))
                {
                    FrmAfirmative dataSaved = new FrmAfirmative("Die Daten wurden erfolgreich gespeichert", 'i');
                    dataSaved.ShowDialog();
                }
                else
                {
                    FrmAfirmative dataSaved = new FrmAfirmative("Daten konnten nicht gespeichert werden. \n Bitte wenden Sie sich an den Administrator.", 'e');
                    dataSaved.ShowDialog();
                }

            }
            catch(Exception ex)  
            {
                FrmAfirmative dataSaved = new FrmAfirmative("Bitte alle Felder ausfüllen.", 'e');
                dataSaved.ShowDialog();
            }
        }

        private void btnloadDepartment_Click(object sender, EventArgs e)
        {
            prepareFields();
        }



    }
}
