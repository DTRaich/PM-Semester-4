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


        // Risiko -> x achse
        // NPV --> 
        // Kosten --> y achse
        public FrmProjectAnalysis()
        {
            InitializeComponent();
        }

        public FrmProjectAnalysis(DataTable dragTable)
        {
            InitializeComponent();
            this.dragTable = dragTable;
            ChartArea area = new ChartArea("Analyse");
            area.AxisX.Title = "sdsd";
            area.AxisY.Title = "sddsfdfdfs";

            Series ss = new Series("TestSeries");
            chartKostRisk.Series.Add(ss);
            chartKostRisk.Series["TestSeries"].ChartType = SeriesChartType.Bubble;
            chartKostRisk.Series["TestSeries"].MarkerStyle = MarkerStyle.Circle;
            chartKostRisk.Series["TestSeries"].Points.AddXY(1, 2, 10);

            Series sb = new Series("1");
            chartKostRisk.Series.Add(sb);
            chartKostRisk.Series["1"].ChartType = SeriesChartType.Bubble;
            chartKostRisk.Series["1"].MarkerStyle = MarkerStyle.Circle;
            chartKostRisk.Series["1"].Points.AddXY(6, 6, 10);

            Series sa = new Series("2");
            chartKostRisk.Series.Add(sa);
            chartKostRisk.Series["2"].ChartType = SeriesChartType.Bubble;
            chartKostRisk.Series["2"].MarkerStyle = MarkerStyle.Circle;
            chartKostRisk.Series["2"].Points.AddXY(4, 7, 3);
      


        }
    }
}
