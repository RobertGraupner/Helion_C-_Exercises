using System;

namespace Ex_7._5
{
    class Program
    {
        static void Main()
        {
            // Zakres sbyte (-128 do 127) sbyte_min -1 = sbyte_max itd
            sbyte number1 = 1;
            number1 -= 127;
            number1 -= 126;
            Console.WriteLine("Number = " + number1);
            // Przesunięcie bitowe wprawo o 2 miejsca to mnozenie x2
            sbyte number2 = 1;
            number2 <<= 2;
            Console.WriteLine("Number = " + number2);
            /* Suma bitowa zostawia włączone bity w przynajmniej jednym arg
            (1 = 1 8 = 1000), przesunięcię bitowe w lewo o 1 dzieli przez 2 */
            sbyte number3 = 1;
            number3 |= 8;
            number3 >>= 1;
            Console.WriteLine("Number = " + number3);
        }
    }
}
