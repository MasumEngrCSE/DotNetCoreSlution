using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class CLResult
{

    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */


    public List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        int[] rankedArray = ranked.ToArray();
        int mindx = rankedArray.Length + 1;

        List<int> rt = new List<int>();

        foreach (int i in player)
        {
            int index = BinarySearch(rankedArray, i);
            if (index >= 0)
            {
                index = rankedArray[index];
            }
            else
            {
                index = mindx;
            }

            rt.Add(index);
        }

        return rt;
    }

    private static int BinarySearch(int[] array, int value)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (array[mid] == value)
            {
                return mid;
            }
            else if (array[mid] < value)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }

    public List<int> climbingLeaderboardCG(List<int> ranked, List<int> player)
    {
        List<int> rt = new List<int>();

        // Step 1: Use a HashSet for ranked scores to remove duplicates
        var rankedSet = new HashSet<int>(ranked);

        // Step 2: Create a dictionary to store ranks of each score in ranked list
        var rankDict = new Dictionary<int, int>();
        int rank = 1;
        foreach (var score in rankedSet.OrderByDescending(p => p))
        {
            rankDict[score] = rank++;
        }

        int mindx = rankDict.Count + 1;

        foreach (int i in player)
        {
            int index = 0;
            // Step 3: Find the rank using the dictionary (constant time)
            if (rankDict.TryGetValue(i, out int playerRank))
            {
                index = playerRank;
            }
            else if (i < rankedSet.Min())
            {
                index = mindx;
            }
            else
            {
                // Find the rank manually (linear time, but only for elements not in the dictionary)
                var pr = rankedSet.First(p => p <= i);
                index = rankDict[pr];
            }

            rt.Add(index);
        }

        return rt;
    }

    public List<int> climbingLeaderboardOld(List<int> ranked, List<int> player)
    {

        List<int> rt = new List<int>();
        var qr = ranked.Select(p => p).Distinct().OrderByDescending(p => p).ToList();

        int mindx = qr.Count() + 1;

        foreach (int i in player)
        {
            int index = 0;
            var pr = qr.FirstOrDefault(p => p <= i);
            if (pr == 0)
            {
                index = mindx;
            }
            else
            {
                index = qr.IndexOf(pr) + 1;
            }

            rt.Add(index);
        }

        return rt.OrderByDescending(p => p).ToList();
    }

}

class ClimbingLeaderboard
{
    public void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();


        List<int> result = new CLResult().climbingLeaderboard(ranked, player);

        Console.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}

//https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem?isFullScreen=true#