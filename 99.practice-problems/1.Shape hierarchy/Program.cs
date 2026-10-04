using System;
namespace _1.Shape_hierarchy
{//1.show hierarchy of shape into 2d and 3d and the their sub shapes using inheritance of classes, what is base and derived class.(shape will be given).
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle("Circle", 5);
            Console.WriteLine(c.show());
            rectangle r = new rectangle("Rectangle", 4, 6);
            Console.WriteLine(r.show());
            triangle t = new triangle("Triangle", 3, 4, 5);
            Console.WriteLine(t.show());
            cube cb = new cube("Cube", 3);
            Console.WriteLine(cb.show());
            sphere s = new sphere("Sphere", 2);
            Console.WriteLine(s.show());
            cylinder cy = new cylinder("Cylinder", 2, 4);
            Console.WriteLine(cy.show());
        }
    }
}
