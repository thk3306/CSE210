using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Alex", "Science");
        Console.WriteLine($"{assignment1.GetSummary()}");

        MathAssignment math1 = new MathAssignment("Ben", "Science", "Section 7.3", "Problems 8-19");
        Console.WriteLine($"{math1.GetSummary()} {math1.GetHomeWorkList()}");

        WritingAssignment write1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"{write1.GetWritingInformation()}");
    }
}