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
    public partial class FrmProjectAnalysis : Form
    {
        private DataTable dragTable;

        public FrmProjectAnalysis()
        {
            InitializeComponent();
        }

        public FrmProjectAnalysis(DataTable dragTable)
        {
            InitializeComponent();
            this.dragTable = dragTable;
            Series ss = new Series("TestSeries");
            chartCost.Series.Add(ss);
            chartCost.Series["TestSeries"].ChartType = SeriesChartType.Bubble;
            chartCost.Series["TestSeries"].MarkerStyle = MarkerStyle.Circle;
            chartCost.Series["TestSeries"].Points.AddXY(1, 2, 10);

            Series sb = new Series("1");
            chartCost.Series.Add(sb);
            chartCost.Series["1"].ChartType = SeriesChartType.Bubble;
            chartCost.Series["1"].MarkerStyle = MarkerStyle.Circle;
            chartCost.Series["1"].Points.AddXY(6, 6, 10);

            Series sa = new Series("2");
            chartCost.Series.Add(sa);
            chartCost.Series["2"].ChartType = SeriesChartType.Bubble;
            chartCost.Series["2"].MarkerStyle = MarkerStyle.Circle;
            chartCost.Series["2"].Points.AddXY(4, 7, 3);
      


        }
    }
}
