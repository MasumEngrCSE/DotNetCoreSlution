public class baseball
{


    public int callPoints(string[] ops)
    {
        int[] itv = new int[ops.Length];
        int i = 0;
        foreach (var op in ops)
        {


            if (op == "C")
            {
                itv[i - 1] = 0;
                i = i - 1;
            }
            else if (op == "D")
                itv[i] = itv[i - 1] * 2;
            else if (op == "+")
                itv[i] = itv[i - 2] + itv[i - 1];
            else
                itv[i] = Convert.ToInt32(op);



            if (op != "C")
                i++;


        }


        int ss = 0;
        foreach (var opv in itv)
        {
            ss = ss + opv;
        }





        return ss;
    }


    public void getPoint()
    {
        //string[] ii = new string[5] { "5", "2", "C", "D", "+" };

        //string[] ii = new string[8] { "5", "-2","4", "C", "D","9", "+","+" };
        string[] ii = new string[1] { "1" };

        int oo = callPoints(ii);

        Console.WriteLine(oo);

        //return oo;
    }

}