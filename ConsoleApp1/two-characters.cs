class TCResult
{

    /*
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public  int alternate(string s)
    {
        string ds = s;
        bool isEnd = false;
        int i = 0;
        string afaces = "";
        while (!isEnd)
        {     
            string tys = ds;
            if (tys.Length>2)
            {
                if((i>tys.Length-1))
                {
                    goto nextfetch;
                }

                
                string tc = ds[i].ToString();
                i++;

                if (afaces.Contains(tc) && (i < tys.Length - 1))
                {
                    tc = ds[i].ToString();
                }

                tys = tys.Replace(tc,"");
                int df = 0;
                string pv="";
                foreach (char c in tys)
                {
                    string cv=c.ToString();
                    if(cv.Equals(pv) )
                    {
                        df = 1;
                        break;
                    }
                    pv = cv;
                }


                if (df == 0 && tys.Length>1)
                {
                    ds = tys;
                }
                else
                {                
                    tys = ds;
                }
                afaces += tc;

            }
            else
            {
                isEnd = true;
            }
        }

    nextfetch:

        int r = 0;
        if(ds.Length<s.Length)
        {
            r = ds.Length;
        }

        return r;
    }

}

class TCSolution
{
    public  void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = new TCResult().alternate(s);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}