using System;
namespace function_overriding
{
    internal class parent
    {
        public virtual void show()// "virtual" allows this method to be overridden by derived classes.
                                  // Without "virtual", the child class could only hide it (using "new"),
                                  // not truly override it.
        {
            Console.WriteLine(" Method of Parent Class");
        }
    }
    class child : parent
    {
        public override void show()// "override" provides a new implementation of the parent's virtual method.
                                   // At runtime, calling show() on a child object will always run THIS version,
                                   // even if it's accessed through a parent-type reference (runtime polymorphism).
        {
            Console.WriteLine(" Method of Child Class");
        }
    }

}
