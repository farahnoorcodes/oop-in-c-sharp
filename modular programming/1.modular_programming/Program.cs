using System;
namespace _1.modular_programming
{
    //modular programming is a software design technique that emphasizes separating the functionality of a program into independent, interchangeable modules, such that each contains everything necessary to execute only one aspect of the desired functionality.
    //in simple words, modular programming is a way of breaking down a program into smaller, manageable, and reusable pieces called modules. Each module is designed to perform a specific task or function, and can be developed, tested, and maintained independently of the other modules.
    //modules refers to functions or methods in programming. These functions can be called multiple times from different parts of the program, making the code more organized and easier to read.
    internal class Program
    {
        static string name;
        static int marks1, marks2, marks3;
        static void inputdata()
        {
            Console.Write("Enter student name: ");
            name= Console.ReadLine();
            Console.Write("Enter marks of subject 1: ");
            marks1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of subject 2: ");
            marks2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of subject 3: ");
            marks3= Convert.ToInt32(Console.ReadLine());
        }
        static int calculateTotal()
        {
            int total = marks1 + marks2 + marks3;
            return total;
        }
        static double calculateAverage()
        {
            
            return calculateTotal() / 3.0;
        }
        static string FindGrade(double average)
        {
            if (average >= 80)
                return "A";
            else if (average >= 70)
                return "B";
            else if (average >= 60)
                return "C";
            else if (average >= 50)
                return "D";
            else
                return "F";
        }
        static void displayResult()
        {
           int total = calculateTotal();
            double average = calculateAverage();
            string grade = FindGrade(average);
            Console.WriteLine("\n----------Student Result----------");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Grade: {grade}");
        }

        static void Main(string[] args)
        {
            inputdata();
            displayResult();
            Console.ReadKey();
        }
    }
}
