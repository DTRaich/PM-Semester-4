using Supernova.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    #region connector klasse
    public abstract class CONNECTOR : IConnector
    {
        string conString;

        public string ConString
        {
            get { return conString; }
            set { conString = value; }
        }


        public bool connectToDB()
        {
            return true;
        }

        public System.Data.DataTable SelectTable(string TableName, System.Data.DataTable Filter)
        {
            return null;
        }
    }
    #endregion
   
    static class ConnectorFactory
    {

        public static CONNECTOR getConnector(DBTYPE db)
        {
            switch (db)
            {
                case DBTYPE.MySql:
                   
                    break;
               
            }
            return new MySqlConnector();

         }
    }
}
