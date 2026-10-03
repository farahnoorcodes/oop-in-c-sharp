using System;
namespace _2.abstract_classes
{//abstract class is a class that is declared with the abstract keyword.
    //it may contain abstract methods: which have no body and must be implemented by every non abstract derived class.
    //it can also contain regular methods: which have full body and are inherited
    //it can contain fields , properties, constructor.
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle(5, 10.78);
            r.display();//calling the regular method display() of the base class shape.
            Console.WriteLine($"Area of {r.name}: {r.area()}");//calling the abstract method area() of the derived class rectangle. and the abstract property name of the derived class rectangle.
            Console.WriteLine($"Color of {r.name}: {r.Color}");
            
        }
    }
}
