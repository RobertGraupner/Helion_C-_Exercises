using System;

namespace Ex_13._6
{
    class Program
    {
        static void Main()
        {
            int[][] tab = new int[10][];
            int a = 0;
            int b = 1;

            tab[0] = new int[1] { 1 };

            for(int i = 1; i < 10; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                tab[i] = new int[c];

                for(int j = c; j > 0; j--)
                {
                    tab[i][j - 1] = c - j + 1;
                }
            }

            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write("tab[" + i + "] = ");
                for(int j = 0; j< tab[i].Length; j++)
                {
                    Console.Write(tab[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
