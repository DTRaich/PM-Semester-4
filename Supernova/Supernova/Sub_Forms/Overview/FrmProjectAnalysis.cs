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
                double[] value = ah.getProjectAnalysis(Convert.ToInt32(dr[0].ToString()));
                String workingS = dr[1].ToString() + ", \nNPV: " + value[1];
                Series working = new Series(workingS);
                chartKostRisk.Series.Add(working);
                chartKostRisk.Series[workingS].ChartType = SeriesChartType.Bubble;
                chartKostRisk.Series[workingS].MarkerStyle = MarkerStyle.Circle;
                chartKostRisk.Series[workingS].Points.AddXY(value[0], value[2], value[1]);                
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
            xlApp = new Excel.ApplicationClass();

            string DemoPath = System.Windows.Forms.Application.StartupPath + "\\helper\\BubbleChartTemp.xlsx";// Applica
            xlWorkBook  = xlApp.Workbooks.Open(DemoPath);

                        // Select the first worksheet.
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];
                 
            
            int i=4;
            foreach (DataRow dr in dragTable.Rows)
            {
                double[] value = ah.getProjectAnalysis(Convert.ToInt32(dr[0].ToString()));

                xlWorkSheet.Cells[i, 2] = dr[1].ToString();
                xlWorkSheet.Cells[i, 3] = value[0];
                xlWorkSheet.Cells[i, 4] = value[1];
                xlWorkSheet.Cells[i, 5] = value[2];
                i++;
            }
            

            //Savedialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "BubbleChart.xlsx";
            sfd.Filter = "Excel files (*.xlsx)|*.xlxs|All Files(*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.InitialDirectory = @"C:\Users\Public\Documents\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(sfd.FileName);
            }            
            
            //close Excel
            xlWorkBook.Close();
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
