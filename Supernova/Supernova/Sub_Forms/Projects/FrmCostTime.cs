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
        private double gesamtkosten = 0;
        private double year1 = 0;
        private double year2 = 0;
        private double year3 = 0;
        DataTable month = new DataTable();
        DataTable year = new DataTable();
        DataTable monthEnd = new DataTable();
        DataTable yearEnd = new DataTable();

        public FrmCostTime()
        {
            InitializeComponent();
        }

        public FrmCostTime(ref objects.ProjektDataDummy projektdaten)
        {
            InitializeComponent();
            fillAndBindMonthYearStart();
            fillAndBindMonthYearEnd();
            this.projektdaten = projektdaten;
            nupTimeToMarket.Value = 0;
            maskedTextBox1.Text = String.Format("{0,12:0.00}", 0.0);
            maskedTextBox2.Text = String.Format("{0,12:0.00}", 0.0);
            maskedTextBox3.Text = String.Format("{0,12:0.00}", 0.0); 

            if (projektdaten.ProjectID != 0)
            {
                fillAllBoxes();
            }
           
        }

        private void fillAndBindMonthYearEnd()
        {
            DataColumn dc1 = new DataColumn("Value");
            DataColumn dc2 = new DataColumn("Play");
            monthEnd.Columns.Add(dc1);
            monthEnd.Columns.Add(dc2);
            DataRow dr;
            for (int i = 1; i <= 12; i++)
            {
                dr = monthEnd.NewRow();
                dr[0] = i;
                dr[1] = i;

                monthEnd.Rows.Add(dr);
            }
            monthEnd.AcceptChanges();
            cbEndMonth.DataSource = monthEnd;
            cbEndMonth.ValueMember = "Value";
            cbEndMonth.DisplayMember = "Play";

            // year
            DataColumn dcy1 = new DataColumn("Value");
            DataColumn dcy2 = new DataColumn("Play");
            yearEnd.Columns.Add(dcy1);
            yearEnd.Columns.Add(dcy2);

            DataRow dr2;
            for (int i = 2014; i <= 2034; i++)
            {
                dr2 = yearEnd.NewRow();
                dr2[0] = i;
                dr2[1] = i;

                yearEnd.Rows.Add(dr2);
            }
            yearEnd.AcceptChanges();
            cbEndYear.DataSource = yearEnd;
            cbEndYear.ValueMember = "Value";
            cbEndYear.DisplayMember = "Play";
        }

        private void fillAndBindMonthYearStart()
        {
            DataColumn dc1 = new DataColumn("Value");
            DataColumn dc2 = new DataColumn("Play");
            month.Columns.Add(dc1);
            month.Columns.Add(dc2);
            DataRow dr;
            for (int i = 1; i <= 12; i++ ) 
            {
                dr = month.NewRow();
                dr[0] = i;
                dr[1] = i;

                month.Rows.Add(dr);
            }
            month.AcceptChanges();
            cbStartMonth.DataSource = month;
            cbStartMonth.ValueMember = "Value";
            cbStartMonth.DisplayMember = "Play";
            
            // year
            DataColumn dcy1 = new DataColumn("Value");
            DataColumn dcy2 = new DataColumn("Play");
            year.Columns.Add(dcy1);
            year.Columns.Add(dcy2);

            DataRow dr2;
            for (int i = 2014; i <= 2034; i++)
            {
                dr2 = year.NewRow();
                dr2[0] = i;
                dr2[1] = i;

                year.Rows.Add(dr2);
            }
            year.AcceptChanges();
            cbStartYear.DataSource = year;
            cbStartYear.ValueMember = "Value";
            cbStartYear.DisplayMember = "Play";

        }

        private void fillAllBoxes()
        {
            try
            {
                cbStartMonth.SelectedValue = projektdaten.ProjectStartDate.Month;
                cbStartYear.SelectedValue = projektdaten.ProjectStartDate.Year;
                cbEndMonth.SelectedValue = projektdaten.ProjectEndDate.Month;
                cbEndYear.SelectedValue = projektdaten.ProjectEndDate.Year;
                maskedTextBox1.Text = String.Format("{0,12:0.00}", projektdaten.costsyear1);
                maskedTextBox2.Text = String.Format("{0,12:0.00}", projektdaten.costyear2);
                maskedTextBox3.Text = String.Format("{0,12:0.00}", projektdaten.costyeae3);
                tbCostAll.Text = projektdaten.GesamtKosten.ToString();
                mtbNPV.Text = String.Format("{0,6:0.000}", projektdaten.NPV);
                nupTimeToMarket.Value = projektdaten.TimeToMarket;
            }
            catch (Exception ex)
            {
            }
        }

        public bool checkAndValidateForm()
        {
            collectData();
            return validateData();
            
        }

        private bool validateData()
        {
            bool retVal = true;
            int startYear = Convert.ToInt32(cbStartYear.SelectedValue);
            int endYear = Convert.ToInt32(cbEndYear.SelectedValue);

            if ((startYear > endYear) || (startYear == endYear) && (Convert.ToInt32(cbStartMonth.SelectedValue) > Convert.ToInt32(cbEndMonth.SelectedValue)))
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
                projektdaten.GesamtKosten = gesamtkosten;
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
            projektdaten.ProjectStartDate = new DateTime(Convert.ToInt32(cbStartYear.SelectedValue), Convert.ToInt32(cbStartMonth.SelectedValue), 1);
            projektdaten.ProjectEndDate = new DateTime(Convert.ToInt32(cbEndYear.SelectedValue), Convert.ToInt32(cbEndMonth.SelectedValue), 1);
            projektdaten.costsyear1 = year1;
            projektdaten.costyear2 = year2;
            projektdaten.costyeae3 = year3;
        }

        #region textboxes
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gesamtkosten = gesamtkosten - year1;
                year1 = Convert.ToDouble(maskedTextBox1.Text);
                gesamtkosten = gesamtkosten + year1;
                tbCostAll.Text = gesamtkosten.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            gesamtkosten = gesamtkosten - year2;
            year2 = Convert.ToDouble(maskedTextBox2.Text);
            gesamtkosten = gesamtkosten + year2;
            tbCostAll.Text = gesamtkosten.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
            gesamtkosten = gesamtkosten - year3;
            year3 = Convert.ToDouble(maskedTextBox3.Text);
            gesamtkosten = gesamtkosten + year3;
            tbCostAll.Text = gesamtkosten.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        private void cbStartYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
