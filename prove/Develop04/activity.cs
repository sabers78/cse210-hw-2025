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
        Thread.Sleep(3000);
    }

    public void End()
    {
        string completedMessage = $"Well done. you have completed the {_intro} activity, which lasted {_duration} seconds";
        Console.WriteLine(completedMessage);
    }

    public void ShowSpinner(int spinnerTime)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("__________<* ^,  . )~~~");
        animationStrings.Add("_________<* ^.  , )~~~_");
        animationStrings.Add("________<* ^,  . )~~~__");
        animationStrings.Add("_______<* ^.  , )~~~___");
        animationStrings.Add("______<* ^,  . )~~~____");
        animationStrings.Add("_____<* ^.  , )~~~_____");
        animationStrings.Add("____<* ^,  . )~~~______");
        animationStrings.Add("___<* ^.  , )~~~_______"); 
        animationStrings.Add("__<* ^,  . )~~~________");
        animationStrings.Add("_<* ^.  , )~~~_________");
        animationStrings.Add("<* ^,  . )~~~__________");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinnerTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                         ");
            Console.Write("\r");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        
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