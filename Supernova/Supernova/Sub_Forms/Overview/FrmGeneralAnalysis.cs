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
            Series s = new Series
            {
                Name = "Department",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            this.chartCapacity.Series.Add(s);

            Series ss = new Series
            {
                Name = "Budget",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            this.chartBudget.Series.Add(ss);

            for (int i = 0; i <= 5; i++)
            {
                s.Points.Add(DepSeries[i]);
                var p = s.Points[i];
                p.AxisLabel = stringSeries[i];
                p.LegendText = stringSeries[i];                
                p.Color = c[i];

                ss.Points.Add(BudgetSeries[i]);
                var p2 = ss.Points[i];
                p2.AxisLabel = stringSeries[i];
                p2.LegendText = stringSeries[i];
                p2.Color = c[i];
            }
        }

        private void reloadDepCapa()
        {
            chartCapacity.ResetAutoValues();
            chartCapacity.Series.Clear();
            Series s = new Series
            {
                Name = "series",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            this.chartCapacity.Series.Add(s);
            for (int i = 0; i <= 5; i++)
            {
                s.Points.Add(DepSeries[i]);
                var p = s.Points[i];
                p.AxisLabel = stringSeries[i];
                p.LegendText = stringSeries[i];                
                p.Color = c[i];

            }
        }
        
    }
}
