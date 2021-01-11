using System;

namespace Ex_11._6a
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 20 - i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
