using System;

class Program
{
    static void Main()
    {
       
        bool? over18 = null;

        if (over18 == true)
        {
            Console.WriteLine("Over 18");
        }
        else if (over18 == false)
        {
            Console.WriteLine("Under 18");
        }
        else
        {
            Console.WriteLine("Did not answer question.");
        }
    }

}

