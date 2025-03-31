using System;
using System.Collections.Generic;

public class Scripture
{
    private string _scripture= "Trust in the Lord with all your heart, and lean not unto your own Understanding, in all thy ways acknowledge Him, and He shall direct thy paths.";
    private List<string> _words;
    private Random _random = new Random();

    public Scripture()
    {
        _words = new List<string>(_scripture.Split(' '));
    }

    public string GetHiddenScripture()
    {
        return string.Join(" ", _words);
    }

    public void HideWords()
    {
        int hideTheWords = 3; // this hides my words, so I guess I could change how manywords it hides, if i wanted to.

        for (int i = 0; i <hideTheWords; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index] = "___";
        }


    }
    public bool IsCompletelyHidden()
    {
        return !_words.Exists(word => word != "___");
    }
    
}    
    
        
