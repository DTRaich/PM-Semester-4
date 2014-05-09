﻿using MySql.Data.MySqlClient;
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
        #region logInLogOUtRights
        public int LogOn(string username, int password)
        {
            int retval = -1;

            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call LoginUser(@username,@password)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters["username"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters["password"].Direction = ParameterDirection.Input;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    retval = Convert.ToInt32(rdr[0]);
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

            return retval;
        }
        public void Logout(int uid)
        {
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call LogOut(@userID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("userID", uid);
                cmd.Parameters["userID"].Direction = ParameterDirection.Input;


                connection.Open();
                
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

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
        }
        
        public int UserRight(int userID, string formname)
        {
            int right = -1;
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call getUserRights(@user_id,@formname)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("formname", formname);
                cmd.Parameters["formname"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("user_id", userID);
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

        #endregion

        public DataTable loadtest()
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select USER_ID,U_NAME,U_FIRSTNAME from user";
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

       
    }
}
