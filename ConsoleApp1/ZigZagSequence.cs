class ZigZagSequence
{
    internal void initialCall()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int t = Convert.ToInt32(Console.ReadLine());

        while (t-- > 0)
        {
            int al = Convert.ToInt32(Console.ReadLine());

            var ar = new int[al];

            for (int i = 0; i < t; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for (int i = 1; i <= al; i++)
            //{
            //    ar[i - 1] = i;
            //}

            int mv = ar[ar.Length - 1];


            int k = (ar.Length - 1) / 2;
            int midV = ar[k];

            ar[k] = mv;
            ar[ar.Length - 1] = midV;


            int cv = 0; int nv = 0;
            for (int i = k+1;  i < ar.Length - 1; i++)
            {
                cv = ar[i]; nv = ar[i + 1];

                if(cv < nv)
                {
                    ar[i] = nv;
                    ar[i + 1] = cv;
                }
            }

            string rv = "";
            for (int i = 0; i < ar.Length; i++)
            {
               rv+= ar[i] + " ";
            }

            Console.WriteLine(rv.Trim());

        }




        //var ar=new int[5] { 2,3,5,1,4 };
        ////var ar = new int[7] { 4, 3, 7, 8, 6, 2, 1 };


        //for (int i = 0; i < t; i++)
        //{
        //    ar[i] = Convert.ToInt32(Console.ReadLine());
        //}









    }


    internal void initialCall2()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int t = Convert.ToInt32(Console.ReadLine());

        while (t-- > 0)
        {
            int al = Convert.ToInt32(Console.ReadLine());

            var ar = new int[al];


            for (int i = 1; i <= al; i++)
            {
                ar[i - 1] = i;
            }



            int cv = 0; int nv = 0; bool isOdd = true;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                cv = ar[i]; nv = ar[i + 1];
                if (cv > nv && isOdd)
                {
                    ar[i] = nv;
                    ar[i + 1] = cv;
                }
                else if (cv < nv && !isOdd)
                {
                    ar[i] = nv;
                    ar[i + 1] = cv;
                }

                if (isOdd) isOdd = false;
                else isOdd = true;
            }




            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }

        }




        //var ar=new int[5] { 2,3,5,1,4 };
        ////var ar = new int[7] { 4, 3, 7, 8, 6, 2, 1 };


        //for (int i = 0; i < t; i++)
        //{
        //    ar[i] = Convert.ToInt32(Console.ReadLine());
        //}









    }
}