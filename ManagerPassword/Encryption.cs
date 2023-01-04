using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ManagerPassword
{
    internal class Encryption
    {
        private static long p = 5, q = 9;
        private static char[] characters = new char[] { '#', 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static string EncryptionPwd(string pwd)
        {
            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = CalculateD(m);
            long e = CalculateE(d, m);

            return RSAEncoder(pwd, e, n);
        }
        public static string DecryptionPwd(string hashPwd)
        {
            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = CalculateD(m);
            long e = CalculateE(d, m);

            return RSADecryption(hashPwd, d, n);
        }
        private static string RSAEncoder(string pwd, long e, long n)
        {
            string result = "";
            BigInteger bi;
            for (int i = 0; i < pwd.Length; ++i)
            {
                int index = Array.IndexOf(characters, pwd[i]);
                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi %= n_;
                result += bi.ToString() + "-";
            }
            result = result.Remove(result.Length-1);
            return result;
        }
        private static long CalculateD(long m)
        {
            long d = m - 1;
            for (long i = 2; i < m; ++i)
            {
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }
            }
            return d;
        }
        private static long CalculateE(long d, long m)
        {
            long e = 10;
            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }
            return e;
        }
        public static string RSADecryption(string hashPwd, long d, long n)
        {
            string[] hashPwdArray = hashPwd.Split('-');
            string result = "";
            BigInteger bi;
            foreach (var item in hashPwdArray)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi %= n_;

                int index = Convert.ToInt32(bi.ToString());
                result += characters[index].ToString();
            }
            return result;
        }
    }
}
