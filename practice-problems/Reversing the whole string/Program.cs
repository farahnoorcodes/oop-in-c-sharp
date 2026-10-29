using System;
namespace Reversing_the_whole_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput="";
            try
            {
                Console.Write("Enter a string : ");
                userInput = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(userInput))//if there is no input entered.
                {
                    Console.WriteLine("please enter a valid input");
                }
            }
            catch (Exception)//this will almost never run..........
            {

                Console.WriteLine("please enter a valid input");
            }
            string[] output=new string[userInput.Length];//this array will store the output , and its length will be equal to the length of thr input string
            for(int i = 0; i < userInput.Length; i++)
            {
                output[i] = userInput[userInput.Length - 1 - i].ToString();//store the output arrray charaters from the end of the input string.
            }
            for(int i = 0; i < userInput.Length; i++)
            {
                Console.Write(output[i]);
            }
            
        }
    }
}
