using System;

namespace Ex_10._4
{
    class Program
    {
        static void Main()
        {
            int i = 0;

            do
            {
                Console.WriteLine("[i = {0}] Loops in C#", i);
            }
            while (i++ <= 8);
        }
    }
}
