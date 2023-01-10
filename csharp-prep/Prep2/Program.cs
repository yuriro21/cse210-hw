using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Prep 2 Grade Calculator");
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int userGrade = int.Parse(userAnswer);
        
        string letter = "";
        string sing = "";

        int remainder = userGrade % 10;

        if (remainder >= 7)
        {
            sing = "+";
        }
        else if (remainder < 3)
        {
            sing = "-";
        }
        else
        {
            sing = "";
        }

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (userGrade >= 93)
        {
            sing = "";
        }
        if (letter == "F")
        {
            sing = "";
        }
        
        Console.WriteLine($"Your grade is: {letter}{sing}");

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulation, you pass!");
        }
        else
        {
            Console.WriteLine("Good luck for the next time");
        }
        
    }
}