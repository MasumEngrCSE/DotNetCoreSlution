// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.DesignPattern;
using ConsoleApp1.leetcode;
using ConsoleApp1.MIU;
using ConsoleApp1.Others;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello");

//var cl = new LinkListCls();
//cl.AddTwoLinkList();


//int r=ReverseAnInteger.f(12005);
//int r = ReverseAnInteger.a4(12005);
//Console.WriteLine(r);



int reverse = 0; // Initialize reverse
int n = 123; // Example value of n
// Example usage in a loop
while (n != 0)
{
    reverse = (reverse * 10) + (n % 10);
    n /= 10;
}

Console.WriteLine(reverse);


//var rr = new OddEvenDif();


//int rv = OddEvenDif.f(new int[] { 3, 3, 4, 4 });
//int rv = rr.f(new int[] { 3, 3, 4, 4 });
//int rv=rr.f(new int[]{ 4, 1, 2,3 });
//int rv=rr.f(new int[]{ });
//Console.WriteLine(rv.ToString());

//char[] rt = RetunLengthCharacters.f(new char[] { 'a', 'b','c' },1,2);
//Console.WriteLine(new string(rt));