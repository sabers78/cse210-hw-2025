using System;

class Program
{
    static void Main(string[] args)
    {

        Breathe breather = new Breathe("Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
        0);

        Reflection reflect = new Reflection("Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0
        );

        Listing listActivity = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0
        );
        


        bool quit = false;

        while (quit == false) //I might need to do "quit != true"
        {
            Console.WriteLine("Pick a number to do an activity:");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflection activity");
            Console.WriteLine("3. Listing activity:");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                quit = true;
            }
            else if (choice == "1")
            {
                breather.Run();
            }
            else if (choice == "2")
            {
                reflect.Run();
            }
            else if (choice == "3")
            {
                listActivity.Run();
            }

        }

    }
}