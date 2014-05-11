using Supernova.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.helper
{
    class ParameterHelper
    {
        ParameterLoad paraLoad = new ParameterLoad();
        #region Lists
       

        public List<string> getUserGroups()
        {
            return null;
        }
        public List<string> getAllRights()
        {
            return null;
        }
        #endregion

        #region singelValues
        public string getDepartment(string deparmentName)
        {
            return null;
        }

        public string getUserGroups(string groupName)
        {
            return null;
        }
        #endregion

        #region TableComparer

        public DataTable CompareTables(DataTable ursprung, DataTable aenderung)
        {
            DataTable dt = aenderung.Copy();
            dt.Clear();
            DataRow dr;
            int counter = 0;

            foreach (DataRow row1 in ursprung.Rows)
            {

                var array1 = row1.ItemArray;               
                var array2 = aenderung.Rows[counter].ItemArray;
                counter++;

                if (!array1.SequenceEqual(array2))
                {
                    dr = dt.NewRow();
                    dr.ItemArray = array2;
                    dt.Rows.Add(dr);
                 }
                   
                }            

            dt.AcceptChanges();

            return dt;
        }
        #endregion







    }
}
