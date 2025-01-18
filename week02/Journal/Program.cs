// Save other information (mood of the day) in the journal entry.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _choice = 0;
        Answers a = new Answers();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("What is your name?");
        string _name = Console.ReadLine();
        Questions q = new Questions();

        while (_choice != 5)
        {

            Console.WriteLine($"Please {_name}, select one of the following choices:");
            string _names = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";
            Console.WriteLine($"{_names} \n What would you like to do?");
            _choice = int.Parse(Console.ReadLine());

            if (_choice == 1)  // Write
            {
                string _getquestion = q.GetQuestion();
                Console.WriteLine(_getquestion);
                string _answer = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string _date = theCurrentTime.ToShortDateString();
                Console.WriteLine("What is you mood of the day?");
                string _mood = Console.ReadLine();
                a.GetAnswer(_getquestion, _answer, _date, _mood);
            }
            else if (_choice == 2) // Display
            {

                foreach (string _answer in a._answers)
                {
                    Console.WriteLine(_answer);
                }
            }
            else if (_choice == 3) // Load
            {
                Console.WriteLine("Please enter the name of the file you would like to load: ");
                string _filename = Console.ReadLine();
                string[] _lines = System.IO.File.ReadAllLines(_filename);
                a._answers.Clear();

                foreach (string _line in _lines)
                {
                    a._answers.Add(_line);
                }
            }
            else if (_choice == 4) // Save
            {
                Console.WriteLine("Please enter the name of the file you would like to save: ");
                string _filename = Console.ReadLine();

                using StreamWriter outputFile = new(_filename);
                foreach (string _answer in a._answers)
                {
                    outputFile.WriteLine(_answer);
                }
            }
            else if (_choice == 5) // Quit
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}