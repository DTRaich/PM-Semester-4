using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.data
{
    class DataLoad
    {
        string conSting = "Database=fallstudie;Data Source=188.226.215.238;User Id=user1;Password=password";


        public DataTable loadtest()
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select * from user";
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public int UserRight(int userID, string formname)
        {
            int right = -1;
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call getUserRights(@formname,@user_id)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("formname", formname);
                cmd.Parameters["formname"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("user_id", 1);
                cmd.Parameters["user_id"].Direction = ParameterDirection.Input;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    right = Convert.ToInt32(rdr[0]);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return right;
        }
    }
}
