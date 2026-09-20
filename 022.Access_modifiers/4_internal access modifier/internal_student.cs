using System;
namespace _4_internal_access_modifier
{
    internal class internal_student//An internal member is accessible from any code in the same assembly and is hidden from other assemblies. It is the default accessibility for top-level types (classes, structs, interfaces, enums) that have no modifier.
    {
        internal void Write(string message)//Both the class and its method are internal, so any code in the same project (assembly) can use them, and code in other projects cannot.
        {
            Console.WriteLine("Login " + message);
        }
    }
    internal class logger_details : internal_student//The logger_details class inherits from the internal_student class, so it can access the internal Write method of the base class. This is allowed because both classes are in the same assembly.
    {
        internal void details(string name,string password,int age,string gender)
        {   Console.WriteLine("Details of the user:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Password: " + password);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
        }
    }
}
