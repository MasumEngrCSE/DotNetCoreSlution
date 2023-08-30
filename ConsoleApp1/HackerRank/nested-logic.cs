class nested_logic
{
    internal void initialCall()
    {
        try
        {
            
            string[] ret = Console.ReadLine().TrimEnd().Split(' ');
            string[] aret = Console.ReadLine().TrimEnd().Split(' ');
            int d1, m1, y1, d2, m2, y2;
            d1 = Convert.ToInt32(ret[0]);m1 = Convert.ToInt32(ret[1]);y1 = Convert.ToInt32(ret[2]);
            d2 = Convert.ToInt32(aret[0]);m2 = Convert.ToInt32(aret[1]);y2 = Convert.ToInt32(aret[2]);

            int fa = 0;
            if (d1 > d2 && m1 == m2 && y1 == y2)
                fa = 15 * (d1 - d2);
            else if (m1 > m2 && y1 == y2)
                fa = 500 * (m1 - m2);
            else if (y1 > y2)
                fa = 10000 ;

            Console.WriteLine(fa);


        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}