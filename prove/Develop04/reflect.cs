using System;
using System.Collections.Generic;

public class Reflection : Activity
{

    List<string> _reflectPrompt = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> _reflectionQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private static Random _randomGenerator = new Random();


    public Reflection(string intro, string description, int duration): base(intro,description,duration)
    {
        
    }


    public void Run()
    {

        

        Console.WriteLine(Introduction());
        SetDuration();
        Console.WriteLine(RandomPrompt());
        

        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(_duration);
        while (DateTime.Now < endingTime)
        {
            foreach (string i in _reflectionQuestions)
            {

                if (DateTime.Now >= endingTime)
                {
                    break;
                }

                Console.WriteLine(i);
                ShowSpinner(10);
            }

        }
        Console.WriteLine("Done.");
        Thread.Sleep(2000);
        End();

    }

    public string RandomPrompt()
    {
        int randomIndex = _randomGenerator.Next(_reflectPrompt.Count);

        return _reflectPrompt[randomIndex];
    }
}

