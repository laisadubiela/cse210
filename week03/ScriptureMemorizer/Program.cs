using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Joshua", 1, 9);
        Scripture scripture = new Scripture(reference, "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.");
        
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or quit to exit");
        string input = Console.ReadLine();
        while (input != "quit")
        {
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompleteHidden()) 
            {
                break;
            }
            Console.WriteLine("Press enter to continue or quit to exit");
            input = Console.ReadLine();
        }
    }
}