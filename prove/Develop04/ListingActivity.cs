using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    List<string> ListUserWriting = new List<string>();
    protected int timeActivity3 = -1;
    public ListingActivity() : base()
    {
        setActivityName("Listing Activity");
        setDescription("This activity will help you reflect on the good things in your life by" +
        "having you list as many things as you can in a certain area.");
    }

    List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void runActivity()
    {
        runActivityParentSatart();
        message();
        displayPrompts();
        userWrite();
        indexList(ListUserWriting);
        displayEndingMessage();
    }

    public void message()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
    }
    public void displayPrompts()
    {
        int randomIndex = new Random().Next(0, prompts.Count());
        Console.WriteLine(prompts[randomIndex]);
        Console.WriteLine();
    }
    
    public void mayBegin()
    {
        Console.WriteLine("You may begin in: ");
        CountDown(4);
    }

    public void userWrite()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        timeActivity3 = getTimeActivity();

        while (stopwatch.ElapsedMilliseconds / 1000 < timeActivity3)
        {
            Console.WriteLine("> ");
            string write = Console.ReadLine();
            ListUserWriting.Add(write);
        }
    }

    public void indexList(List<string> list)
    {   
        int items = list.Count();
        Console.WriteLine();
        Console.WriteLine($"You listed {items} items!");
    }
}