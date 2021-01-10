using System;

namespace Ex_11._3b
{
    class Program
    {
        static void Main()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 != 0 && i % 4 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
