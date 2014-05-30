using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    public abstract class CONNECTOR
    {
        public string test()
        {
            return "sdasd";
        }
    }
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
