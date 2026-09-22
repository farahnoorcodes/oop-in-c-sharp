using System;
namespace _6.private_protected_access_modifier
{
    internal class private_protected_class
    {
        private protected string name = "farah";
        private protected int age = 18;
        public void Display()
        {
            Console.WriteLine($"Name: {name}\n Age: {age}\n cnic: {cnic}");
        }


        private protected string cnic;
    }

    internal class confidential : private_protected_class
    {
        // Parameterless constructor (needed if you still want `new confidential()`)
        public confidential() { }

        // Parameterized constructor
        public confidential(string a, int b, string c)
        {
            name = a;   // fixed: assign parameter INTO field
            age = b; 
            cnic = c;
        }

        public void Show()
        {
            name = "ehsan";
            age = 20;
            cnic = "1234565789";
            Display();
        }
        
    }

    
}
