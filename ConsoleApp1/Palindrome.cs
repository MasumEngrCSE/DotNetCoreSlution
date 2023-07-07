using System;
using System.Collections.Generic;
using System.IO;

class Palindrome
{
    //Write your code here
    LinkedList<char> stack=new LinkedList<char>();
    LinkedList<char> queue=new LinkedList<char>();
    void pushCharacter(char c)
    {
        stack.AddLast(c);
    }

    void enqueueCharacter(char c)
    {
        queue.AddFirst(c);
    }

    char popCharacter()
    {
        char c= stack.First();
        stack.RemoveFirst();

        return c;
    }

    char dequeueCharacter()
    {
        char c= queue.First();
        queue.RemoveFirst();
        return c;
    }


    internal void initialCall()
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Palindrome obj = new Palindrome();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }








}