using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Nicolas", "Coding");
        Console.WriteLine(test.GetSummary());

        MathAssignment newtest = new MathAssignment("Bob Marley","math","5.3","4-12");
        Console.WriteLine(newtest.GetSummary());
        Console.WriteLine(newtest.GetHomeworkList());

        WritingAssignment lasttest = new WritingAssignment("Gerald", "Agriculture", "The Song of Flowers" );
        Console.WriteLine(lasttest.GetSummary());
        Console.WriteLine(lasttest.GetWritingInformation());
    }
}