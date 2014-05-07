using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Supernova
{
    public partial class FrmOrderControlling : Form
    {

        private List<Form> formslist;
        Form currentFrm;
        private int o= 0;

        public FrmOrderControlling(List<Form> FormList)
        {
            InitializeComponent();
            this.formslist = FormList;
        }

        private void FrmOrderControlling_Load(object sender, EventArgs e)
        {
            currentFrm = formslist[o];
            this.pnlControl.Controls.Add(currentFrm);
            currentFrm.Show();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MethodInfo info = currentFrm.GetType().GetMethod("checkAndValidateForm");            
            bool ok = (bool)info.Invoke(currentFrm, null);
            if (ok)
            {
                o = 0 + 1;
                currentFrm.Close();
                currentFrm = formslist[o];               
                this.pnlControl.Controls.Add(currentFrm);
                currentFrm.Show();
            }
        }
    }
}
