using System;

namespace Ex_13._2
{
    class Program
    {
        static void Main()
        {
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[3];
            tab[2] = new int[2];
            tab[3] = new int[1];

            int counter = 1;

            int i = 0;
            while(i < tab.Length)
            {
                int j = 0;
                while(j < tab[i].Length)
                {
                    tab[i][j] = counter++;
                    j++;
                }
                i++;
            }

            for(int k = 0; k < tab.Length; k++)
            {
                Console.Write("tab[{0}] = ", k);
                for (int l = 0; l < tab[k].Length; l++)
                {
                    Console.Write("{0} ",tab[k][l]);
                }
                Console.WriteLine("");
            }

        }
    }
}
