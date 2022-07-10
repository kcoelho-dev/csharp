

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Similar to C++ that you currently know, Char variables need to use single quotation marks. E.G:\nchar gender = 'm';");
        Console.WriteLine("In addition, chars can be represented by an integer number.");

        for (int i = 97; i <= 122; i++)
        {
            Console.WriteLine("Char number (" + (int)i + ") is equal to: " + (char)(i));
        }

        // Continue
        Console.WriteLine("Press a key to continue...");
        Console.ReadLine();
        Console.Clear();
        // Console cleaned

        Console.WriteLine("Now we can show some ways to use strings in CSHARP");

        string text1 = "Kelvin Coelho Loiola" + "Has born in December 1987";
        Console.WriteLine(text1);

        string text2 = @"Last year he wanted to travel around the world!
                         For Example:
                         - Toronto, in Canada;
                         - Camberra, in Australia;
                         - Los Angeles, in United States;
        ";
        Console.WriteLine(text2);
    }
}