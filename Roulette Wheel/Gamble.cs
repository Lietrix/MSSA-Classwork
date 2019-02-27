using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Wheel
{
    //The Player
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

        public void BetOnNumber(int num, double amount)
        {
            if(myWheel.Result.Key == num)
            {
                amount *= 35;
                this.money += amount;
            }
            else
            {
                this.money -= amount;
            }
        }

        public void BetOnEven(double amount)
        {
            if(myWheel.Result.Key == 0)
            {
                this.money -= amount;
            }
            else if(myWheel.Result.Key % 2 == 0)
            {
                amount *= 2;
                this.money += amount;
            }
            else
            {
                this.money -= amount;
            }
        }

        public void BetOnOdd(double amount)
        { 
            if (myWheel.Result.Key % 2 == 1)
            {
                amount *= 2;
                this.money += amount;
            }
            else
            {
                this.money -= amount;
            }
        }

        private int[,] table = new int[,]
        { {3,6,9,12,15,18,21,24,27,30,33,36},
         {2,5,8,11,14,17,20,23,26,29,32,35},
         {1,4,7,10,13,16,19,22,25,28,31,34}
        };
    }


}
