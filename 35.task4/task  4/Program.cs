using System;
namespace task__4
{//write a program to create a class student with private data members name, roll no and marks. Write getter and setter methods for each data member. Create a method to display the details of the student. Create an object of the class and call the display method.
    class Program
        {
            static void Main()
            {
                Student s1 = new Student("Ali", 1, 85.5);
                s1.Display();

                s1.Marks = 90;           // using setter
                Console.WriteLine("Updated Marks: " + s1.Marks);  // using getter

                Console.ReadKey();
            }
        }
    }

