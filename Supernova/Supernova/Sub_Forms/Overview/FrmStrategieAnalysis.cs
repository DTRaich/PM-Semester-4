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
    public partial class FrmStrategieAnalysis : Form
    {

        AnalysisHelper ah = new AnalysisHelper();
        
        String[] StrategyName;
        int[] StrategyValue;

        String[] CategoryName;
        int[] CategoryValue;

        public FrmStrategieAnalysis()
        {
            InitializeComponent();
            LoadSeries();
            LoadCharts();

        }

        private void LoadCharts()
        {
            chartStrategy.Legends.Clear();
            Series s = new Series
            {
                Name = "Strategy",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            this.chartStrategy.Series.Add(s);

            chartCategory.Legends.Clear();
            Series ss = new Series
            {
                Name = "Category",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            this.chartCategory.Series.Add(ss);

            for (int i = 0; i <= 4; i++)
            {
                s.Points.Add(StrategyValue[i]);
                var p = s.Points[i];
                p.AxisLabel = StrategyName[i];
                p.LegendText = StrategyName[i];
            }

            for (int i = 0; i <= 6; i++)
            {
                ss.Points.Add(CategoryValue[i]);
                var p2 = ss.Points[i];
                p2.AxisLabel = CategoryName[i];
                p2.LegendText = CategoryName[i];
            }


        }

        private void LoadSeries()
        {
            CategoryName = ah.getSeriesCategoryyName();
            CategoryValue = ah.getSeriesCategoryValue();

            StrategyName = ah.getSeriesStrategyName();
            StrategyValue = ah.getSeriesStrategyValue();
        }


        //5 Strategies  7 Categories
    }
}
