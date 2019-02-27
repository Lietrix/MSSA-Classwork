using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Wheel
{
    //the player
    class Gambler : Gamble
    {
        private string Name;

        public Gambler(string Name, double money)
        {
            this.Name = Name;
            this.money = money;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nMoney : ${money}");
        }
    }

    class Gamble
    {
        public double money = 0;
        Wheel myWheel = new Wheel();

        private int[,] table = new int[,]
        { {3,6,9,12,15,18,21,24,27,30,33,36},
         {2,5,8,11,14,17,20,23,26,29,32,35},
         {1,4,7,10,13,16,19,22,25,28,31,34}
        };

        public void BetEven()
        {
            Console.WriteLine(myWheel.Result);
        }
    }


}
