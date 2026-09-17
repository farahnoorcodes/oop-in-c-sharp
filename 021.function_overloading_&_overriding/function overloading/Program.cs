using System;
namespace function_overloading
{// function overloading means creating multiple functions with the same name but different parameters (different type or number of parameters) within a same class. The compiler determines which function to call based on the arguments passed to the function.
    // overloading conditions:
    //same name
    //within same class
    //different parameters (type or number)
    //order of parameters can be different
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b,int c)
        {
            return (int)(a + b + c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two numbers = " + Add(10, 20));
            Console.WriteLine("Sum of three numbers = " + Add(10, 20, 30));
            Console.ReadKey();
        }
    }
}
