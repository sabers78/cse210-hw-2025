using System.Collections.Generic; 

public class Breathe : Activity
{


    public Breathe(string intro, string description, int duration): base(intro,description,duration)
    {

    }
    public void Run()
    {
        Console.WriteLine(Introduction());

        SetDuration();
        ShowSpinner(5);
        

        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(_duration);
        while (DateTime.Now < endingTime)
        {
            Console.WriteLine("Breath in...");
            countDown();
            Console.WriteLine("Breath Out...");
            countDown();

        }
        Console.WriteLine("Done.");
        Thread.Sleep(2000);
        End();

    }

    

}