﻿using Supernova.interfaces;
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

            if (projektdaten.ProjectID != 0)
            {
                fillAllBoxes();
            }
        }

        private void fillAllBoxes()
        {
            // reset?

            switch (projektdaten.techleader)
            {
                case 10:
                    radioButton11.Checked = true;
                    break;
                case 8:
                    radioButton12.Checked = true;
                    break;
                case 6:
                    radioButton13.Checked = true;
                    break;
                case 4:
                    radioButton14.Checked = true;
                    break;
                case 2:
                    radioButton15.Checked = true;
                    break;
            }

            switch (projektdaten.wachstum)
            {
                case 10:
                    radioButton21.Checked = true;
                    break;
                case 8:
                    radioButton22.Checked = true;
                    break;
                case 6:
                    radioButton23.Checked = true;
                    break;
                case 4:
                    radioButton24.Checked = true;
                    break;
                case 2:
                    radioButton25.Checked = true;
                    break;
            }

            switch (projektdaten.mitarbeiter)
            {
                case 10:
                    radioButton31.Checked = true;
                    break;
                case 8:
                    radioButton32.Checked = true;
                    break;
                case 6:
                    radioButton33.Checked = true;
                    break;
                case 4:
                    radioButton34.Checked = true;
                    break;
                case 2:
                    radioButton35.Checked = true;
                    break;
            }

            switch (projektdaten.Prozess)
            {
                case 10:
                    radioButton41.Checked = true;
                    break;
                case 8:
                    radioButton42.Checked = true;
                    break;
                case 6:
                    radioButton43.Checked = true;
                    break;
                case 4:
                    radioButton44.Checked = true;
                    break;
                case 2:
                    radioButton45.Checked = true;
                    break;
            }

            switch (projektdaten.Kunde)
            {
                case 10:
                    radioButton51.Checked = true;
                    break;
                case 8:
                    radioButton52.Checked = true;
                    break;
                case 6:
                    radioButton53.Checked = true;
                    break;
                case 4:
                    radioButton54.Checked = true;
                    break;
                case 2:
                    radioButton55.Checked = true;
                    break;
            }
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

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.techleader = 5 * 2;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.techleader = 4 * 2;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.techleader = 3 * 2;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.techleader = 2 * 2;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.techleader = 1 * 2;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.wachstum = 5 * 2;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.wachstum = 4 * 2;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.wachstum = 3 * 2;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.wachstum = 2 * 2;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.wachstum = 1 * 2;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.mitarbeiter = 5 * 2;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.mitarbeiter = 4 * 2;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.mitarbeiter = 3 * 2;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.mitarbeiter = 2 * 2;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.mitarbeiter = 1 * 2;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Prozess = 5 * 2;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Prozess = 4 * 2;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Prozess = 3 * 2;
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Prozess = 2 * 2;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Prozess = 1 * 2;
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Kunde = 5 * 2;

        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Kunde = 4 * 2;
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Kunde = 3 * 2;
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Kunde = 2 * 2;
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            projektdaten.Kunde = 1 * 2;
        }
    }
}
