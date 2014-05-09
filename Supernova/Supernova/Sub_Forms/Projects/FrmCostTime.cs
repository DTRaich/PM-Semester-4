using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Projects
{
    public partial class FrmCostTime : Form
    {
        private objects.ProjektDataDummy projektdaten;

        public FrmCostTime()
        {
            InitializeComponent();
        }

        public FrmCostTime(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            this.projektdaten = projektdaten;
        }
    }
}
