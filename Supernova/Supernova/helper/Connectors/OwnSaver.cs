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
        }
        

        public void SaveStructur(DataTable toSaveTable)
        {
            // 
        }
    }
}
