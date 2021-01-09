using System;

namespace Ex_10._5
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                    {
                    Console.WriteLine("[i = {0}]  is even number", i);
                    }
                else
                {
                    Console.WriteLine("[i = {0}]  is odd number", i);
                }
            }


            int j = 1;
            while(j < 21)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("[j = {0}]  is even number", j);
                }
                else
                {
                    Console.WriteLine("[j = {0}]  is odd number", j);
                }
                j++;
            }


            int k = 1;
            do
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine("[k = {0}]  is even number", k);
                }
                else
                {
                    Console.WriteLine("[k = {0}]  is odd number", k);
                }
                k++;
            }
            while (k < 21);
        }
    }
}
