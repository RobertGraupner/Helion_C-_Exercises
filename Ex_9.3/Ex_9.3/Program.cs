using System;

namespace Ex_9._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int abs = number < 0 ? -number : number;
            Console.WriteLine("The absolute value is: " + abs);
        }
    }
}
