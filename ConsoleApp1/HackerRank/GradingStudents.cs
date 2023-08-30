class gradingResult
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public List<int> gradingStudents(List<int> grades)
    {
        var result = new List<int>();
        foreach (var grade in grades)
        {
            if (grade <38 )
                result.Add(grade);
            else
            {
                int newRval =Convert.ToInt32(Math.Ceiling((float)grade / 5) * 5);
                if((newRval-grade)<3)
                    result.Add(newRval);
                else
                    result.Add(grade);
            }
        }
        return result;
    }

}

class gradingSolution
{
    public void initialCall()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = new gradingResult().gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}