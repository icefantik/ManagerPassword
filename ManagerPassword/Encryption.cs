using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPassword
{
    internal class Encryption
    {
        static long p = 5, q = 9;
        public static string EncryptionPwd(string pwd)
        {
            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = CalculateD(m);
            long e = CalculateE(d, m);
            return "";
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
        public static string DecryptionPwd(string hashPwd)
        {

            return "";
        }
    }
}
