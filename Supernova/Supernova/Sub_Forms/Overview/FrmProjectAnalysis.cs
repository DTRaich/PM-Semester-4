﻿using Supernova.helper;
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
                double[] value = ah.getProjectAnalysis(Convert.ToInt32(dr[0].ToString()));
                String workingS = dr[1].ToString() + ", NPV: " + value[2];
                Series working = new Series(workingS);
                chartKostRisk.Series.Add(working);
                chartKostRisk.Series[workingS].ChartType = SeriesChartType.Bubble;
                chartKostRisk.Series[workingS].MarkerStyle = MarkerStyle.Circle;
                chartKostRisk.Series[workingS].Points.AddXY(value[0], value[1], value[2]);
                
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
            xlWorkBook = xlApp.Workbooks.Open("BubbleChartTemp.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            
            //musst be blank (X)
            //xlWorkSheet.Cells[1, 1] = "X";
            xlWorkSheet.Cells[1, 2] = "Y";
            
            //xlWorkSheet.Cells[1, 3] = "Bubbles";

            int i=1;
            double[,] matrix = new double[5,3]{{9,2,3},{3,2,7},{5,7,9},{6,3,8},{2,9,9}};
            

            // excel in weiser riese 
            //detail table export
 
            
            for (int j = 0; j <= 4; j++)
            {
                xlWorkSheet.Cells[j + 2, 1] = matrix[j, 0];
                xlWorkSheet.Cells[j + 2, 2] = matrix[j, 1];
                xlWorkSheet.Cells[j + 2, 3] = matrix[j, 2];
            }
            
            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 100, 300, 250);
            
            Excel.Chart chartPage = myChart.Chart;
            
            

            chartRange = xlWorkSheet.get_Range("A1:C6", misValue);
            chartPage.SetSourceData(chartRange, misValue);
            
            chartPage.ChartType = Excel.XlChartType.xlBubble;
            

            //Savedialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "BubbleChart.xls";
            sfd.Filter = "Excel files (*.xls)|*.xls|All Files(*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.InitialDirectory = @"C:\Users\Public\Documents\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }            
            
            //close Excel
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
