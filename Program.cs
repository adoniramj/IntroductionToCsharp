using System;

class Program
{
    static void Main()
    {
        int i = 10;
        bool b = true;

        if(b)
        {
            Console.WriteLine("b is {0}", b);
        }

        if (b && i > 5)
        {
            Console.WriteLine("Both conditions are true");
        }

        bool bigger = i > 10 ? true : false;
        Console.WriteLine(bigger);
    }

}

