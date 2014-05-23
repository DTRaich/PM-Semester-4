using MySql.Data.MySqlClient;
using Supernova.helper;
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
        DBerror dbError = DBerror.getInstanze();

        #region logInLogOUt---Rights
        public int LogOn(string username, int password)
        {
            dbError.deleteDBError();
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
        public void Logout(int uid)
        {
            dbError.deleteDBError();

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
        public int UserRight(int userID, string formname)
        {
            dbError.deleteDBError(); 
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
                dbError.setDBError();
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

        public DataTable loadRightsMappingTable(int groupID)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                connection.Open();
                string comand = "Select GR_FORMS,GR_RIGHTS,GR_GROUP from group_rights where GR_GROUP = " + groupID;
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
        #endregion

        #region projectLoad
        public DataSet loadWholeProjectData(int id)
        {
            dbError.setDBError();
            DataSet ds = new DataSet();
            DataTable basis = loadBasisData(id);
            DataTable risks = loadRisks(id);
            DataTable strategie = loadStrategie(id);
            DataTable divCriteria = loadDivCriteria(id);
            DataTable needDepCapa = loadNeedDepCapa(id);
            DataTable budget = loadNeedBudget(id);

            ds.Tables.Add(basis);
            ds.Tables.Add(risks);
            ds.Tables.Add(strategie);
            ds.Tables.Add(divCriteria);
            ds.Tables.Add(needDepCapa);
            ds.Tables.Add(budget);
            ds.AcceptChanges();

            return ds;



        }

        private DataTable loadNeedBudget(int id)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Budget");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select NB_YEAR1, NB_YEAR2, NB_YEAR3 from NEED_BUDGET where NB_PID like '"+ id+"'" ;

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

        private DataTable loadNeedDepCapa(int id)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("DepCapa");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select NDC_DEPID, NDC_YEAR1, NDC_YEAR2, NDC_YEAR3 from NEED_DEP_CAPA where NDC_POID like '"+ id+"'";

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

        private DataTable loadDivCriteria(int id)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("DIVCriteria");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string com1 = "Select PTC_CRITERIA, PTC_ORIGINALVALUE from Project_to_CRITERIA ";
                string com2 = "where PTC_Project like " + id + "' AND PTC_CRITERIA < 24 OR PTC_CRITERIA = 33";
                string comand = com1 + com2;
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

        private DataTable loadStrategie(int id)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Strategie");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string com1 = "Select PTC_CRITERIA, PTC_ORIGINALVALUE from Project_to_CRITERIA ";
                string com2 = "where PTC_Project like " + id + "' AND PTC_CRITERIA > 27 AND  PTC_CRITERIA < 33";
                string comand = com1 + com2;

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

        private DataTable loadRisks(int id)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Risiko");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string com1 = "Select PTC_CRITERIA, PTC_ORIGINALVALUE from Project_to_CRITERIA ";
                string com2 = "where PTC_Project like " + id + "' AND PTC_CRITERIA < 28 AND  PTC_CRITERIA > 23";
                string comand = com1 + com2;
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

        private DataTable loadBasisData(int id)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Basis");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select * from Projects where PROJECT_ID like '"+id+"'";

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

            #endregion projectLoad
        #region department
        public int LoadMyDepartment(int userid)
        {
            dbError.deleteDBError();
            int retval = -1;

            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetDeptByAbt(@id)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("id", userid);
                cmd.Parameters["id"].Direction = ParameterDirection.Input;

                
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
        public DataTable LoadDepartmenntCapacity(int departID)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetDepartmentCapa(@DepID)";
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
        
      
        
        #endregion
        #region user
        public DataTable LoadUserData(int userID)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetUserDataById(@userid)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("userid", userID);
                cmd.Parameters["userid"].Direction = ParameterDirection.Input;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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
        
        public DataTable LoadUserData(string userName)
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(conSting);

            try
            {
                string commandText = "Call GetUserData(@username)";                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = commandText;

                cmd.Parameters.AddWithValue("username", userName);
                cmd.Parameters["username"].Direction = ParameterDirection.Input;

               connection.Open();
               MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               dt.Load(rdr);
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

        public DataTable getUserList()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("BenutzerListe");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select U_NAME as Benutzername, U_FIRSTNAME as Vorname, U_LASTNAME as Nachname, U_MAIL as EMail, UG_NAME as Benutzergruppe from user, user_groups where U_GROUP = USER_GROUPS_ID ORDER BY U_NAME ASC";

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

        #endregion
        #region criteria
        public DataSet LoadCriteriaWeightDataSet()
        {            
            DataSet ds = new DataSet("CriteriaWeight");
            DataTable criterias = getAllCriterias();
            DataTable activeCriterias = getAllActiveCriterias();
            DataTable weight = getActiveCriteriasWeights();
            DataTable scale = getScaleTable();

            ds.Tables.Add(criterias);
            ds.Tables.Add(activeCriterias);
            ds.Tables.Add(weight);
            ds.Tables.Add(scale);

            ds.AcceptChanges();
            
            return ds;
        }

        private DataTable getScaleTable()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Scale");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select CS_ID, C_NAME as Kriterium, CS_MAX as Maximum,CS_POINTS as Punktzahl ,CS_DESCRIPTION as Kommentar from CriteriaScaling, criteria where CS_CritID = Criteria_ID  AND C_ISACTIVE = 1 order by CS_ID ; ";

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

        private DataTable getActiveCriteriasWeights()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("ActiveCriteriasWeight");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                string comand = "Call GetActiveCriteriaWeight()";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = comand;

                connection.Open();
                MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(rdr);
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

        private DataTable getAllActiveCriterias()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("ActiveCriterias");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select Criteria_ID, C_NAME from criteria where C_ISACTIVE = 1 order by Criteria_ID";

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

        private DataTable getAllCriterias()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Criterias");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select Criteria_ID, C_NAME,C_ISACTIVE from criteria order by Criteria_ID";

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


        #endregion

        public DataTable LoadBudget()
        {
            dbError.deleteDBError();
            DataTable dt = new DataTable("Gesamtbudget");
            MySqlConnection connection = new MySqlConnection(conSting);
            try
            {
                connection.Open();
                string comand = "Select BUDGET_ID, B_YEAR1, B_YEAR2, B_YEAR3 from Budget ";

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
