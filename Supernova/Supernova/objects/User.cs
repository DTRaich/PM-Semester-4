using Supernova.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.objects
{
    class User
    {
        private DataTable userData;
        public int userID = 0, departmentID = -1, userGroupID,passwort;
        public string firstname, lastname, username, email;
      
        //neu erstellen
        public User()
        {
        }

        public bool LoadUser(string name)
        {
            DataLoad dl = new DataLoad();
            userData = dl.LoadUserData(name);
            if (userData.Rows.Count > 0)
            {
                extractUserData();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadUser(int userID)
        {
            DataLoad dl = new DataLoad();
            userData = dl.LoadUserData(userID);
            if (userData.Rows.Count > 0)
            {
                extractUserData();
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public bool changePasswort()
        {
            // user speichern
            DataSave ds = new DataSave();
            bool savingWorked = false;
            savingWorked = ds.ChangePassword(userID, passwort);

            return savingWorked;
        }
       
        #region extractAndCollect

        private void extractUserData()
        {         
            foreach (DataRow dr in userData.Rows)
            {
               userID = Convert.ToInt32(dr["USER_ID"].ToString());            
               userGroupID  = Convert.ToInt32(dr["U_GROUP"].ToString());
               passwort = Convert.ToInt32(dr["U_PASSWORD"].ToString());
               firstname = dr["U_FIRSTNAME"].ToString();
               lastname = dr["U_LASTNAME"].ToString();
               username = dr["U_NAME"].ToString();
               email = dr["U_MAIL"].ToString();

               try
               {
                   departmentID = Convert.ToInt32(dr["U_DEPARTMENT"].ToString());
               }
               catch (Exception ex)
               {
                   departmentID = -1;
               }
            }
        }
        
        #endregion
    }
}
