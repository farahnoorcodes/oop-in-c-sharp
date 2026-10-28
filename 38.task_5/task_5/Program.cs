using System;
namespace task_5
{//create a base person class containing:  1. age  2. name   3.a method display person.
    //create a derived class named teacher containing  1.subject  2.a method DisplayTeacher
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : Farah Noor\nRoll No : 25-CPE-18");
            Teacher t1 = new Teacher();
            t1.name = "naila";
            t1.age = 32;
            t1.subject = "physics";
            t1.DisplayTeacher();
            Console.ReadKey();

        }
    }
}
