using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;
using Supernova.Sub_Forms.General;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmRightsReglement : Form
    {
        int newRight = 0;
        DataTable userGroups;
        DataTable rights;
        DataTable rightsMapping;
        DataTable originRightsMapping;
        

        ParameterLoad pl;
        DataLoad loader;

        public FrmRightsReglement()
        {
            InitializeComponent();
            pl = new ParameterLoad();
            loader = new DataLoad();

            initializeGroups();
            startGridPreparing();
        }

        #region prepare
        
        private void startGridPreparing()
        {
            if (loadTables())
            {
                prepareGridView();
            }
            else 
            { 
                // DB Fehler
                this.Close();
            }
           
        }

        private bool loadTables()
        {
            resetGrid();
      
            bool retval = true;

            rights = pl.loadRights();

            rightsMapping = loader.loadRightsMappingTable(Convert.ToInt32(cbUserGroups.SelectedValue));
            if (rightsMapping.Rows.Count > 0)
            {
                originRightsMapping = rightsMapping.Copy();
            }
            else
            {
                retval = false;
            }
            return retval;


        }

        private void prepareGridView()
        {

            rightsGrid.DataSource = rightsMapping;

            DataGridViewComboBoxColumn cl = new DataGridViewComboBoxColumn();
            cl.DataSource = rights;
            cl.ValueMember = "RIGHTS_ID";
            cl.DisplayMember = "R_NAME";
            rightsGrid.Columns.Add(cl);
            rightsGrid.Columns[0].Visible = false;
            rightsGrid.Columns[1].HeaderText = "Ansicht";
            rightsGrid.Columns[4].HeaderText = "Recht";
            rightsGrid.Columns[2].Visible = false;
            rightsGrid.Columns[3].Visible = false;
            rightsGrid.Columns[1].ReadOnly = true;
            rightsGrid.Columns[4].ReadOnly = true;

            rightsGrid.EndEdit();
            
        }

        private void resetGrid()
        {
            rightsGrid.Columns.Clear();
            rightsMapping = null;
            rightsMapping = new DataTable();
            rights = null;
            rights = new DataTable();
            rightsGrid.DataSource = null;

            

        }


        private void initializeGroups()
        {
            userGroups = pl.loadUserGroups();

            try
            {

                cbUserGroups.DataSource = userGroups;
                cbUserGroups.ValueMember = "USER_GROUPS_ID";
                cbUserGroups.DisplayMember = "UG_NAME";

            }
            catch (Exception ex)
            {
                FrmAfirmative DBError = new FrmAfirmative("Fehler in der Datenbank. \n Bitte wenden sie sich an den Administrator.", 'e');
                DBError.StartPosition = FormStartPosition.CenterParent;
                DBError.ShowDialog();
            }
        }


        #endregion


        #region Click-Events

        private void btnLoadGroups_Click(object sender, EventArgs e)
        {
            startGridPreparing();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable newRights = new DataTable();
            DataColumn cl = new DataColumn();
            newRights.Columns.Add(cl);
            DataColumn cl2 = new DataColumn();
            newRights.Columns.Add(cl2);
            DataRow dr;
            foreach (DataGridViewRow r in rightsGrid.Rows) 
            {
                dr = newRights.NewRow();
                dr[0] = Convert.ToInt32(r.Cells[1].Value);
                dr[1] = Convert.ToInt32(r.Cells[0].Value);
            }
            
        }

        #endregion




    }
}
