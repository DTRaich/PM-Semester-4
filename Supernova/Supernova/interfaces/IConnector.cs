using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Supernova.interfaces
{
    interface IConnector
    {
        bool connectToDB();
        DataTable SelectTable(string TableName, DataTable Filter);
       
    }
}
