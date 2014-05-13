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
    public partial class FrmRightsReglement : Form
    {
        DataTable userGroups = new DataTable();

        public FrmRightsReglement()
        {
            InitializeComponent();
            initializeGroups();
        }

        private void initializeGroups()
        {
            ParameterLoad pl = new ParameterLoad();
            userGroups = pl.loadUserGroups();

            try
            {   

            cbUserGroups.DataSource = userGroups;
            cbUserGroups.ValueMember = "USER_GROUPS_ID";
            cbUserGroups.DisplayMember = "UG_NAME";
               
            }
            catch (Exception ex)
            {

            }
        }
    }
}
