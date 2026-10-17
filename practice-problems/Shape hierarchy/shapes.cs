using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shape_hierarchy
{
    abstract class shapes//class is abstract because it is not possible to create an object of this class
    {
         protected string name;
        public shapes(string name)//constructor of the class shapes
        {
            this.name = name;
        }
        abstract public double area();//abstract method because it is not possible to define the area of a shape without knowing the shape
        abstract public string show();//abstract method because it is not possible to define the show of a shape without knowing the shape
    }
     abstract class twoDshapes : shapes//class is derived from the abstract class shapes
    {
        public twoDshapes(string name) : base(name) { }
        public abstract double perimeter();//abstract method because it is not possible to define the perimeter of a shape without knowing the shape
        public override string show()//overriding the abstract method show
        {
            Console.WriteLine("This is a two dimensional shape");
            Console.WriteLine(" shape: " + name);
            Console.WriteLine(" area: " + area().ToString("F2"));
            Console.WriteLine(" perimeter: " + perimeter().ToString("F2"));
            return "";
        }
    }
    abstract class threeDshapes : shapes//class is derived from the abstract class shapes
    {
        public threeDshapes(string name) : base(name) { }
        public abstract double volume();//abstract method because it is not possible to define the volume of a shape without knowing the shape
        public override string show()//overriding the abstract method show
        {
            Console.WriteLine("This is a three dimensional shape");
            Console.WriteLine(" shape: " + name);
            Console.WriteLine(" area: " + area().ToString("F2"));
            Console.WriteLine(" volume: " + volume().ToString("F2"));
            return "";
        }
    }
    class Circle : twoDshapes//class is derived from the abstract class twoDshapes
    {
        private double radius;
        public Circle(string name, double radius) : base(name)//constructor of the class Circle
        {
            this.radius = radius;
        }
        public override double area()//overriding the abstract method area
        {
            return Math.PI * radius * radius;
        }
        public override double perimeter()//overriding the abstract method perimeter
        {
            return 2 * Math.PI * radius;
        }
        
    }
    class rectangle : twoDshapes//class is derived from the abstract class twoDshapes
    {
        private double length;
        private double width;
        public rectangle(string name, double length, double width) : base(name)//constructor of the class rectangle
        {
            this.length = length;
            this.width = width;
        }
        public override double area()//overriding the abstract method area
        {
            return length * width;
        }
        public override double perimeter()//overriding the abstract method perimeter
        {
            return 2 * (length + width);
        }
    }
    class triangle : twoDshapes//class is derived from the abstract class twoDshapes
    {
        private double a;
        private double b;
        private double c;
        public triangle(string name, double a, double b, double c) : base(name)//constructor of the class triangle
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double area()//overriding the abstract method area
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public override double perimeter()//overriding the abstract method perimeter
        {
            return a + b + c;
        }
    }
    class cube : threeDshapes//class is derived from the abstract class threeDshapes
    {
        private double side;
        public cube(string name, double side) : base(name)//constructor of the class cube
        {
            this.side = side;
        }
        public override double area()//overriding the abstract method area
        {
            return 6 * side * side;
        }
        public override double volume()//overriding the abstract method volume
        {
            return side * side * side;
        }
    }
    class sphere : threeDshapes//class is derived from the abstract class threeDshapes
    {
        private double radius;
        public sphere(string name, double radius) : base(name)//constructor of the class sphere
        {
            this.radius = radius;
        }
        public override double area()//overriding the abstract method area
        {
            return 4 * Math.PI * radius * radius;
        }
        public override double volume()//overriding the abstract method volume
        {
            return (4 / 3) * Math.PI * radius * radius * radius;
        }
    }
    class cylinder : threeDshapes//class is derived from the abstract class threeDshapes
    {
        private double radius;
        private double height;
        public cylinder(string name, double radius, double height) : base(name)//constructor of the class cylinder
        {
            this.radius = radius;
            this.height = height;
        }
        public override double area()//overriding the abstract method area
        {
            return 2 * Math.PI * radius * (radius + height);
        }
        public override double volume()//overriding the abstract method volume
        {
            return Math.PI * radius * radius * height;
        }
    }
}
