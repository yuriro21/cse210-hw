using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    protected int timeActivity1 = -1; 
    public BreathingActivity() : base()
    {
        setActivityName("BreathingActivity");
        setDescription("This activity will help you relax by walking your through breathing in and" +
         "out slowly. Clear your mind and focus on your breathing.");
    }

    public void runActivity()
    {
        runActivityParentSatart();
        Breathing();
        runActivityParentEnd();
    }

    public void Breathing()
    {   
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        timeActivity1 = getTimeActivity();

        while (stopwatch.ElapsedMilliseconds / 1000 < timeActivity1)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in... ");
            CountDown(4);
            Console.WriteLine("Breathe out... ");
            CountDown(6);
            Console.WriteLine();
        }
    }
}