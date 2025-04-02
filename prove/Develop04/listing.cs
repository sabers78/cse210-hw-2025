public class Listing : Activity
{
    List<string> prompt = new List<string>()
    {
        "What are you grateful for today?",
        "How have you seen the Lord's hand in your life?",
        "What beautfiul things did you see today?",
        "Who has made a difference in your life in the last year?",
        "How has school been a blessing?",
        "Who are you best freinds?",
        "What things contributed most to your testimony?"
    };

    List<string> userItems = new List<string>();

    private static Random _randomGenerator = new Random();

        public Listing(string intro, string description, int duration): base(intro,description,duration)
    {
        
    }

    public void Run()
    {

        Console.WriteLine(Introduction());
        SetDuration();
        Console.WriteLine(RandomPrompt());
        countDown();
        Console.WriteLine("Start:");

        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(_duration);
        while (DateTime.Now < endingTime)
        {
            userItems.Add(Console.ReadLine());


        }
        Console.WriteLine($"You listed {userItems.Count} items.");
        Console.WriteLine("Done.");
        Thread.Sleep(2000);
        End();

    }

    public string RandomPrompt()
    {
        int randomIndex = _randomGenerator.Next(prompt.Count);

        return prompt[randomIndex];
    }



}