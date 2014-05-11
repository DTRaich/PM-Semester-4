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
        public int userID = 0;
        public string firstname, lastname, username, email, department, usergroup;
      
        //neu erstellen
        public User()
        {
        }

        public User(int id)
        {
            DataLoad dl = new DataLoad();
            userID = id;
            userData = dl.LoadUserData(userID);
            extractUserData();
        }

        /// <summary>
        /// Saves the User. MEthod defines if update or new User
         /// </summary>
        /// <returns></returns>
        public bool saveUser()
        {
            // user speichern
            DataSave ds = new DataSave();
            List<string> userData = collectUserData();
            bool savingWorked = false;

            if (userID == 0)
            {
               savingWorked = ds.SaveUser(this);
            }else
            {
                savingWorked = ds.UpdateUser(userID, this);
            }

            return savingWorked;      
        }
        #region extractAndCollect

        private void extractUserData()
        {
            foreach (DataRow dr in userData.Rows)
            {

            }
        }
        private List<string> collectUserData()
        {
            // collects the User Data for Saving them to Db
            return null;
        }
        #endregion
    }
}
