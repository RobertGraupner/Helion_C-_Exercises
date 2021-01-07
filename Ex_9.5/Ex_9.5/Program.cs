using System;

namespace Ex_9._5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    goto case 8;
                case 4:
                    goto case 8;
                case 8:
                    Console.WriteLine("You entered 1, 4 or 8");
                    break;
                case 2:
                    goto case 7;
                case 3:
                    goto case 7;
                case 7:
                    Console.WriteLine("You entered 2, 3 lub 7");
                    break;
                default:
                    Console.WriteLine("You didn't enter a number 1, 2, 3, 4, 7 or 8");
                    break;
            }
        }
    }
}
