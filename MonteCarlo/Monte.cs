using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Monte
    {
        static void Main(string[] args)
        {
            double test = EstPi(randomNums(1000000));
            Console.WriteLine(test);
            Console.WriteLine(Math.Abs(Math.PI - test));
        }

        public struct Coord
        {
            public double x;
            public double y;
            public Coord(double x1, double y1)
            {
                this.x = x1;
                this.y = y1;
            }

            public Coord(Random num)
            {
                this.x = num.NextDouble();
                this.y = num.NextDouble();
            }

        }

//---------Calculates the hypotenuse of a a triangle given 2 coords------------

        public static double Hypontenuse(Coord input)
            => Math.Sqrt((input.x * input.x) + (input.y * input.y));

//---------Generates a double array with random coords w/ size of input--------

        public static double[] randomNums(int input)
        {
            double[] nums = new double[input];
            Random rand = new Random();
            int i = 0;
            while (i < input)
            {
                Coord kak = new Coord(rand);
                nums[i] = Hypontenuse(kak);
                i++;
            }
            return nums;
        }

//----------Counts how many overlap the circle, and returns pi estimate---------

        public static double EstPi(double[] input)
        {
            int counter = 0;
            double denom = input.Length;
            foreach (double x in input)
            {
                if(x < 1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            return (counter / denom) * 4;
        } 

    }
}
