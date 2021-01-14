using System;

namespace Ex_12._4
{
    class Program
    {
        static void Main()
        {
            int[] table = new int[100];
            for (int i = 0; i < 100; i++)
            {
                table[i] = i % 10;
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Table value [{0}] = {1}", i, table[i]);
            }
        }
    }
}
