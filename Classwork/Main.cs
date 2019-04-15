using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Classworks
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine(Reverse("happy"));
            //
            //  string str = "This is a test";
            //  str = str.Replace(" ", String.Empty);
            //  Console.WriteLine(str);   
            Console.WriteLine(Bowling.check(136));
        }

        public static string Reverse(string input)
        {
            string output = String.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];

            }
            return output;
        }

    }
}
