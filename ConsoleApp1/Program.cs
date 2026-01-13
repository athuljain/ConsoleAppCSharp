using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("you are not eligible to vote");
            }
        }
    }
}