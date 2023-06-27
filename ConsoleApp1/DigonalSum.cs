using System.Xml.Linq;

class digonalClass
{
    public void digonalSum()
    {


        List<List<int>> arr = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 }
};

        int la = 0, ra = 0;



        for (int i = 0; i < arr.Count; i++)
        {
            List<int> innerList = arr[i];

            la += innerList[i];
            ra += innerList[(innerList.Count - 1) - i];

            //for (int j = 0; j < innerList.Count; j++)
            //{
            //    la += innerList[i];
            //    ra += innerList[(innerList.Count-1)-i];


            //    int element = innerList[j];
            //    Console.WriteLine("Element at arr[{0}][{1}]: {2}", i, j, element);
            //}



        }

        int aa = Math.Abs(la - ra);

        Console.WriteLine(aa);
    }
}