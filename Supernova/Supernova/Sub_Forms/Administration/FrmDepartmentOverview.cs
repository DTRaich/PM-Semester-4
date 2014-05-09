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
    public partial class FrmDepartmentOverview : Form
    {
        public FrmDepartmentOverview()
        {
            InitializeComponent();
            LoadChildForm();
        }

        private void LoadChildForm()
        {
            pnlDepartment.Controls.Clear();
            FrmDepartmentSpecifikation frm = new FrmDepartmentSpecifikation();
            frm.AutoScroll = true;
            frm.AutoSize = true;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlDepartment.Controls.Add(frm);
            frm.Show();
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
