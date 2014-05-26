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
            }

        }

        private void ShowLogin()
        {
            rtbText.Text = texter.GetLogin();
        }
    }
}
