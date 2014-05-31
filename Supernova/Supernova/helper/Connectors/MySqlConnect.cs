using MySql.Data.MySqlClient;
using Supernova.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.helper.Connectors
{
    class MySqlConnector : CONNECTOR
    {
        string conString;
        private static MySqlConnector  instance;

        private MySqlConnector() { }

        public static MySqlConnector getInstance()
        {
            if (instance == null)
            {
                instance = new MySqlConnector();
            }

            return instance;
        }



        public override string ConString
        {
            get { return conString; }
            set { conString = value; }
        }


        public override bool connectToDB()
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
        
        public override DataTable SelectTable(string TableName, DataTable Filter)
        {
            DataTable dt = new DataTable();

            MySqlConnection connection = new MySqlConnection(conString);
            try
            {
                connection.Open();
                string com1 = "Select ";
                string comand = "Select GR_FORMS,GR_RIGHTS,GR_GROUP from group_rights where GR_GROUP = " + groupID;
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Auf die Tabelle konnte nicht zugegriffen werden");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return dt;
        }
    }
}
