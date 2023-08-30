class winningCardTuring
{
    internal void initialCall()
    {
        int[][] hands = new int[][] {
            new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 },
            new int[] { 1, 2, 2, 4, 4, 1 },
            new int[] { 1, 2, 3 }
        };

        //hands = new int[][] {
        //    new int[] { 5,5 },
        //    new int[] { 2, 2}
        //};

        int r = 0;
        int maxC = -1; int cc = 0;
        for (int i = 0; i < hands.Length; i++)
        {

            for (int j = 0; j < hands[i].Length; j++)
            {
                if (maxC < hands[i][j])
                {
                    int nC = 0;
                    for (int l = 0; l < hands[i].Length; l++)
                    {
                        if (hands[i][l] == hands[i][j]) nC++;
                    }
                    if (nC == 1)
                        maxC = hands[i][j];
                }
            }
        }
        r = maxC;
        Console.WriteLine(r);
    }

  
}