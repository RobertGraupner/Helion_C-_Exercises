using System;

namespace Ex_14._3
{
    class Rectangle
    {

        int leftTopX;
        int leftTopY;

        int rightTopX;
        int rightTopY;

        int leftBottomX;
        int leftBottomY;

        int rightBottomX;
        int rightBottomY;

        int TakeLeftTopX()
        {
            return leftTopX;
        }
        int TakeLeftTopY()
        {
            return leftTopY;
        }
        int TakeRightTopX()
        {
            return  rightTopX;
        }
        int TakeRightTopY()
        {
            return rightTopY;
        }
        int TakeLeftBottomX()
        {
            return leftBottomX;
        }
        int TakeLeftBottomY()
        {
            return leftBottomY;
        }
        int TakeRightBottomX()
        {
            return rightBottomX;
        }
        int TakeRightBottomY()
        {
            return rightBottomY;
        }


        void DisplayCoordinates()
        {
            Console.WriteLine("Left top x: " + TakeLeftTopX());
            Console.WriteLine("Left top y: " + TakeLeftTopY());

            Console.WriteLine("Right top x: " + TakeRightTopX());
            Console.WriteLine("Right top y: " + TakeRightTopY());

            Console.WriteLine("Left bottom x: " + TakeLeftBottomX());
            Console.WriteLine("Left bottom y: " + TakeLeftBottomY());

            Console.WriteLine("Right bottom x: " + TakeRightBottomX());
            Console.WriteLine("Right bottom y: " + TakeRightBottomY());
        }

        public static void Main()
        {
            Rectangle rectangle1 = new Rectangle();

            rectangle1.leftTopX = 100;
            rectangle1.leftTopY = 100;

            rectangle1.rightTopX = 200;
            rectangle1.rightTopY = 100;

            rectangle1.leftBottomX = 100;
            rectangle1.leftBottomY = 150;

            rectangle1.rightBottomX = 200;
            rectangle1.rightBottomY = 150;

            rectangle1.DisplayCoordinates();
            rectangle1.check();

        }

        void check()
        {
            if ((TakeLeftTopX() != TakeLeftBottomX()) ||
                (TakeRightTopX() != TakeRightBottomX()) ||
                (TakeLeftTopY() != TakeRightTopY()) ||
                (TakeLeftBottomY() != TakeRightBottomY()))
            {

                Console.WriteLine("false");
                    
            }
            else
            {
                Console.WriteLine("true");
            }
        }

    }
}
