using System;
namespace boolean_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {//boolean operations are used to perform logical operations on boolean values (true or false). The most common boolean operations are AND, OR, and NOT.

            //AND operation: returns true if both operands are true, otherwise returns false. represented by the symbol "&&".
            //or operation: returns true if at least one of the operands is true, otherwise returns false. represented by the symbol "||".
            //NOT operation: returns the opposite value of the operand. represented by the symbol "!".
            //equality operation: returns true if both operands are equal, otherwise returns false. represented by the symbol "==".
            //not equal operation: returns true if both operands are not equal, otherwise returns false. represented by the symbol "!=".
            //greater than operation: returns true if the left operand is greater than the right operand, otherwise returns false. represented by the symbol ">".
            //less than operation: returns true if the left operand is less than the right operand, otherwise returns false. represented by the symbol "<".
            //greater than or equal to operation: returns true if the left operand is greater than or equal to the right operand, otherwise returns false. represented by the symbol ">=".
            //less than or equal to operation: returns true if the left operand is less than or equal to the right operand, otherwise returns false. represented by the symbol "<=".
            int age;
            bool hasCard;
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            hasCard = true;
            if(age>= 18 && hasCard==true)
            {
                Console.WriteLine("Allowed");
            }
            else
            {
                Console.WriteLine("Not allowed");
            }
            Console.ReadKey();
        }
    }
}
