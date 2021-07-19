using System;

namespace Chapter_1_Solution__ELeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age:");
            byte Age = byte.Parse(Console.ReadLine());

            if (Age > 10)
            {
                Console.WriteLine("You are " + Age + " Years Old");
            }
            else 
                Console.WriteLine("Make sure you are atleast 10 years old before trying again");
        }
    }
}
