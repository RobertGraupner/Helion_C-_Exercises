using System;

namespace Ex_11._2
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i++ <  20)
            {
               if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
              
            }
        }
    }
}
