using MySql.Data.MySqlClient;
using Supernova.helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.data
{
    class ValidationData
    {

        string conSting = "Database=fallstudie;Data Source=188.226.215.238;User Id=user1;Password=password";
        DBerror dbError = DBerror.getInstanze();

        public DataTable SaveAndValidateHaveTo(int proID, int haveTo)
        {
            DataTable dt = new DataTable();

            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                string commandText = "Call SoValHaveTo(@project,@have)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("project", proID);
                cmd.Parameters["project"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("have", haveTo);
                cmd.Parameters["have"].Direction = ParameterDirection.Input;

              
                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

            }
            catch (Exception ex)
            {
                dbError.setDBError("Die Datenbank ist gerade nicht verfügbar. Bitte wenden sie sich an ihren Administrator.");

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
