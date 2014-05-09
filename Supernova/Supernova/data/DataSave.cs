using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.data
{
    class DataSave
    {
        public bool SaveUser(List<string> userData)
        {
            return true;

        }        

        public bool SaveNewProject(DataSet savingDataSet)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject(int ProjectID, DataSet savingDataSet)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(int userID, List<string> userData)
        {
            throw new NotImplementedException();
        }
    }
}
