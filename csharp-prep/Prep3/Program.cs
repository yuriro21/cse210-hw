using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Prep 3, Magic Number! try to guess a number between 1 and 10");

        string game = "yes";

        while (game == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1 , 11);
            int guess = 0;
            int count = 0;
            
                while (magicNumber != guess)
                {
                    Console.Write("What is your guess? ");
                    string guessN = Console.ReadLine();
                    guess = int.Parse(guessN);

                    if (magicNumber < guess )
                    {
                        Console.WriteLine("Lower");
                    }
                    else if ( magicNumber > guess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }

                    count = count + 1;
                }
            Console.WriteLine($"You tried {count} times");
            Console.WriteLine("Do you want to play again? ");
            game = Console.ReadLine();
        }
    }
}