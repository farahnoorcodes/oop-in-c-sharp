using System;
namespace go_to_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; // Will hold the user's input

        Start: // Label marking a point the code can jump back to
            Console.Write("enter a positive number: ");

            number = Convert.ToInt32(Console.ReadLine()); // Read and convert input to an integer

            if (number < 0) // Check if the number is negative
            {
                Console.WriteLine("please enter a positive number");
                goto Start; // Jump back to the 'Start' label and ask again
            }

            Console.WriteLine("Number = " + number); // Print the valid number
            Console.ReadKey(); // Pause the console so the window stays open until a key is pressed
        }
    }
}