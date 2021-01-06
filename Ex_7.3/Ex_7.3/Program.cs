using System;

namespace Ex_7._3
{
    class Program
    {
        static void Main()
        {
            int number1 = 5;
            int number2 = 12;
            int and = number1 & number2;
            Console.WriteLine("5 & 12 = " + and);
            int or = number1 | number2;
            Console.WriteLine("5 | 12 = " + or);
        }
    }
}
