using System;
namespace if_else_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.Write("Enter marks: ");
            marks = Convert.ToInt32(Console.ReadLine());
            if(marks>=50) {
                Console.WriteLine("Pass");
            }
            else {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}
