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
using Supernova.objects;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmUser : Form
    {
        DataTable departments;
        DataTable usergroup;
        User userdata;

        public FrmUser()
        {
            InitializeComponent();
            initializeComboBox();
            userdata = new User();
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
            }else
            {
                bool loadworked = userdata.LoadUser(userload);
                if (!loadworked)
                {
                    FrmAfirmative NoUser = new FrmAfirmative("Kein User gefunden. \n Bitte überprüfen sie ihre Eingaben.", 'e');
                    NoUser.StartPosition = FormStartPosition.CenterParent;
                    NoUser.ShowDialog();
                }
                else 
                {
                    prepareBoxes();
                }
            }
        }

        private void prepareBoxes()
        {
            txtVorname.Text = userdata.firstname;
            txtNachname.Text = userdata.lastname;
            txtUsername.Text = userdata.username;
            txtEmail.Text = userdata.email;
            cbAbteilung.SelectedValue = userdata.departmentID;
            cbBenutzergruppe.SelectedValue = userdata.userGroupID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //userdata.firstname = txtVorname.Text;
            //userdata.lastname = txtNachname.Text;
            //userdata.username = txtUsername.Text;
            //userdata.passwort = Convert.ToInt32(txtPassword.Text);
            //userdata.email = txtEmail.Text;
            //userdata.departmentID = Convert.ToInt32(cbAbteilung.ValueMember);
            //userdata.userGroupID = Convert.ToInt32(cbBenutzergruppe.ValueMember);



        }
    }
}
