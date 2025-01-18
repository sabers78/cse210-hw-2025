using System;

class Program
{
    static void Main(string[] args)
    {
        // initailze guessed number
        int guessedNumber;

        //initilaze guess list
        List<int> guessList = new List<int>();

        // find a random number

        Random randomNumberGenorator = new Random();
        int randomNumber = randomNumberGenorator.Next(0,100);

        //max number variable
        int maxNumber = 100;
        // guess the number
        do
        {
            Console.WriteLine($"Guess a number between 0 and 100:");
            string guessedNumberInput = Console.ReadLine();

            // turn the guessed number into an int
            guessedNumber = int.Parse(guessedNumberInput);

            // check to see if the number is higher or lower.
            if (guessedNumber == randomNumber)
            {
                Console.WriteLine($"Good job! {guessedNumber} was the number!");
                guessList.Add(guessedNumber);

            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Lower");
                guessList.Add(guessedNumber);
            }
            else
            {
                Console.WriteLine("Higher");
                guessList.Add(guessedNumber);
            }
        } while (guessedNumber != randomNumber); 

        int countGuesses = guessList.Count;
        Console.WriteLine($"You guessed the number in this many times:{countGuesses}");
        
        
    }
}