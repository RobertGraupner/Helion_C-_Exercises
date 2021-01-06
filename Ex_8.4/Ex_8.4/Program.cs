using System;

namespace Ex_8._4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter x and y of the first point:");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x and y of the second point:");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            if (x1 == x2)
            {
                Console.WriteLine("The straight line is parallel to y axis.");
            }
            else if (y1 == y2)
            {
                Console.WriteLine("The straight line is parallel to x axis.");
            }
            else
            {
                Console.WriteLine("The straight line is not parallel to any axis.");
            }
        }
    }
}
