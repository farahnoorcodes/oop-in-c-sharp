using System;
namespace _5.private_protected
{
    public class private_protected_class
    {
        private protected int accountid;

    }
    public class derived_class : private_protected_class
    {
        public void display()
        {
            Console.Write("Enter Account ID: ");
            accountid = int.Parse(Console.ReadLine());
            Console.WriteLine("Account ID: " + accountid);
        }
    }
}
