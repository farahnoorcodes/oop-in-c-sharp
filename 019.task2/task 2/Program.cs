using System;
namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write a c# program that takes marks from the user and display the grade based on the marks entered by the user
            // 80-100 A
            // 70-79 B
            // 60-69 C
            // 50-59 D
            // Below 50 F

            int marks;
            bool isValidInput = true;
            do {
                Console.Write("Enter your marks: ");
                marks = Convert.ToInt32(Console.ReadLine());

                if (marks >= 80 && marks <= 100)
                {
                    Console.Write("Your grade is A");
                    break; // added to break the loop if valid marks are entered
                }
                else if (marks >= 70 && marks < 80)
                {
                    Console.Write("Your grade is B");
                    break; // added to break the loop if valid marks are entered
                }
                else if (marks >= 60 && marks < 70)
                {
                    Console.Write("Your grade is C");
                    break; // added to break the loop if valid marks are entered
                }
                else if (marks >= 50 && marks < 60)
                {
                    Console.Write("Your grade is D");
                    break; // added to break the loop if valid marks are entered
                }
                else if (marks >= 0 && marks < 50) // fixed: only counts as F if marks is 0 or above
                {
                    Console.Write("Your grade is F");
                    break; // added to break the loop if valid marks are entered
                }
                else
                {
                    Console.WriteLine("Invalid marks entered");
                    isValidInput = false; // added to break the loop if invalid marks are entered
                }
            }while(isValidInput==false); // added a loop to keep asking for input until valid marks are entered)

            Console.WriteLine("\n"); // added to add a new line after the grade is displayed
            Console.ReadKey(); // added back so the console stays open to show the result
        }
    }
}