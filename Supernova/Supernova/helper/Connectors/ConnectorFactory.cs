using Supernova.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    #region connector klasse
    public abstract class CONNECTOR : IConnector
    {
        string conString;

        public virtual string ConString
        {
            get { return conString; }
            set { conString = value; }
        }


        public virtual bool connectToDB()
        {
            return true;
        }

        public virtual DataTable SelectTable(string TableName, System.Data.DataTable Filter)
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
                case DBTYPE.MySql: MySqlConnector.getInstance();
                   
                    break;
               
            }

            return MySqlConnector.getInstance();
         }
    }
}
