﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova
{
    public partial class FrmMain : Form
    {
        private Leader leader;
        public FrmMain()
        {
            InitializeComponent();

            leader = new Leader(this.pnlMain);
        }

        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            leader.LoadLogin();
        }
    }
}