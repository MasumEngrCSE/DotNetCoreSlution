using System;

//Write your code here

class propagatingException
{
    public void initialCall()
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



    }
}

class Calculator
{
    internal int power(int n, int p) 
    {
        if (n<0 || p<0) 
        {
            throw new NegativeException();
        }
        else
        {
            return (int)Math.Pow(n, p);
        }
       
    }

}

class NegativeException : Exception
{
    internal NegativeException()
        : base("n and p should be non-negative")
    {
    }
}