using System;
namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // initialize counter variable

            // loop continues as long as i is less than or equal to 5
            while (i <= 5)
            {
                Console.WriteLine(i); // print the current value of i
                i++; // increment i by 1 to move towards the loop's end condition
            }

            Console.ReadKey(); // wait for a key press before closing the console window
        }
    }
}