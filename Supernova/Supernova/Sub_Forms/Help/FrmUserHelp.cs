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
            tvUserHelp.Nodes[0].Expand();
            ShowLogin();
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
                case "projekte_anzeigen": ShowProjekteAnzeigen();
                    break;
                case "projekte_erstellen": ShowProjekteErstellen();
                    break;
                case "kriterien_priorisieren": ShowKriterienPriorisieren();
                    break;
                case "budget": ShowBudget();
                    break;
                case "rechteverwaltung": ShowRelease2();
                    break;
                case "schnittstellenverwaltung": ShowRelease2();
                    break;
            }

        }

        private void ShowBudget()
        {
            rtbText.Rtf = texter.GetBudget();
        }

        private void ShowRelease2()
        {
            rtbText.Rtf = "Release 2 : Hilfetext bei vollständiger Implementierung";
        }

        private void ShowLogin()
        {
            rtbText.Rtf = texter.GetLogin();
        }

        private void ShowAbteilungskapazitaet()
        {
            rtbText.Rtf = texter.GetAbteilungskapazitaet();
        }

        private void ShowBenutzerinformationen()
        {
            rtbText.Rtf = texter.GetBenutzerinformationen();
        }

        private void ShowBenutzerverwaltung()
        {
            rtbText.Rtf = texter.GetBenutzerverwaltung();
        }

        private void ShowPasswortAendern()
        {
            rtbText.Rtf = texter.GetPasswortAendern();
        }

        private void ShowProjekteAnzeigen()
        {
            rtbText.Rtf = texter.GetProjekteAnzeigen();
        }

        private void ShowProjekteErstellen()
        {
            rtbText.Rtf = texter.GetProjekteErstellen();
        }

        private void ShowKriterienPriorisieren()
        {
            rtbText.Rtf = texter.GetKriterienPriorisieren();
        }
    }
}
