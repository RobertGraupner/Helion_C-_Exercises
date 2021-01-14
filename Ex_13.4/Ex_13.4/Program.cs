using System;

namespace Ex_13._4
{
    class Program
    {
        static void Main()
        {
            bool[,] tab = new bool[5, 8];

            bool value = true;
         

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        tab[i, j] = value;
                     }
                    else
                    {
                        tab[i, j] = !value;
                    }
                    j++;
                }
                i++;
            }

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 8; j++)
                {

                    if (tab[i, j])
                    {
                        Console.WriteLine("tab[{0},{1}] = 1", i, j);
                    }
                    else
                    {
                        Console.WriteLine("tab[{0},{1}] = 0", i, j);
                    }
                }
            }
        }
    }
}
