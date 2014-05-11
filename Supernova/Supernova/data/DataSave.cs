using MySql.Data.MySqlClient;
using Supernova.objects;
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
        public bool UpdateUser(int userID, User userData)
        {
            MySqlConnection connection = new MySqlConnection(conSting);
                    
            try{
                //SaveOrUpdateUser firstN, lastN,u_name,email,Passwort, groupsid, depid, userID 

                string commandText = "Call SaveOrUpdateUser(@firstN,@lastN,@u_name,@email,@Passwort,@groupsid,@depid,@userID)";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = commandText;

                    cmd.Parameters.AddWithValue("firstN",userData.firstname);
                    cmd.Parameters["firstN"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("lastN", userData.lastname);
                    cmd.Parameters["lastN"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("u_name", userData.username);
                    cmd.Parameters["u_name"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("email", userData.email);
                    cmd.Parameters["email"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("Passwort", userData.);
                    cmd.Parameters["Passwort"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("groupsid", userData.userGroupID);
                    cmd.Parameters["groupsid"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("depid", userData.departmentID);
                    cmd.Parameters["depid"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("userID", userData.userID);
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
            return true;
        }
        #endregion

        #region projectMatters

        public bool SaveNewProject(ProjektDataDummy projektData)
        {
            return true;
        }

        public bool UpdateProject(int ProjectID, ProjektDataDummy projektData)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region criteriaMatters
        public void saveCriteriaActivation(DataTable  differenz)
        {
            MySqlConnection connection = new MySqlConnection(conSting);
            int c_active;
            int c_id;
        
            foreach (DataRow dr in differenz.Rows)
            {
                try
                {
                  c_id =  Convert.ToInt32(dr["CRITERIA_ID"].ToString());
                  c_active = Convert.ToInt32(dr["C_ISACTIVE"].ToString());
                  if (c_active == 1)
                  {
                     c_active = 0;
                 }
                 else
                 {
                    c_active = 1;
                 }
    
                
                    string commandText = "Call SetCriteriaActive(@id,@active)";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = commandText;

                    cmd.Parameters.AddWithValue("id", c_id);
                    cmd.Parameters["id"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("active", c_active);
                    cmd.Parameters["active"].Direction = ParameterDirection.Input;


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
