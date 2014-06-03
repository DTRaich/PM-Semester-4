using Supernova.data;
using Supernova.Sub_Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection; 
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmProjectOverview : Form
    {
    #region  fields
        DataLoad dl = new DataLoad();
        private int currentProjectID = 0;
        private int currentHaveTo = 0;
        string currentProjectName;
        private double currentPoints = 0;
        DataTable strategies;
        DataTable categories;
        DataTable source;
        DataTable dragTable = new DataTable();
        private int currentRow = 0;
        private bool adminorGLVal;
        
#endregion fields
        public FrmProjectOverview()
        {
            InitializeComponent();
            InitializeCustom();            
        }

        private void InitializeCustom()
        {
            resetAllStuff();
            LoadMainGrid();
            fillFilter();
            fillDragDropTable();
            adminorGLVal=  checkAdminOrGL();
        }

        

    #region fill and Load
        private void resetAllStuff()
        {
            currentProjectID = 0;
            currentRow = 0;
            currentProjectName = string.Empty;
            currentPoints = 0;
            strategies = null;
            strategies = new DataTable();
            categories = null;
            categories = new DataTable();
            dragTable = null;
            dragTable = new DataTable();

        }
        private void fillDragDropTable()
        {
            DataColumn dc1 = new DataColumn();
            DataColumn dc2 = new DataColumn();
            dragTable.Columns.Add(dc1);
            dragTable.Columns.Add(dc2);
            dragTable.AcceptChanges();
        }
        
        private void fillFilter()
        {
            ParameterLoad loader = new ParameterLoad();
            strategies = loader.loadStrategies();
            categories = loader.loadProjectKategorie();

            DataRow dr = strategies.NewRow();
            dr[0] = 0;
            dr[1] = "Alle";
            strategies.Rows.Add(dr);

            DataRow dr2 = categories.NewRow();
            dr2[0] = 0;
            dr2[1] = "Alle";
            categories.Rows.Add(dr2);


            cbStrategy.DataSource = strategies;
            cbStrategy.ValueMember = "CRITERIA_ID";
            cbStrategy.DisplayMember = "C_NAME";

            cbCategory.DataSource = categories;
            cbCategory.ValueMember = "PC_ID";
            cbCategory.DisplayMember = "PC_NAME";

            cbStrategy.SelectedValue = 0;
            cbCategory.SelectedValue = 0;


        }

        private void LoadMainGrid()
        {
            source = dl.LoadGenerealOverview();
            source.Columns.Add("Muss-Projekt", System.Type.GetType("System.Boolean"));

            foreach (DataRow dataRow in source.Rows)
            {
                if (dataRow["MUSS_Projekt"].ToString().Equals("1"))
                {
                    dataRow["Muss-Projekt"] = true;
                }
                else
                {
                    dataRow["Muss-Projekt"] = false;
                }
            }

            mainGrid.DataSource = source;
            mainGrid.ReadOnly = true;
            mainGrid.Columns[0].Visible = false;
            mainGrid.Columns["MUSS_Projekt"].Visible = false;
            mainGrid.Columns[mainGrid.Columns.Count-2].Visible = false;
            mainGrid.Columns[mainGrid.Columns.Count - 3].Visible = false;


        }
    #endregion 
    #region CMSCLICk

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            DataSave saver = new DataSave();
            FrmAfirmative delete = new FrmAfirmative("Möchten sie das ausgewählte Projekt löschen?", 'd');
            if (delete.ShowDialog() == DialogResult.OK)
            {                
                bool retval = saver.DeleteProject(currentProjectID);
                if (retval)
                {
                    FrmAfirmative deleted = new FrmAfirmative("Das Projekt wurde erfolgreich gelöscht. \n ", 'i');
                    deleted.ShowDialog();
                    InitializeCustom();
           
                }
                else
                {
                    FrmAfirmative notDeleted = new FrmAfirmative("Das Projekt konnte nicht gelöscht werden.\nBitte überprüfen Sie ob der Benutzer als Projektleiter eingetragen wurde.", 'e');
                    notDeleted.ShowDialog();
                }
            }
            ;
        }

        private void tsmDetail_Click(object sender, EventArgs e)
        {
            FrmProjectDetails detail = new FrmProjectDetails(currentProjectID, currentPoints, currentProjectName);
            detail.StartPosition = FormStartPosition.CenterParent;
            detail.ShowDialog();
        }

        private void tsmChange_Click(object sender, EventArgs e)
        {
            Leader lead = Leader.getLeaderInst();
            lead.LoadEditProjects(currentProjectID);


        }

        private void tsmHaveTo_Click(object sender, EventArgs e)
        {
            ValidationData valDat = new ValidationData();

            DataTable val = valDat.SaveAndValidateHaveTo(currentProjectID,currentHaveTo);

            if (val.Rows.Count > 0)
            {
                FrmHaveToErrorPopUp errorHave = new FrmHaveToErrorPopUp(val, currentProjectID);
                errorHave.StartPosition = FormStartPosition.CenterParent;
                errorHave.ShowDialog();
            }
            else
            {
                InitializeCustom();
            }
            
           
        }

        private void mainGrid_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsGridMenu.Show(mainGrid, new Point(e.X, e.Y));
            }
        }
        #endregion
    #region buttonEvents
        private void btnDepBudAnalysis_Click(object sender, EventArgs e)
        {
            FrmGeneralAnalysis frm = new FrmGeneralAnalysis();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnStrategieAnalysis_Click(object sender, EventArgs e)
        {
            FrmStrategieAnalysis frm = new FrmStrategieAnalysis();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnRiskCostAnalysis_Click(object sender, EventArgs e)
        {
            DataTable analyse = getAnaylseProject();
            if (analyse.Rows.Count > 0)
            {
                FrmProjectAnalysis frm = new FrmProjectAnalysis(analyse);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else
            {
                FrmAfirmative frm = new FrmAfirmative("Keine Projekte ausgewählt",'e');
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
           
        }
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelExport();
        }
       
        private void btnFilter_Click(object sender, EventArgs e)
        {
            getFilter();
        }

        private void getFilter()
        {
            int categoryid = 0;
            int strategyid = 0;
            int userid = 0;
            int haveto = 0;
            DataLoad dl = new DataLoad();

            categoryid = Convert.ToInt32(cbCategory.SelectedValue);
            strategyid = Convert.ToInt32(cbStrategy.SelectedValue);
            if (cbMust.Checked)
            {
                haveto = 1;
            }

            if (cbMy.Checked)
            {
                userid = Leader.getLeaderInst().getUserID();
            }
            source = null;
            mainGrid.DataSource = null;
            source = dl.LoadOverviewFilter(categoryid, strategyid, userid, haveto);
            mainGrid.DataSource = source;

        }
        

    #endregion

    #region drag and Drop

        private DataTable getAnaylseProject()
        {
            DataTable dt = new DataTable();
            dt = dragTable.Copy();
            dt.Clear();
            dt.AcceptChanges();
            foreach(DataRow dr in dragTable.Rows){
            for (int i = 0; i < clbBox.Items.Count; i++)
            {
                if (clbBox.Items[i].ToString().Equals(dr[1].ToString()) &&clbBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    DataRow r = dt.NewRow();
                    r[0] = dr[0];
                    r[1] = dr[1];
                    dt.Rows.Add(r);

                }
            }
            }
            dt.AcceptChanges();

            return dt;
        }

        private void mainGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo info = mainGrid.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    DataRowView view = (DataRowView)mainGrid.Rows[info.RowIndex].DataBoundItem;
                    if (view != null)
                    {
                        mainGrid.DoDragDrop(view, DragDropEffects.Copy);
                    }
                }
            }

            getCurrentStuff();
           

        }

        private void getCurrentStuff()
        {
            int row = mainGrid.CurrentRow.Index;

         

            if (row != -1)
            {
                currentProjectID = Convert.ToInt32(mainGrid[0, row].Value);
                currentPoints = Convert.ToDouble(mainGrid[7, row].Value);
                currentProjectName = mainGrid[1, row].Value.ToString();
                currentHaveTo = Convert.ToInt32(mainGrid["MUSS_Projekt", row].Value);
                currentRow = row;

                // drehen, damit richtiges abgespeichert werden kann
                if (currentHaveTo == 0)
                {
                    currentHaveTo = 1;
                }
                else
                {
                    currentHaveTo = 0;
                }

            }
        }
          

        private void clbBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }


      
        private void clbBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRowView)))
            {

              DataRowView projektView = (DataRowView)e.Data.GetData(typeof(DataRowView));
              int proID = Convert.ToInt32(projektView.Row.ItemArray[0].ToString());
              string proName = projektView.Row.ItemArray[1].ToString();

              bool retval = true;
              
              foreach (DataRow dr in dragTable.Rows)
              {
                  if (Convert.ToInt32(dr[0].ToString()) == proID)
                  {
                      retval = false;
                  }
              }

              if (retval)
              {
                  if (dragTable.Rows.Count == 5 && checkCountOFList())
                  {
                      FrmAfirmative frm = new FrmAfirmative("Zuviele Projekte\nZu viele Projekt ausgewählt setzten Sie zuerst Projekte inaktiv", 'e');
                      frm.ShowDialog();
                  }
                  else
                  {
                      addValueToTable(proID, proName);
                      addValuetoList(proName);
                  }
              }
              else
              {
                  FrmAfirmative frm = new FrmAfirmative("Projekt bereits vorhanden\nDas ausgewählte Projekt ist bereits ausgewählt",'e');
                  frm.ShowDialog();
              }
               
            }
        }

        private void addValuetoList(string proName)
        {
            clbBox.Items.Add(proName);
            clbBox.SetItemChecked(clbBox.Items.Count-1,true);

        }

        private void addValueToTable(int proID, string proName)
        {
            DataRow dr = dragTable.NewRow();
            dr[0] = proID;
            dr[1] = proName;
            dragTable.Rows.Add(dr);
            dragTable.AcceptChanges();
        }

      

        private bool checkCountOFList()
        {
            int c = clbBox.CheckedItems.Count;
            if(c < 5)
            {
                return true;
            }else
            {
                return false;
            }
        }

        #endregion

        private void cmsGridMenu_Opening(object sender, CancelEventArgs e)
        {
            if(AllowChanging())
            {
                tsmChange.Enabled = true;
                tsmDelete.Enabled = true;
                

            }else
            {
                tsmChange.Enabled = false;
                tsmDelete.Enabled = false;

            }
           
        }

        private bool AllowChanging()
        {
            bool retval = false;          
            if (adminorGLVal)
            {
                retval = true;
            }
            else
            {
                int userid = Leader.getLeaderInst().getUserID();
                int columindexCreat = mainGrid.Columns.Count - 3;
                int columindexLead = mainGrid.Columns.Count - 2;

                int ersteller = Convert.ToInt32(mainGrid[columindexCreat, currentRow].Value.ToString()) ;
                int leiter = Convert.ToInt32(mainGrid[columindexLead, currentRow].Value.ToString());
                if (userid == ersteller ||userid == leiter )
                {
                    retval = true;
                }
            }
            return retval;
        }

        private bool checkAdminOrGL()
        {
            bool retval = false;
            int RightsID = dl.UserRight(Leader.getLeaderInst().getUserID(), this.Name);
            switch (RightsID)
            {
                case 16:  retval= true; // ADmin
                    break;
                case 17:  retval = true; // GL
                    break;

            }
            return retval;
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
            for (i = 1; i < mainGrid.ColumnCount - 3; i++)
            {
                xlWorkSheet.Cells[1, i] = mainGrid.Columns[i].Name.ToString();
            }

            for (i = 0; i <= mainGrid.RowCount -2; i++)
            {
                for (j = 1; j < mainGrid.ColumnCount - 3; j++)
                {
                    xlWorkSheet.Cells[i + 2, j ] = mainGrid[j, i].Value.ToString();
                }
            }


            SaveFileDialog sfd = new SaveFileDialog();
            
            sfd.FileName = "ProjectOverview.xls";
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
