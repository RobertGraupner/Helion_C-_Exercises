﻿using System;

namespace Ex_11._1
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i<=20; i++)
            {
                if (i % 2 == 0) continue;
                Console.Write(i + " ");
            }
        }
    }
}
