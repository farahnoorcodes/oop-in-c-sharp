using System;
namespace _1.try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try catch is used to handle exceptions in C# programming. It allows you to catch and handle errors that may occur during the execution of your code, preventing the program from crashing.
            try
            {
                int num;
                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());// user can enter alphabetic characters or special characters  instead of numbers which will throw an exception
                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format. Please enter a valid number." + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The number you entered is too large or too small." + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);// this will catch any other exceptions that are not specifically handled above such as if the user enters a null value or any other unexpected error occurs.
            }
        }
    }
}
