using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MIU
{
    internal class ReverseAnInteger
    {

        public static int f(int n)
        {
            int rv = 0;

            string str1 = n.ToString(), str2 = "";
            string fv = str1.Substring(0, 1);
            int outv;
            int st = 0;
            if (int.TryParse(fv, out outv)==false)
            {
                st = 1;
                
                //fv = int.Parse(fv);
            }
            else
                fv = "";


            for (int i = st; i < str1.Length; i++)
            {
                str2 = str1.Substring(i, 1) + str2;
                //int outv,f=0;

                //if (int.TryParse(str1.Substring(i, 1), out outv) && (string.IsNullOrEmpty(lv)||  int.TryParse(lv, out outv)))
                //{
                //    str2 = str1.Substring(i, 1) + str2;
                //}
                //else
                //{
                //    str2 = str2 + str1.Substring(i, 1);
                //    lv = str1.Substring(i, 1);
                //}
            }

            rv = Convert.ToInt32(fv+str2);

            return rv;
        }


        public static int a4(int n)
        {
            int sign = 1;
            if (n == 0) return 0;
            if (n < 0)
            {
                sign = -1;
                n = -n;
            }
            int reverse = 0;
            while (n != 0)
            {
                reverse = (reverse * 10) + (n % 10);
                n /= 10;
            }
            return sign * reverse;
        }





    }
}
