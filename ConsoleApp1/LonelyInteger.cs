class LIResult
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public int lonelyinteger(List<int> a)
    {
        //var dl = a.Where(p => p > 0).Distinct();

        //return dl.Count();

        int n=a.Count();
        int res=0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {

                if (a[i] == a[j])
                {
                    count++;
                }
            }
            if (count == 1)
            {
                res = a[i];
            }

        }
        return res;

    }

}

class LISolution
{
    public void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = new LIResult().lonelyinteger(a);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}