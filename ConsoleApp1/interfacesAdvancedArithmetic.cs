using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class AACalculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int aaSum = 0;
        for (int i = 1;i<=n/2;i++)
        {
            if (n%i == 0)
            {
                aaSum+=i;
            }
        }


        return aaSum+n;
    }
}

class interfacesAdvancedArithmetic
{
    internal void initialCall()
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new AACalculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}