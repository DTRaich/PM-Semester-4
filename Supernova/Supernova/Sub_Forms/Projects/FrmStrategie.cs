using Supernova.interfaces;
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
    public partial class FrmStrategie : Form,ICriteriaChecking
    {
        private objects.ProjektDataDummy projektdaten;

        public FrmStrategie()
        {
            InitializeComponent();
        }

        public FrmStrategie(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            this.projektdaten = projektdaten;
        }

        public bool checkAndValidateForm()
        {
            return true;
        }
    }
}
