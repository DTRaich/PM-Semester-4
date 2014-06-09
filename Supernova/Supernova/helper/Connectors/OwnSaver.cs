using Supernova.data;
using Supernova.objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    class OwnSaver
    {
        private DBTYPE DB;
        private CONNECTOR connect;

        public OwnSaver(DBTYPE DB)
        {
            // TODO: Complete member initialization
            this.DB = DB;
            connect = ConnectorFactory.getConnector(DB);
        }


        public void SaveStructur(DataTable toSaveTable, Tables currentTable, string formTableName)
        {
            switch (currentTable)
            {
                case Tables.Abteilungen: SaveStructurDeparts(toSaveTable, formTableName);
                    break;
                case Tables.Benutzer: SaveStructurUser(toSaveTable, formTableName);
                    break;
            }
        }
        #region userStruct
        private void SaveStructurUser(DataTable toSaveTable, string formTableName)
        {
            DataSave saverObject = new DataSave();
            DataTable loaded = connect.SelectFromColumns(toSaveTable, formTableName);
            List<User> saver = getUserSaveStruct(toSaveTable, loaded);

            for (int i = 0; i < saver.Count; i++ )
            {
                saverObject.UpdateUser(saver[i], 0);
            }          

        }

        private List<User> getUserSaveStruct(DataTable toSaveTable, DataTable loaded)
        {
           List<User> userList = new List<User>();
           
           foreach (DataRow dr in loaded.Rows)
           {
               User currentUser = getUser(dr, toSaveTable);
               userList.Add(currentUser);

           }

           return userList;
        }

        private User getUser(DataRow dr, DataTable toSaveTable)
        {
           //@firstN,@lastN,@u_name,@email,@Passwort,@groupsid,@userID)";

            User user = new User();
            int rowcount = 0;

            user.userGroupID = 24;
            user.userID = 0;
            user.departmentID = 0;
            user.firstname = string.Empty;
            user.lastname = string.Empty;
            user.email = string.Empty;
            user.username = string.Empty;


            foreach (DataRow zuordnung in toSaveTable.Rows)
            {
                if (zuordnung[0].ToString().Equals("U_NAME"))
                {
                    user.username = dr[rowcount].ToString() + DateTime.Now.Second.ToString();
                }
                if (zuordnung[0].ToString().Equals("U_FIRSTNAME"))
                {
                    user.firstname = dr[rowcount].ToString();
                }
                if (zuordnung[0].ToString().Equals("U_LASTNAME"))
                {
                    user.lastname = dr[rowcount].ToString();
                }
                if (zuordnung[0].ToString().Equals("U_MAIL"))
                {
                    user.email = dr[rowcount].ToString();
                }                
                rowcount++;
            }
            return user;
        }


        #endregion userStruct

        #region departmentStruct
        private void SaveStructurDeparts(DataTable toSaveTable, string formTableName)
        {
            DataSave saverObject = new DataSave();
            DataTable loaded = connect.SelectFromColumns(toSaveTable, formTableName);
            string depName = "import";
            int year1 = 0;
            int year2 = 0;
            int year3 = 0;
            int ordnungscount = 0;
            foreach(DataRow dr in loaded.Rows)
            {
                ordnungscount = 0;
                foreach (DataRow zuordnung in toSaveTable.Rows)
                {
                    if (zuordnung[0].ToString().Equals("D_NAME"))
                    {
                        depName = dr[ordnungscount].ToString();
                    }
                    if (zuordnung[0].ToString().Contains("YEAR1"))
                    {
                        year1 = Convert.ToInt32(dr[ordnungscount].ToString());
                    }
                    if (zuordnung[0].ToString().Contains("YEAR1"))
                    {
                        year2 = Convert.ToInt32(dr[ordnungscount].ToString());

                    }
                    if (zuordnung[0].ToString().Contains("YEAR1"))
                    {
                        year3 = Convert.ToInt32(dr[ordnungscount].ToString());

                    }

                    ordnungscount++;
                }
                saverObject.newDep(depName,year1,year2,year3);
            }

        }
        #endregion departmentStruct
    }
    

}
