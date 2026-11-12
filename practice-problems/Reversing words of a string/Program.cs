using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_words_of_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user_input = " ";
            start:
            try
            {
                Console.WriteLine("Enter a string: ");
                user_input = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred, please enter a valid string! " );
                goto start;
            }
            string[] words = user_input.Split(' ');
            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                Console.Write(new string(charArray) + " ");
            }
            
        }
    }
}
