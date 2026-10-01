using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.private_protected
{//private protected access modifier is accessible within the containing class or types derived from the containing class, but only within the same assembly. It is a combination of private and protected access modifiers.
    internal class Program
    {
        static void Main(string[] args)
        {
            derived_class obj = new derived_class();
            obj.display();
            Console.ReadKey();
        }
    }
}
