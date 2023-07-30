using System.Linq;

class SMResult
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public  int sockMerchant(int n, List<int> ar)
    {
        ar.Sort();
        int pc = 0;
        int pv = 0;
        var pairl = new Dictionary<int, int>();
        foreach (var itm in ar)
        {
            bool ifExists = pairl.ContainsKey(itm);

            if (itm == pv && !ifExists)
                pairl.Add(itm, 2);
            else if (itm == pv && ifExists)
                pairl[itm]= pairl[itm]+1;

            pv = itm;

        }

        foreach (var itm in pairl) {

            pc += (itm.Value / 2);
        }


        return pc;

    }

}

class SMSolution
{
    public  void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = new SMResult().sockMerchant(n, ar);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}