using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Enter your last name");
        string LastName = Console.ReadLine();
        Console.WriteLine("Hello " + FirstName); //concatenation syntax
        Console.WriteLine("Hello this is {0} {1}", FirstName, LastName); //placeholder syntax
    }

}

