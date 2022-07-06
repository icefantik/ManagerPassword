using ManagerPassword.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagerPassword
{
    class CheckData
    {
        public static bool CheckTextBoxData(string title, string username, string email, string url, string password, string note)
        {
            if (!(title == "" || username == "" || email == "" || url == "" || password == "" || note == "") && CheckUsername(username))
            {
                return true;
            }
            return false;
        }
        public static bool CheckUsername(string username)
        {
            Regex regex = new Regex(@"^[a-zA-Z](.[a-zA-Z0-9_-]*)$");
            MatchCollection match = regex.Matches(username);
            if (match.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
