using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop: starts at i = 1, runs while i <= 5, increments i by 1 each time
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i); // print the current value of i
            }
            Console.ReadKey(); // wait for a key press before closing the console window
        }
    }
}