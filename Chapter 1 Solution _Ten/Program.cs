using System;

namespace Chapter_1_Solution__Ten
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                else Console.WriteLine(-i);
            }
        } 
    }
}
