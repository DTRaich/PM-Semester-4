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
        DBTYPE DB;
        MySqlConnector mysql = new MySqlConnector();
        public FrmWeiserRieseMain()
        {
            InitializeComponent();
            fillBoxes();
        }

        private void fillBoxes()
        {
            cbDBTYPE.DataSource = Enum.GetNames(typeof(DBTYPE));
            cbConnector.DataSource = Enum.GetNames(typeof(Connector));
            cbOperant1.DataSource = Enum.GetNames(typeof(Operant));
            cbOperant2.DataSource = Enum.GetNames(typeof(Operant));
            cbOriginTable.DataSource = Enum.GetNames(typeof(Tables));

        }

      #region click leftside
        private void btnTest_Click(object sender, EventArgs e)
        {
              DB = (DBTYPE)Enum.Parse(typeof(DBTYPE), cbDBTYPE.SelectedItem.ToString());
           
            switch (DB)
            {
                case DBTYPE.MySql: SetUpMysql();
                                        
                    break;
            }
          
           
        }

        private void SetUpMysql()
        {
            mysql = new MySqlConnector();
            mysql.ConString = txtConnect.Text;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtcolumn1.Text = string.Empty;
            txtcolumn2.Text = string.Empty;
            txtConnect.Text = string.Empty;
            txtTabelle.Text = string.Empty;
            txtvalue1.Text = string.Empty;
            txtvalue2.Text = string.Empty;    
        }
#endregion




    }
}
