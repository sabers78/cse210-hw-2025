using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // initlile the vairable: number
        int number;
        //initialize the list

        List<int> numberList = new List <int>();

        do {
            //ask the user for a number.
            Console.WriteLine("Give me a number");
            string inputNumber = Console.ReadLine();

            //change the number the user input from a string into an int
            number = int.Parse(inputNumber);

            //add the input number and put it into the list
            numberList.Add(number);


        } while(number != 0);
        
        //removes 0 from the list
        numberList.Remove(0);

        //prints the sum of the list
        int totalSum = numberList.Sum();
        Console.WriteLine($"The sum of all the numbers is {totalSum}");
        
        // finds the length of the list
        int listLength = numberList.Count();

        //convert totalSum into a float
        float floatSum = ((float)totalSum);
        // finds and prints the average of the numbers in the list

        float listAverage = floatSum / listLength;
        Console.WriteLine($"The average number is: {listAverage}");

        // finds the max value of the nubmers in the list
        int highestNumber = numberList.Max();
        Console.WriteLine($"The highest number is: {highestNumber}");
    }
}