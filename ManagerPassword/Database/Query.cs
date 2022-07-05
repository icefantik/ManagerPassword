using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPassword.Database
{
    class Query
    {
        public static string execGetUserData = "exec GetUserData;";
        public static string execAddElem = "exec CreatUserData @title = '{0}', @username = '{1}', @email = '{2}', @url = '{3}', @password = '{4}', @note = '{5}';";
    }
}
