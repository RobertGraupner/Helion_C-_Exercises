using System;

namespace EX_10._3
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            while(i <= 20)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
