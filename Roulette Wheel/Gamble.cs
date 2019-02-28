using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            Console.WriteLine($"\n\tWelcome new Player {Name}!\n\tYou are starting out with ${money}" +
                $"\n\n\t\tGood Luck!\n");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nMoney : ${money}");
        }

        public void MainMenu()
        {
            if(this.money <= 0)
            {
                Console.WriteLine("You have run out of money, better luck next time...");
                Thread.Sleep(1200);
                foreach(var x in Name)
                {
                    Thread.Sleep(120);
                    Console.Write("\t" + x);
                }
                Thread.Sleep(1500);
                Console.WriteLine("\n\t\t\tYou suck");
                Thread.Sleep(500);
                Environment.Exit(0);
            }
            Console.WriteLine("\n\tDecide what you would like to bet on:"
                + "\n1. Color\n2. Odd\n3. Even\n4. High or Low\n5. Column\n"
                + "6. Row \n7. Single Number \n8. Corner Number\n9. Split Number\n10. Dozens\n11. Show Info\n12. Quit\n");
            try
            {
                Console.WriteLine("Type a number: ");
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n1. Red\n2. Black\n3. Green\n4. Exit");
                        string opt1 = Console.ReadLine();
                        switch (opt1)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                double betAmount = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnColor("Red", betAmount));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                double betAmount1 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnColor("Black", betAmount1));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                double betAmount2 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnColor("Green", betAmount2));
                                MainMenu();
                                break;
                            case "4":
                                MainMenu();
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nAmount: ");
                        double betAmount3 = double.Parse(Console.ReadLine());
                        WinOrLose(BetOnOdd(betAmount3));
                        MainMenu();
                        break;
                    case "3":
                        Console.WriteLine("\nAmount: ");
                        double betAmount4 = double.Parse(Console.ReadLine());
                        WinOrLose(BetOnEven(betAmount4));
                        MainMenu();
                        break;
                    case "4":
                        Console.WriteLine("\n1. High (19-36)\n2. Low (1-18)\n3. Exit");
                        string opt2 = Console.ReadLine();
                        switch (opt2)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                double betAmount5 = double.Parse(Console.ReadLine());
                                WinOrLose(BetHighOrLow("High", betAmount5));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                double betAmount6 = double.Parse(Console.ReadLine());
                                WinOrLose(BetHighOrLow("Low", betAmount6));
                                MainMenu();
                                break;
                            case "3":
                                MainMenu();
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nWhich Column would you like to bet on?"
                            + "\n1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n");
                        int col = Int32.Parse(Console.ReadLine());
                        if(col >= 13 || col <= 0)
                        {
                            throw new InvalidOperationException();
                        }
                        Console.WriteLine("\nAmount: ");
                        double betAmount7 = double.Parse(Console.ReadLine());
                        WinOrLose(BetOnColumn(col, betAmount7));
                        MainMenu();
                        break;
                    case "6":
                        Console.WriteLine("\nWhich Row would you like to bet on?"
                            + "\n1\n2\n3\n");
                        int row = Int32.Parse(Console.ReadLine());
                        if (row >= 4 || row <= 0)
                        {
                            throw new InvalidOperationException();
                        }
                        Console.WriteLine("\nAmount: ");
                        double betAmount8 = double.Parse(Console.ReadLine());
                        WinOrLose(BetOnRow(row, betAmount8));
                        MainMenu();
                        break;
                    case "7":
                        Console.WriteLine("/nWhat number do you want to bet on?\n");
                        int num = Int32.Parse(Console.ReadLine());
                        if(num >= 37 || num <= 0)
                        {
                            throw new InvalidOperationException();
                        }
                        double betAmount9 = double.Parse(Console.ReadLine());
                        WinOrLose(BetOnNumber(num, betAmount9));
                        MainMenu();
                        break;
                    case "8":
                        Console.WriteLine("\nWhat number base do you want to bet on?\n Only the center row\n2,5,8,11,14,17,20,23,26,29,32,35\n");
                        int num1 = Int32.Parse(Console.ReadLine());
                        if (num1 >= 37 || num1 <= 0 || num1 % 3 == 0 || num1 % 3 == 1)
                        {
                            throw new InvalidOperationException();
                        }
                        Console.WriteLine("Which corner would you like to bet on?\n1. Top Left\n2. Top Right\n3. Bottom Left\n4. Bottom Right\n5. Exit\n");
                        string opt3 = Console.ReadLine();
                        switch (opt3)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                double betAmount10 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnCorner(num1 ,"TopLeft", betAmount10));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                double betAmount11 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnCorner(num1, "TopRight", betAmount11));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                double betAmount12 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnCorner(num1, "BottomLeft", betAmount12));
                                MainMenu();
                                break;
                            case "4":
                                Console.WriteLine("\nAmount: ");
                                double betAmount13 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnCorner(num1, "TopRight", betAmount13));
                                MainMenu();
                                break;
                            case "5":
                                MainMenu();
                                break;
                            default:
                                throw new InvalidOperationException();


                        }
                        break;
                    case "9":
                        Console.WriteLine("\nWhat number base do you want to bet on?\n");
                        int num2 = Int32.Parse(Console.ReadLine());
                        if (num2 >= 37 || num2 <= 0)
                        {
                            throw new InvalidOperationException();
                        }
                        Console.WriteLine("Which direction would you like to split?\n1. Up\n2. Down\n3. Right\n4. Left\n5. Exit\n");
                        string opt4 = Console.ReadLine();
                        switch (opt4)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                double betAmount14 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnSplit(num2, "Up", betAmount14));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                double betAmount15 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnSplit(num2, "Down", betAmount15));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                double betAmount16 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnSplit(num2, "Right", betAmount16));
                                MainMenu();
                                break;
                            case "4":
                                Console.WriteLine("\nAmount: ");
                                double betAmount17 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnSplit(num2, "Left", betAmount17));
                                MainMenu();
                                break;
                            case "5":
                                MainMenu();
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                        break;
                    case "10":
                        Console.WriteLine("\nChoose a dozen to bet on.\n1. 1-12\n2. 13-24\n3. 25-36\n4. Exit\n");
                        string opt5 = Console.ReadLine();
                        switch (opt5)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                double betAmount18 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnDozen(1, betAmount18));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                double betAmount19 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnDozen(2, betAmount19));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                double betAmount20 = double.Parse(Console.ReadLine());
                                WinOrLose(BetOnDozen(3, betAmount20));
                                MainMenu();
                                break;
                            case "4":
                                MainMenu();
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                        break;
                    case "11":
                        ShowInfo();
                        MainMenu();
                        break;
                    case "12":
                        Environment.Exit(0);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException IO)
            {
                Console.WriteLine(IO.Message);
                MainMenu();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
                MainMenu();
            }
        }
    }

    class Gamble : Wheel
    {
        public double money = 0; 

        private int[,] table = new int[3, 12]
        {
            {3,6,9,12,15,18,21,24,27,30,33,36},
            {2,5,8,11,14,17,20,23,26,29,32,35},
            {1,4,7,10,13,16,19,22,25,28,31,34}
        };

        public bool BetOnCorner(int num, string corner, double amount)
        {
            int temp = Result.Key;

            if(corner == "TopLeft")
            {
                List<int> bets = new List<int>
                {
                    table[1, num],
                    table[0, num],
                    table[1, num - 1],
                    table[0, num -  1]
                };
                if (bets.Contains(temp))
                {
                    this.money += amount * 7;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if(corner == "TopRight")
            {
                List<int> bets = new List<int>
                {
                    table[1, num],
                    table[0, num],
                    table[1, num + 1],
                    table[0, num +  1]
                };
                if (bets.Contains(temp))
                {
                    this.money += amount * 7;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (corner == "BottomLeft")
            {
                List<int> bets = new List<int>
                {
                    table[1, num],
                    table[2, num],
                    table[1, num - 1],
                    table[2, num -  1]
                };
                if (bets.Contains(temp))
                {
                    this.money += amount * 7;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (corner == "BottomRight")
            {
                List<int> bets = new List<int>
                {
                    table[1, num],
                    table[2, num],
                    table[1, num + 1],
                    table[2, num +  1]
                };
                if (bets.Contains(temp))
                {
                    this.money += amount * 7;
                }
                else
                {
                    this.money -= amount;
                }
            }
            return false;
        }

        public bool BetOnSplit(int num, string split, double amount)
        {
            int temp = Result.Key;
            int[] bet = new int[2];
            bet[0] = num;
            if (split == "Up")
            {
                bet[1] = num + 1;
                if (bet.Contains(temp))
                {
                    this.money += amount * 16;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (split == "Down")
            {
                bet[1] = num - 1;
                if (bet.Contains(temp))
                {
                    this.money += amount * 16;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (split == "Right")
            {
                bet[1] = num + 3;
                if (bet.Contains(temp))
                {
                    this.money += amount * 16;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (split == "Left")
            {
                bet[1] = num - 3;
                if (bet.Contains(temp))
                {
                    this.money += amount * 16;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            return false;
        }

        public bool BetOnNumber(int num, double amount)
           {
               if(Result.Key == num)
               {
                   this.money += amount * 34;
                return true;
               }
               else
               {
                   this.money -= amount;
               }
            return false;
           }

        public bool BetOnEven(double amount)
        {
            int temp = Result.Key;
            if(temp == 0)
            {
                this.money -= amount;
            }
            else if(temp % 2 == 0)
            {
                this.money += amount;
                return true;
            }
            else
            {
                this.money -= amount;
            }
            return false;
        }

        public bool BetOnOdd(double amount)
        { 
            if (Result.Key % 2 == 1)
            {
                this.money += amount;
                return true;
            }
            else
            {
                this.money -= amount;
            }
            return false;
        }
               
        public bool BetOnColor(string color, double amount)
        {
            string result = Result.Value;
            if (color == "Green")
            {
                if (result == color)
                {
                    this.money += amount * 34;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else
            {
                if (result == color)
                {
                    this.money += amount;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            return false;
        }
               
        public bool BetOnRow(int row, double amount)
        {
            int temp = Result.Key;

            if(temp % 3 == 0)
            {
                if(row == 0)
                {
                    this.money += amount * 2;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if(temp % 3 == 1)
            {
                if (row == 1)
                {
                    this.money += amount * 2;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if(temp % 3 == 2)
            {
                if (row == 2)
                {
                    this.money += amount * 2;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            return false;
        }
               
        public bool BetOnColumn(int column, double amount)
        {
            int temp = Result.Key;
            int[] bet = new int[] { column * 3, column * 3 - 1, column * 3 - 2 };
            if (bet.Contains(temp))
            {
                this.money += amount * 10;
                return true;
            }
            else
            {
                this.money -= amount;
            }
            return false;
        }
               
        public bool BetHighOrLow(string HL, double amount)
        {
            int temp = Result.Key;
            if(temp >= 18)
            {
                if(HL == "High")
                {
                    money += amount;
                    return true;
                }
                else
                {
                    money -= amount;
                }
            }
            else if(temp == 0)
            {
                money -= amount;
            }
            else
            {
                if(HL == "Low")
                {
                    money += amount;
                    return true;
                }
                else
                {
                    money -= amount;
                }
            }
            return false;
        }
               
        public bool BetOnDozen(int dozen, double amount)
        {
            int temp = Result.Key;
            if(temp == 0)
            {
                this.money -= amount;
            }
            else  if(temp >=13 && temp <= 24)
            {
                if(dozen == 2)
                {
                    this.money += amount * 2;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (temp <= 12)
            {
                if (dozen == 1)
                {
                    this.money += amount * 2;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            else if (temp >= 25)
            {
                if (dozen == 3)
                {
                    this.money += amount * 2;
                    return true;
                }
                else
                {
                    this.money -= amount;
                }
            }
            return false;
        }

        public void WinOrLose(bool outcome)
        {
            Thread.Sleep(1200);
            if (outcome)
            {
                Console.WriteLine("\n\t\tCongratulations! You won the bet!\n\tMake a new bet\n");
                Console.WriteLine($"You now have: ${money}");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("\n\t\tSorry you lost, better luck next time! Make a new bet\n");
                Console.WriteLine($"You now have: ${money}");
                Thread.Sleep(1500);
            }
        }


    }


}
