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
        DataTable userGroups;
        DataTable forms;
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

        private void startGridPreparing()
        {
            if (loadTables())
            {
                prepareGridView();
                setValues();
            }
            else 
            { 
                // DB Fehler
                this.Close();
            }
           
        }

        private bool loadTables()
        {
            bool retval = true;
            rights = pl.loadRights();
            forms = pl.loadForms();
            rightsMapping = loader.loadRightsMappingTable(Convert.ToInt32(cbUserGroups.SelectedValue));
            if (rights.Rows.Count > 0 && forms.Rows.Count > 0 && rightsMapping.Rows.Count > 0)
            {
                originRightsMapping = rightsMapping.Copy();
            }
            else 
            {
                retval = false;
            }
            return retval;
          

        }

        private void setValues()
        {
            // 
        }

        private void prepareGridView()
        {
            rightsGrid.DataSource = forms;
            DataGridViewComboBoxColumn cl = new DataGridViewComboBoxColumn();
            cl.DataSource = rights;
            cl.ValueMember = "RIGHTS_ID";
            cl.DisplayMember = "R_NAME";
            rightsGrid.Columns.Add(cl);
            rightsGrid.Columns[0].Visible = false;
            rightsGrid.Columns[1].HeaderText = "Ansicht";
            rightsGrid.Columns[1].ReadOnly = true;
            rightsGrid.Columns[2].HeaderText = "Recht";
      
            rightsGrid.EndEdit();
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
                FrmAfirmative DBError = new FrmAfirmative("Fehler in der Datenbank. \n Bitte wenden sie sich an den Administrator.",'e');
                DBError.StartPosition = FormStartPosition.CenterParent;
                DBError.ShowDialog();
            }
        }
    }
}
