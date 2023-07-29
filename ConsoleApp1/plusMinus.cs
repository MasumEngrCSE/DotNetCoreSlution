class plusMinus
{
    internal void initialCall()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        new PMResult().plusMinus(arr);
    }
}


class PMResult
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public  void plusMinus(List<int> arr)
    {
        float cp = 0; float cn = 0; float cz = 0;

        foreach (var itm in arr)
        {

            if (itm > 0)
                cp++;
            else if (itm < 0)
                cn++;
            else if (itm == 0)
                cz++;

        }


       // decimal cpd = (decimal)(cp / arr.Count);

        Console.WriteLine($"{((cp / arr.Count)).ToString("0.000000")}");
        Console.WriteLine($"{((cn / arr.Count)).ToString("0.000000")}");
        Console.WriteLine($"{((cz / arr.Count)).ToString("0.000000")}");


    }

}

