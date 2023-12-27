using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Others
{
    public class nextPerfectSquare
    {
        // Function to find the
        // next perfect square
        public void initialCall()
        {

            //int N = 0;

            //int nextN = (int)Math.Floor(Math.Sqrt(N)) + 1;

            //Console.WriteLine(nextN * nextN);



            do
            {

                int nv =Convert.ToInt32(Console.ReadLine());


                int nextNv = (int)Math.Floor(Math.Sqrt(nv)) + 1;

                Console.WriteLine(nextNv * nextNv);


            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
