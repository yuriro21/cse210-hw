using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List <int> numbers = new List<int>();

        int number = -1;

        while (number !=0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        float sumNumbers = 0;
        float count = -1;
        int largest = 0;

        foreach (int n in numbers)
        {
            sumNumbers += n;
            count = count + 1;

            if (largest < n)
            {
                largest = n;
            }
        }        

        float average = sumNumbers / count;

        Console.WriteLine("");
        Console.WriteLine($"The list have {numbers.Count} items");
        Console.WriteLine($"The sum is {sumNumbers}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The larguest number is: {largest}"); 
    }
}