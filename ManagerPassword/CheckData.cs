using ManagerPassword.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace ManagerPassword
{
    class CheckData
    {
        private static string patternUsername = @"^[a-zA-Z](.[a-zA-Z0-9_-]*)$";
        private static string patternEmail = @"(@)(.+)$";
        private static readonly string securityCode = "mJeb44V5grh0pTB6wgepSw==";
        public static bool CheckTextBoxData(string title, string username, string email, string url, string password, string note)
        {
            if (CheckEmpty(title, username, email, url, password, note) && CheckUsername(username) && CheckEmail(email))
            {
                return true;
            }
            return false;
        }
        private static MatchCollection FormRegex(string pattern, string input)
        {
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);
            return match;
        }
        private static bool CheckEmpty(string title, string username, string email, string url, string password, string note)
        {
            if (!(title == "" || username == "" || email == "" || url == "" || password == "" || note == ""))
            {
                return true;
            }
            Message.MessageBoxError(Message.msgEmptyTextBox);
            return false;
        }
        public static bool CheckUsername(string username)
        {
            if (FormRegex(patternUsername, username).Count > 0)
            {
                return true;
            }
            Message.MessageBoxError(Message.msgBadUsername);
            return false;
        }
        public static bool CheckEmail(string email)
        {
            if (FormRegex(patternEmail, email).Count > 0)
            {
                return true;
            }
            Message.MessageBoxError(Message.msgBadEmail);
            return false;
        }
        public static string EncryptionPwd(string pwd)
        {
            byte[] data = Encoding.UTF8.GetBytes(pwd);
            SHA512 shaM = new SHA512Managed();
            byte[] result = shaM.ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", String.Empty);
        }
        public static string DecryptionPwd(string hashPwd)
        {
            SHA512Managed sha512 = new SHA512Managed();
            Byte[] EncryptedSHA512 = sha512.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(hashPwd, securityCode)));
            sha512.Clear();
            var t = Convert.ToBase64String(EncryptedSHA512);
            return "";
        }
    }
}
