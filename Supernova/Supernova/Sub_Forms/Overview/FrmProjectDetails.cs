using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmProjectDetails : Form
    {
        private int currentProjectID;
        private int currentPoints;
        String currentProjectName;

        DataTable details;
        public FrmProjectDetails()
        {
            InitializeComponent();
            fillGrid();
           
        }
        public FrmProjectDetails(int currentProjectID,int currentPoints,String currentProjectName)
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

       
    }
}
