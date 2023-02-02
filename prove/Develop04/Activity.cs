using System.Diagnostics;
using System.Threading;

public class Activity
{
    private string activityName, description, startingMessage, endingMessage;
    protected int spinnerCounter = 0;
    protected int timeActivity = 0;

    public Activity()
    {
        spinnerCounter = timeActivity = 0;
    }

    public void setActivityName(string _activityName)
    {   
       activityName = _activityName;
    }

    public void setDescription(string _description)
    {
        description = _description;
    }

    public int getTimeActivity()
    {
        return timeActivity;
    }

    public void displaySartingMessage()
    {
        startingMessage = string.Format("Welcom to the {0}", activityName);
        Console.WriteLine(startingMessage);
        Console.WriteLine();
    }

    public void displayDescription()
    {
        Console.WriteLine(description);
        Console.WriteLine();
    }

    public void displayEndingMessage()
    {
        endingMessage = string.Format("You have complete another {0} seconds of the {1}.", timeActivity, activityName);
        Console.WriteLine();
        Console.WriteLine("Well done!");
        displaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(endingMessage);
        Console.WriteLine();
        displaySpinner(10);
    }

    public void displaySpinner(int numSecondsToRun)
    {   
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.WriteLine(string.Format("You may bigin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void displayGetSessionLength()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        timeActivity = int.Parse(Console.ReadLine());
    }

    public void displayGetReady()
    {
        Console.WriteLine("Get ready...");
        displaySpinner(5);
    }

    public void runActivityParentSatart()
    {
        displaySartingMessage();
        displayDescription();
        displayGetSessionLength();
        displayGetReady();
    }

    public void runActivityParentEnd()
    {
        displayEndingMessage();
    }   

    public void CountDown(int countDownTime)
    {
        for (int i = countDownTime; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}