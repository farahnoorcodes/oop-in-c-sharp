using System;
namespace function_with_parameter
{
    internal class Program
    {
        // Method that takes a parameter and prints the student's name
        static void displayname(string name)
        {
            Console.WriteLine("Student Name: " + name);
        }

        static void Main()
        {
            // Calling the method and passing "Ali" as the argument
            displayname("Ali");

            // Waits for a key press before closing the console window
            Console.ReadKey();
        }
    }
}