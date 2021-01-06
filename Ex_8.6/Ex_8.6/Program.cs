using System;

namespace Ex_8._6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of square side:");
            int dl = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the circle:");
            int r = int.Parse(Console.ReadLine());

            if (dl * Math.Sqrt(2) < 2 * r)
            {
                Console.WriteLine("A square  with a side of " + dl + " will fit in a circle with a radius of " + r);
            }
            else
            {
                Console.WriteLine("A square  with a side of " + dl + " will not fit in a circle with a radius of " + r);
            }

        }
    }
}
