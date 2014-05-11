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
        public int userID = 0, deparmentID, userGroupID, passwort;
        public string firstname, lastname, username, email;
      
        //neu erstellen
        public User()
        {
        }

        public User(string name)
        {
            DataLoad dl = new DataLoad();
            userData = dl.LoadUserData(name);
            extractUserData();
        }

        /// <summary>
        /// Saves the User. Method defines if update or new User
         /// </summary>
        /// <returns></returns>
        public bool saveUser()
        {
            // user speichern
            DataSave ds = new DataSave();
            List<string> userData = collectUserData();
            bool savingWorked = false;

            savingWorked = ds.UpdateUser(userID, this);
            

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
