using System;

namespace Ex_8._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter parameters A, B and C of the quadratic equation:");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine("\nParameters of quadratic equation:");
            Console.WriteLine("A: " + a + " B: " + b + " C: " + c + "\n");

            if (a == 0)
            {
                Console.WriteLine("It's not a quadratic equation.");
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("This equation has no solution in the set of real numbers.");
                }
                else
                {
                    Console.WriteLine("This equation has a solution in  the set of  real numbers.");
                }
            }
        }
    }
}
