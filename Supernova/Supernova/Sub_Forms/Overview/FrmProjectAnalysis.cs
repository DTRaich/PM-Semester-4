﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmProjectAnalysis : Form
    {
        private DataTable dragTable;

        public FrmProjectAnalysis()
        {
            InitializeComponent();
        }

        public FrmProjectAnalysis(DataTable dragTable)
        {
            this.dragTable = dragTable;
        }
    }
}
