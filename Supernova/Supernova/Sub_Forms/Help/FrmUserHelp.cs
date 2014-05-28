using Supernova.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Help
{
    public partial class FrmUserHelp : Form
    {
        HelperTexts texter = new HelperTexts();

        public FrmUserHelp()
        {
            InitializeComponent();
        }

        private void tvUserHelp_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "login": ShowLogin();
                    break;
                case "abteilungskapazitaet": ShowAbteilungskapazitaet();
                    break;
                case "benutzerinformationen": ShowBenutzerinformationen();
                    break;
                case "benutzerverwaltung": ShowBenutzerverwaltung();
                    break;
                case "passwort_aendern": ShowPasswortAendern();
                    break;
            }

        }

        private void ShowLogin()
        {
            rtbText.Text = texter.GetLogin();
        }

        private void ShowAbteilungskapazitaet()
        {
            rtbText.Text = texter.GetAbteilungskapazitaet();
        }

        private void ShowBenutzerinformationen()
        {
            rtbText.Text = texter.GetBenutzerinformationen();
        }

        private void ShowBenutzerverwaltung()
        {
            rtbText.Text = texter.GetBenutzerverwaltung();
        }

        private void ShowPasswortAendern()
        {
            rtbText.Text = texter.GetPasswortAendern();
        }
    }
}
