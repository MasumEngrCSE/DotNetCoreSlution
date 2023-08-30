using System;

class NYResult
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public  void minimumBribes(List<int> q)
    {
        var oq2 = new List<int>();
        q.ForEach(x => oq2.Add(x));

        oq2.Sort();

        int b = 0, ai = 0, fvi = 0, bc = 0, ch = 0;
        //Console.WriteLine(string.Join(" ", oq));
        foreach (var itm in q)
        {
            fvi = q.FindIndex(p => p == itm);
            ai = oq2.FindIndex(p => p == itm);


            b = ai - fvi;

            if (b > 2)
            {
                ch = 1;
                break;
            }

            else if (b > 0)
                bc += b;

            // Console.WriteLine($" B:{b}");
        }

        if (ch > 0)
            Console.WriteLine("Too chaotic");
        else
            Console.WriteLine($"{bc}");
    }
}

class newyearchaos
{
    public  void initialCall()
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            new NYResult().minimumBribes(q);
        }
    }
}