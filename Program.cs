using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int useNumber = int.Parse(Console.ReadLine());
        if (useNumber == 1)
        {
            Console.WriteLine("Your number is one");
        }
    }
}

