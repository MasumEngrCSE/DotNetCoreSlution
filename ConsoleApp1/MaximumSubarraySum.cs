class MaximumSubarraySumResult
{

    /*
     * Complete the 'maximumSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. LONG_INTEGER_ARRAY a
     *  2. LONG_INTEGER m
     */

    public static long maximumSum(List<long> a, long m)
    {
        //3 3 9 9 5
        string numbersAsString = string.Join("", a);
        int ll = a.Count;
        List<string> la = new List<string>();
        for (int i = 0; i < ll; i++)
        {
            int lj = 0;
            string ta = "";
            int j = 0;


            while ((j + i + 1) <= ll)
            {
                ta = numbersAsString.Substring(j, i + 1);

                la.Add(ta);

                j += 1;
            }
        }

        List<long> lS = new List<long>();
        long lv = 0;
        foreach (string x in la)
        {
            lv = 0;
            foreach (char xi in x)
            {
                lv += Convert.ToInt64(xi.ToString());
            }

            lS.Add(lv % m);
        }

        long mxret = lS.Max(); ;


        return mxret;
    }


    public static long maximumSum3(List<long> a, long m)
    {
        //3 3 9 9 5
        //string numbersAsString = string.Join("", a);
        int ll = a.Count;
        List<string> la = new List<string>();
        List<long> lS = new List<long>();
        for (int i = 0; i < ll; i++)
        {
            int lj = 0;
            string ta = "";
            int j = 0;

            lS.Add(a[i] % m);
        }
        //long lv = 0;


        long mxret = lS.Max();


        return mxret;
    }





    public static long maximumSum2(List<long> a, long m)
    {
        int n = a.Count;
        //long maxSum = 0;
        long prefixSum = 0;

        long maxSumRet = 0;
        SortedSet<long> prefixSums = new SortedSet<long>();

        for (int i = 0; i < n; i++)
        {
            int lc = i;
            prefixSum = 0;
            int slen = 0;
            
            while(lc<n)
            {

                prefixSum += a[lc];
                prefixSums.Add(prefixSum % m);

                lc += 1;
                slen += 1;


                //int ns = 0;

                //while (ns < slen)
                //{
                //    prefixSum += a[tl];
                //    tl += 1;
                //    ns += 1;
                //}
                //prefixSum = a[lc];
            }
            //prefixSum = (prefixSum + a[i]) % m;
            //SortedSet<long> sortedSet = prefixSums.GetViewBetween(0, prefixSum);
            //long prevSum = sortedSet.Max;
            //maxSum = Math.Max(maxSum, (prefixSum - prevSum + m) % m);

            //if (maxSumRet < maxSum)
            //    maxSumRet = maxSum;

            //prefixSums.Add(prefixSum);
        }
        maxSumRet = prefixSums.Max();
        return maxSumRet;
    }

    public static long maximumSum4(List<long> a, long m)
    {
        //3 3 9 9 5

        int n = a.Count;
        long prefixSum;
        long maxSumRet=0;
        SortedSet<long> prefixSums = new SortedSet<long>();

        for (int i = 0; i < n; i++)
        {
            prefixSum = 0;
            int slen = 0;

            for (int j=i;j < n;j++)
            {
                prefixSum += a[j];

                if(maxSumRet< (prefixSum % m))
                    maxSumRet= prefixSum % m;


                //prefixSums.Add(prefixSum % m);

                slen += 1;
            }
        }
        //maxSumRet = prefixSums.Max();
        return maxSumRet;
    }


    public static int RangeSum(List<int> numbers, int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

}

class MaximumSubarraySumSolution
{
    public void MaximumSubarraySum()
    {
        //List<long> a2 = new List<long> { 3, 3, 9, 9, 5 };
        ////List<long> a2 = new List<long> { 1, 5, 9 };
        //long result2 = MaximumSubarraySumResult.maximumSum4(a2, 7);

        //return;

        #region Test 2

        string filePath = @"E:\Work History\202306\22\MaximumSubarrayDummyData.txt";
        try
        {
            string fileContents = "";
            fileContents = File.ReadAllText(filePath);
            int n2 = Convert.ToInt32("100000");
            long m2 = Convert.ToInt64("10002143548612");
            var sp = fileContents.TrimEnd().Split(' ');
            List<long> a3 = new List<long>();
            foreach (string xi in sp)
            {
                string[] lines = xi.Split('\n');

                if (lines.Length > 1)
                {
                    foreach (string xii in lines)
                    {
                        a3.Add(Convert.ToInt64(xii.ToString()));
                    }
                }
                else
                {

                    a3.Add(Convert.ToInt64(xi.ToString()));
                }
            }

            long result3 = MaximumSubarraySumResult.maximumSum4(a3, m2);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
        
        #endregion




        return;

        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            long m = Convert.ToInt64(firstMultipleInput[1]);

            List<long> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt64(aTemp)).ToList();

            long result = MaximumSubarraySumResult.maximumSum4(a, m);

            //Console.WriteLine(result);

            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}


////https://www.hackerrank.com/challenges/maximum-subarray-sum/problem?isFullScreen=true&h_r=next-challenge&h_v=zen