using System;
namespace assignment_about_overriding
{
    internal class parent
    {
        public virtual void display()
        {
            Console.WriteLine("This is parent class");
        }
        public virtual int add(int a, int b)
        {
            Console.Write("This is parent class add method: ");
            return a + b;
        }
        public virtual long power(int a,int b)
        {
            int result = 1;
            for(int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.Write($"In the parent class: {a}^{b} = ");
            return result;
        }
        public virtual string concatenation(string a,string b)
        {
            Console.Write("In the parent class: ");
            return a + b;
        }
        public virtual double roundoff(double a)
        {
            Console.WriteLine("In the parent class:");
            Console.WriteLine($"the floor of {a} is = " + Math.Floor(a));
            Console.Write($"{a} is Ceiling to = ");
            return Math.Ceiling(a);
        }
    }

    internal class child : parent
    {
        public override void display()
        {
            Console.WriteLine("This is child class");
        }
        public override int add(int a, int b)
        {
            Console.Write("This is child class add method: ");
            return a + b ;
        }
        public override long power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.Write($"In the child class: {a}^{b} = ");
            return result;
        }
        public override string concatenation(string a, string b)
        {
            Console.Write("In the child class: ");
            return a + b;
        }
        public override double roundoff(double a)
        {
            Console.WriteLine("\nIn the child class:");
            Console.WriteLine($"the floor of {a} is = " + Math.Floor(a));
            Console.Write($"{a} is Ceiling to = ");
            return Math.Ceiling(a);
        }
    }

    internal class sub_child : child
    {
        public override void display()
        {
            Console.WriteLine("This is sub child class");
        }
        public override int add(int a, int b)
        {
            Console.Write("This is sub child class add method: ");
            return a + b ;
        }
        public override long power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.Write($"In the sub child class: {a}^{b} = ");
            return result;
        }
        public override string concatenation(string a, string b)
        {
            Console.Write("In the sub child class: ");
            return a + b;
        }
        public override double roundoff(double a)
        {
            Console.WriteLine("\nIn the sub child class:");
            Console.WriteLine($"the floor of {a} is = " + Math.Floor(a));
            Console.Write($"{a} is Ceiling to = ");
            return Math.Ceiling(a);
        }
    }

    internal class sub_sub_child : sub_child
    {
        public override void display()
        {
            Console.WriteLine("This is sub sub child class");
        }
        public override int add(int a, int b)
        {
            Console.Write("This is sub sub child class add method: ");
            return a + b ;
        }
        public override long power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.Write($"In the  sub sub child class: {a}^{b} = ");
            return result;
        }
        public override string concatenation(string a, string b)
        {
            Console.Write("In the sub sub child class: ");
            return a + b;
        }
        public override double roundoff(double a)
        {
            Console.WriteLine("\nIn the sub sub child class:");
            Console.WriteLine($"the floor of {a} is = " + Math.Floor(a));
            Console.Write($"{a} is ceiling to = ");
            return Math.Ceiling(a);
        }
    }
}