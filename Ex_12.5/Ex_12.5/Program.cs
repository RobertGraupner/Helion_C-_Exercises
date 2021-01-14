using System;

namespace Ex_12._5
{
    class Program
    {
        static void Main()
        {
           

            char[] table = new char[26];

            for (int i = 0; i < 26; i++)
            {
                table[i] = (char)('a' + i);
            }
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("Table value[{0}] = {1}", i, table[i]);
            }
        }
    }
}
