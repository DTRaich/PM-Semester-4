using MySql.Data.MySqlClient;
using Supernova.helper;
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
        DBerror dbError = DBerror.getInstanze();

        #region userAndRights
        public bool DeleteUser(int userID)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                //SaveOrUpdateUser firstN, lastN,u_name,email,Passwort, groupsid, depid, userID 

                string commandText = "Call DeleteUser(@deletID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("deletID", userID);
                cmd.Parameters["deletID"].Direction = ParameterDirection.Input;


                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

             

            }
            catch (Exception ex)
            {
                retval = false;
                dbError.setDBError();

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
        
        public bool ChangePassword(int userID, int passwort)
        {
            dbError.deleteDBError();

            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                string commandText = "Call ChangePassword(@id,@pswd)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("id", userID);
                cmd.Parameters["id"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("pswd", passwort);
                cmd.Parameters["pswd"].Direction = ParameterDirection.Input;


                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();
                
            }
            catch (Exception ex)
            {
                retval = false;
                dbError.setDBError();

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

        public bool UpdateUser(User userData, int originDepID)
        {
            dbError.deleteDBError();

            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;
                    
            try{
                string commandText = "Call SaveOrUpdateUser(@firstN,@lastN,@u_name,@email,@Passwort,@groupsid,@userID)";
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

                    cmd.Parameters.AddWithValue("Passwort", userData.passwort);
                    cmd.Parameters["Passwort"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("groupsid", userData.userGroupID);
                    cmd.Parameters["groupsid"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("userID", userData.userID);
                    cmd.Parameters["userID"].Direction = ParameterDirection.Input;

                    connection.Open();
                    cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    connection.Close();
                    if (userData.departmentID != originDepID)
                    {

                        UpdateDepLeader(userData.username,userData.departmentID, originDepID);
                    }

                    retval = true;


                }
                catch (Exception ex)
                {
                    retval = false;
                    dbError.setDBError();

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

        private void UpdateDepLeader(string userNAME, int newDepartID, int originDepID)
        {

            if (originDepID == -1)
            {
                updateLeaderWithoutRef(userNAME, newDepartID);
            }
            else
            {
                updateLeaderWithRef(originDepID);
            }

        }

        private void updateLeaderWithRef( int originDepID)
        {
            MySqlConnection connection = new MySqlConnection(conSting);
            
            try
            {
                string commandText = "Call UpdateDepLeaderRef(@OriginDepID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;                

                cmd.Parameters.AddWithValue("OriginDepID", originDepID);
                cmd.Parameters["OriginDepID"].Direction = ParameterDirection.Input;

                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();


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
        }

        private void updateLeaderWithoutRef(string userName, int newDepartID)
        {
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call UpdateDepLeader(@UserName,@NewDepartID)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("UserName", userName);
                cmd.Parameters["UserName"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("NewDepartID", newDepartID);
                cmd.Parameters["NewDepartID"].Direction = ParameterDirection.Input;

                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();              


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
        }


        #endregion

        # region departments

        public bool SaveDepCapa(int CapaID, int year1, int year2, int year3)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                //SaveOrUpdateDep 

                string commandText = "Call SaveDepartmentCapa(@depid,@y1,@y2,@y3)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("depid", CapaID);
                cmd.Parameters["depid"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y1", year1);
                cmd.Parameters["y1"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y2", year2);
                cmd.Parameters["y2"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y3", year3);
                cmd.Parameters["y3"].Direction = ParameterDirection.Input;



                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

            }
            catch (Exception ex)
            {
                retval = false;
                dbError.setDBError();

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

        public bool newDep(string depName, int year1, int year2, int year3)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                //SaveOrUpdateDep 

                string commandText = "Call SaveNewDepartment(@depname,@y1,@y2,@y3)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("depname", depName);
                cmd.Parameters["depname"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y1", year1);
                cmd.Parameters["y1"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y2", year2);
                cmd.Parameters["y2"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y3", year3);
                cmd.Parameters["y3"].Direction = ParameterDirection.Input;



                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

            }
            catch (Exception ex)
            {
                retval = false;
                dbError.setDBError();

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

        public bool DeleteDep(int CapaID)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                //Delete Department

                string commandText = "Call DeleteDepart(@depid)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("depid", CapaID);
                cmd.Parameters["depid"].Direction = ParameterDirection.Input;


                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

            }
            catch (Exception ex)
            {
                retval = false;
                dbError.setDBError();

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



        #endregion

        #region projectMatters

        public bool SaveorUpdateProject(ProjektDataDummy projektData)
        {
            dbError.deleteDBError();
            dbError.setDBError();

            return true;
        }

        
        #endregion

        #region criteriaMatters
        private void newWeightCalculation()
        {
            dbError.deleteDBError();

            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                string commandText = "Call UpdateCriteriaWeight()";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;
                connection.Open();

                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

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
        }

        public bool saveCriteriaActivation(DataTable  differenz)
        {
            dbError.deleteDBError();

            bool retval = true;
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
                    

                    // new weight

                    newWeightCalculation();

                }
                catch (Exception ex)
                {
                    retval = false;
                    dbError.setDBError();

                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }                

            }
            return retval;

        }
       
        private void saveOneCriteriaWeight(int c_from_id, int c_to_id, int weights)
        {
            dbError.deleteDBError();

            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                string commandText = "Call SaveCriteriaWeight(@fromName,@toName,@weight)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("fromName", c_from_id);
                cmd.Parameters["fromName"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("toName", c_to_id);
                cmd.Parameters["toName"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("weight", weights);
                cmd.Parameters["weight"].Direction = ParameterDirection.Input;


                connection.Open();

                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

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

        }

        public bool saveCriteriaWeight(DataTable toSave)
        {
            foreach (DataRow dr in toSave.Rows)
            {
                saveOneCriteriaWeight(Convert.ToInt32(dr[0].ToString()), Convert.ToInt32(dr[1].ToString()), Convert.ToInt32(dr[2].ToString()));
            }
            //
            newWeightCalculation();
            return true;

        }

        public bool saveScaling(DataTable differenz)
        {
            bool retval = true;
            foreach (DataRow dr in differenz.Rows)
            {
                dbError.deleteDBError();

                MySqlConnection connection = new MySqlConnection(conSting);
                try
                {
                    string commandText = "Call SaveScaling(@critID,@max)";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = commandText;

                    cmd.Parameters.AddWithValue("critID", Convert.ToInt32(dr[0].ToString()));
                    cmd.Parameters["critID"].Direction = ParameterDirection.Input;                   

                    cmd.Parameters.AddWithValue("max", Convert.ToDecimal(dr[2].ToString()));
                    cmd.Parameters["max"].Direction = ParameterDirection.Input;
                                        

                    connection.Open();

                    cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    connection.Close();

                }
                catch (Exception ex)
                {
                    retval = false;
                    dbError.setDBError();
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
                
            }
            return retval;
        }
        #endregion

        public bool SaveBudget(int BudgetID, int year1, int year2, int year3)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                //SaveOrUpdateDep 

                string commandText = "Call SaveBudget(@budgetid,@y1,@y2,@y3)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("budgetid", BudgetID);
                cmd.Parameters["budgetid"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y1", year1);
                cmd.Parameters["y1"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y2", year2);
                cmd.Parameters["y2"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y3", year3);
                cmd.Parameters["y3"].Direction = ParameterDirection.Input;



                connection.Open();
                cmd.ExecuteReader(CommandBehavior.CloseConnection);

                connection.Close();

            }
            catch (Exception ex)
            {
                retval = false;
                dbError.setDBError();

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
        
    }
}
