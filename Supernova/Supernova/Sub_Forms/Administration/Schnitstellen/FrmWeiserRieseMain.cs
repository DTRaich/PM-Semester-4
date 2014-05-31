﻿using Supernova.helper.Connectors;
using Supernova.Sub_Forms.General;
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
        CONNECTOR connect;
        DataTable externTable;

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
              testConnection(DB);  
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            DB = (DBTYPE)Enum.Parse(typeof(DBTYPE), cbDBTYPE.SelectedItem.ToString());
            SelectTable(DB);
           
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


        private void testConnection(DBTYPE dbty)
        {
            lblDone.Visible = false;
            string connectString = txtConnect.Text;
            if (!String.IsNullOrEmpty(connectString))
            {
                connect = ConnectorFactory.getConnector(dbty);
                connect.ConString = connectString;
                if (connect.connectToDB())
                {
                  lblDone.Visible = true;
                 lblDone.Text = "Erfolgreich";
                 lblDone.ForeColor = Color.Green;
                }
                else
                {
                lblDone.Visible = true;
                lblDone.Text = "Fehlgeschlagen";
                lblDone.ForeColor = Color.Red;
                }
            }
            else
            {
                FrmAfirmative frm = new FrmAfirmative("Bitte Connection-String angeben", 'e');
                frm.ShowDialog();
            }
            
        }

        private void SelectTable(DBTYPE DB)
        {
            string tableName = txtTabelle.Text;
            string connectString = txtConnect.Text;
            if (!String.IsNullOrEmpty(tableName) && !String.IsNullOrEmpty(connectString))
            {
                LoadTable(DB, connectString, tableName);
            }
            else
            {
                FrmAfirmative frm = new FrmAfirmative("Bitte Connection-String angeben\nBitte Tabellen-Name angeben", 'e');
                frm.ShowDialog();
            }
        }

        private void LoadTable(DBTYPE dbty, string con, string tableName)
        {
           DataTable filter = getFilterStuff();
           connect = ConnectorFactory.getConnector(dbty);
           connect.ConString = con;
           externTable = connect.SelectTable(tableName, filter);
             
        }

        private DataTable getFilterStuff()
        {
            #region build table
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Spalte");
            DataColumn dc1 = new DataColumn("Operant");
            DataColumn dc2 = new DataColumn("Wert");
            DataColumn dc3 = new DataColumn("Connect");
            dt.Columns.Add(dc);
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.AcceptChanges();
            DataRow dr;
            DataRow dr2;

            string column1 = txtcolumn1.Text;
            string column2 = txtcolumn1.Text;
            string wert1 = txtvalue1.Text;
            string wert2 = txtvalue2.Text;
            #endregion
                       
            if (!String.IsNullOrEmpty(column1) && !String.IsNullOrEmpty(wert1))
            {
                 Operant op = (Operant)Enum.Parse(typeof(Operant), cbOperant1.SelectedItem.ToString());
                dr = dt.NewRow();
                dr[0] = column1;
                dr[1] = op ;
                dr[2] = wert1;
                if (!String.IsNullOrEmpty(column2) && !String.IsNullOrEmpty(wert2))
                {
                    Operant op2 = (Operant)Enum.Parse(typeof(Operant), cbOperant2.SelectedItem.ToString());
                    Connector con = (Connector)Enum.Parse(typeof(Connector), cbConnector.SelectedItem.ToString());
                    dr[3] = con;
                    dr2 = dt.NewRow();
                    dr2[0] = column2;
                    dr2[1] = op2;
                    dr2[2] = wert2;
                    dt.Rows.Add(dr);
                    dt.Rows.Add(dr2);

                }
                else
                {
                    dt.Rows.Add(dr);
                }
            }
            dt.AcceptChanges();
            return dt;
        }
       
        


    }
}
