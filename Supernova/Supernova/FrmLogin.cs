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

        //Button Click Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        //Login Method
        private void Login() 
        {
        
            // Set text-boxes and labels to standard
            txtPassword.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            lblErrorUsername.Visible = false;
            lblErrorPassword.Visible = false;

            // declare variables
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            txtPassword.Text = string.Empty;
            //checks if username- or password field are empty
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrEmpty(username))
            {
                //Change TextBox Colour and show error label
                txtUsername.BackColor = Color.Bisque;
                lblErrorUsername.ForeColor = Color.DarkRed;
                lblErrorUsername.Visible = true;

                if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                {
                    //Change TextBox Colour and show error label
                    txtPassword.BackColor = Color.Bisque;
                    lblErrorPassword.ForeColor = Color.DarkRed;
                    lblErrorPassword.Visible = true;
                }

            }
            else
            {
                if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                {
                    //Change TextBox Colour and show error label
                    txtPassword.BackColor = Color.Bisque;
                    lblErrorPassword.ForeColor = Color.DarkRed;
                    lblErrorPassword.Visible = true;
                }
                else
                {
                    int pass = 0;
                     try
                     {
                         //convert password to int
                         pass = Convert.ToInt32(password);
                     }
                     catch (Exception ex)
                     {

                     }

                    DataLoad dl = new DataLoad();

                    // method Logon , checks if user exists
                        int userid = dl.LogOn(username, pass);

                    if (userid == -1)
                    {
                        // Error werfen
                        FrmAfirmative UnknownUser = new FrmAfirmative("Diese Login Daten sind uns nicht bekannt \n Bitte überprüfen sie ihre Eingaben.", 'e');
                        UnknownUser.StartPosition = FormStartPosition.CenterParent;
                        UnknownUser.ShowDialog();

                    }
                    else
                        {
                        if (userid == -2)
                        {
                            // -2 means userid is current userid, user already logged in
                            FrmAfirmative AlreadyLoggedIn = new FrmAfirmative("Dieser User ist bereits eingeloggt \n Bitte ändern sie die Login Daten.", 'e');
                            AlreadyLoggedIn.StartPosition = FormStartPosition.CenterParent;
                            AlreadyLoggedIn.ShowDialog();
                        }
                        else
                        {
                            // nach login, userid wird gesetzt
                            lead.setUserID(userid);
                            lead.RemoveLogin();
                            lead.LoadProjektView();
                        }
                    }

                }
            }

        }

       
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)   
        {
           if (e.KeyChar == (char)13)
            {
                Login();
               
            }
        }


    }
}
