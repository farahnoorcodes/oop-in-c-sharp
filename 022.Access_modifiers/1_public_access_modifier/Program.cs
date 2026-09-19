using System;
namespace _1_public_access_modifier
{//public access modifier is the most permissive access level. It allows a class, method, or member to be accessed from any other code in the same assembly or another assembly that references it. In other words, public members can be accessed from anywhere in the application.
    //exaple of public access modifier:
    //In this example, we have a class called "student" with two public fields: "name" and "age". We also have a public method called "display" that prints the values of these fields to the console. In the Main method, we create two instances of the student class and set their name and age fields. We then call the display method to print their information to the console.
    //you can add class by right click on the project and select add class and give it a name.
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "farah noor";
            s1.age = 18;
            s1.display();

            student s2 = new student();
            s2.name = "Ehsan";
            s2.age = 20;
            s2.display();

            Console.ReadKey();
        }
    }
}
