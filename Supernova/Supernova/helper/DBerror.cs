using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.helper
{
    public class DBerror
    {
        private static DBerror dberror;
        private ToolStripStatusLabel dBerrolabel;
        private DBerror()
        {
        }

        //ToolStripStatusLabel dblabel
        public static DBerror getInstanze()
        {
            if (dberror == null)
            {
                dberror = new DBerror();
            }
            return dberror;
        }
        public void setDbLabel(ToolStripStatusLabel dblabel)
        {
            dBerrolabel = dblabel;
        }

        public void setDBError()
        {
            dBerrolabel.Text = "Datenbank ist nicht erreichbar!";
            dBerrolabel.Visible = true;
            dBerrolabel.ForeColor = Color.Red;
        }
        public void deleteDBError()
        {
            dBerrolabel.Visible = false;

        }
    }
}
