using System;
namespace _2.abstract_classes
{
    abstract class shape//abstract class is a class that is declared with the abstract keyword.
    {
        public abstract double area();//abstract method is a method that is declared with the abstract keyword and does not have a body. It must be implemented by every non-abstract derived class.
        public void display()
        {
            Console.WriteLine("this is a shape");
        }
        public abstract string name { get; }//abstract property is a property that is declared with the abstract keyword and does not have a body. It must be implemented by every non-abstract derived class.
        public abstract ConsoleColor Color { get; set; }//abstract property is a property that is declared with the abstract keyword and does not have a body. It must be implemented by every non-abstract derived class.
    }
    class rectangle : shape//rectangle is derived from shape so it must contain the implementation of the abstract method area() otherwise it will give an error.
    {
        private double length;
        private double width;
        private ConsoleColor color;
        public rectangle(double l, double w)
        {
            length = l;
            width = w;
            color = ConsoleColor.Red;
        }
        public override double area() { //override keyword is used to do the implementation of the abstract method.
            return length*width;
        }
        public override string name { get { return "rectangle"; } }//override keyword is used to do the implementation of the abstract property.
        public override ConsoleColor Color
        {
            get { return color; }      // lowercase: the field
            set { color = value; }     // lowercase: the field, and use value
        }//override keyword is used to do the implementation of the abstract property.
    }
}
