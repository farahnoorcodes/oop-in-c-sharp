using System;
namespace _2.parameterized_constructor
{
    class student//creating class student
    {
        public string name;
        public int age;
        public student(string name, int age)//creating parameterized constructor,giving values to the constructor
        {
            this.name = name;//this keyword is used to refer to the current instance of the class
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                student s1 = new student("Ahmad", 21);//creating object of class student and passing values to the constructor,dont need to call the constructor explicitly,dont need to give values to the variables after creating them.
                s1.display();
                Console.ReadKey();
        }
    }
}
