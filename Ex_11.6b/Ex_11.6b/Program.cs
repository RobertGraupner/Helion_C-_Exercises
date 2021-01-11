using System;

namespace Ex_11._6b
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 20)
            {
              int j = 20 - i;
                while (j > 0)
                {
                    Console.Write(j + " ");
                    j--;
                }
                Console.WriteLine("");
                i++;
            }
        }
    }
}
