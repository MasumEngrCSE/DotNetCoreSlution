// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello");

//var cl = new newyearchaos();
//cl.initialCall();


var oq = new List<int>() { 1 , 2 , 5, 3, 7 ,8, 6 ,4 };
var oq2 = new List<int>();
oq.ForEach(x => oq2.Add(x));

oq2.Sort();

int b = 0, ai = 0, fvi = 0, bc = 0, ch = 0;
Console.WriteLine(string.Join(" ", oq));
foreach (var itm in oq)
{
    fvi = oq.FindIndex(p => p == itm);
    ai = oq2.FindIndex(p => p == itm);

    Console.Write($"fv:{itm}");
    Console.Write($" ai:{ai}");
    Console.Write($" fvi:{fvi}");


    b = ai - fvi;

    if (b > 2)
    {
        ch = 1;
        break;
    }

    else if (b > 0)
        bc += b;

    Console.WriteLine($" B:{b}");
}

if (ch > 0)
    Console.WriteLine("Too chaotic");
else
    Console.WriteLine($"Total B:{bc}");

//string vv = "84 48 13 20 61 20 33 97 34 45 6 63 71 66 24 57 92 74 6 25 51 86 48 15 64 55 77 30 56 53 37 99 9 59 57 61 30 97 50 63 59 62 39 32 34 4 96 51 8 86 10 62 16 55 81 88 71 25 27 78 79 88 92 50 16 8 67 82 67 37 84 3 33 4 78 98 39 64 98 94 24 82 45 3 53 74 96 9 10 94 13 79 15 27 56 66 32 81 77";
//List<int> a = vv.Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
//a.Sort();

//var ddd=(from p in a
//        group p by p into pg
//        select new
//        {
//            n=pg.Key,
//            nc=pg.Count(),
//        }).ToList();
//int dc = ddd.Where(p => p.nc == 1).FirstOrDefault().n;
//Console.WriteLine(dc);

//var dl = a.Where(p => p > 0).Distinct();
//Console.WriteLine(dl.Count());





