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
            us.LoadUser(uid);
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            if (checkifcorrectOldPW() && checkifnewPWmatches())
            {
                us.passwort = Convert.ToInt32(mtbNewPW1.Text.ToString());
                us.changePasswort();
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
                FrmAfirmative frm = new FrmAfirmative("inkorrekt Paswort", 'e');
                frm.ShowDialog();
                return false;
            }
        }

    }
}
