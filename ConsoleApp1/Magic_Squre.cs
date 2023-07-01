public class MSResult
{

    /*
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    public int formingMagicSquare(List<List<int>> s)
    {
        List<List<int>> s2 = s;

        int[] r = new int[s.Count];
        int[] c = new int[s.Count];
        // List<int> il=new List<int>();
        for (int i = 0; i < s.Count; i++)
        {
            List<int> il = s[i];

            int rsum = 0;
            for (int j = 0; j < il.Count; j++)
            {
                Console.Write(il[j] + " ");

                rsum += il[j];
                c[j] += il[j];
            }

            Console.WriteLine(" = " + rsum);
            r[i] = rsum;

        }




        Console.Write("C:");
        foreach (var itm in c)
        {
            Console.Write(itm + " ");
        }

        Console.WriteLine("");

        Console.Write("R:");
        foreach (var itm in r)
        {
            Console.Write(itm + " ");
        }

        Console.WriteLine("");

        ////------------------
        ///

        for (int i = 0; i < c.Length; i++)
        {
            //Console.Write(c[i] + " ");

            if (c[i] != 15)
            {
                Console.WriteLine("Need Work C:" + i);
            }
        }

        Console.WriteLine("");
        int rcc = 0;
        ///---------------------------------------------
        #region Row Change


        /*
        for (int i = 0; i < r.Length; i++)
        {
            if (r[i] != 15)
            {
                Console.WriteLine("Need Work r:" + i);
                Console.WriteLine($"R:{i},Col:0 " + s[i][0]);
                if (r[i] > 15)
                {
                    if ((s[i][0] > s[i][2]))
                    {
                        s2[i][0] -= r[i] - 15;
                        rcc += r[i] - 15;
                    }
                    else
                    {
                        s2[i][2] -= r[i] - 15;
                        rcc += r[i] - 15;
                    }
                }
                else if(r[i] < 15)
                {
                    if ((s[i][0] > s[i][2]) && c[0] < 15)
                    {
                        s2[i][0] += 15 - r[i];
                        rcc += 15 - r[i];
                    }
                    else if ((s[i][0] > s[i][2]) && c[0] > 15)
                    {
                        s2[i][0] -= r[i]-15;
                        rcc += r[i]-15;
                    }
                    else if(c[2] > 15)
                    {
                        s2[i][2] -= r[i]-15;
                        rcc += r[i]-15;
                    }
                    else if (c[2] < 15)
                    {
                        s2[i][2] += 15 - r[i];
                        rcc += 15 - r[i];
                    }
                }

            }
        }
        */

        #endregion


        #region change by Column


        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] > 15)
            {
                if (s2[0][i] <= s2[2][i])
                {
                    s2[2][i] -= c[i] - 15;
                }
                else
                {
                    s2[0][i] -= c[i] - 15;
                }
            }
            else if (c[i] < 15)
            {
                if (s2[0][i] <= s2[2][i])
                {
                    s2[2][i] += 15-c[i];
                }
                else
                {
                    s2[0][i] += 15-c[i];
                }
            }
        }

        #endregion


        Console.WriteLine("Printing Change Magic Squre:");


        for (int i = 0; i < s2.Count; i++)
        {
            List<int> il = s[i];

            int rsum = 0;
            for (int j = 0; j < il.Count; j++)
            {
                Console.Write(il[j] + " ");

                rsum += il[j];
                //c[j] += il[j];
            }

            Console.WriteLine(" = " + rsum);
            //r[i] = rsum;

        }



        ///---------------------------






        Console.WriteLine("Result:" + rcc);

        return rcc;
    }

}

class MSSolution
{
    public void smCalculation()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> s = new List<List<int>>();

        s.Add(new List<int> { 4, 9, 2 });
        s.Add(new List<int> { 5, 5, 7 });
        s.Add(new List<int> { 8, 1, 5 });

        //for (int i = 0; i < 3; i++)
        //{
        //    s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        //}

        int result = new MSResult().formingMagicSquare(s);
        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}


//https://www.hackerrank.com/challenges/magic-square-forming/problem?isFullScreen=true