using MySql.Data.MySqlClient;
using Supernova.helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.data
{
    class AnalysisLoad
    {
        string conSting = "Database=fallstudie;Data Source=188.226.215.238;User Id=user1;Password=password";
        DBerror dbError = DBerror.getInstanze();

        public DataTable LoadDepartmentCapacity(int departID)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetDepCapa(@DepID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("DepID", departID);
                cmd.Parameters["DepID"].Direction = ParameterDirection.Input;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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
        public DataTable LoadCalcDepartmentCapacity(int departID)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetDepCapaAnalysis(@DepID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("DepID", departID);
                cmd.Parameters["DepID"].Direction = ParameterDirection.Input;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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
        public DataTable LoadBudget()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetBudgetAnalysis()";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;


                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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

        public DataTable LoadCalcBudget()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetCalcBudgetAnalysis()";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;


                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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

        public DataTable LoadStrategy()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetStrategyAnalysis()";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;


                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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

        public DataTable LoadCategory()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetCategoryAnalysis()";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;


                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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
        public DataTable LoadProjectAnalysis(int ProjID)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetProjectAnalysis(@ProjID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("ProjID", ProjID);
                cmd.Parameters["ProjID"].Direction = ParameterDirection.Input;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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
