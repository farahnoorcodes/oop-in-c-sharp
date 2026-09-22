using System;
namespace task_for__if__else_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a c# program that marks from the user and displays the garde. use the following condtion:
            //80 or above-->A
            //70-79-->B
            //60-69-->C
            //50-59--D
            //below 50-->F
            int marks;
            start:
            Console.Write("Enter your marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 100 || marks < 0)
            {
                Console.WriteLine("Invalid marks entered");
                goto start;
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is F");
            }

        }
    }
}
