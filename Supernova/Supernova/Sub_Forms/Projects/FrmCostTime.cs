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
    public partial class FrmCostTime : Form, ICriteriaChecking
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
            cbStartMonth.SelectedIndex = 0;
            cbStartYear.SelectedIndex = 0;
            cbEndMonth.SelectedIndex = 0;
            cbEndYear.SelectedIndex = 0;
        }

        public bool checkAndValidateForm()
        {
            collectData();
            return validateData();
        }

        private bool validateData()
        {
            bool retVal = true;

            if (((int) cbStartYear.SelectedValue > (int) cbEndYear.SelectedValue) || ((int) cbStartYear.SelectedValue == (int) cbEndYear.SelectedValue && (int) cbStartMonth.SelectedValue > (int) cbEndMonth.SelectedValue))
            {
                errMsgStartEndDate.Visible = true;
                retVal = false;
            }
            else
            {
                errMsgStartEndDate.Visible = false;
            }

            try
            {
                projektdaten.GesamtKosten = Convert.ToDouble(mtbTotalCost.Text);
                projektdaten.NPV = Convert.ToDouble(mtbTotalCost.Text);
                projektdaten.TimeToMarket = (int) nupTimeToMarket.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                retVal = false;
            }

            return retVal;
        }

        private void collectData()
        {
            projektdaten.ProjectStartDate = new DateTime(Convert.ToInt32(cbStartYear.SelectedItem), Convert.ToInt32(cbStartMonth.SelectedItem), 1);
            projektdaten.ProjectEndDate = new DateTime(Convert.ToInt32(cbEndYear.SelectedItem), Convert.ToInt32(cbEndMonth.SelectedItem), 1);
        }
    }
}
