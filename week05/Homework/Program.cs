using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment ("Jonh", "Multiplication");
        Console.WriteLine(a1.GetSummary());


        MathAssignment a2 = new("Levi", "Algebra", "Section 7.3", "Problems 8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignmnt a3 = new WritingAssignmnt("Joseph", "Business", "How to get the client");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}