using System;

namespace Ex_7._6
{
    class Program
    {
        static void Main()
        {
            int number1 = 6;
            int number2 = 8;

            Console.WriteLine("Before change:");
            Console.WriteLine("Number 1 = " + number1);
            Console.WriteLine("Number 2 = " + number2);

            number1 ^= number2;
            
            number2 ^= number1;
           
            number1 ^= number2;
            

            Console.WriteLine("After change:");
            Console.WriteLine("Number 1 = " + number1);
            Console.WriteLine("Number 2 = " + number2);

        }
    }
}
