using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("February 20, 2023 Runing", 30, 3);
        Bicycles bicycles = new Bicycles(40, "February 21, 2023 Bicycles", 20);
        Swimming swimming = new Swimming("February 22, 2023 Swimming", 15, 30);

        activities.Add(running);
        activities.Add(bicycles);
        activities.Add(swimming);

        foreach(Activity item in activities)
        {
            Console.WriteLine(item.GetSumary());
        }
    }
}