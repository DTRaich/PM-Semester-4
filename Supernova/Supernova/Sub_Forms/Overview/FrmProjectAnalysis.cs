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
    public partial class FrmProjectAnalysis : Form
    {
        private DataTable dragTable;

        AnalysisHelper ah = new AnalysisHelper();

        // Risiko -> x achse
        // NPV --> 
        // Kosten --> y achse
        //public FrmProjectAnalysis()
        //{
        //    InitializeComponent();
        //}

        public FrmProjectAnalysis(DataTable dragTable)
        {

            InitializeComponent();
            this.dragTable = dragTable;


            //Series working;
            foreach (DataRow dr in dragTable.Rows)
            {
                Series working = new Series(dr[1].ToString());
                double[] value = ah.getProjectAnalysis(Convert.ToInt32(dr[0].ToString()));
                chartKostRisk.Series.Add(working);
                chartKostRisk.Series[dr[1].ToString()].ChartType = SeriesChartType.Bubble;
                chartKostRisk.Series[dr[1].ToString()].MarkerStyle = MarkerStyle.Circle;
                chartKostRisk.Series[dr[1].ToString()].Points.AddXY(value[0], value[1], value[2]);
                
            }

            
      


        }
    }
}
