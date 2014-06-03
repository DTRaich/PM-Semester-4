using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;
using Excel = Microsoft.Office.Interop.Excel;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmProjectDetails : Form
    {
        private int currentProjectID;
        private double currentPoints;
        String currentProjectName;

        DataTable details;
        public FrmProjectDetails()
        {
            InitializeComponent();
            fillGrid();
           
        }
        public FrmProjectDetails(int currentProjectID,double currentPoints,String currentProjectName)
        {
            this.currentProjectID = currentProjectID;
            this.currentPoints = currentPoints;
            this.currentProjectName = currentProjectName;
            InitializeComponent();
            fillGrid();
            fillBoxes();
        }

        private void fillGrid()
        {
           
            DataLoad loader = new DataLoad();
            details = loader.LoadProjectDetails(currentProjectID);
            detailsGrid.DataSource = details;
            
        }

        private void fillBoxes()
        {
            txtName.Text = currentProjectName;
            txtPoints.Text = currentPoints.ToString();

        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelExport();
        }

        private void ExcelExport()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = lblName.Text;
            xlWorkSheet.Cells[1, 2] = currentProjectName;
            xlWorkSheet.Cells[1, 3] = lblPoints.Text;
            xlWorkSheet.Cells[1, 4] = currentPoints;
            
            for (i = 0; i < detailsGrid.ColumnCount ; i++)
            {
                xlWorkSheet.Cells[2, i+1] = detailsGrid.Columns[i].Name.ToString();
            }

            for (i = 0; i <= detailsGrid.RowCount -1; i++)
            {
                for (j = 0; j < detailsGrid.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[i + 3, j+1] = detailsGrid[j, i].Value;
                }
            }


            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "ProjectDetails"+currentProjectName+".xls";
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
