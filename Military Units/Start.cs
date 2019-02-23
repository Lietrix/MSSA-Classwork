using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------Starting with option 2---------------------
//Write your parent classes first.These will be the classes you will 
//subclass to create the appropriate objects.For example, you might 
//have a personnel class, a weapons class, a missions class, and a 
//vehicles class.
//-----------------------------------------------------------------

//----------------------------Second Part--------------------------
//If you chose to implement Option 1 in the first part, implement 
//Option 2 in in this part.If you chose to implement Option 2 in the
//first part, in this part, implement the appropriate subclasses. 
//For example, if one of your parent classes is Weapon, in this
//class you may elect to implement SmallCaliberWeapon,
//IndirectFireWeapon, and DirectFireWeapon.
//-----------------------------------------------------------------

//----------------------------Third part---------------------------
//If you chose to implement Option 2 in the first part, in this part 
//implement the appropriate methods as virtual and overidden methods,
//or use another suitable technique.As an example, if you have a method
//named mount(), it will exhibit different behavior depending on whether 
//it's called on a type RifleSight or a type Helicopter. As another example,
//if you have a method named load(), it will exhibit different behavior
//depending on whether it's called on a type AutomaticWeapon or a type
//Howitzer. Otherwise, implement your subclasses.
//-----------------------------------------------------------------

//--------------------------Finally block--------------------------
//If you chose to implement Option 2 in the first part, in this part 
//implement Option 1 in this part.Otherwise, implement the methods as 
//instructed for the third part. Note that you may chose to implement
//the main class first and the data type classes second, or the data
//type classes first and the main class second. In both cases, you need
//a main class to instantiate objects of the data types you create and
//exercise the methods of those data types.Generally most developers will
//implement the data types first and the main class second. Doing it the 
//other way is part of a discipline called test-driven development, and 
//is associated with agile techniques.Regardless of what you choose, you
//should be familiar with both processes.
//-----------------------------------------------------------------

namespace Military_Units
{
    class DesertStorm : Missions
    {
        

        public DesertStorm()
        {
            missionName = "Desert Storm";
            soldiers = 50;
            tanks = 5;
            generateSoldiers();
            generateTanks();
        }

        void generateSoldiers()
        {
            Infantry unit = new Infantry();
            for (int i = 0; i < soldiers; i++)
            {
                AP += unit.attackPower;
                HP += unit.health;
            }

        }

        void generateTanks()
        {
            Tank unit1 = new Tank();
            for (int i = 0; i < tanks; i++)
            {
                AP += unit1.attackPower;
                HP += unit1.health;
            }
        }


    }

    class MyArmy
    {
        public int infantry = 200;
        public int radioOperators = 10;
        public int corpsman = 12;
        public int tanks = 20;
        public int ArmyPower;
        public int ArmyHealth;

        public MyArmy()
        {
            calculateArmyPower();
        }

        Infantry unit = new Infantry();
        Radioman unit1 = new Radioman();
        Corpsman unit2 = new Corpsman();
        Tank unit3 = new Tank();

        public void calculateArmyPower()
        {
            //resets calculations
            ArmyPower = 0;
            ArmyHealth = 0;

            for (int i = 0; i < infantry; i++)
            {
                ArmyPower += unit.attackPower;
                ArmyHealth += unit.health;
            }

            for (int i = 0; i < radioOperators; i++)
            {
                ArmyPower += unit1.attackPower;
                ArmyHealth += unit1.health;
            }

            for (int i = 0; i < corpsman; i++)
            {
                ArmyPower += unit2.attackPower;
                ArmyHealth += unit2.health;
            }

            for (int i = 0; i < tanks; i++)
            {
                ArmyPower += unit3.attackPower;
                ArmyHealth += unit3.health;
            }
        }

        public virtual void CalculateUnits()
        {
            //TODO: make this method calculate the ammount of units left after a mission and before.
            int temp = ArmyHealth;

            int x = unit.health * infantry;
            int x1 = unit1.health * radioOperators;
            int x2 = unit2.health * corpsman;
            int y = unit.health * tanks;

            temp -= x;


            if (unit2.health == 0)
            {

            }
            
            

        }

    }
        

    class Start
    {
        static void Main(string[] args)
        {
            MyArmy Liet = new MyArmy();
            ConductMission(Liet, DesertStorm);

        }

        public static void ConductMission(MyArmy x, Missions y)
        {
            this.x.ArmyHealth - this.y.AP;
            this.y.HP - this.x.ArmyPower;
            //TODO: Right now this won't do anything since CalculateUnits isn't finished
            x.CalculateUnits;
            x.calculateArmyPower;

        }

    }
}
