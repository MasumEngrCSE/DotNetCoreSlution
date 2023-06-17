using System;

class Person
{
    
    delegate void MyDelegate(string message);
    public void Introduction()
    {


        string str = "racecar";

        if (IsPalindrome(str))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }


        //MyDelegate myDelegate = MyMethod;
        //myDelegate += YourMethod;

        //myDelegate("Hello, world!");

        //Console.WriteLine("I am a person.");
    }

    public static bool IsPalindrome(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }



    public void MyMethod(string message)
        {
            Console.WriteLine("MyMethod: {0}", message);
        }

    public void YourMethod(string message)
        {
            Console.WriteLine("YourMethod: {0}", message);
        }
}