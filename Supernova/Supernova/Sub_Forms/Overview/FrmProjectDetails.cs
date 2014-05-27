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
        DataTable details;
        public FrmProjectDetails()
        {
            InitializeComponent();
            fillGrid();
           
        }
        public FrmProjectDetails(int currentProjectID)
        {
            this.currentProjectID = currentProjectID;
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
            
        }

       
    }
}
