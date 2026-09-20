using System;
namespace task_3
{
    internal class class_for_task_3
    {
        public string CheckNumber(int number)
        {
            if (number > 0)
            {
                return number+":  The number is positive.";
            }
            else if (number < 0)
            {
                return number+":  The number is negative.";
            }
            else
            {
                return number+":  The number is zero.";
            }
            
        }
    }
}
