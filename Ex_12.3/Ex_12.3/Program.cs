using System;

namespace Ex_12._3
{
    class Program
    {
        static void Main()
        {
            bool[] table = new bool[20];

            for(int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    table[i] = true;
                }
                else
                {
                    table[i] = false;
                }
                
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Table value [{0}] = {1}", i, table[i]);
            }
        }
    }
}
