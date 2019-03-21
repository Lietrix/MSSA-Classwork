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
        private double betAmount = 0;
        private string opt;
        

        public Gambler(string Name, double money)
        {
            this.Name = Name;
            this.money = money;
            Console.WriteLine($"\n\tWelcome new Player {Name}!\n\tYou are starting out with ${money}" +
                $"\n\n\t\tGood Luck!\n");
        }

        public void ShowInfo()
        {
            TypedWords($"Name : {Name}\nMoney : ${money}\n");
            Thread.Sleep(1200);
        }

        public void MainMenu()
        {
            if(this.money <= 0)
            {
                TypedWords("\n\t\t\tYou have run out of money, better luck next time...");              
                Thread.Sleep(1500);
                TypedWords(Name);
                TypedWords("\n\t\t\t\t\t\tGood Bye");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            Console.WriteLine("\n\tDecide what you would like to bet on:"
                + "\n1. Color\n2. Odd\n3. Even\n4. High or Low\n5. Column\n"
                + "6. Row \n7. Single Number \n8. Corner Number\n9. Split Number\n10. Dozens\n11. Show Info\n12. Quit\n");
            try
            {
                Console.WriteLine("Type a number: ");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n1. Red\n2. Black\n3. Green\n4. Exit");
                        opt = Console.ReadLine();
                        switch (opt)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnColor("Red", betAmount));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnColor("Black", betAmount));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnColor("Green", betAmount));
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
                        betAmount = check(double.Parse(Console.ReadLine()));
                        WinOrLose(BetOnOdd(betAmount));
                        MainMenu();
                        break;
                    case "3":
                        Console.WriteLine("\nAmount: ");
                        betAmount = check(double.Parse(Console.ReadLine()));
                        WinOrLose(BetOnEven(betAmount));
                        MainMenu();
                        break;
                    case "4":
                        Console.WriteLine("\n1. High (19-36)\n2. Low (1-18)\n3. Exit");
                        opt = Console.ReadLine();
                        switch (opt)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetHighOrLow("High", betAmount));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetHighOrLow("Low", betAmount));
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
                        betAmount = check(double.Parse(Console.ReadLine()));
                        WinOrLose(BetOnColumn(col, betAmount));
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
                        betAmount = check(double.Parse(Console.ReadLine()));
                        WinOrLose(BetOnRow(row, betAmount));
                        MainMenu();
                        break;
                    case "7":
                        Console.WriteLine("/nWhat number do you want to bet on?\n");
                        int num = Int32.Parse(Console.ReadLine());
                        if(num >= 37 || num <= 0)
                        {
                            throw new InvalidOperationException();
                        }
                        betAmount = check(double.Parse(Console.ReadLine()));
                        WinOrLose(BetOnNumber(num, betAmount));
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
                        opt = Console.ReadLine();
                        switch (opt)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnCorner(num1 ,"TopLeft", betAmount));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnCorner(num1, "TopRight", betAmount));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnCorner(num1, "BottomLeft", betAmount));
                                MainMenu();
                                break;
                            case "4":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnCorner(num1, "TopRight", betAmount));
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
                        opt = Console.ReadLine();
                        switch (opt)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnSplit(num2, "Up", betAmount));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnSplit(num2, "Down", betAmount));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnSplit(num2, "Right", betAmount));
                                MainMenu();
                                break;
                            case "4":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnSplit(num2, "Left", betAmount));
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
                        opt = Console.ReadLine();
                        switch (opt)
                        {
                            case "1":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnDozen(1, betAmount));
                                MainMenu();
                                break;
                            case "2":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnDozen(2, betAmount));
                                MainMenu();
                                break;
                            case "3":
                                Console.WriteLine("\nAmount: ");
                                betAmount = check(double.Parse(Console.ReadLine()));
                                WinOrLose(BetOnDozen(3, betAmount));
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
            catch (InvalidOperationException)
            {
                Console.WriteLine("That was an invalid option, returning to main menu...\n");
                Thread.Sleep(1500);
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message + "\n");
                Thread.Sleep(1500);
            }
            finally
            {
                MainMenu();
            }
        }

        public double check(double num)
        {
            if (num > money)
            {
                throw new Exception("You do not have the much money, returning to main menu");
            }
            else
            {
                return num;
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

        public static void TypedWords(string sentence)
        {
            foreach (char ch in sentence)
            {
                Thread.Sleep(110);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(ch);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }




    }


}
