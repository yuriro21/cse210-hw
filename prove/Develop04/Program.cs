using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {  
        Activity activity = new Activity();

        int userChoice = 0;

        List<string> menu = new List<string>()
        {
            "Menu Options: ",
                "1. Start breathing activity",
                "2. Start reflecting activity",
                "3. Start listing activity",
                "4. Play a game",
                "5. Quit",
        };

        while (userChoice != 5)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Selet a choice from menu: ");
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.runActivity();
                    break;
                case 2:
                    ReflectionActivity activity2 = new ReflectionActivity();
                    activity2.runActivity();
                    break;
                case 3:
                    ListingActivity activity3 = new ListingActivity();
                    activity3.runActivity();
                    break;
                case 4:
                    Game newGame = new Game();
                    newGame.startGame();
                    Thread.Sleep(5000);
                    break;
            }
        }
    }
}