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

        
        public DataSet loadWholeProjectData(int id)
        {
            dbError.setDBError();
            throw new NotImplementedException();
        }
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

        #endregion
        #region criteria
        public DataSet LoadCriteriaWeightDataSet()
        {
            dbError.deleteDBError();
            MySqlConnection connection = new MySqlConnection(conSting);

            DataSet ds = new DataSet("CriteriaWeight");
            DataTable dt = new DataTable("Criterias");
            DataTable ddt = new DataTable("CriteriaWeight");

            try
            {
                connection.Open();
                string comand = "Select Criteria_ID, C_NAME,C_ISACTIVE from criteria order by Criteria_ID";
                //string comandsec = "Select CTC_FromCriteria,CTC_ToCriteria,CTC_Points from CRITERIA_TO_CRITERIA order by CTC_FromCriteria";

                MySqlDataAdapter adap = new MySqlDataAdapter(comand, connection);
                //MySqlDataAdapter adapsec = new MySqlDataAdapter(comandsec, connection);
                adap.Fill(dt);
                //adapsec.Fill(ddt);
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
            ds.Tables.Add(dt);
            //ds.Tables.Add(ddt);
            ds.AcceptChanges();
            
            return ds;
        }

        #endregion




       
    }
}
