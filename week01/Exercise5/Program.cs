using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumberSquared = PromptUserNumber();
        Console.WriteLine($"{userName}, your favorite number squared is {userNumberSquared}");
    }    

    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the Program.");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        return name;    
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string userResponse = Console.ReadLine();
        int userNumber = int.Parse(userResponse);
        int SquareNumber = userNumber * userNumber;
        return SquareNumber;
    }
}