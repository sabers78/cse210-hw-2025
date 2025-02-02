public class Entry
{


    //make a list of prompts
    public  List<string> promptList = new List<string>() {
        "What was your favorite activity you did today?", "What was your happiest moment", "Who was the coolest person you met today?", "What made you stronger today?", "What was the Lord's hand in your life today?", "What was the strongest emotion I felt today?"
        };

    //The entry list that will store the entries    
    public List<string> entryList = new List<string>();

    //This list will store the prompts in the order that they appeared so as to make thejournal more coesive
    public List<string>  orderedPrompt = new List<string>();
    
    //find random prompts
    Random randomPrompt =  new Random();
    


    public void AddEntry()
    {
        //find random prompts within the add entry method
        int randomIndex = randomPrompt.Next(promptList.Count);
        string randomDailyPrompt = promptList[randomIndex];

        //Stuff I need to display (Also add the entry to the entry list)
        Console.WriteLine(randomDailyPrompt);
        Console.Write("Entry:");
        string dailyEntry = Console.ReadLine();
        entryList.Add(dailyEntry);
        orderedPrompt.Add(randomDailyPrompt);

    }
    
    public void Display()
    {
        //display journal
        foreach (string journalEntry in entryList)
        {
            int index = entryList.IndexOf(journalEntry);
            string correspondingPrompt = orderedPrompt[index];
            Console.WriteLine($"prompt: {correspondingPrompt}");
            Console.WriteLine($"Entry: {journalEntry}");

        }
        

    }

    public void SaveEntry()
    {
        //save daily entry as a text file
        string fileName = "journalentry.txt";

        //save orderedprompt as a text file
        string promptFileName = "journalprompt.txt";


        //use streamweriter to write the text to a file
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
             foreach (string textEntry in entryList)
            {
                string entryListToText = textEntry;
                outputFile.WriteLine(entryListToText);
                

            }

            
        }

        using (StreamWriter outputPromptFile = new StreamWriter(promptFileName))
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            foreach (string textPrompt in orderedPrompt)
            {
                string promptListToText = textPrompt;
                outputPromptFile.WriteLine($"{dateText} {promptListToText}");
            }
        }

        Console.WriteLine("Journal Saved.");
    }
}
        

       