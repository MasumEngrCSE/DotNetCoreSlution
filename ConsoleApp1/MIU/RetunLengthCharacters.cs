using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MIU
{
    internal class RetunLengthCharacters
    {
        public static char[] f(char[] a, int start, int len)
        {
            char[] b = new char[len];
            if (a.Length < len || start < 0 || start+len>a.Length)
            {
                return null;
            }

            for (int i = start,j=0; j < len;i++,j++)
            {
                    b[j] = a[i];

            }
            return b;
        }
    }
}
