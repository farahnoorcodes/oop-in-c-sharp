using System;
namespace switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice; // Stores the user's menu selection

            // Display menu options
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.Write("Enter choice: ");

            // Read user input and convert it from string to int
            choice = Convert.ToInt32(Console.ReadLine());

            // Evaluate the choice and execute the matching case
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition selected");
                    break; // Exit switch after handling case 1

                case 2:
                    Console.WriteLine("Subtraction selected");
                    break; // Exit switch after handling case 2

                default:
                    // Runs if choice doesn't match any case above
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadKey(); // Keep console window open until a key is pressed
        }
    }
}