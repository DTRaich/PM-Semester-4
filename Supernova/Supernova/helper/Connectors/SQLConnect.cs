using Supernova.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    class SQLConnect : IConnector
    {
        public bool connectToDB()
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable SelectTable(string TableName, System.Data.DataTable Filter)
        {
            throw new NotImplementedException();
        }
    }
}
