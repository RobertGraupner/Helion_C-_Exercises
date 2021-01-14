using System;

namespace Ex_13._5
{
    class Program
    {
        static void Main()
        {
            int[,,] tab = new int[2, 2, 2];

            int counter = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        tab[i, j, k] = counter++;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine("tab[{0}, {1}, {2}] = {3}", i, j, k, tab[i, j, k]);
                    }
                }
            }
        }
    }
}
