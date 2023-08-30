class mini_max_sum
{
    internal void initialCall()
    {
        List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        new mmsResult().miniMaxSum(arr);
    }
}



class mmsResult
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public void miniMaxSum(List<Int64> arr)
    {

        var arrS = new List<Int64>();

        Int64 sumL = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            sumL = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (i != j)
                    sumL += arr[j];
            }

            arrS.Add(sumL);
        }


        Int64 minr = arrS.Min(i => i);
        Int64 maxr = arrS.Max(i => i);

        Console.Write(minr);
        Console.Write(" ");
        Console.Write(maxr);


    }

}