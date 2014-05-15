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
        ParameterLoad pl = new ParameterLoad();
        private int personalUserID = 0;
        private int depIdBeforeChange = -1;

        #region cosntructAndInitialize
        public FrmUser(int userid)
        {
            InitializeComponent();
            initializeComboBox();
            userdata = new User();
            personalUserID = userid;
        }

        private void initializeComboBox()
        {
          
            departments = pl.loadAvaliableDeparments();
            usergroup = pl.loadUserGroups();

            //sonder row für abts ohne abteilung
            DataRow dr = departments.NewRow();
            dr["DEPARTMENTS_ID"] = 0;
            dr["D_NAME"] = "Keine";

            departments.Rows.Add(dr);

            try
            {
                cbAbteilung.DataSource = departments;
                cbAbteilung.ValueMember = "DEPARTMENTS_ID";
                cbAbteilung.DisplayMember = "D_NAME";
                cbAbteilung.Visible = false;
                lblAbteilung.Visible = false;

                cbBenutzergruppe.DataSource = usergroup;
                cbBenutzergruppe.ValueMember = "USER_GROUPS_ID";
                cbBenutzergruppe.DisplayMember = "UG_NAME";
                cbBenutzergruppe.SelectedValueChanged +=cbBenutzergruppe_SelectedValueChanged;

            }
            catch (Exception ex)
            {
                FrmAfirmative DBError = new FrmAfirmative("Fehler beim Laden der Anwendung. \n Bitte wenden sie sich an den Administrator.", 'e');
                DBError.StartPosition = FormStartPosition.CenterParent;
                DBError.ShowDialog();
                this.Close();
            }

          }
       
        #endregion

        #region Events
        private void cbBenutzergruppe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbBenutzergruppe.SelectedValue) == 25)
            {
                cbAbteilung.Visible = true;
                lblAbteilung.Visible = true;
            }
            else
            {
                cbAbteilung.Visible = false;
                lblAbteilung.Visible = false;
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
                    txtUsername.ReadOnly = true;
                    depIdBeforeChange = userdata.departmentID;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
            DataLoad loader = new DataLoad();

            if (checkContent())
            {
                if (cbAbteilung.Visible == true)
                {
                    if (Convert.ToInt32(cbAbteilung.SelectedValue) == 0)
                    {
                        userdata.departmentID = -1;

                    }
                    else
                    {
                        userdata.departmentID = Convert.ToInt32(cbAbteilung.SelectedValue);
                    }
                }
                else
                {
                    userdata.departmentID = -1;
                }

                userdata.userGroupID = Convert.ToInt32(cbBenutzergruppe.SelectedValue);

                // vermeidung doppeter usernamen
                if (txtUsername.ReadOnly)
                {
                    normalUpdateSave();
                }
                else
                {
                    DataTable dt = loader.LoadUserData(userdata.username);
                    if (dt.Rows.Count > 0)
                    {
                        FrmAfirmative SaveNewUser = new FrmAfirmative("Speichern nicht möglich. \n Benutzer bereits vorhanden", 'e');
                        SaveNewUser.ShowDialog();
                    }
                    else
                    {
                        normalUpdateSave();
                    }
                }
                

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userdata.userID == personalUserID)
            {
                FrmAfirmative SaveNewUser = new FrmAfirmative("Den eigenen aktiven Benutzer zu löschen ist verboten. \n ", 'e');
                SaveNewUser.ShowDialog();
            }
            else
            {
                              
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetBoxes();
            prepareBoxes();
        }

        #endregion

        
        #region privateMethod

       
        private void normalUpdateSave()
        {
            DataSave saver = new DataSave();

            if (saver.UpdateUser(userdata,depIdBeforeChange))
            {
                FrmAfirmative SaveNewUser = new FrmAfirmative("Diese Benutzerdaten wurden gespeichert. \n ", 'i');
                SaveNewUser.ShowDialog();

                resetBoxes();
            }
            else
            {
                FrmAfirmative SaveNewUser = new FrmAfirmative("Speichern fehlgeschlagen. \n Bitte wenden sie sich an den Administrator", 'e');
                SaveNewUser.StartPosition = FormStartPosition.CenterParent;
                SaveNewUser.ShowDialog();
            }
        }
      

        private void deleteNonAbt()
        {
            DataSave saver = new DataSave();

            bool deleteWorked = saver.DeleteUser(userdata.userID, 0);
            if (deleteWorked)
            {
                FrmAfirmative DELTEUser = new FrmAfirmative("Der Benutzer wurde gelöscht. \n ", 's');
                DELTEUser.ShowDialog();
                resetBoxes();
            }
            else
            {
                FrmAfirmative DELTEUser = new FrmAfirmative("Speichern fehlgeschlagen. \n Bitte wenden sie sich an den Administrator", 'e');
                DELTEUser.ShowDialog();
            }
            resetBoxes();

        }



        private void prepareBoxes()
        {
            txtVorname.Text = userdata.firstname;
            txtNachname.Text = userdata.lastname;
            txtUsername.Text = userdata.username;
            txtEmail.Text = userdata.email;
            cbBenutzergruppe.SelectedValue = userdata.userGroupID;

            if (userdata.departmentID != -1)
            {
                departments = pl.loadMyDeparment(userdata.userID);
                //sonder row für abts ohne abteilung
                DataRow dr = departments.NewRow();
                dr["DEPARTMENTS_ID"] = 0;
                dr["D_NAME"] = "Keine";

                departments.Rows.Add(dr);
                cbAbteilung.DataSource = departments;
                cbAbteilung.SelectedValue = userdata.departmentID;
                cbAbteilung.ValueMember = "DEPARTMENTS_ID";
                cbAbteilung.DisplayMember = "D_NAME";
               
            }
            else
            {
                departments = pl.loadAvaliableDeparments();
                //sonder row für abts ohne abteilung
                DataRow dr = departments.NewRow();
                dr["DEPARTMENTS_ID"] = 0;
                dr["D_NAME"] = "Keine";

                departments.Rows.Add(dr);
                cbAbteilung.DataSource = departments;
                cbAbteilung.SelectedValue = userdata.departmentID;
                cbAbteilung.ValueMember = "DEPARTMENTS_ID";
                cbAbteilung.DisplayMember = "D_NAME";
                cbAbteilung.SelectedValue = 0;
            }

           // txtUsername.ReadOnly = true;

        }

        private void resetBoxes()
        {
            txtVorname.Text = string.Empty;
            txtNachname.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsernameLoad.Text = string.Empty;
            cbBenutzergruppe.SelectedIndex = 1;

            mtbPassword.ResetText();
            cbAbteilung.Visible = false;


            txtUsername.ReadOnly = false;
            userdata = new User();
            depIdBeforeChange = -1;
            

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
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAbteilung_Click(object sender, EventArgs e)
        {

        }

       

        
        
    }
}
