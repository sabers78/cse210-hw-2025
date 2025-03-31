using System;

class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new Reference();



        Scripture verse = new Scripture();

        while (!verse.IsCompletelyHidden())
        {   
            Console.Clear();

            Console.WriteLine($"{newReference.GetScriptureReference()} {verse.GetHiddenScripture()} ");
            string theInput = Console.ReadLine();

            if (theInput == "")
            {
                verse.HideWords();
            }
            else if (theInput == "quit")
            {
                Console.Write("Quitting the Program.");
                break;
            } 
        }
    }
}