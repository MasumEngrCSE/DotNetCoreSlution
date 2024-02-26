using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MIU
{
    internal class OddEvenDif
    {


       public static int f(int[] a)
        {

            int odd = 0, even = 0;

            //foreach (int i in a)
            //{
            //    if(i%2 == 0)
            //        even += i;
            //    else odd += i;
            //}

            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                    even += a[i];
                else odd += a[i];
            }


            return odd-even;
        }
    }
}
