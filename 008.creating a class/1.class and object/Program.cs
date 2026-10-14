using System;
namespace _1.class_and_object
{
    class student//creating a class using class keyword
    {
        public string name;//creating a variable in the class which is called as data member
        public int age;
        public void display()//creating a method in the class which is called as member function
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    internal class Program//creating a class using class keyword
    {
        static void Main(string[] args)//excution starts from here
        {
            student s1 = new student();//creating an object of the class student
            s1.name = "Ali";//assigning value to the data member of the class
            s1.age = 20;
            s1.display();//calling the member function of the class
            Console.ReadKey();
        }
    }
}
