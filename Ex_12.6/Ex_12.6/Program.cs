using System;

namespace Ex_12._6
{
    class Program
    {
        static void Main()
        {
            int[] table = new int[10];
            int counter = 0;
            while (counter < table.Length)
            {
                table[counter] = counter;
                counter++;
            }

            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine("tablica[{0}] = {1}", i, table[i]);
            }
        }
    }
}
