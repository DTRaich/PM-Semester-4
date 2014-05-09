using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmDepartmentOverview : Form
    {
        public FrmDepartmentOverview(int Userid)
        {
            InitializeComponent();
            LoadChildForm(CheckRights(Userid));            
        }

        private int CheckRights(int Userid)
        {
            DataLoad dl = new DataLoad();
            return dl.UserRight(Userid,this.Name);
        }

        private void LoadChildForm(int rights)
        {
            pnlDepartment.Controls.Clear();
            FrmDepartmentSpecifikation frm = new FrmDepartmentSpecifikation();
            frm.AutoScroll = true;
            frm.AutoSize = true;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlDepartment.Controls.Add(frm);
            frm.Show();
            if (rights == 18 || rights == 19)
            {
                InvalidChoose();
            }
        }

        private void InvalidChoose()
        {
            btnChoose.Visible = false;
            cboDepartment.Visible = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
