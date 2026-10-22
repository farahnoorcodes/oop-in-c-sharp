using System;
namespace teachers_data_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            teacher t1 = new teacher("farah", "programming", 2);
            t1.display();
            teacher t2 = new teacher("yasir", "programming", 12);
            t2.display();
        }
    }
}
