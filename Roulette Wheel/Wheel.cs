using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette_Wheel
{
  //  enum WheelOrder
  //  {
  //      // The wheel order
  //          G0, R32, B15, R19, B4, R21, B2, R25, B17, R34, B6, R27, B13, 
  //          R36, B11, R30, B8, R23, B10, R5, B24, R16, B33, R1, B20, R14,
  //          B31, R9, B22, R18, B29, R7, B28, R12, B35, R3, B26
  //  };

    public class Wheel
    {
        public static KeyValuePair<int, string> Result { get => spin(); }

        static int[] WheelOrder = new int[]
        {
            0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13,
            36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14,
            31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26
        };

        //      wheel bin
        public static Dictionary<int, string> bins = new Dictionary<int, string>()
        {
            {0,"Green"},
            {1,"Red"},{2,"Black"},{3,"Red"},
            {4,"Red"},{5,"Black"},{6,"Black"},
            {7,"Red"},{8,"Black"},{9,"Black"},
            {10,"Black"},{11,"Red"},{12,"Black"},
            {13,"Black"},{14,"Red"},{15,"Black"},
            {16,"Red"},{17,"Red"},{18,"Red"},
            {19,"Red"},{20,"Red"},{21,"Black"},
            {22,"Black"},{23,"Black"},{24,"Black"},
            {25,"Black"},{26,"Red"},{27,"Red"},
            {28,"Red"},{29,"Red"},{30,"Black"},
            {31,"Black"},{32,"Black"},{33,"Red"},
            {34,"Red"},{35,"Red"},{36,"Black"}
        };
        //    clears single line
        static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        //     Makes the ball spin and land on a random number
        static KeyValuePair<int, string> spin()
        {
            Random rand = new Random();
            bool spinning = true;
            KeyValuePair<int, string> tempResult = bins.ElementAt(0);

            int start = rand.Next(0, 36);

            //The lower the speed, the faster the spin.
            int speed = rand.Next(12, 30);
            Console.WriteLine("\tBall is spinning...");
            while (spinning)
            {
                Console.Write($"\t{WheelOrder[start]}");
                start++;
                Thread.Sleep(speed);
                ClearLine();
                if (speed < 200)
                {
                    speed += 5;
                }
                else if(speed < 300)
                {
                    speed += 8;
                }
                else
                {
                    speed += 10;
                }
                if(start > 36)
                {
                    start = 0;
                }
                if(speed >= 400)
                {
                    Console.Write($"\t{WheelOrder[start]}");
                    Thread.Sleep(1000);
                    ClearLine();
                    tempResult = bins.ElementAt(WheelOrder[start]);
                    Console.WriteLine($"\n\tThe ball lands on {tempResult}.");
                    spinning = false;
                }
            }
            return tempResult;
        }
    }


}
