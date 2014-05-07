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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login() 
        {
            txtPassword.BackColor = Color.White;
            txtUsername.BackColor = Color.White;

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrEmpty(username))
            {
                //error anzeigen
                txtUsername.BackColor = Color.Bisque;

                if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                {
                    //error anzeigen
                    txtPassword.BackColor = Color.Bisque;
                }

            }
            else
            {
                if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                {
                    //error anzeigen
                    txtPassword.BackColor = Color.Bisque;
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
                    }
                    else
                    {
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
