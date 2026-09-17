using System;
namespace function_with_multiple__parameters
{
    internal class Program
    {
        // Function that takes two integer parameters and prints their sum
        static void add(int a, int b)
        {
            int sum = a + b; // Add the two parameters
            Console.WriteLine($"Sum = {sum}"); // Display the result
        }

        static void Main()
        {
            add(10, 20); // Call the function with two arguments
            Console.ReadKey(); // Wait for a key press before closing the console
        }
    }
}