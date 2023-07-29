class LCResult
{

    /*
     * Complete the 'maxCost' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY cost
     *  2. STRING_ARRAY labels
     *  3. INTEGER dailyCount
     */

    public int maxCost(List<int> cost, List<string> labels, int dailyCount)
    {

        var Dcost = new List<int>();
        int dt = 0; int dcsum = 0;
        for (int i = 0; i < cost.Count; i++)
        {


            if (dt < dailyCount || labels[i] == "illegal")
            {
                dcsum += cost[i];
                //Dcost.Add(i); 
            }
            else if (dt >= dailyCount && labels[i] == "legal")
            {
                Dcost.Add(dcsum);
                dt = 0;
                dcsum = cost[i];

            }

            if (labels[i] == "legal")
                dt++;

        }

        if (Dcost.Count > 0)
        {
            dcsum = Dcost.Max();
        }
        else { dcsum = 0; }



        return dcsum;
    }

}



class LaptomMaxCost
{

    public void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int costCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> cost = new List<int>();

        for (int i = 0; i < costCount; i++)
        {
            int costItem = Convert.ToInt32(Console.ReadLine().Trim());
            cost.Add(costItem);
        }

        int labelsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> labels = new List<string>();

        for (int i = 0; i < labelsCount; i++)
        {
            string labelsItem = Console.ReadLine();
            labels.Add(labelsItem);
        }

        int dailyCount = Convert.ToInt32(Console.ReadLine().Trim());

        int result = new LCResult().maxCost(cost, labels, dailyCount);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }

}