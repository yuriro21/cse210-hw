using System;

class Program
{
    static void Main(string[] args)
    {
        Assignmet student1 = new Assignmet("Samuel Bennett", "Multiplication");
        MathAssignment student2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment student3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(student1.GetSummary());
        Console.WriteLine();
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}