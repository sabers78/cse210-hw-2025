using System.Collections.Generic; 

public class Breathe : Activity
{


    public void Display()
    {
        Introduction();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Breath in...");
            countDown();
            Console.Write("Breath Out...");
            countDown();

        }
        Console.WriteLine("Done.");
        Thread.Sleep(2000);
        Console.WriteLine($"It took {_duration} seconds to complete this activity.");

    }

    

}