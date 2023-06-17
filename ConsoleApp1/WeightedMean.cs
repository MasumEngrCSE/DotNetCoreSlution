class Result
{

    /*
     * Complete the 'weightedMean' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY X
     *  2. INTEGER_ARRAY W
     */

    public static void weightedMean(List<int> X, List<int> W)
    {
        var nx=new int[X.Count];
        int i = 0;
        foreach (int iv in X)
        {
            nx[i] += X[i] * W[i];


            i++;
        }


        int ws=W.Sum(i=>i);

        int xs= nx.Sum(i=>i);

        float wm=(float)xs/(float)ws;

        Console.WriteLine(float.Round(wm,1).ToString("0.0"));

    }

}

class WeightedMeanSolution
{
    public void weightedMeanResult()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

        List<int> weights = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(weightsTemp => Convert.ToInt32(weightsTemp)).ToList();

        Result.weightedMean(vals, weights);
    }
}