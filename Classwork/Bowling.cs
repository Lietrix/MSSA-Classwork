using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Bowling
    {
        public static void SetPins(int pins)
        {
            // This method will print to the console a pattern of pins given the ammount
            int rows = 0;
            for (int i = 1; i < pins; i++)
            {
                pins -= i;
                rows++;
            }
        }

        public static bool check(int x)
        {
            int y = 0;
            int count = 0;
            while (y < x)
            {
                y += count;
                count++;
            }
            return y == x;
        }

    }
}

