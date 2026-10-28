using System;
namespace task_5
{
    internal class person
    {
        public string name;
        public int age;
        public void displayPerson()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
