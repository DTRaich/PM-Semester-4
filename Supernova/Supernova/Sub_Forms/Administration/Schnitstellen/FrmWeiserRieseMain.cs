using Supernova.helper.Connectors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Administration.Schnitstellen
{
    public partial class FrmWeiserRieseMain : Form
    {
        //  EmployeeType empType = (EmployeeType)Enum.Parse(ddl.SelectedValue); 
        public FrmWeiserRieseMain()
        {
            InitializeComponent();
            fillBoxes();
        }

        private void fillBoxes()
        {
            cbDBTYPE.DataSource = Enum.GetNames(typeof(DBTYPE));
          
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

       
    }
}
