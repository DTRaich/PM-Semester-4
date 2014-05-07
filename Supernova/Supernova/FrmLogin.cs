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

namespace Supernova
{
    public partial class FrmLogin : Form
    {
        private Leader lead;
        public FrmLogin(Leader l)
        {
            InitializeComponent();
            this.lead = l;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login() 
        {
        
            txtPassword.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            lblErrorUsername.Visible = false;
            lblErrorPassword.Visible = false;

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrEmpty(username))
            {
                //error anzeigen
                txtUsername.BackColor = Color.Bisque;
                lblErrorUsername.ForeColor = Color.DarkRed;
                lblErrorUsername.Visible = true;

                if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                {
                    //error anzeigen
                    txtPassword.BackColor = Color.Bisque;
                    lblErrorPassword.ForeColor = Color.DarkRed;
                    lblErrorPassword.Visible = true;
                }

            }
            else
            {
                if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                {
                   
                    txtPassword.BackColor = Color.Bisque;
                    lblErrorPassword.ForeColor = Color.DarkRed;
                    lblErrorPassword.Visible = true;
                }
                else
                {
                    int pass = 0;
                     try
                     {
                         pass = Convert.ToInt32(password);
                     }
                     catch (Exception ex)
                     {

                     }

                    DataLoad dl = new DataLoad();

                    int userid = dl.LogOn(username, pass);

                    if (userid == -1)
                    {
                        // Error werfen
                        FrmAfirmative UnknownUser = new FrmAfirmative("Diese Login Daten sind uns nicht bekannt \n Bitte überprüfen sie ihre Eingaben.", 'e');
                        UnknownUser.ShowDialog();
                    }
                    else
                    {
                        lead.setUserID(userid);
                        InitializeRights();
                    }

                }
            }

        }

        private void InitializeRights()
        {
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)   
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //        Login();
            }
        }


    }
}
