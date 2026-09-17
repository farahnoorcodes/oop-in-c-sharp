using System;
namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // Initialize counter variable to 1

            do
            {
                Console.WriteLine(i); // Print the current value of i
                i++;                  // Increment i by 1 after each iteration
            } while (i <= 5);         // Condition checked AFTER the loop body runs;
                                      // loop continues as long as i is 5 or less

            Console.ReadKey(); // Pause the console so the window stays open until a key is pressed
        }
    } 
}