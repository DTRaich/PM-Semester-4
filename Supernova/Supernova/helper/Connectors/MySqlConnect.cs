using MySql.Data.MySqlClient;
using Supernova.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    class MySqlConnector : CONNECTOR
    {
        string conString;

        public string ConString
        {
            get { return conString; }
            set { conString = value; }
        }


        public bool connectToDB()
        {
            MySqlConnection connection = new MySqlConnection(conString);
            bool retval = true;
            try
            {
              connection.Open();
               
            }
            catch (Exception ex)
            {
                retval = false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return retval;
        }
        
        public System.Data.DataTable SelectTable(string TableName, System.Data.DataTable Filter)
        {
            return null;
        }
    }
}
