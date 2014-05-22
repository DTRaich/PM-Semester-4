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
            collectData();
            return validateData();
        
        }

        private void collectData()
        {
           
        }

        private bool validateData()
        {
            return true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
