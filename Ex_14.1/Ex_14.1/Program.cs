using System;

namespace Ex_14._1
{
 
    class Integer
    {
        int number;

        int takeNumber()
        {
            return number;
        }

        void displayNumber()
        {
            Console.WriteLine(number);
        }

        public static void Main()
        {
            Integer number1 = new Integer();
            number1.number = 1;
            Console.WriteLine("number1.number = " + number1.takeNumber());
        }

    }
}
