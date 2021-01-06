using System;

namespace Ex_8._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("The absolute value is: " + -number);
            }
            else
            {
                Console.WriteLine("The absolute value is: " + number);
            }
        }
    }
}
