using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int sum = 0;
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        
        int largest = int.MinValue;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        } 
            
        float average = (float)sum / numbers.Count;
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");

    }
}