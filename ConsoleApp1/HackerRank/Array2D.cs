using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank
{
    public class Array2D
    {


        public void calculate2dArray()
        {
            List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < 6; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}


            //arr.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
            //arr.Add(new List<int> { 0, 1, 0, 0, 0, 0 });
            //arr.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
            //arr.Add(new List<int> { 0, 0, 2, 4, 4, 0 });
            //arr.Add(new List<int> { 0, 0, 0, 2, 0, 0 });
            //arr.Add(new List<int> { 0, 0, 1, 2, 4, 0 });

            arr.Add(new List<int> { 0, -4, -6, 0, -7, -6 });
            arr.Add(new List<int> { -1, -2, -6, -8, -3, -1 });
            arr.Add(new List<int> { -8, -4, -2, -8, -8, -6 });
            arr.Add(new List<int> { -3, -1, -2, -5, -7, -4 });
            arr.Add(new List<int> { -3, -5, -3, -6, -6, -6 });
            arr.Add(new List<int> { -3, -6, 0, -8, -6, -7 });

            int col = 0;
            List<int> lstAsum = new List<int>();
            for (int i = 0; i < 16; i++)
            {

                int rn = i / 4;

                if (col == 4) col = 0;

                int gc = 1;
                int gr = 0;
                int gs = 0;
                for (int r = rn; r < rn + 3; r++)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        if (!(gr == 1 && (gc == 4 || gc == 6)))
                        {
                            gs += arr[r][j];
                            Console.Write(arr[r][j] + " ");
                        }
                        gc++;
                    }
                    gr++;
                }

                Console.WriteLine(" :" + gs);

                lstAsum.Add(gs);


                col++;
            }

            Console.WriteLine(lstAsum.Max());


        }

    }
}
