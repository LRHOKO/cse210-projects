using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int listNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (listNumber != 0)
        {
             Console.Write("Enter a number (0 to quit): ");

             string userInput = Console.ReadLine();
             listNumber = int.Parse(userInput);

             if (listNumber != 0)
             {
                numbers.Add(listNumber);
             }



        }
      
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+= number;
        }

        Console.WriteLine($"The sum is: {sum}");



        float average = ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {average:F15}");

           int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}