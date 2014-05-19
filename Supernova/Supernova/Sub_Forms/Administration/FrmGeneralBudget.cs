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

            mtbBudget1.Text = Convert.ToDecimal(budget.Rows[0][1]).ToString();
            mtbBudget2.Text = Convert.ToDecimal(budget.Rows[0][2]).ToString();
            mtbBudget3.Text = Convert.ToDecimal(budget.Rows[0][3]).ToString();

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

            int budget1 = Convert.ToInt32(mtbBudget1.Text);
            int budget2 = Convert.ToInt32(mtbBudget2.Text);
            int budget3 = Convert.ToInt32(mtbBudget3.Text);

            saver.SaveBudget(budgetid, budget1, budget2, budget3);
           
        }
    }
}
