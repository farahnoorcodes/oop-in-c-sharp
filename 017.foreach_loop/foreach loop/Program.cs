using System;
namespace foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of names to loop through
            string[] names = { "Afaq", "Ahmad", "hammza" };

            // foreach automatically iterates over each element in the array,
            // assigning it to 'name' one at a time — no manual index needed
            foreach (string name in names)
            {
                Console.WriteLine(name); // Print the current name
            }

            Console.ReadKey(); // Pause the console so the window stays open until a key is pressed
        }
    }
}