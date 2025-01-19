using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string endName = PromptUsername();
        int endNumber = PromptUserNumber();
        int endSquare = SquareNumber(endNumber);
        DisplayResult(endName, endSquare);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //ask for and terutn the serers name as a string

        static string PromptUsername()
        {
            Console.WriteLine("What is your name:");
            string usersName = Console.ReadLine();
            return usersName;

        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string userNumber = Console.ReadLine();
            int realUserNumber = int.Parse(userNumber);

            return realUserNumber;

        }

        //sqaure number function

        static int SquareNumber(int realUserNumber)
        {
            int needToSqaure = realUserNumber * realUserNumber;
            return needToSqaure;
        }

        static void DisplayResult(string usersName, int needToSqaure )
        {
            Console.WriteLine($"Your name is {usersName}, and your favorite number (squared) is {needToSqaure}");
            
        }
    }
}