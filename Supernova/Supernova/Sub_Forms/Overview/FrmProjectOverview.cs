using Supernova.data;
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
        DataLoad dl = new DataLoad();
        private int currentProjectID = 0;
        String currentProjectName;
        private double currentPoints = 0;
        DataTable strategies;
        DataTable categories;
        DataTable source;
        public FrmProjectOverview()
        {
            InitializeComponent();
            LoadMainGrid();
            fillFilter();
           
        }

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
           source =  dl.LoadOverviewFilter(categoryid,strategyid,userid,haveto);
           mainGrid.DataSource = source;

        }
    }
}
