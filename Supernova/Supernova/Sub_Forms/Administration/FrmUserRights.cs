using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmUserRights : Form
    {
        public FrmUserRights()
        {
            InitializeComponent();
            // hier user anlegen und Gruppen rechte ziehen können
        }

        private void btnUserLoad_Click(object sender, EventArgs e)
        {
            lblErrorText.Visible = false;
            string userload = txtUsernameLoad.Text;

            if (String.IsNullOrWhiteSpace(userload) || String.IsNullOrEmpty(userload)) 
            {
                lblErrorText.ForeColor = Color.DarkRed;
                lblErrorText.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
