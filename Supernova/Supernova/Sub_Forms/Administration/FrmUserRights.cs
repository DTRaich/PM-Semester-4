using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;
using Supernova.Sub_Forms.General;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmUserRights : Form
    {
        DataTable departments;
        DataTable usergroup;

        public FrmUserRights()
        {
            InitializeComponent();
            initializeComboBox();
            // hier user anlegen und Gruppen rechte ziehen können
        }

        private void initializeComboBox()
        {
            ParameterLoad pl = new ParameterLoad();
            departments = pl.loadDeparments();
            usergroup = pl.loadUserGroups();

            try
            {
                cbAbteilung.DataSource = departments;
                cbAbteilung.ValueMember = "DEPARTMENTS_ID";
                cbAbteilung.DisplayMember = "D_NAME";

                cbBenutzergruppe.DataSource = usergroup;
                cbBenutzergruppe.ValueMember = "USER_GROUPS_ID";
                cbBenutzergruppe.DisplayMember = "UG_NAME";
            }
            catch (Exception ex)
            {
                FrmAfirmative DBError = new FrmAfirmative("Fehler beim Laden der Anwendung. \n Bitte wenden sie sich an den Administrator.", 'e');
                DBError.StartPosition = FormStartPosition.CenterParent;
                DBError.ShowDialog();
                this.Close();
            }

          }

        private void btnUserLoad_Click(object sender, EventArgs e)
        {
            lblErrorText.Visible = false;
            string userload = txtUsernameLoad.Text;

            if (String.IsNullOrWhiteSpace(userload) || String.IsNullOrEmpty(userload)) 
            {
                lblErrorText.ForeColor = Color.DarkRed;
                lblErrorText.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
