using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper
{
    public enum DBTYPES
    {
        Oracle,
        MYSQL,
        SQL
    }

    public class WeiserRieseHelperSingleton
    {
        private static WeiserRieseHelperSingleton instance;
        public static WeiserRieseHelperSingleton getInstance()
        {
           if (instance == null)
            {
                instance = new WeiserRieseHelperSingleton();
            }
            return instance;
        }
    }

}
