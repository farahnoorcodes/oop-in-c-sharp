using System;
namespace _3.throw_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {// throw is a keyword in C# that is used to signal the occurrence of an exception during the execution of a program. It allows you to create and throw exceptions, which can be caught and handled by the calling code. When an exception is thrown, the normal flow of the program is interrupted, and control is transferred to the nearest catch block that can handle the exception.

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                throw new Exception("Age cannot be negative.");// exception is thrown when the age is negative, and the program will terminate unless the exception is caught and handled by a try-catch block

            }

            Console.WriteLine("Your age is " + age);// The program will continue executing if the age is valid (non-negative).
            //with try-catch block and goto statement:
            long number;
        Retry:
            try
            {
                Console.WriteLine("Enter a number:");
                number = Convert.ToInt64(Console.ReadLine());
                if(number>123456789)
                {
                    throw new Exception("Number is too large.");// exception is thrown when the number is too large, and the program will terminate unless the exception is caught and handled by a try-catch block
                }

            }
            catch (FormatException)// FormatException is thrown when the input is not in a valid format for conversion to a long integer.
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto Retry;
            }
            
        }
    }
}
