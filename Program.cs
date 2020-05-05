using System;

class Program
{
    static void Main()
    {
        int[] EvenNumbers = new int[3];

        EvenNumbers[0] = 2;
        EvenNumbers[1] = 4;
        EvenNumbers[2] = 6;

        Console.WriteLine(EvenNumbers[1]);

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        foreach (string i in cars){
            Console.WriteLine(i);
        }

        cars[4] = "Ferrari";
    }
}

