using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPassword.Database
{
    class Query
    {
        public static string execGetUserData = "exec GetAllUserData;";
        public static string execAddElem = "exec CreatUserData @title = '{0}', @username = '{1}', @email = '{2}', @url = '{3}', @password = '{4}', @note = '{5}';";
        public static string execDeteleUser = "exec DeleteUserData @id = {0};";
        public static string execUpdateUserData = "exec UpdateUserData @id = {0}, @title = '{1}', @username = '{2}', @email = '{3}', @url = '{4}', @password = '{5}', @note = '{6}';";
    }
}
