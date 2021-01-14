using System;

namespace Ex_12._2
{
    class Program
    {
        static void Main()
        {
            int[] table = new int[10];
            int counter = 0;

            for (int i = 10; i <= 100; i+= 10)
            {
                table[counter] = i;
                counter++;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Table value [{0}] = {1}", i, table[i]);
            }
        }
    }
}
