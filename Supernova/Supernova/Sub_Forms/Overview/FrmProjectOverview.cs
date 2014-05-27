﻿using Supernova.data;
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
        public FrmProjectOverview()
        {
            InitializeComponent();
            LoadMainGrid();
           
        }

        private void LoadMainGrid()
        {
            DataTable source = dl.LoadGenerealOverview();
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
    }
}
