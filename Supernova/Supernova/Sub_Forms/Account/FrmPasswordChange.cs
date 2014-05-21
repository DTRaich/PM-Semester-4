using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.Sub_Forms.General;
using Supernova.objects;

namespace Supernova.Sub_Forms.Account
{
    public partial class FrmPasswordChange : Form
    {
        User us;
        public FrmPasswordChange(int uid)
        {
            InitializeComponent();
            us = new User();
            us.LoadUser(uid);
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            if (checkifcorrectOldPW() && checkifnewPWmatches())
            {
                us.passwort = Convert.ToInt32(mtbNewPW1.Text.ToString());
                if (us.changePasswort())
                {
                 
                    FrmAfirmative frm = new FrmAfirmative("Password wurde geändert.",'i');
                    frm.ShowDialog();
                    this.Close();

                }
                else
                {
                    FrmAfirmative frm = new FrmAfirmative("Password konnte nicht geändert werden. \n Bitte wenden Sie sich an den Administrator.", 'e');
                    frm.ShowDialog();
                }
            }
        }

        private bool checkifnewPWmatches()
        {
            if (mtbNewPW1.Text.ToString()!=String.Empty && mtbNewPW1.Text == mtbNewPW2.Text)
            {
                return true;
            }
            else
            {
                FrmAfirmative frm = new FrmAfirmative("Das neue Passwort stimmt nicht überein!",'e');
                frm.ShowDialog();
                return false;
            }

        }

        private bool checkifcorrectOldPW()
        {
            if (us.passwort.ToString() == mtbOldPW.Text.ToString())
            {
                return true;
            }
            else
            {
                FrmAfirmative frm = new FrmAfirmative("Das eingegebene Passwort ist falsch! \n Bitte versuchen Sie es erneut.", 'e');
                frm.ShowDialog();
                return false;
            }
        }

    }
}
