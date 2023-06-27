class DistonaryTest
{


    public void MobileNUmberCheck()
    {

        int n = int.Parse(Console.In.ReadLine());
        Dictionary<string, string> mob = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] data = input.Split(' ');

            if (data.Length == 2 && data[1].Length == 8)
                mob.Add(data[0], data[1]);
        }



        // Read queries until there is no more input
        while (true)
        {
            string s = Console.ReadLine();

            if (string.IsNullOrEmpty(s))
                break;

            bool ifExists = mob.ContainsKey(s);

            if (ifExists)
            {
                string mfound = mob[s];
                Console.WriteLine($"{s}={mfound}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }




   
}