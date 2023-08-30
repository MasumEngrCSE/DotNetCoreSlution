using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class running_time_and_complexity
{
    internal void initialCall()
    {
        Stopwatch sw = Stopwatch.StartNew();

        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 0; i < t; i++)
        {

            int number = Convert.ToInt32(Console.ReadLine().Trim());

            bool isp = IsPrime(number);
            string nt = "Not prime";

            if (isp)
                nt = "Prime";


            Console.WriteLine(nt);
        }

        sw.Stop();
        Console.WriteLine($"ElapsedMilliseconds:{sw.ElapsedMilliseconds}");

    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        // Check for divisibility from 2 to the square root of the number
        // If the number has any divisors within this range, it is not prime.

        int i;
        for (i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine($"---------- {number}:{i}--------");
                return false;
            }
        }
        Console.WriteLine($"---------- {number}:{i}--------");

        return true;
    }


    internal void initialCall2()
    {
        Stopwatch sw = Stopwatch.StartNew();

        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int ll = n / 2;
            bool isp = false;
            string nt = "Not prime";

            if (n > 2 && (n % 2 == 0))
                isp = true;
            else
            {
                for (int j = 2; j <= ll; j++)
                {
                    if (n % j == 0)
                    {
                        isp = true;
                        Console.WriteLine($"---------- {n}:{j}--------");
                        break;
                    }
                }
            }

            if (!isp && n > 1)
                nt = "Prime";

            Console.WriteLine(nt);
        }


        sw.Stop();
        Console.WriteLine($"ElapsedMilliseconds:{sw.ElapsedMilliseconds}");
    }
}