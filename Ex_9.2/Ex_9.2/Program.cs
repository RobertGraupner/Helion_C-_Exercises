using System;

namespace Ex_9._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int value2 = int.Parse(Console.ReadLine());
            bool score;

            score = value1 % value2 == 0 ? true : false;

            Console.WriteLine("The modulo division result is 0: It's " + score);
        }
    }
}
