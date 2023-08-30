class StandardDeviationResult
{

    /*
     * Complete the 'stdDev' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     * 
     * 
     * The sum of the array values is  and there are  elements. The mean is .
Subtract the mean from each element, square each result, and take their sum.
     */

    public static void stdDev(List<int> arr)
    {
        // Print your answers to 1 decimal place within this function

        double s =arr.Sum();

        double e =arr.Count();
        double m =s/e;


        List<double> arrSE=new List<double>();


        foreach(int x in arr)
        {
            arrSE.Add((x-m)* (x - m));
        }


        double se =arrSE.Sum();

        double sr=Math.Sqrt(se/ (double)e);
        
        Console.WriteLine(sr.ToString("0.0"));

    }

}

class StandardDeviationSolution
{
    public  void SDCalculation()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

        StandardDeviationResult.stdDev(vals);
    }
}