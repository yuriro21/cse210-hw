using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program! ");

        PromptGenerator _prompts = new PromptGenerator();
        Journal _journal = new Journal();
        Entry _entry = new Entry();

        int _userAnswer = -1;
        
        while (_userAnswer !=5)
        {
            string _prompt = _prompts.GetPrompt();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What do you want to do? ");
            _userAnswer = int.Parse(Console.ReadLine());

            if (_userAnswer == 1)
            {
                Console.WriteLine($"{_prompt}");
                string _userDay = Console.ReadLine();
                _entry.Write(_userDay);
            }
            else if (_userAnswer == 2)
            {
                _entry.Read();
            }
            else if (_userAnswer == 3)
            {
                _journal.Load();
            }
            else if (_userAnswer == 4)
            {
                _journal.Save();
            }
            else
            {
                _userAnswer = 5;
                Console.WriteLine("See you soon");
            }
        }
    }
}