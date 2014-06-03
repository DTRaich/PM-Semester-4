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

        public override DataTable SelectStruct(string TableName)
        {
            DataTable dt = new DataTable();

            MySqlConnection connection = new MySqlConnection(conString);
            try
            {
                connection.Open();
                
                string comand ="SELECT COLUMN_NAME,IS_NULLABLE , DATA_TYPE, CHARACTER_MAXIMUM_LENGTH as MAX_LENGTH";
                comand = comand + " FROM information_schema.columns WHERE table_name= '" + TableName+ "' ";
                comand = comand + " order by ORDINAL_POSITION";
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
                string cm1 = "Select * from " + TableName;
                string cm2 = string.Empty;
                string cm3 = string.Empty;

                if (Filter.Rows.Count > 0 && Filter.Rows.Count < 2)
                {
                    cm2 = " Where " + Filter.Rows[0][0].ToString() + " " + getOperant(Filter.Rows[0][1].ToString()) + " "+Filter.Rows[0][1].ToString()+" ;";
                }
                else
                {
                    if (Filter.Rows.Count == 2)
                    {
                        cm2 = " Where " + Filter.Rows[0][0].ToString() + " " + getOperant(Filter.Rows[0][1].ToString()) + " " + Filter.Rows[0][2].ToString() + " ;";
                        cm3 = " " + getConnector(Filter.Rows[0][3].ToString()) + " " + Filter.Rows[1][0].ToString() + " " + getOperant(Filter.Rows[1][1].ToString()) + " " + Filter.Rows[1][2].ToString() + " ;";

                    }
                }     
                string comand = cm1+ cm2+cm3;
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

        public override DataTable SelectFromColumns(DataTable ColumnNames, string TableName)
        {
            DataTable dt = new DataTable();

            MySqlConnection connection = new MySqlConnection(conString);
            try
            {
                connection.Open();

                string comand = "SELECT COLUMN_NAME,IS_NULLABLE , DATA_TYPE, CHARACTER_MAXIMUM_LENGTH as MAX_LENGTH";
                comand = comand + " FROM information_schema.columns WHERE table_name= '" + ColumnName + "' ";
                comand = comand + " order by ORDINAL_POSITION";
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
