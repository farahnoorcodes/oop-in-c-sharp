using System;
namespace task_3//create a function named CheckNumber that takes an integer as input and returns a string indicating whether the number is positive, negative, or zero.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class_for_task_3 obj = new class_for_task_3();
            Console.WriteLine(obj.CheckNumber(5));
            Console.WriteLine(obj.CheckNumber(-3));
            Console.WriteLine(obj.CheckNumber(0));
            Console.ReadKey();  
        }
    }
}
