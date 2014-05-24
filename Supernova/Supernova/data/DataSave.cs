using MySql.Data.MySqlClient;
using Supernova.helper;
using Supernova.objects;
using Supernova.Sub_Forms.General;
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

        public bool SaveorUpdateProject(List<string> basis, DataSet CriteriasDataSet, DataTable depCapaTable, List<double> budget)
        {
            bool retval = true;
            int projectID = 0;
            bool notTheir = true;
            // schon vorhanden?
            if(basis[0].Equals("0"))
            {
                projectID = getProjectID(basis[1].ToString());
                notTheir = false;
            }else
            {         
                projectID = Convert.ToInt32(basis[0].ToString());
            }

            // wenn es eine projektid gibt und nicht nageschaut wurtde oder wenn sie null ist speichern sonst nicht
            if ((projectID != 0 && notTheir) || projectID == 0) 
            {
                // null speichern 1 update (für db)
                saveBasis(basis);
                if (projectID == 0)
                {
                    projectID = getProjectID(basis[1].ToString());
                    saveCriteria(projectID, CriteriasDataSet, 0);
                    saveDepartmentNeedCapa(projectID,depCapaTable);
                    saveNeedBudget(projectID, budget);
                }
                else
                {
                    saveCriteria(projectID, CriteriasDataSet, 1);
                    saveDepartmentNeedCapa(projectID,depCapaTable);
                    saveNeedBudget(projectID, budget);

                }
            }
            else
            {
                retval = false;
                FrmAfirmative frm = new FrmAfirmative("Projekttitel bereits vorhanden",'e');
                frm.ShowDialog();
            }
           

            return retval;
        }

        private void saveNeedBudget(int projectID, List<double> budget)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                string commandText = "Call SoUNeedBudget(@id,@y1,@y2,@y3)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("id", projectID);
                cmd.Parameters["id"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y1", budget[0]);
                cmd.Parameters["y1"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y2", budget[1]);
                cmd.Parameters["y2"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("y3", budget[2]);
                cmd.Parameters["y3"].Direction = ParameterDirection.Input;
                
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

        private void saveDepartmentNeedCapa(int projectID, DataTable depCapaTable)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            foreach(DataRow dr in depCapaTable.Rows)
            {

                try
                {

                    string commandText = "Call SoUNeedCapa(@proID,@DEPID,@y1,@y2,@y3)";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = commandText;

                    cmd.Parameters.AddWithValue("proID", projectID);
                    cmd.Parameters["proID"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("DEPID", dr[0]);
                    cmd.Parameters["DEPID"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("y1", dr[2]);
                    cmd.Parameters["y1"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("y2", dr[3]);
                    cmd.Parameters["y2"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("y3", dr[4]);
                    cmd.Parameters["y3"].Direction = ParameterDirection.Input;
                    

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
        }

        private int getProjectID(string p)
        { 
            dbError.deleteDBError();
            int retVal = 0;

            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Select PROJECT_ID from Projects where P_NAME like'" + p + "'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    retVal = Convert.ToInt32(rdr[0]);
                }
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

            return retVal;
        }

        private void saveCriteria(int projectID, DataSet CriteriasDataSet, int update)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            foreach (DataTable t in CriteriasDataSet.Tables)
            {
                foreach (DataRow dr in t.Rows)
                {
                    try
                    {

                        string commandText = "Call SoUCritPro(@pid,@critid,@val,@update)";
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = commandText;

                        cmd.Parameters.AddWithValue("pid", projectID);
                        cmd.Parameters["pid"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("critid", dr[0]);
                        cmd.Parameters["critid"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("val", dr["Value"]);
                        cmd.Parameters["val"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("update", update);
                        cmd.Parameters["update"].Direction = ParameterDirection.Input;
                        
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
            }
            

        }

        private void saveBasis( List<string> basis)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {                

                string commandText = "Call SoUProjectBasis(@id,@name,@desc,@lead,@start,@end,@create,@cat)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("id", basis[0]);
                cmd.Parameters["id"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("name", basis[1]);
                cmd.Parameters["name"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("desc", basis[2]);
                cmd.Parameters["desc"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("lead", basis[3]);
                cmd.Parameters["lead"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("start", basis[4]);
                cmd.Parameters["start"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("end", basis[5]);
                cmd.Parameters["end"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("create", basis[6]);
                cmd.Parameters["create"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("cate", basis[7]);
                cmd.Parameters["cate"].Direction = ParameterDirection.Input;

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

        public bool SaveBudget(int BudgetID, decimal year1, decimal year2, decimal year3)
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);
            bool retval = true;

            try
            {
                

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
