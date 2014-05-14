using MySql.Data.MySqlClient;
using Supernova.helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.data
{
    class ParameterLoad
    {
        string conSting = "Database=fallstudie;Data Source=188.226.215.238;User Id=user1;Password=password";
        DBerror dbError = DBerror.getInstanze();

        public DataTable loadDeparments()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select DEPARTMENTS_ID,D_NAME from Departments";
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);
                
            }
            catch (Exception ex)
            {
                dbError.setDBError();

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
        public DataTable loadUserGroups()
        {
            dbError.deleteDBError();

            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select USER_GROUPS_ID,UG_NAME from user_groups";
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);
               

            }
            catch (Exception ex)
            {
                dbError.setDBError();

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

        public DataTable loadRights()
        {
            dbError.deleteDBError();

            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select RIGHTS_ID, R_NAME from rights";
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                dbError.setDBError();

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
   
        public DataTable loadForms()
        {
            dbError.deleteDBError();

            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select FORMS_ID,F_DESCRIPTION from forms";
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                dbError.setDBError();

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
   
        public DataTable loadPotentAbts()
        {
            dbError.deleteDBError();

            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select USER_ID,U_NAME from user where U_GROUP = 25 AND USER_ID NOT IN (Select D_LEADER from Departments)";
                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                dbError.setDBError();
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
