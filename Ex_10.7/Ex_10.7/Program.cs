using System;

namespace Ex_10._7
{
    class Program
    {
        static void Main()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
           

            int j = 100;

            while (j > 0)
            {
                if (j % 3 == 0 && j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j--;
            }

            int k = 100;

            do
            {
                if (k % 3 == 0 && k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
            }
            while (k > 0);
        }
    }
    
}
