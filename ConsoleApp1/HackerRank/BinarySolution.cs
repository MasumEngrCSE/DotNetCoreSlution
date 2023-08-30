using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank
{
    public class BinarySolution
    {


        public void TenthToBianry1Count()
        {

            int bn = 125;
            //int bn = v10;
            List<int> list = new List<int>();
            while (0 < bn)
            {
                if (bn % 2 == 0)
                    list.Add(0);
                else
                    list.Add(1);

                bn /= 2;
            }

            int c1 = 0;
            int pc1 = 0;
            foreach (int i in list)
            {
                if (i == 1)
                    c1++;
                else if (i == 0)
                    c1 = 0;

                if (c1 > pc1)
                    pc1 = c1;
            }

            Console.WriteLine(pc1);
        }


    }
}
