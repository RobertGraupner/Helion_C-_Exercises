using System;

namespace Ex_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 256;
            int resultRight = number >> 2;
            Console.WriteLine("256 << 2 = " + resultRight);
            int resultLeft = number << 2;
            Console.WriteLine("256 >> 2 = " + resultLeft);
        }
    }
}
