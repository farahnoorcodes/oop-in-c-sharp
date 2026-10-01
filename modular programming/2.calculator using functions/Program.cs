using System;
namespace _2.calculator_using_functions
{
    internal class Program
    {
        static int addition(int a, int b)
        { 

            return a + b;
        }
        static int subtraction(int a, int b)
        {
            return a - b;
        }
        static int multiplication(int a, int b)
        {
            return a * b;
        }
        static double division(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which operation do you want to perform? \n1. add\n2. subtract\n3. multiply\n4. divide");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {addition((int)num1, (int)num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {subtraction((int)num1, (int)num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {multiplication((int)num1, (int)num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Result: {division(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
