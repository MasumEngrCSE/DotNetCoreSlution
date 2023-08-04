using System;
using System.Collections.Generic;
using System.Data;

class QuartilesResult
{

    /*
     * Complete the 'quartiles' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> quartiles(List<int> arr)
    {
       
        int q1 = 0, q2 = 0, q3 = 0;
        //List<int> arrOrdered = arr.OrderBy(p => p).ToList();
        arr.Sort();

        var ll = new List<int>();
        var lm = new List<int>();
        var lr = new List<int>();

        if ((arr.Count % 2) == 0)
        {
            int la = arr.Count / 2;
            int li = 0;
            foreach (int i in arr)
            {
                if (li < la)
                    ll.Add(i);

                else if (li >= la)
                    lr.Add(i);
                li++;
            }

            lm.Add(ll[ll.Count-1]);
            lm.Add(lr[0]);


            int lv = ll.Count / 2;
            //q1 =(int)Math.Ceiling((decimal)(ll[lv - 1] + ll[lv]) / (decimal)2);
            q1 = ((ll[lv - 1] + ll[lv]) / 2);
            q2 = lm.Sum(p=>p)/2;
            q3 = ((lr[lv - 1] + lr[lv]) / 2);
            //(int)Math.Ceiling((decimal)(lr[lv - 1] + lr[lv]) / (decimal)2);
            //((lr[lv - 1] + lr[lv]) / 2);

        }
        else
        {
            int la = arr.Count / 2;
            int li = 0;
            foreach (int i in arr)
            {
                if (li < la)
                    ll.Add(i);
                else if (li == la)
                    lm.Add(i);
                else if (li > la)
                    lr.Add(i);

                li++;
            }
            int lv = ll.Count / 2;
            //q1 = (int)Math.Ceiling((decimal)(ll[lv - 1] + ll[lv]) / (decimal)2);
            q1 = ((ll[lv - 1] + ll[lv]) / 2);
            q2 = lm.FirstOrDefault();
            //q3 = (int)Math.Ceiling((decimal)(lr[lv - 1] + lr[lv]) / (decimal)2);
            q3 = ((lr[lv - 1] + lr[lv]) / 2);

        }

      
        var qtrlist = new List<int>();
        qtrlist.Add(q1);
        qtrlist.Add(q2);
        qtrlist.Add(q3);

        return qtrlist;
    }

    public static List<double> quartilesDouble(List<int> arr)
    {
        double q1 = 0, q2 = 0, q3 = 0;
        List<int> arrOrdered = arr.OrderBy(p => p).ToList();

        var ll = new List<int>();
        var lm = new List<int>();
        var lr = new List<int>();

        if ((arrOrdered.Count % 2) == 0)
        {
            int la = arrOrdered.Count / 2;
            int li = 0;
            foreach (int i in arrOrdered)
            {
                if (li < la)
                    ll.Add(i);

                else if (li >= la)
                    lr.Add(i);
                li++;
            }

            lm.Add(ll[ll.Count - 1]);
            lm.Add(lr[0]);


            int lv = ll.Count / 2;
            q1 = (double)((double)(ll[lv - 1] + ll[lv]) / (double)2);
            q2 = lm.Average(p => p);
            q3 = (double)((double)(lr[lv - 1] + lr[lv]) / (double)2);

        }
        else
        {
            int la = arrOrdered.Count / 2;
            int li = 0;
            foreach (int i in arrOrdered)
            {
                if (li < la)
                    ll.Add(i);
                else if (li == la)
                    lm.Add(i);
                else if (li > la)
                    lr.Add(i);

                li++;
            }
            int lv = ll.Count / 2;
            q1 = (double)((double)(ll[lv - 1] + ll[lv]) / (double)2);
            q2 = lm.FirstOrDefault();
            q3 = (double)((double)(lr[lv - 1] + lr[lv]) / (double)2);

        }


        var qtrlist = new List<double>();
        qtrlist.Add(q1);
        qtrlist.Add(q2);
        qtrlist.Add(q3);

        return qtrlist;
    }

    public static List<double> quartilesDoubleOnline(List<double> arrOrdered)
    {
        double q1 = 0, q2 = 0, q3 = 0;
        arrOrdered.Sort();

        var ll = new List<int>();
        var lm = new List<int>();
        var lr = new List<int>();
        int halflenght = arrOrdered.Count / 2;
        if ((arrOrdered.Count % 2) == 0)
        {

            q1 = median(arrOrdered.GetRange(0, halflenght));
            q3 = median(arrOrdered.GetRange(halflenght, halflenght));
        }
        else
        {

            q1 = median(arrOrdered.GetRange(0, halflenght));
            q3 = median(arrOrdered.GetRange(halflenght + 1, halflenght));
        }
        q2 = median(arrOrdered);

        var qtrlist = new List<double>();
        qtrlist.Add(q1);
        qtrlist.Add(q2);
        qtrlist.Add(q3);

        return qtrlist;
    }

    public static double median(List<double> median)
    {
        if (median.Count % 2 == 0)
        {
            return (median[median.Count / 2] + median[median.Count / 2 - 1]) / 2;
        }
        else
        {
            return median[median.Count / 2];
        }
    }

    public static List<int> qtr2()
    {
        //int[] dataset = { 18, 45, 55, 70, 76, 83, 88, 90, 92, 92, 95, 98 };
        //int[] dataset = { 9,5,7,1,3 };
        int[] dataset = { 3, 5, 7, 8, 12, 13, 14, 18, 21 };



        Array.Sort(dataset);

        int q1Index = (int)Math.Ceiling(dataset.Length * 0.25) - 1;
        int q2Index = (int)Math.Ceiling(dataset.Length * 0.5) - 1;
        int q3Index = (int)Math.Ceiling(dataset.Length * 0.75) - 1;

        int q1 = dataset[q1Index];
        int q2 = dataset[q2Index];
        int q3 = dataset[q3Index];

        //var ll = new List<int>();
        //var lm = new List<int>();
        //var lr = new List<int>();

        var qtrlist = new List<int>();
        qtrlist.Add(q1);
        qtrlist.Add(q2);
        qtrlist.Add(q3);

        return qtrlist;
    }


    public static void interQuartile(List<Double> values, List<Double> freqs)
    {
        // Print your answer to 1 decimal place within this function

        List<double> S = new List<double>();

        for (int i = 0; i < values.Count; i++)
        {
            Double value = values[i];
            Double freq = freqs[i];

            for (int j = 0; j < freq; j++)
            {
                S.Add(value);
            }
        }

        S.Sort();


        double q1 = 0, q2 = 0, q3 = 0;


        int halflenght = S.Count / 2;

        if ((S.Count % 2) == 0)
        {

            q1 = median(S.GetRange(0, halflenght));
            q3 = median(S.GetRange(halflenght, halflenght));
        }
        else
        {

            q1 = median(S.GetRange(0, halflenght));
            q3 = median(S.GetRange(halflenght + 1, halflenght));
        }



        //q1 = median(S.GetRange(0, halflenght));
        //q3 = median(S.GetRange(halflenght, halflenght));


        double iqtr=q3- q1;

        Console.WriteLine(iqtr.ToString("0.0"));
    }

}

class QuartilesSolution
{
    public void CalculatingQuartiles()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);


        inputN:
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        if (n < 5 || n>50)
            goto inputN;

        inputArray:

        List<double> data = null;
        try
        {
            data = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dataTemp => Convert.ToDouble(dataTemp)).ToList();

        }
        catch (Exception)
        {
            goto inputArray;
            throw;
        }

        //data = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();


       if(data.Count !=n)
            goto inputArray;


        List<double> res = QuartilesResult.quartilesDoubleOnline(data);
        //List<int> res = QuartilesResult.quartiles(data);

        //List<int> res = QuartilesResult.qtr2();


        Console.WriteLine(String.Join("\n", res));

        //textWriter.WriteLine(String.Join("\n", res));

        //textWriter.Flush();
        //textWriter.Close();
    }


    public void CalculatingInterquartile()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<double> val = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valTemp => Convert.ToDouble(valTemp)).ToList();

        List<double> freq = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(freqTemp => Convert.ToDouble(freqTemp)).ToList();

        QuartilesResult.interQuartile(val, freq);
    }

}