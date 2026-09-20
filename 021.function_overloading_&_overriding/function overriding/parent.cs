using System;
namespace function_overriding
{
    internal class parent
    {
        public virtual void show()
        {
            Console.WriteLine(" Method of Parent Class");
        }
    }
    class child : parent
    {
        public override void show()
        {
            Console.WriteLine(" Method of Child Class");
        }
    }

}
