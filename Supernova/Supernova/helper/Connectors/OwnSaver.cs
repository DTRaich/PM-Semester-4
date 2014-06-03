using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    class OwnSaver
    {
        private DBTYPE DB;
        private CONNECTOR connect;

        public OwnSaver(DBTYPE DB)
        {
            // TODO: Complete member initialization
            this.DB = DB;
            connect = ConnectorFactory.getConnector(DB);
        }


        public void SaveStructur(DataTable toSaveTable, Tables currentTable)
        {
            switch (currentTable)
            {
                case Tables.Abteilungen: SaveStructurDeparts(toSaveTable);
                    break;
                case Tables.Benutzer: SaveStructurUser(toSaveTable);
                    break;
            }
        }

        private void SaveStructurUser(DataTable toSaveTable)
        {
            foreach (DataRow dr in toSaveTable.Rows)
            {
            }
            
        }

        private void SaveStructurDeparts(DataTable toSaveTable)
        {
            foreach (DataRow dr in toSaveTable.Rows)
            {
            }
            
        }
    }
    

}
