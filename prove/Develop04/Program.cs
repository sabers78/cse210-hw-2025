using System;

class Program
{
    static void Main(string[] args)
    {

        


        bool quit = false;

        while (quit == false)
        {
            Console.WriteLine("Pick a number to do an activity:");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflection activity");
            Console.WriteLine("3. Listing activity:");
            Console.WriteLine("quit");

            string quitCheck = Console.ReadLine();

            if (quitCheck == "quit" || quitCheck == "Quit")
            {
                quit = true;
            }

        }

    }
}