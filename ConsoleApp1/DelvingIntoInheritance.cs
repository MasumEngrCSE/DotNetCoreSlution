using System;
using System.Linq;

class InhPerson
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public InhPerson() { }
    public InhPerson(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : InhPerson
{
    private int[] testScores;
    public Student(string? firstName, string? lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }

    public char Calculate()
    {
        int gpa = testScores.Sum() / testScores.Count();


        if (gpa >= 90 && gpa <= 100)
            return 'O';
        else if (gpa >= 80 && gpa < 90)
            return 'E';
        else if (gpa >= 70 && gpa < 80)
            return 'A';
        else if (gpa >= 55 && gpa < 70)
            return 'P';
        else if (gpa >= 40 && gpa < 55)
            return 'D';
        else if (gpa < 40)
            return 'T';
        else
            return default;

    }
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}

class diInheritance
{
    public void call()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}