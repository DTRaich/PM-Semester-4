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
        public virtual DataTable SelectStruct(string TableName)
        {
            return null;
        }
        protected string getConnector(string p)
        {
            Connector c = (Connector)Enum.Parse(typeof(Connector), p);
            string s = string.Empty;
            switch (c)
            {
                case Connector.AND: s = "AND";
                    break;
                case Connector.OR: s = "OR";
                    break;
            }

            return s;

        }

        protected string getOperant(string typ)
        {
            Operant c = (Operant)Enum.Parse(typeof(Operant), typ);
            string s = string.Empty;
            switch (c)
            {
                case Operant.bigger: s = ">";
                    break;
                case Operant.biggerEqual: s = ">=";
                    break;
                case Operant.samllerEqual: s = "<=";
                    break;
                case Operant.equal: s = "=";
                    break;
                case Operant.smaller: s = "<";
                    break;
            }

            return s;
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
