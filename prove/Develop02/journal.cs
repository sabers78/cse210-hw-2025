using System.IO;
using System;
using System.Collections.Generic;


public class Journal
{
    // file names

    string filePrompt = "journalprompt.txt";

    string fileEntry = "journalentry.txt";


    public void LoadJournalPrompts()
    {
        string[] lines = System.IO.File.ReadAllLines(filePrompt);
        string[] entryLines = System.IO.File.ReadAllLines(fileEntry);

        for (int i = 0; i < lines.Length; i++) // We know lines and entryLines have the same length
        {
            // Process prompt
            string[] parts = lines[i].Split("%%");
            string loadedPrompt = parts[0];
            Console.WriteLine("Prompt: " + loadedPrompt);

            // Process entry
            string[] otherParts = entryLines[i].Split("%%");
            string loadedEntry = otherParts[0];
            Console.WriteLine("Entry: " + loadedEntry);

            // Add a line break between prompt/entry pairs
            Console.WriteLine();
        }
    }
}