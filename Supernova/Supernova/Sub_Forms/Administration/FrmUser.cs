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
                    btnDelete.Visible = true;
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
           
            if (checkContent())
            {
                userdata.departmentID = Convert.ToInt32(cbAbteilung.SelectedValue);
                userdata.userGroupID = Convert.ToInt32(cbBenutzergruppe.SelectedValue);
                DataSave saver = new DataSave();
                if (saver.UpdateUser(userdata))
                {
                    FrmAfirmative SaveNewUser = new FrmAfirmative("Diese Benutzerdaten wurden gespeichert. \n ", 'i');
                    SaveNewUser.StartPosition = FormStartPosition.CenterParent;
                    SaveNewUser.ShowDialog();
                }
                else 
                {
                    FrmAfirmative SaveNewUser = new FrmAfirmative("Speichern fehlgeschlagen. \n Bitte wenden sie sich an den Administrator", 'e');
                    SaveNewUser.StartPosition = FormStartPosition.CenterParent;
                    SaveNewUser.ShowDialog();
                }
               
            }
        }

        private bool checkTextBox(string content, TextBox field)
        {
            field.BackColor = Color.White;

            if (String.IsNullOrWhiteSpace(content) || String.IsNullOrEmpty(content))
            {
                field.BackColor = Color.Bisque;
                return false;
            }
            else 
            {
                
                return true;
            }
        }

        private bool checkMaskedBox(string content, MaskedTextBox field)
        {
           field.BackColor = Color.White;

           if (String.IsNullOrWhiteSpace(content) || String.IsNullOrEmpty(content))
            {
                field.BackColor = Color.Bisque;
                return false;
            }
            else
            {
               return true;
            }

          
        }

        private bool checkContent()
        {
            bool retval = true;


            if (checkTextBox(txtUsername.Text, txtUsername))
            {
                userdata.username = txtUsername.Text;                
            }
            else
            {
                retval = false;
            }

            if (checkTextBox(txtVorname.Text, txtVorname))
            {
                userdata.firstname = txtVorname.Text;
            }
            else
            {
                retval = false;
            }

            if (checkTextBox(txtNachname.Text, txtNachname))
            {
                userdata.lastname = txtNachname.Text;
            }
            else
            {
                retval = false;
            }

            if (checkTextBox(txtEmail.Text, txtEmail))
            {
                userdata.email = txtEmail.Text;
            }
            else
            {
                retval = false;
            }

            if (checkMaskedBox(mtbPassword.Text, mtbPassword))
            {
                userdata.passwort = Convert.ToInt32(mtbPassword.Text);
            }
            else
            {
                retval = false;
            }

            return retval;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
