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
        private decimal gesamtkosten = 0;
        private decimal year1 = 0;
        private double year2 = 0;
        private double year3 = 0;

        public FrmCostTime()
        {
            InitializeComponent();
        }

        public FrmCostTime(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            double test = 10.00;
            this.projektdaten = projektdaten;
            cbStartMonth.SelectedIndex = 0;
            cbStartYear.SelectedIndex = 0;
            cbEndMonth.SelectedIndex = 0;
            cbEndYear.SelectedIndex = 0;
            nupTimeToMarket.Value = 0;
            try
            {
                maskedTextBox1.Text = String.Format("{0,12:0.00}", 1023.45); 

            }catch(Exception ex)
            {
            }

            //maskedTextBox1.Text = "0.00";
            //maskedTextBox1.Text = "0.00";
        }

        public bool checkAndValidateForm()
        {
            //collectData();
            //return validateData();
            return true;
        }

        private bool validateData()
        {
            bool retVal = true;
            int startYear = Convert.ToInt32(cbStartYear.SelectedItem);
            int endYear= Convert.ToInt32(cbEndYear.SelectedItem);

            if ((startYear > endYear) || (startYear == endYear) && (Convert.ToInt32(cbStartMonth.SelectedItem) > Convert.ToInt32(cbEndMonth.SelectedItem)))
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
               // projektdaten.GesamtKosten = gesamtkosten;
                projektdaten.NPV = Convert.ToDouble(mtbNPV.Text);
                projektdaten.TimeToMarket = Convert.ToInt32(nupTimeToMarket.Value);
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

        #region textboxes
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            //gesamtkosten = gesamtkosten - year1;
            //year1 = decimal.parsse(maskedTextBox1.Text);
            //gesamtkosten = gesamtkosten + year1;
            //tbCostAll.Text = gesamtkosten.ToString();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
        //    gesamtkosten = gesamtkosten - year2;
        //    year2 = Convert.ToDouble(maskedTextBox2.Text);
        //    gesamtkosten = gesamtkosten + year2;
        //    tbCostAll.Text = gesamtkosten.ToString();
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            //gesamtkosten = gesamtkosten - year3;
            //year3 = Convert.ToDouble(maskedTextBox3.Text);
            //gesamtkosten = gesamtkosten + year3;
            //tbCostAll.Text = gesamtkosten.ToString();
        }

        #endregion
    }
}
