using System;
using System.Threading;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        AllGoals allGoals = new AllGoals();
        int userMenuChoice = 0;
        List<string> menu = new List<string>()
        {
            "Menu Options: ",
                "   1. Create new goal",
                "   2. List goals",
                "   3. Save goals",
                "   4. Load goals",
                "   5. Record event",
                "   6. Quit" 
        };

        while (userMenuChoice != 6)
        {   
            Console.WriteLine($"You have {allGoals.getTotalPoints()} points.");
            Console.WriteLine();

            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Selet a choice from menu: ");
            userMenuChoice = int.Parse(Console.ReadLine());

            switch (userMenuChoice)
            {
                case 1:
                    SimpleGoal simplegoal1 = new SimpleGoal();
                    EternalGoal eternalGoal1 = new EternalGoal();
                    ChecklistGoal checklistGoal1 = new ChecklistGoal();

                    Console.WriteLine("The tipes of goals are: ");
                    Console.WriteLine("   1. Simple goal");
                    Console.WriteLine("   2. Eternal goal");
                    Console.WriteLine("   3. Checklist goal");
                    int userChoiceCase1 = int.Parse(Console.ReadLine());
                    //Goal goal = null;


                    if (userChoiceCase1 == 1)
                    {
                        simplegoal1.runActivity();
                        string goal = simplegoal1.ToString();
                        allGoals.addGoal(goal);
                    }
                    else if (userChoiceCase1 == 2)
                    {
                        eternalGoal1.runActivity();
                        string goal = eternalGoal1.ToString();
                        allGoals.addGoal(goal);
                    }
                    else if (userChoiceCase1 == 3)
                    {
                        checklistGoal1.runActivity();
                        string goal = checklistGoal1.ToString();
                        allGoals.addGoal(goal);
                    }
                    break;
                    ///////////////////////////////////////////////////////
                    // switch (userChoiceCase1)
                    // {
                    //     case 1:
                    //         simplegoal1.runActivity();   
                    //         break;
                    //     case 2:
                    //         eternalGoal1.runActivity();
                    //         break;
                    //     case 3:
                    //         checklistGoal1.runActivity();
                    //         break;
                    // }
                    // if (goal != null)
                    //     {
                    //         allGoals.addGoal(goal);
                    //     }

                    // break;                    
                case 2:
                    Console.WriteLine("The goals are: ");
                    allGoals.DisplayGoals();
                    Thread.Sleep(4000);
                    break;
                case 3:
                    allGoals.SaveGoal();
                    break;
                case 4:
                    SaveLoad load = new SaveLoad();
                    load.LoadFile();
                    break;
                case 5:
                    
                    break;
            }
        }
    }
}