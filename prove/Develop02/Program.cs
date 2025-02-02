using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's journal together!");

        //loop in the journal
        
        bool endJournal = false;
        
        //make a new entry method
        Entry newEntry = new Entry();
        Journal loadEntry = new Journal();

        while (endJournal == false)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");

            
            
            
            string menuSelect = Console.ReadLine();
            int numberMenu = int.Parse(menuSelect);

            if (numberMenu == 1)
            {
                
                newEntry.AddEntry();
                
            }
            else if (numberMenu == 2)
            {
                newEntry.Display();

            }
            else if (numberMenu == 3)
            {
                loadEntry.LoadJournalPrompts();

            }
            else if (numberMenu == 4)
            {
                newEntry.SaveEntry();

            }
            else if (numberMenu == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Error, Try again.");
            }



        }

    }
}