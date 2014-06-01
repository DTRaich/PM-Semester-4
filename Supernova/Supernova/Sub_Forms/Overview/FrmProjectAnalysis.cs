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
    public partial class FrmProjectAnalysis : Form
    {
        private DataTable dragTable;

        AnalysisHelper ah = new AnalysisHelper();

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

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelExport();
        }

        private void ExcelExport(){
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //xlWorkSheet.Cells[1, 1] = "X";
            xlWorkSheet.Cells[1, 2] = "Y";
            //xlWorkSheet.Cells[1, 3] = "Bubbles";

            int i=1;
            double[,] matrix = new double[5,3]{{0,0,0},{0,0,0},{0,0,0},{0,0,0},{0,0,0}};
            foreach (DataRow dr in dragTable.Rows)
            {
                i++;
                double[] value = ah.getProjectAnalysis(Convert.ToInt32(dr[0].ToString()));
                //matrix[i, 0] = value[0];
                //matrix[i, 1] = value[1];
                //matrix[i, 2] = value[2];
                xlWorkSheet.Cells[i, 1] = value[0];
                xlWorkSheet.Cells[i, 2] = value[1];
                xlWorkSheet.Cells[i, 3] = value[2];
            }
            //for (int j = 0; j <= 4; j++)
            //{
            //    xlWorkSheet.Cells[j + 2, 1] = matrix[j, 0];
            //    xlWorkSheet.Cells[j + 2, 2] = matrix[j, 1];
            //    xlWorkSheet.Cells[j + 2, 3] = matrix[j, 2];
            //}
            
            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 100, 300, 250);
            Excel.Chart chartPage = myChart.Chart;
            chartRange = xlWorkSheet.get_Range("A1", "C6");

            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlBubble3DEffect;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "BubbleChart.xls";
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
