namespace _CharsStringsTexts
{
    class CharStringTexts
    {
        public string firstLine = "Similar to C++ that you currently know, Char variables need to use single quotation marks. E.G:\nchar gender = 'm';";
        public string secondLine = "In addition, chars can be represented by an integer number.";



        public void viewCharFromInt()
        {
            int endPoint = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());
            

            if (endPoint < startPoint)
            {
                Console.WriteLine("You have entered a shorter end point than the start point.\nThe values will be exchanged with each other.");
                int aux = endPoint;
                endPoint = startPoint;
                startPoint = aux;
                for (int i = 97; i <= 122; i++)
                {
                    Console.WriteLine("Char number (" + (int)i + ") is equal to: " + (char)(i));
                }
            }
        }

        // // Continue
        // Console.WriteLine("Press a key to continue...");
        // Console.ReadLine();
        // Console.Clear();
        // // Console cleaned

        // Console.WriteLine("Now we can show some ways to use chars and strings in CSHARP");

        // string text1 = "Kelvin Coelho Loiola" + "Has born in December 1987";
        // Console.WriteLine(text1);

        // string text2 = @"Last year he wanted to travel around the world!
        //                 For Example:
        //                 - Toronto, in Canada;
        //                 - Camberra, in Australia;
        //                 - Los Angeles, in United States;
        // ";
        // Console.WriteLine(text2);
        
    }   //  End of class
}   // End of namespace