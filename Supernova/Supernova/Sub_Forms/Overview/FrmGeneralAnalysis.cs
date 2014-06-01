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
using Excel = Microsoft.Office.Interop.Excel;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmGeneralAnalysis : Form
    {
        AnalysisHelper ah = new AnalysisHelper();
        ParameterLoad pl = new ParameterLoad();
        DataLoad loader = new DataLoad();

        DataTable depComboTab;


        String[] stringSeries = { "geplant Jahr 1", "offen Jahr 1", "geplant Jahr 2", "offen Jahr 2", "geplant Jahr 3", "offen Jahr 3" };
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
            chartCapacity.Legends.Clear();
            Series s = new Series
            {
                Name = "Department",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            this.chartCapacity.Series.Add(s);


            chartBudget.Legends.Clear();
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

        private void btnExcelExportCapa_Click(object sender, EventArgs e)
        {
            ExcelExportCapa();
        }

        private void btnExcelExportBudget_Click(object sender, EventArgs e)
        {
            ExcelExportBudget();
        }

        private void ExcelExportBudget()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //add data 
            xlWorkSheet.Cells[1, 1] = "";
            xlWorkSheet.Cells[2, 1] = "Jahr 1";
            xlWorkSheet.Cells[3, 1] = "Jahr 2";
            xlWorkSheet.Cells[4, 1] = "Jahr 3";

            xlWorkSheet.Cells[1, 2] = "geplant";
            xlWorkSheet.Cells[1, 3] = "offen";

            int n = 0;

            for (int i = 2; i <= 4; i++)
            {                
                for (int j = 2; j <=3; j++)
                {
                    xlWorkSheet.Cells[i, j] = BudgetSeries[n];
                    n++;
                }
            }


            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "c4");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "BudgetStatistic.xls";
            sfd.Filter = "Excel files (*.xls)|*.xls|All Files(*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.InitialDirectory = @"C:\Users\Public\Documents\";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }

            xlWorkBook.Close(false, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

        }

        private void ExcelExportCapa()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //add data 
            xlWorkSheet.Cells[1, 1] = "";
            xlWorkSheet.Cells[2, 1] = "Jahr 1";
            xlWorkSheet.Cells[3, 1] = "Jahr 2";
            xlWorkSheet.Cells[4, 1] = "Jahr 3";

            xlWorkSheet.Cells[1, 2] = "geplant";
            xlWorkSheet.Cells[1, 3] = "offen";

            int n = 0;

            for (int i = 2; i <= 4; i++)
            {
                for (int j = 2; j <= 3; j++)
                {
                    xlWorkSheet.Cells[i, j] = DepSeries[n].ToString();
                    n++;
                }
            }


            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "c4");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "KapazitätStatistic.xls";
            sfd.Filter = "Excel files (*.xls)|*.xls|All Files(*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.InitialDirectory = @"C:\Users\Public\Documents\";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }

            xlWorkBook.Close(false, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }




        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        
    }
}
