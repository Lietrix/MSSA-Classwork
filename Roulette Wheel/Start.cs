using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Wheel
{
    class Start
    {
        static void Main(string[] args)
        {
           string startName = getName();
           double startMoney = getMoney();
           Gambler player = new Gambler(startName, startMoney);

                player.MainMenu();


        }

        public static string getName()
        {
            Console.Write("What is your name gambler?\n\n\t");
            string startName = Console.ReadLine();
            return startName;
        } 

        public static double getMoney()
        {
            Console.WriteLine("How much money do you have?\n");
            double startMoney = 0;
            while (true)
            {
                try
                {
                    startMoney = double.Parse(Console.ReadLine());
                    if (startMoney > 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nThat was not a valid number, please type a valid number");
                }

            }
            return startMoney;
        }


    }
}
