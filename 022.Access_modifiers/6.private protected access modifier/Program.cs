using _6.private_protected_access_modifier;

internal class Program
{
    static void Main(string[] args)
    {
        private_protected_class person1 = new private_protected_class();
        person1.Display();

        confidential person2 = new confidential();
        person2.Show();

        confidential person3 = new confidential("manahil", 19, "987654321234");
        person3.Display();

        confidential person4 = new confidential("emaan", 20, "12345678987654321");
        person4.Display();
    }
}