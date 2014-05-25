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
    public partial class FrmProjectDetails : Form
    {
        private int currentProjectID;

        public FrmProjectDetails()
        {
            InitializeComponent();
        }

        public FrmProjectDetails(int currentProjectID)
        {
            // TODO: Complete member initialization
            this.currentProjectID = currentProjectID;
        }
    }
}
