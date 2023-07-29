
class LSResult
{

    /*
     * Complete the 'longestSubarray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public  int longestSubarray(List<int> arr)
    {

        var groupByFirstLetterQuery =
            from student in arr
            group student by student
            into newGroup
            select new
            {
                VV=newGroup.Key,
                CC=newGroup.Count()
            };
        ;

        return 0;

    }

}


class longestSubarray
{
    public  void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = new LSResult().longestSubarray(arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}