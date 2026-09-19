using System;
namespace _1_public_access_modifier
{
    
        public class student
        {
            public string name;
            public int age;
            public void display()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            }
        }
    
}
