using System;

namespace Ex_8._5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the x coordinate of the rectangle:");
            int xSquare = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y coordinate of the rectangle:");
            int ySquare = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the rectangle:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the x coordinate of the point:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y coordinate of the point:");
            int y = int.Parse(Console.ReadLine());

            if (x >= xSquare && x <= xSquare + width && y >= ySquare && y <= ySquare + height)
            {
                Console.WriteLine("The point is in the rectangle");
            }
            else
            {
                Console.WriteLine("The point is not in the rectagle");
            }

        }
    }
}
