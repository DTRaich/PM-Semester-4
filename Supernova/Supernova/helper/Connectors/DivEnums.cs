using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper.Connectors
{
    //class DivEnums
    //{
    //}
    public enum DBTYPE
    {
        Oracle,
        MySql,
        SQL
    }

    public enum Connector
    {
        AND,
        OR      
    }

    public enum Operant
    {
        smaller,
        equal,
        bigger,
        samllerEqual,
        biggerEqual
        
    }

    public enum Tables
    {
        Abteilungen,
        Benutzer  
    }
}
