using Supernova.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Projects
{
    public partial class FrmBasisData : Form,ICriteriaChecking
    {
        public FrmBasisData()
        {
            InitializeComponent();
        }

        public bool checkAndValidateForm()
        {
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
