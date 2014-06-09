using Supernova.data;
using Supernova.helper;
using Supernova.helper.Connectors;
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
        #region setup
        DBTYPE DB;
        CONNECTOR connect;
        DataTable externTable;
        Tables currentTable;
        string  fromTable;

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
        #endregion
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

            dgvExtern.DataSource = null;
            dgvExtern.Columns.Clear();
            dgvExternStruct.DataSource = null;
            dgvExternStruct.Columns.Clear();
            externTable = null;
            externTable = new DataTable();
        }
        #endregion
        #region methods leftside
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
            fromTable = tableName;
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
           DataTable Struktur = connect.SelectStruct(tableName);
           dgvExtern.DataSource = null;
           dgvExtern.DataSource = externTable;

           dgvExternStruct.DataSource = null;
           dgvExternStruct.DataSource = Struktur;

           for (int i = 0; i < dgvExtern.Columns.Count; i++)
           {
               dgvExtern.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
           }
           for (int i = 0; i < dgvExternStruct.Columns.Count; i++)
           {
               dgvExternStruct.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
           }

             
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
        #endregion 

        #region drag and Drop structur

        private void dgvWeiserRieseStruct_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void dgvExternStruct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo info = dgvExternStruct.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    DataRowView view = (DataRowView)dgvExternStruct.Rows[info.RowIndex].DataBoundItem;
                    if (view != null)
                    {
                        dgvExternStruct.DoDragDrop(view, DragDropEffects.Copy);
                    }
                }
            }
        }

        private void dgvWeiserRieseStruct_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvWeiserRieseStruct.PointToClient(new Point(e.X, e.Y));
            int  currentRow =   dgvWeiserRieseStruct.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
          //  int currentcolumn = dgvWeiserRieseStruct.HitTest(clientPoint.X, clientPoint.Y).ColumnIndex;

            if (currentRow != -1 && e.Data.GetDataPresent(typeof(DataRowView)))
            {
                DataRowView TableView = (DataRowView)e.Data.GetData(typeof(DataRowView));
                DataGridViewRow curRow = (DataGridViewRow)dgvWeiserRieseStruct.Rows[currentRow];
                if (CheckTableMatches(TableView, curRow))
                {
                    insertColumnNameinStructTable(TableView.Row[0].ToString(), currentRow);
                }
                else
                {
                    FrmAfirmative error = new FrmAfirmative("Fehler \nDatei-Typ oder Länge ist nicht passend", 'e');
                    error.ShowDialog();
                }
            }

        }

        #endregion
        #region DragDropperHelper
        private void insertColumnNameinStructTable(string p, int currentRow)
        {
            dgvWeiserRieseStruct[dgvWeiserRieseStruct.Columns.Count - 1, currentRow].Value = p;
        }

        private bool CheckTableMatches(DataRowView TableView, DataGridViewRow currentRow)
        {
            DBerror error = DBerror.getInstanze();
            try
            {
                
                error.deleteDBError();
                string errortext = string.Empty;
                // wenn nicht gleicher datentyp
                if (!currentRow.Cells[2].Value.ToString().Equals(TableView[2].ToString()))
                {
                    errortext = "Falscher Daten-Typ \n";
                    error.setDBError(errortext);
                    return false;
                }

                // Datenlänge 
                try
                {
                    if (Convert.ToDouble(currentRow.Cells[3].Value) < Convert.ToDouble(TableView[3].ToString()))
                    {
                        errortext = errortext + "Maximale Länge der Daten zu hoch \n";
                        error.setDBError(errortext);
                        return false;
                    }
                }
                catch (Exception)
                {
                }
                // nullable 
                string origin = currentRow.Cells[1].Value.ToString();
                string foreign = TableView[1].ToString();
                if (origin.Equals("NO") && foreign.Equals("YES"))
                {
                    
                    errortext = errortext + "Null Fehler \n";
                    error.setDBError(errortext);
                    return false;
                }

            }
            catch(Exception ex)
            {
                error.setDBError("Kritischer Fehler in DragDrop Routine");
                return false;
            }
            return true;
        }  
        #endregion

        #region drag drop inhalt

        private void dgvWeiserRieseInhalt_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dgvWeiserRieseInhalt_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRowView)))
            {

                DataRowView TableView = (DataRowView)e.Data.GetData(typeof(DataRowView));

            }
        }
        private void dgvExtern_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo info = dgvExtern.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    DataRowView view = (DataRowView)dgvExtern.Rows[info.RowIndex].DataBoundItem;
                    if (view != null)
                    {
                        dgvExtern.DoDragDrop(view, DragDropEffects.Copy);
                    }
                }
            }
        }
     

        
        #endregion
        #region rightside click

        private void btnGetAViewData_Click(object sender, EventArgs e)
        {
           
        }
        private void btnStruct_Click(object sender, EventArgs e)
        {
            ValidationData val = new ValidationData();
            Tables tabl = (Tables)Enum.Parse(typeof(Tables), cbOriginTable.SelectedItem.ToString());
            DataTable structur;
            DataTable inhalt;
            if (tabl == Tables.Abteilungen)
            {
                structur = val.GetAllColumnsDepartment();
                inhalt = val.GetRowDepartment();
                currentTable = Tables.Abteilungen;
               
            }
            else
            {
                structur = val.GetAllColumnsUser();
                inhalt = val.GetRowUser();
                currentTable = Tables.Benutzer;

            }
            DataColumn dc = new DataColumn("Referenz-Spalte");
            structur.Columns.Add(dc);
            dgvWeiserRieseStruct.DataSource = null;
            dgvWeiserRieseStruct.DataSource = structur;

            dgvWeiserRieseInhalt.DataSource = null;
            dgvWeiserRieseInhalt.DataSource = inhalt;
            dgvWeiserRieseInhalt.Columns[0].Visible = false;


            for (int i = 0; i < dgvWeiserRieseStruct.Columns.Count; i++)
            {
                dgvWeiserRieseStruct.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgvWeiserRieseInhalt.Columns.Count; i++)
            {
                dgvWeiserRieseInhalt.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        private void btnGetNewData_Click(object sender, EventArgs e)
        {
            
            DataTable toSaveTable = getToSaveData();
            if (toSaveTable.Rows.Count > 0)
            {

                OwnSaver ownsaver = new OwnSaver(DB);
                ownsaver.SaveStructur(toSaveTable, currentTable, fromTable);
                //FrmAfirmative error = new FrmAfirmative("Daten wurden übernommen", 'i');
                //error.ShowDialog();
            }
            else
            {
                FrmAfirmative error = new FrmAfirmative("Fehler\n Keine Änderungen festgestellt", 'e');
                error.ShowDialog();
            }
           
           
        }

     
        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            StartExcelImporter();
        }

       
        private void btnDiscardSettings_Click(object sender, EventArgs e)
        {
            dgvWeiserRieseInhalt.DataSource = null;
            dgvWeiserRieseInhalt.Columns.Clear();
            dgvWeiserRieseStruct.DataSource = null;
            dgvWeiserRieseStruct.Columns.Clear(); 
        }
        #endregion


        #region rightside methods

        private DataTable getToSaveData()
        {
            DataTable toSave = new DataTable();
            DataColumn dc = new DataColumn("FROM");
            DataColumn dc2 = new DataColumn("TO");
            toSave.Columns.Add(dc);
            toSave.Columns.Add(dc2);
            toSave.AcceptChanges();
            DataRow dr;

            foreach (DataGridViewRow gridrow in dgvWeiserRieseStruct.Rows)
            {
                DataGridViewCell dgcell = gridrow.Cells[dgvWeiserRieseStruct.Columns.Count - 1];
                if (dgcell.Value != null && !dgcell.Value.ToString().Equals(string.Empty))
                {
                    dr = toSave.NewRow();
                    dr[0] = gridrow.Cells[0].Value;
                    dr[1] = dgcell.Value;
                    toSave.Rows.Add(dr);
                }
            }
            toSave.AcceptChanges();
            return toSave;
        }

        private void StartExcelImporter()
        {
            //MessageBox.Show("excel importer du lutscher");
        }
        #endregion
        
        #region tab pages locker
      


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl2.SelectedIndex == e.TabPageIndex)
            {
                // nix
            }
            else
            {
                tabControl2.SelectedIndex = e.TabPageIndex;
                if (e.TabPageIndex == 0)
                {
                    btnGetAViewData.Visible = false;
                    btnGetStructAndWholetable.Visible = true;

                }
                else
                {
                    btnGetAViewData.Visible = true;
                    btnGetStructAndWholetable.Visible = false;
                }
            }
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == e.TabPageIndex)
            {
                // nix
            }
            else
            {
                tabControl1.SelectedIndex = e.TabPageIndex;
                if (e.TabPageIndex == 0)
                {
                    btnGetAViewData.Visible = false;
                    btnGetStructAndWholetable.Visible = true;

                }
                else
                {
                    btnGetAViewData.Visible = true;
                    btnGetStructAndWholetable.Visible = false;
                }
            }
        }

        #endregion

        


    }
}
