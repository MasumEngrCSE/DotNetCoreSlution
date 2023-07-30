// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello");

//var cl = new LISolution();
//cl.initialCall();


string vv = "84 48 13 20 61 20 33 97 34 45 6 63 71 66 24 57 92 74 6 25 51 86 48 15 64 55 77 30 56 53 37 99 9 59 57 61 30 97 50 63 59 62 39 32 34 4 96 51 8 86 10 62 16 55 81 88 71 25 27 78 79 88 92 50 16 8 67 82 67 37 84 3 33 4 78 98 39 64 98 94 24 82 45 3 53 74 96 9 10 94 13 79 15 27 56 66 32 81 77";

//vv = "59 88 14 8 85 1 94 74 57 96 39 2 47 43 35 17 53 52 92 31 99 48 94 30 92 60 32 45 88 13 39 50 22 65 89 46 65 76 57 67 99 35 76 46 85 82 45 62 53 80 74 22 31 52 82 13 41 96 2 1 80 62 4 20 50 89 59 67 60 8 41 14 47 48 17 4 43 30 32";

vv = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33";

List<int> a = vv.Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
//a.Sort();

var ddd=(from p in a
        group p by p into pg
        select new
        {
            n=pg.Key,
            nc=pg.Count(),
        }).ToList();
int dc = ddd.Where(p => p.nc == 1).FirstOrDefault().n;
Console.WriteLine(dc);

//var dl = a.Where(p => p > 0).Distinct();
//Console.WriteLine(dl.Count());





