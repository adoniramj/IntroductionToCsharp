using System;

class Program
{
    static void Main()
    {
        string str1 = "one\nTwo\nThree";
        string str2 = "C:\\Desktop\\folder1"; //Using escape sequence
        string str3 = @"C:\Desktop\folder1"; //Verbatim literal
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);
    }

}

