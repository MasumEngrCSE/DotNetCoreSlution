using System.Text.RegularExpressions;

class RegexPSolution
{
    public void initialCall()
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        var list = new List<string>();
        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];


            string patN = "[a-z]";
            string patEmail = "[a-z]@gmail.com";

            if (Regex.IsMatch(firstName, patN) && Regex.IsMatch(emailID,patEmail))
            {
                list.Add(firstName);
            }
        }

        Console.WriteLine(String.Join("\n", list.OrderBy(p=>p)));
    }
}