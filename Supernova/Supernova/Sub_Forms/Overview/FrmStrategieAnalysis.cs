using Supernova.helper;
using Supernova.Sub_Forms.General;
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

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelExport(StrategyValue,StrategyName,"Strategie");
        }

        private void btnExcelExportCat_Click(object sender, EventArgs e)
        {
            ExcelExport(CategoryValue,CategoryName, "Kategorie");
        }

        private void ExcelExport(int[] Value, String[] Name, String Term)
        {
            try
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
                xlWorkSheet.Cells[2, 1] = Term.ToString();

                int n = 0;
                for (int j = 2; j <= Value.Length + 1; j++)
                {
                    xlWorkSheet.Cells[j, 1] = Name[n].ToString();
                    xlWorkSheet.Cells[j, 2] = Value[n].ToString();
                    n++;
                }


                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(180, 10, 300, 250);
                Excel.Chart chartPage = myChart.Chart;
                int leng = Value.Length + 1;
                chartRange = xlWorkSheet.get_Range("A1", "b" + leng);
                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

                SaveFileDialog sfd = new SaveFileDialog();

                sfd.FileName = Term + "Statisik.xls";
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
            catch (Exception ex)
            {
                FrmAfirmative error = new FrmAfirmative("Fehler \nExcel-Erstellung war nicht möglich\n Bitte prüfen Sie ob Excel richtig installiert ist", 'e');
                error.ShowDialog();
            }
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
