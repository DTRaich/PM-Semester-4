using Supernova.data;
using Supernova.Sub_Forms.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmProjectOverview : Form
    {
#region  fields
        DataLoad dl = new DataLoad();
        private int currentProjectID = 0;
        String currentProjectName;
        private double currentPoints = 0;
        DataTable strategies;
        DataTable categories;
        DataTable source;
        DataTable dragTable = new DataTable();
        
#endregion fields
        public FrmProjectOverview()
        {
            InitializeComponent();
            LoadMainGrid();
            fillFilter();
            fillDragDropTable();

        }

        private void fillDragDropTable()
        {
            DataColumn dc1 = new DataColumn();
            DataColumn dc2 = new DataColumn();
            dragTable.Columns.Add(dc1);
            dragTable.Columns.Add(dc2);
            dragTable.AcceptChanges();
        }

#region fill and Load
        private void fillFilter()
        {
            ParameterLoad loader = new ParameterLoad();
            strategies = loader.loadStrategies();
            categories = loader.loadProjectKategorie();

            DataRow dr = strategies.NewRow();
            dr[0] = 0;
            dr[1] = "Keine";
            strategies.Rows.Add(dr);

            DataRow dr2 = categories.NewRow();
            dr2[0] = 0;
            dr2[1] = "Keine";
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
            mainGrid.DataSource = source;
            mainGrid.ReadOnly = true;

        }
#endregion 
#region CMSCLICk
        private void tsmDetail_Click(object sender, EventArgs e)
        {
            FrmProjectDetails detail = new FrmProjectDetails(currentProjectID, currentPoints, currentProjectName);
            detail.ShowDialog();
        }

        private void tsmChange_Click(object sender, EventArgs e)
        {
            Leader lead = Leader.getLeaderInst();
            lead.LoadEditProjects(currentProjectID);

        }

        private void mainGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = mainGrid.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow != -1)
            {
                currentProjectID = Convert.ToInt32(mainGrid[0, currentMouseOverRow].Value);
                currentPoints = Convert.ToDouble(mainGrid[7, currentMouseOverRow].Value);
                currentProjectName = mainGrid[1, currentMouseOverRow].Value.ToString();

            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsGridMenu.Show(mainGrid, new Point(e.X, e.Y));
            }
        }
#endregion
#region buttonEvents
        private void btnDepBudAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnStrategieAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnRiskCostAnalysis_Click(object sender, EventArgs e)
        {

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
           bool  retval = false;


            return retval;
        }

        #endregion


       
    }
}
