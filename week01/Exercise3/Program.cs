using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher.");
            
            }
        
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }

            else
            {
                Console.WriteLine("You did it!");
            }
            
            
        }
        
    }
}