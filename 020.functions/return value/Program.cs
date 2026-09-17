using System;
namespace return_value
{
    internal class Program
    {
        // Function that returns the sum of two integers
        static int Add(int a, int b)
        {
            return a + b; // Send the result back to the caller
        }

        static void Main(string[] args)
        {
            int result;
            result = Add(10, 20); // Store the returned value in 'result'
            Console.WriteLine($"Sum = {result}");
            Console.ReadKey();
        }
    }
}