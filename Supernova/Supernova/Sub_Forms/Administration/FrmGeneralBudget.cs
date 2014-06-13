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
using Supernova.Sub_Forms.Overview;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmGeneralBudget : Form
    {       int budgetid = 0;
        public FrmGeneralBudget()
        {
            
            InitializeComponent();
            prepareBoxes();
        }

        private void prepareBoxes()
        {
            DataTable budget = new DataTable();
            DataLoad loader = new DataLoad();

            budget = loader.LoadBudget();
            
            string b1 = budget.Rows[0][1].ToString();
            string b2 = budget.Rows[0][2].ToString();
            string b3 = budget.Rows[0][3].ToString();


            mtbBudget1.Text = String.Format("{0,13:0.00}", b1);
            mtbBudget2.Text = String.Format("{0,13:0.00}", b2);
            mtbBudget3.Text = String.Format("{0,13:0.00}", b3);

            budgetid = Convert.ToInt32(budget.Rows[0][0]);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mtbBudget1.Text = string.Empty;
            mtbBudget2.Text = string.Empty;
            mtbBudget3.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSave saver = new DataSave();
            try
            {

                double budget1 = Convert.ToDouble(mtbBudget1.Text);
                double budget2 = Convert.ToDouble(mtbBudget2.Text);
                double budget3 = Convert.ToDouble(mtbBudget3.Text);

                saver.SaveBudget(budgetid, budget1, budget2, budget3);
                //----
                DataLoad dl = new DataLoad();

                DataTable val = dl.LoadGenerealOverview();

                if (val.Columns.Count == 8)
                {
                    FrmHaveToErrorPopUp errorHave = new FrmHaveToErrorPopUp(val, -1);
                    errorHave.StartPosition = FormStartPosition.CenterParent;
                    errorHave.ShowDialog();
                }
                else
                {
                    //---
                    FrmAfirmative saved = new FrmAfirmative("Das Jahresbudget wurde gespeichert.", 'i');
                    saved.ShowDialog();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(" Bitte die Zahl rechsbündig formatieren");
            }
           
           
        }
    }
}
