using Supernova.data;
using Supernova.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmGeneralAnalysis : Form
    {
        AnalysisHelper ah = new AnalysisHelper();
        ParameterLoad pl = new ParameterLoad();
        DataLoad loader = new DataLoad();

        DataTable depComboTab;


        String[] stringSeries = { "geplant Jahr1", "offen Jahr1", "geplant Jahr2", "offen Jahr2", "geplantJahr3", "offen Jahr3" };
        Color[] c = { Color.Green, Color.Blue, Color.Green, Color.Blue, Color.Green, Color.Blue };

        int[] DepSeries;
        double[] BudgetSeries;
        int currentid = 0;

        public FrmGeneralAnalysis()
        {
            InitializeComponent();
            
            fillcboDepartment();
            LoadDepartmentStatistic();
            LoadBudgetStatistic();
            LoadCharts();
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
            reloadDepCapa();
        }

        private void LoadDepartmentStatistic()
        {
            currentid = Convert.ToInt32(cboDepartment.SelectedValue);
            DepSeries = ah.getSeriesDepartment(currentid);
        }
        private void LoadBudgetStatistic()
        {
            BudgetSeries = ah.getSeriesBudget();
        }

        private void LoadCharts()
        {
            for (int i = 0; i <= 5; i++)
            {
                Series s = this.chartCapacity.Series.Add(stringSeries[i]);
                Series ss = this.chartBudget.Series.Add(stringSeries[i]);
                s.Points.Add(DepSeries[i]);
                s.Color = c[i];
                s.AxisLabel = stringSeries[i];
                ss.Points.Add(BudgetSeries[i]);
                ss.Color = c[i];
                ss.AxisLabel = stringSeries[i];
            }
        }

        private void reloadDepCapa()
        {
            chartCapacity.Series.Clear();
            
            for (int i = 0; i <= 5; i++)
            {
                Series s = this.chartCapacity.Series.Add(stringSeries[i]);
                s.Points.Add(DepSeries[i]);
                s.Color = c[i];
                s.AxisLabel = stringSeries[i];

            }
        }
        
    }
}
