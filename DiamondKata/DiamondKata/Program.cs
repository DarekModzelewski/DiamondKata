using DiamondKata;
using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter a character: ");

            char character = Console.ReadLine().ToUpper()[0];
            var output = Diamond.Create(character);
            Console.WriteLine(output);

            Console.Write("Do you want to enter another character? (y/n): ");

            char response = Console.ReadLine().ToLower()[0];

            if (response != 'y')
            {
                continueProgram = false;
            }
        }


    }

}