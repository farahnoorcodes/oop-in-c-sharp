using System;
namespace _2.try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isPrime = true;
            bool isValid = false;

        start://program will jump to this point if the user enters an invalid input
            Console.Write("Enter a number to check if it is prime or composite: ");

            try
            {
                number = Convert.ToInt32(Console.ReadLine());//this line may throw an exception if the input is not a valid integer
                isValid = true;   // reached only if the conversion succeeded

                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            catch (Exception)//catch block will handle the exception thrown by the try block
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                goto start;//program will jump to the start label to prompt the user for input again
            }
            finally//finally block will always execute regardless of whether an exception was thrown or not
            {
                if (isValid)
                {
                    if (number<=1)
                    {
                        Console.WriteLine($"{number} is neither prime nor composite.");
                    }
                    else if (isPrime)
                    {
                        Console.WriteLine($"{number} is a prime number.");

                    }
                    else
                    {
                        Console.WriteLine($"{number} is a composite number.");
                    }
                }
            }
        }
    }
}
