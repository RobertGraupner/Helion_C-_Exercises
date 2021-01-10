using System;

namespace Ex_11._4
{
    class Program
    {
        static void Main()
        {
            for (int i = -100; i <= 100; i++)
            {
                if ((i % 4 != 0) || (i % 8 == 0) || (i % 10 == 0))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
