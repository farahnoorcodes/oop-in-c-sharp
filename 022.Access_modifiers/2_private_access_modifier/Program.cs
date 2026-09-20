using System;
namespace _2_private_access_modifier
{
   class Program
    {
        static void Main(string[] args)
        {
            private_student s1 = new private_student();
            s1.SetMarks(85); // Set marks using the public method
            Console.WriteLine("Student Marks with valid input: " + s1.GetMarks()); // Get marks using the public method
            
            s1.SetMarks(150); // Attempt to set marks with an invalid value
            Console.WriteLine("Student Marks with invalid input: " + s1.GetMarks()); // Get marks using the public method
        }
    }
}
