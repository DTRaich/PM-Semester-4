using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.data
{
    class DataSave
    {
        string conSting = "Database=fallstudie;Data Source=188.226.215.238;User Id=user1;Password=password";

        #region userAndRights
        public bool SaveUser(List<string> userData)
        {
            return true;

        }


        public bool UpdateUser(int userID, List<string> userData)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region projectMatters

        public bool SaveNewProject(DataSet savingDataSet)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject(int ProjectID, DataSet savingDataSet)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region criteriaMatters
        public void saveCriteriaActivation(string c_name)
        {
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call SetCriteriaActive(@name)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("name", c_name);
                cmd.Parameters["name"].Direction = ParameterDirection.Input;


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
       
        public void saveCriteriaWeight(string c_from_name, string c_to_name, int weights)
        {
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call SaveCriteriaWeight(@fromName,@toName,@weight)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("fromName", c_from_name);
                cmd.Parameters["fromName"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("toName", c_to_name);
                cmd.Parameters["toName"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("weight", weights);
                cmd.Parameters["weight"].Direction = ParameterDirection.Input;


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
        #endregion
    }
}
