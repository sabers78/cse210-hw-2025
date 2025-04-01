using System; 
using System.Threading; 

public class Activity
{
    private string _intro;
    private string _description;
    protected int _duration;


    public Activity(string intro, string description, int duration)
    {
        _intro = intro;
        _description = description;
        _duration = duration;

        
    }

    public string Introduction()
    {
        return $"Welcome to the {_intro} activity.\n{_description}";
    }

    public void SetDuration()
    {
        Console.WriteLine("How much time would you like to dedicate to this activity?");
        string time = Console.ReadLine();
        int userTime = int.Parse(time);
        Console.WriteLine("Perfect, pause for a second and prepare to begin.");
        _duration = userTime;
    }

    public void end()
    {
        string completedMessage = $"Well done. you have completed the {_intro} activity, which lasted {_duration} seconds";
        Console.WriteLine(completedMessage);
    }

    public void ShowSpinner()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("___<* ^,  , )~~~____ ");
            Thread.Sleep(3000);

        }
        Console.WriteLine("Done");
    }

    public void countDown()
    {
        for (int i = 5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    
    
}