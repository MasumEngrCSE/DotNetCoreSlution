using com.sun.swing.@internal.plaf.metal.resources;
using Newtonsoft.Json.Linq;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


class SumNSeriesResult
{

    /*
     * Complete the 'summingSeries' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    //public decimal summingSeries(decimal n)
    //{
    //    if (n == 1) return 1;

    //    return summingSeries(n - 1) + (2 * n - 1);
    //}

    delegate BigInteger NumberChanger(BigInteger n);

    static int mod = 1000000007;
    public double summingSeries(double n)
    {
        double sum = 0;

        sum= (((n % mod) * (n % mod)) % mod);
        //sum = ((n * 2)*n)/2;


        return sum;
    }



    public BigInteger CallSummingSeries(BigInteger n)
    {
        if (n == 0) return 0;
        return CallSummingSeries(n - 1) + (2 * n - 1);

    }



    public decimal summingSeries2(decimal n)
    {
        //n = n - 1;
        //var nc = Convert.ToDouble(n);
        if (n == 0) return 0;
        return summingSeries2(n - 1) + (2 * n - 1);
        //return summingSeries(n - 1)+ Convert.ToDecimal(Math.Pow(nc, 2) - Math.Pow((nc - 1), 2));

    }

    public long summingSeriesOrg(long n)
    {
        long retval = 0;

        //for (int i = 1; i <= n; i++)
        //{
        //    //retval += 2 * i - 1;
        //    retval += Math.Pow(i, 2)- Math.Pow((i-1), 2);
        //    // retval += CalculatePower(i, 2) - CalculatePower((i - 1), 2);
        //}

        ///solution:2
        //object lockObject = new object(); // Used for synchronization
        //Parallel.For(1, n + 1, i =>
        //{
        //    long term = 2 * i - 1;
        //    lock (lockObject)
        //    {
        //        retval += term;
        //    }
        //});

        #region Solution:3

        var lst = new List<long>();

        long nr = n;
        //int l = n.ToString().Length;
        long rv = 100000000;
        if (nr > rv)
        {
            while (nr > rv)
            {
                nr -= rv;
                lst.Add(rv);
            }

            if (nr < rv)
            {
                lst.Add(nr);
            }
        }
        else
        {
            lst.Add(nr);
        }


        //foreach (var item in lst)
        //{

        //    retval += summingSeries2(item);
        //}



        object lockObject = new object(); // Used for synchronization
        Parallel.For(0, lst.Count, i =>
        {
            retval += summingSeries2(lst[i]);
            //long term = 2 * i - 1;
            //lock (lockObject)
            //{
            //    retval += term;
            //}
        });

        #endregion
        ///








        //retval = n*n;


        return retval;
    }

    public long summingSeries2(long n)
    {
        long retval = 0;


        object lockObject = new object(); // Used for synchronization
        Parallel.For(1, n + 1, i =>
        {
            long term = 2 * i - 1;
            lock (lockObject)
            {
                retval += term;
            }
        });


        return retval;
    }


    static int CalculatePower(int baseNumber, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }

}

class SumNSeriesSolution
{
    public async void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            double result = new SumNSeriesResult().summingSeries(n);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}

