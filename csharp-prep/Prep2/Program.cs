using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percent did you get?");
        string gradePercent = Console.ReadLine();

        int numberPercent = int.Parse(gradePercent);

        string finalGrade = ""; 

        if (numberPercent >= 90)
        {
            finalGrade = "A";
        }

        else if (numberPercent >= 80)
        {
            finalGrade = "B";
        }

        else if (numberPercent >= 70)
        {
            finalGrade = "C";
        }

        else if (numberPercent >= 60)
        {
            finalGrade = "D";
        }

        else if (numberPercent < 60)
        {
            finalGrade = "F";
        }


        if (numberPercent >= 70)
        {
            Console.WriteLine($"Congratulations! You did well and passed with a {finalGrade}");
        }

        else 
        {
            Console.WriteLine("I'm sorry, you did not pass. Try again!");
        }

       
    }
}