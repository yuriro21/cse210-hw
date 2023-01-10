using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int Square = SquareNumber(UserNumber);
        DisplayResult(userName, Square);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number}");
        }

    }
}